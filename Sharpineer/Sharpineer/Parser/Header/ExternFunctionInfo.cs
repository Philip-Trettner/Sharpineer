using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClangSharp;

namespace Sharpineer.Parser.Header
{
    /// <summary>
    /// Information about extern "C" functions
    /// </summary>
    public class ExternFunctionInfo
    {
        /// <summary>
        /// Function name
        /// </summary>
        public string Name;

        /// <summary>
        /// Function parameters
        /// </summary>
        public readonly List<ArgumentInfo> Parameters = new List<ArgumentInfo>();

        /// <summary>
        /// Function return type
        /// </summary>
        public TypeInfo ReturnType;

        /// <summary>
        /// Calling convention
        /// </summary>
        public CXCallingConv CallingConvention;
    }
}
