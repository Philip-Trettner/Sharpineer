using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        /// <summary>
        /// Offset for fields
        /// </summary>
        public long Offset = -1;
        
        public string RefQualifier => Type.PointerType != null && !(Type.PointerType.StructInfo?.IsHandle ?? false) ? "ref " : "";
        public string FunctionArg => (Type.MarshalAs?.Length == 0 ? "" : Type.MarshalAs + " ") + RefQualifier + Type.DecoratedCSharpType + " @" + Name;

        public string OffsetAttribute => string.Format("[FieldOffset({0})]", Offset / 8);

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
                            yield return string.Format("public string {0}Str => new string({0});", Name);
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
