using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ClangSharp;
using Sharpineer.Helper;

namespace Sharpineer.Parser.Header
{
    public enum TypeConverter
    {
        AsciiEncoder,
        WCharEncoder
    }

    /// <summary>
    /// Type information
    /// </summary>
    public class TypeInfo
    {
        public string Name; // canonical
        public string OriginalName; // before typedef
        public CXTypeKind Type;

        public string NonConstName => IsConst && Name.StartsWith("const ") ? Name.Substring(6) : Name;

        public string CSharpType;
        public string TypeComment;

        public string MarshalAs;

        public bool RequiresUnicode = false;

        public bool IsConst = false;

        public EnumInfo EnumInfo; // if Type == Enum
        public StructInfo StructInfo; // if Type == Record

        public TypeInfo ArrayElementType; // if Type == XyzArray
        public long ArraySize = -1;

        public TypeInfo PointerType;

        public readonly List<TypeConverter> Converters = new List<TypeConverter>();

        public string DecoratedCSharpType
            => string.IsNullOrEmpty(TypeComment) ? CSharpType : CSharpType + " /* " + TypeComment + " */";

        public static TypeInfo FromClangType(CXType type)
        {
            var cantype = clang.getCanonicalType(type);
            var isConst = clang.isConstQualifiedType(cantype) != 0;
            var info = new TypeInfo
            {
                Name = clang.getTypeSpelling(cantype).ToString(),
                OriginalName = clang.getTypeSpelling(type).ToString(),
                Type = cantype.kind,
                IsConst = isConst
            };
            switch (info.Type)
            {
                case CXTypeKind.CXType_ConstantArray:
                case CXTypeKind.CXType_DependentSizedArray:
                case CXTypeKind.CXType_IncompleteArray:
                case CXTypeKind.CXType_VariableArray:
                    info.ArrayElementType = FromClangType(clang.getArrayElementType(cantype));
                    info.ArraySize = clang.getArraySize(cantype);
                    break;

                case CXTypeKind.CXType_Pointer:
                    info.PointerType = FromClangType(clang.getPointeeType(cantype));
                    break;
            }
            info.InitType();
            return info;
        }


        private void InitType()
        {
            CSharpType = null;
            TypeComment = "";
            switch (OriginalName)
            {
                case "BOOL":
                    CSharpType = "bool";
                    break;

                case "BYTE":
                    CSharpType = "byte";
                    break;

                default:
                    if (Name != OriginalName)
                        TypeComment = OriginalName;
                    switch (Name)
                    {
                        case "void":
                            CSharpType = "void";
                            break;

                        case "int":
                        case "long":
                            CSharpType = "int";
                            break;

                        case "unsigned char":
                            CSharpType = "byte";
                            break;

                        case "unsigned":
                        case "unsigned int":
                        case "unsigned long":
                            CSharpType = "uint";
                            break;

                        case "long long":
                            CSharpType = "long";
                            break;

                        case "unsigned long long":
                            CSharpType = "ulong";
                            break;

                        case "short":
                            CSharpType = "short";
                            break;

                        case "unsigned short":
                            CSharpType = "ushort";
                            break;

                        case "char":
                        case "wchar_t":
                            CSharpType = "char";
                            RequiresUnicode = true;
                            break;

                        default:
                            switch (Type)
                            {
                                case CXTypeKind.CXType_Pointer:
                                    if (PointerType.Type == CXTypeKind.CXType_Record)
                                    {
                                        CSharpType = PointerType.NonConstName.ToCSharpName();
                                        MarshalAs = "[MarshalAs(UnmanagedType.LPStruct)]";
                                    }
                                    else
                                    {
                                        CSharpType = "IntPtr";
                                        TypeComment = Name;
                                    }
                                    break;

                                case CXTypeKind.CXType_Record:
                                    // direct struct has C# version
                                    CSharpType = Name.ToCSharpName();
                                    MarshalAs = "[MarshalAs(UnmanagedType.Struct)]";
                                    break;

                                case CXTypeKind.CXType_Enum:
                                    // enums
                                    CSharpType = Name.ToCSharpName();
                                    break;

                                case CXTypeKind.CXType_ConstantArray:
                                    Debug.Assert(ArrayElementType != null);
                                    MarshalAs = string.Format("[MarshalAs(UnmanagedType.ByValArray, SizeConst = {0})]", ArraySize);
                                    CSharpType = ArrayElementType.CSharpType + "[]";
                                    if (string.IsNullOrEmpty(ArrayElementType.TypeComment))
                                        TypeComment = string.Format("{0} [{1}]", ArrayElementType.TypeComment, ArraySize);

                                    // special case: chars
                                    if (ArrayElementType.Name == "char")
                                    {
                                        CSharpType = "byte[]";
                                        Converters.Add(TypeConverter.AsciiEncoder);
                                    }

                                    // char arrays
                                    if (ArrayElementType.Name == "wchar_t")
                                    {
                                        Converters.Add(TypeConverter.WCharEncoder);
                                    }
                                    break;

                                default:
                                    CSharpType = "UNKNOWN"; // unknown type
                                    TypeComment = Name + ", " + OriginalName;
                                    break;
                            }
                            break;
                    }
                    break;
            }

            // TODO: Strings
            // TODO: Structs (out, ref)

            Debug.Assert(CSharpType != null);
        }

        public override string ToString() => Name + " (" + OriginalName + ", " + Type + ")";

        public void AddReference(string dll, ITypeProvider typer)
        {
            ArrayElementType?.AddReference(dll, typer);
            PointerType?.AddReference(dll, typer);

            switch (Type)
            {
                case CXTypeKind.CXType_Record:
                    StructInfo = typer.QueryStruct(Name);
                    StructInfo?.AddReference(dll, typer);
                    break;

                case CXTypeKind.CXType_Enum:
                    EnumInfo = typer.QueryEnum(Name);
                    if (EnumInfo == null)
                        Console.WriteLine("Missing " + Name);
                    EnumInfo?.AddReference(dll, typer);
                    break;
            }

            // postprocess
            {
                // handles
                if (PointerType?.StructInfo?.IsHandle ?? false)
                {
                    MarshalAs = "[MarshalAs(UnmanagedType.Struct)]";
                }
            }
        }
    }
}
