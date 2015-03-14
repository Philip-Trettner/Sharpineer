using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpineer.Helper
{
    public static class StringExtensions
    {
        public static string Capitalize(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            return char.ToUpper(s[0]) + s.Substring(1).ToLowerInvariant();
        }

        public static string ToCamelCaseCSharpName(this string name, bool removeTag = true)
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
    }
}
