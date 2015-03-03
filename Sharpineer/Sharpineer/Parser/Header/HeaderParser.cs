using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using ClangSharp;
using Sharpineer.Helper;

namespace Sharpineer.Parser.Header
{
    public class HeaderParser
    {
        /// <summary>
        /// All header files
        /// </summary>
        public readonly string[] HeaderFiles;

        /// <summary>
        /// All discovered enums
        /// </summary>
        public readonly List<EnumInfo> Enums = new List<EnumInfo>();

        public HeaderParser(params string[] headerFiles)
        {
            HeaderFiles = headerFiles;
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

            // cleanup
            clang.disposeIndex(index);
            clang.disposeTranslationUnit(unit);
        }

        public CXChildVisitResult VisitEnums(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            // ignore system headers
            if (cursor.IsInSystemHeader())
                return CXChildVisitResult.CXChildVisit_Continue;

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
            if (Enums.Any(e => e.Name == enumName))
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
            Enums.Add(info);

            // descend
            return CXChildVisitResult.CXChildVisit_Recurse;
        }
    }
}
