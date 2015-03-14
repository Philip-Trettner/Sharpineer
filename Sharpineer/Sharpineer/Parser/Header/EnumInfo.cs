using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Sharpineer.Helper;

namespace Sharpineer.Parser.Header
{
    public class EnumInfo
    {
        /// <summary>
        /// Enum name
        /// </summary>
        public string Name;

        /// <summary>
        /// Enum base type
        /// </summary>
        public string BaseType;

        /// <summary>
        /// Mapping from value name to actual value
        /// </summary>
        public readonly Dictionary<string, long> Values = new Dictionary<string, long>();

        /// <summary>
        /// List of enclosed namespaces
        /// </summary>
        public readonly List<string> Namespaces = new List<string>();

        /// <summary>
        /// References in dll
        /// </summary>
        public readonly HashSet<string> ReferencedDlls = new HashSet<string>();

        public int PrefixLength
        {
            get
            {
                var name = Values.First().Key;
                var l = 0;
                for (var i = 1; i < name.Length; ++i)
                {
                    var prefix = name.Substring(0, i);
                    if (Values.Keys.Any(k => !k.StartsWith(prefix)))
                        break;
                    l = i;
                }
                while (Values.Keys.Any(k => char.IsDigit(k[l + 1])))
                {
                    --l;
                    while (l > 0 && name[l] != '_')
                        --l;
                }
                return l;
            }
        }

        /// <summary>
        /// C# name
        /// </summary>
        public string CSharpName => Name.ToCSharpName();

        /// <summary>
        /// True iff enum could be flags
        /// </summary>
        public bool FlagCompatible => Values.Values.All(v => v.IsPowerOfTwo());

        public override string ToString()
        {
            return "enum " + Name + " \n{\n" + Values.Select(kvp => "  " + kvp.Key + ",\n").Aggregate((s1, s2) => s1 + s2) + "}";
        }

        public IEnumerable<string> CSharpDefinition
        {
            get
            {
                var pl = PrefixLength;
                if (FlagCompatible)
                    yield return "[Flags]";
                yield return string.Format("public enum {0} /* {1} */", CSharpName, Name);
                yield return "{";
                foreach (var value in Values)
                    yield return string.Format("    {0} = {1},", value.Key.Substring(pl).ToCSharpName(), value.Value);
                yield return "}";
            }
        }

        public void AddReference(string dll, ITypeProvider typer)
        {
            ReferencedDlls.Add(dll);
        }
    }
}
