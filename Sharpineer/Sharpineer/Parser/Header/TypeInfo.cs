using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClangSharp;

namespace Sharpineer.Parser.Header
{
    /// <summary>
    /// Type information
    /// </summary>
    public class TypeInfo
    {
        public string Name; // canonical
        public string OriginalName; // before typedef
        public CXTypeKind Type;

        public string CSharpType;
        public string TypeComment;

        public bool RequiresUnicode = false;

        public EnumInfo EnumType; // if Type == Enum

        public string DecoratedCSharpType
            => string.IsNullOrEmpty(TypeComment) ? CSharpType : CSharpType + " /* " + TypeComment + " */";

        public static TypeInfo FromClangType(CXType type)
        {
            var cantype = clang.getCanonicalType(type);
            var info = new TypeInfo
            {
                Name = clang.getTypeSpelling(cantype).ToString(),
                OriginalName = clang.getTypeSpelling(type).ToString(),
                Type = cantype.kind
            };
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

                default:
                    switch (Name)
                    {
                        case "void":
                            CSharpType = "void";
                            break;

                        case "int":
                        case "long":
                            CSharpType = "int";
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
                            CSharpType = "ulonglong";
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

                        case "HWND__ *":
                            CSharpType = "IntPtr";
                            TypeComment = "HWND";
                            break;

                        default:
                            if (Type == CXTypeKind.CXType_Pointer)
                            {
                                CSharpType = "IntPtr";
                                TypeComment = Name;
                            }
                            else
                            {
                                CSharpType = "UNKNOWN"; // unknown type
                                TypeComment = Name + ", " + OriginalName;
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
    }
}
