using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
