using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpineer.Parser.Header
{
    public interface ITypeProvider
    {
        StructInfo QueryStruct(string name);

        EnumInfo QueryEnum(string name);
    }
}
