using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpineer.Parser.Header
{
    /// <summary>
    /// Function parameter info
    /// </summary>
    public class ArgumentInfo
    {
        public string Name;
        public TypeInfo Type;

        public override string ToString() => Name + ": " + Type;

        /// <summary>
        /// Returns list of converter members
        /// </summary>
        public IEnumerable<string> Converters
        {
            get
            {
                foreach (var converter in Type.Converters)
                    switch (converter)
                    {
                        case TypeConverter.AsciiEncoder:
                            yield return string.Format("public string {0}Str => Encoding.ASCII.GetString({0});", Name);
                            break;
                        case TypeConverter.WCharEncoder:
                            yield return string.Format("public string {0}Str => Encoding.Unicode.GetString({0});", Name);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
            }
        }

        public void AddReference(string dll, ITypeProvider typer)
        {
            Type.AddReference(dll, typer);
        }
    }
}
