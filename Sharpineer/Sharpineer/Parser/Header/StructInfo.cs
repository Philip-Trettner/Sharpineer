using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpineer.Parser.Header
{
    public class StructInfo
    {
        public string Name;
        public TypeInfo TypeInfo;

        public readonly List<ArgumentInfo> Members = new List<ArgumentInfo>();
    }
}
