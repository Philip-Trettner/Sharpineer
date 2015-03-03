using System;
using System.Collections.Generic;
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
        public string Name;
        public CXTypeKind Type;

        public EnumInfo EnumType; // if Type == Enum

        public static TypeInfo FromClangType(CXType type)
        {
            var info = new TypeInfo
            {
                Name = clang.getTypeSpelling(type).ToString(),
                Type = type.kind
            };
            return info;
        }
    }
}
