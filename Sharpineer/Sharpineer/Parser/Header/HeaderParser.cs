using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using ClangSharp;
using Sharpineer.Helper;

namespace Sharpineer.Parser.Header
{
    public class HeaderParser : ITypeProvider
    {
        /// <summary>
        /// All header files
        /// </summary>
        public readonly string[] HeaderFiles;
        
        /// <summary>
        /// Discovered enums
        /// </summary>
        public readonly Dictionary<string, EnumInfo> Enums = new Dictionary<string, EnumInfo>(); 

        /// <summary>
        /// All discovered extern "C" functions
        /// </summary>
        public readonly Dictionary<string, ExternFunctionInfo> ExternFunctions = new Dictionary<string, ExternFunctionInfo>();

        /// <summary>
        /// All known structs
        /// </summary>
        public readonly Dictionary<string, StructInfo> Structs = new Dictionary<string, StructInfo>();

        /// <summary>
        /// Merges ansi and unicode functions
        /// (keeps unicode versions)
        /// </summary>
        public void MergeAnsiUnicode()
        {
            foreach (var kvp in ExternFunctions.ToArray())
            {
                var name = kvp.Key;
                var f = kvp.Value;

                if (name.EndsWith("W") &&
                    ExternFunctions.ContainsKey(name.Substring(0, name.Length - 1) + "A"))
                {
                    ExternFunctions.Remove(name.Substring(0, name.Length - 1) + "A");
                    ExternFunctions.Remove(name);

                    f.Name = name.Substring(0, name.Length - 1);
                    ExternFunctions.Add(f.Name, f);
                }
            }
        }

        public HeaderParser(params string[] headerFiles)
        {
            HeaderFiles = headerFiles;
        }

        /// <summary>
        /// Annotate external functions with dll name
        /// </summary>
        public void NotifyDll(string dllName, IEnumerable<string> funcNames)
        {
            foreach (var funcName in funcNames.Where(funcName => ExternFunctions.ContainsKey(funcName)))
            {
                var func = ExternFunctions[funcName];
                func.DllName = dllName;
                func.AddReference(dllName, this);
            }
        }

        /// <summary>
        /// Parses all headers using libClang
        /// </summary>
        public void Parse()
        {
            // setup files
            var args = new List<string> { "-x", "c++", "-I./" };
            var tmpfile = Path.GetTempFileName();
            var lines = HeaderFiles.Select(header => "#include \"" + header + "\"").ToList();
            File.WriteAllLines(tmpfile, lines);

            // parse files
            CXTranslationUnit unit;
            CXUnsavedFile unsavedFile;
            var index = clang.createIndex(0, 0);
            var translationUnitError = clang.parseTranslationUnit2(index, tmpfile, args.ToArray(), args.Count, out unsavedFile, 0, 0, out unit);

            if (translationUnitError != CXErrorCode.CXError_Success)
            {
                Console.WriteLine("Error: " + translationUnitError);
                var numDiagnostics = clang.getNumDiagnostics(unit);

                for (uint i = 0; i < numDiagnostics; ++i)
                {
                    var diagnostic = clang.getDiagnostic(unit, i);
                    Console.WriteLine(clang.getDiagnosticSpelling(diagnostic).ToString());
                    clang.disposeDiagnostic(diagnostic);
                }

                throw new InvalidOperationException("Error while compiling");
            }

            // visit enums
            clang.visitChildren(clang.getTranslationUnitCursor(unit), VisitEnums, new CXClientData(IntPtr.Zero));

            // visit extern functions
            clang.visitChildren(clang.getTranslationUnitCursor(unit), VisitExternFunctions, new CXClientData(IntPtr.Zero));

            // visit structs
            clang.visitChildren(clang.getTranslationUnitCursor(unit), VisitStructs, new CXClientData(IntPtr.Zero));

            // cleanup
            clang.disposeIndex(index);
            clang.disposeTranslationUnit(unit);
        }

        public CXChildVisitResult VisitExternFunctions(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            // check for functions
            var curKind = clang.getCursorKind(cursor);
            if (curKind != CXCursorKind.CXCursor_FunctionDecl) return CXChildVisitResult.CXChildVisit_Recurse;

            var funcType = clang.getCursorType(cursor);
            var funcName = clang.getCursorSpelling(cursor).ToString();
            var callingConv = clang.getFunctionTypeCallingConv(funcType);

            var info = new ExternFunctionInfo
            {
                Name = funcName,
                CallingConvention = callingConv,
                ReturnType = TypeInfo.FromClangType(clang.getResultType(funcType))
            };
            var argc = clang.getNumArgTypes(funcType);
            for (uint i = 0; i < argc; ++i)
                info.Parameters.Add(new ArgumentInfo()
                {
                    Name = clang.getCursorSpelling(clang.Cursor_getArgument(cursor, i)).ToString(),
                    Type = TypeInfo.FromClangType(clang.getArgType(funcType, i))
                });

            // already found? continue
            // TODO: error checking?
            if (ExternFunctions.ContainsKey(info.Name))
                return CXChildVisitResult.CXChildVisit_Continue;

            // add func info
            ExternFunctions.Add(info.Name, info);

            // recurse
            return CXChildVisitResult.CXChildVisit_Recurse;
        }

