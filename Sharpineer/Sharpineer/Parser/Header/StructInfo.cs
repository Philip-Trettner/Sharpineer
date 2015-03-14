using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Sharpineer.Helper;

namespace Sharpineer.Parser.Header
{
    public class StructInfo
    {
        /// <summary>
        /// Struct name
        /// </summary>
        public string Name;

        /// <summary>
        /// Typeifo of this struct in C code
        /// </summary>
        public TypeInfo TypeInfo;

        /// <summary>
        /// List of struct fields
        /// </summary>
        public readonly List<ArgumentInfo> Members = new List<ArgumentInfo>();

        /// <summary>
        /// Set of dlls that reference this struct
        /// </summary>
        public readonly HashSet<string> ReferencedDlls = new HashSet<string>();

        /// <summary>
        /// Name of the struct for C# version
        /// </summary>
        public string CSharpName => Name.ToCSharpName();

        public bool IsHandle
            => TypeInfo.Name.EndsWith("__") &&
               Members.Count == 1 && 
               Members[0].Name == "unused" &&
               Members[0].Type.CSharpType == "int";

        public void AddReference(string dll, ITypeProvider typer)
        {
            if (!ReferencedDlls.Add(dll))
                return; // early-out

            foreach (var member in Members)
                member.AddReference(dll, typer);
        }

        /// <summary>
        /// Returns the csharp definition of this struct
        /// </summary>
        public IEnumerable<string> CSharpDefinition
        {
            get
            {
                yield return "[StructLayout(LayoutKind.Explicit), Serializable]";
                yield return string.Format("public struct {0} /* {1}, {2} */", CSharpName, Name, TypeInfo.OriginalName);
                yield return "{";
                if (IsHandle)
                {
                    yield return "    [FieldOffset(0)]";
                    yield return "    public IntPtr handle;";
                }
                else
                {
                    foreach (var field in Members)
                    {
                        if (!string.IsNullOrEmpty(field.Type.MarshalAs))
                            yield return "    " + field.Type.MarshalAs;

                        yield return "    " + field.OffsetAttribute;

                        yield return string.Format("    public {0} {1};", field.Type.DecoratedCSharpType, field.Name);

                        foreach (var converter in field.Converters)
                            yield return "    " + converter;
                    }
                }
                yield return "}";
            }
        }
    }
}
