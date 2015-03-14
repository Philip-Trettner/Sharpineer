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
        /// Name of the struct for C# version
        /// </summary>
        public string CSharpName => CSharpNameOf(Name);

        /// <summary>
        /// Name of the struct for C# version
        /// </summary>
        public static string CSharpNameOf(string name)
        {
            // remove leading "tag"
            if (name.StartsWith("tag") && name.Length > 3 && char.IsUpper(name[3]))
                name = name.Substring(3);
            // trim ' ', '_'
            name = name.Trim(' ', '_');
            // make uppercase to camelcase
            if (name.All(char.IsUpper) && name.Length > 1)
                name = name.Capitalize();
            // ABC_DEF -> AbcDef
            if (name.Contains('_'))
                name = name.Split('_').Select(s => s.Capitalize()).Aggregate((s1, s2) => s1 + s2);
            return name;
        }

        /// <summary>
        /// Returns the csharp definition of this struct
        /// </summary>
        public IEnumerable<string> CSharpDefinition
        {
            get
            {
                yield return "[StructLayout(LayoutKind.Sequential)]";
                yield return string.Format("public struct {0} /* {1}, {2} */", CSharpName, Name, TypeInfo.OriginalName);
                yield return "{";
                foreach (var field in Members)
                {
                    if (!string.IsNullOrEmpty(field.Type.MarshalAs))
                        yield return "    " + field.Type.MarshalAs;

                    yield return string.Format("    public {0} {1};", field.Type.DecoratedCSharpType, field.Name);

                    foreach (var converter in field.Converters)
                        yield return "    " + converter;
                }
                yield return "}";
            }
        }
    }
}