        public CXChildVisitResult VisitStructs(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            // check for functions
            var curKind = clang.getCursorKind(cursor);
            if (curKind != CXCursorKind.CXCursor_StructDecl) return CXChildVisitResult.CXChildVisit_Recurse;

            var structType = clang.getCursorType(cursor);
            var structName = clang.getCursorSpelling(cursor).ToString();

            if (Structs.ContainsKey(structName))
                return CXChildVisitResult.CXChildVisit_Continue;

            var info = new StructInfo()
            {
                Name = structName,
                TypeInfo = TypeInfo.FromClangType(structType)
            };
            Structs.Add(structName, info);

            clang.visitChildren(cursor, (cxCursor, parent1, clientData) =>
            {
                var kind = clang.getCursorKind(cxCursor);
                if (kind != CXCursorKind.CXCursor_FieldDecl) return CXChildVisitResult.CXChildVisit_Recurse;

                var fieldType = clang.getCursorType(cxCursor);
                var fieldName = clang.getCursorSpelling(cxCursor).ToString();

                info.Members.Add(new ArgumentInfo()
                {
                    Name = fieldName,
                    Type = TypeInfo.FromClangType(fieldType)
                });

                return CXChildVisitResult.CXChildVisit_Recurse;
            }, new CXClientData(IntPtr.Zero));

            // recurse
            return CXChildVisitResult.CXChildVisit_Continue;
        }

        public CXChildVisitResult VisitEnums(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            // check for enums
            var curKind = clang.getCursorKind(cursor);
            if (curKind != CXCursorKind.CXCursor_EnumDecl) return CXChildVisitResult.CXChildVisit_Recurse;

            string baseType;
            switch (clang.getEnumDeclIntegerType(cursor).kind)
            {
                case CXTypeKind.CXType_Int:
                    baseType = "int";
                    break;
                case CXTypeKind.CXType_UInt:
                    baseType = "uint";
                    break;
                case CXTypeKind.CXType_Short:
                    baseType = "short";
                    break;
                case CXTypeKind.CXType_UShort:
                    baseType = "ushort";
                    break;
                case CXTypeKind.CXType_LongLong:
                    baseType = "long";
                    break;
                case CXTypeKind.CXType_ULongLong:
                    baseType = "ulong";
                    break;
                default:
                    baseType = "int";
                    break;
            }

            var enumName = clang.getCursorSpelling(cursor).ToString();

            // From ClangSharpPInvokeGenerator:
            //   enumName can be empty because of typedef enum { .. } enumName;
            //   so we have to find the sibling, and this is the only way I've found
            //   to do with libclang, maybe there is a better way?
            if (string.IsNullOrEmpty(enumName))
            {
                var forwardDeclaringVisitor = new ForwardDeclVisitor(cursor);
                clang.visitChildren(clang.getCursorLexicalParent(cursor), forwardDeclaringVisitor.Visit, new CXClientData(IntPtr.Zero));
                enumName = clang.getCursorSpelling(forwardDeclaringVisitor.ForwardDeclarationCursor).ToString();

                if (string.IsNullOrEmpty(enumName))
                {
                    enumName = "_";
                }
            }

            // already found? continue
            if (Enums.ContainsKey(enumName))
                return CXChildVisitResult.CXChildVisit_Continue;

            var info = new EnumInfo
            {
                Name = enumName,
                BaseType = baseType
            };

            // TODO: Namespaces

            // collect enum values
            clang.visitChildren(cursor, (cxCursor, _, __) =>
            {
                var valName = clang.getCursorSpelling(cxCursor).ToString();
                var valValue = clang.getEnumConstantDeclValue(cxCursor);
                info.Values.Add(valName, valValue);
                return CXChildVisitResult.CXChildVisit_Continue;
            }, new CXClientData(IntPtr.Zero));

            // add enum
            Enums.Add(info.Name, info);

            // descend
            return CXChildVisitResult.CXChildVisit_Recurse;
        }

        public StructInfo QueryStruct(string name)
        {
            return Structs.ContainsKey(name) ? Structs[name] : null;
        }

        public EnumInfo QueryEnum(string name)
        {
            return Enums.ContainsKey(name) ? Enums[name] : null;
        }
    }
}
