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
        /// Name of the imported dll
        /// </summary>
        public string DllName;

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

        /// <summary>
        /// If true, this function has FooA/FooW versions
        /// </summary>
        public bool HasAnsiUnicodeVersions;

        /// <summary>
        /// True if any parameter is unnamed
        /// </summary>
        public bool HasUnnamedParameter => Parameters.Any(p => string.IsNullOrEmpty(p.Name));

        /// <summary>
        /// True iff any type requires unicode
        /// </summary>
        public bool RequiresUnicode => Parameters.Any(p => p.Type.RequiresUnicode) || ReturnType.RequiresUnicode;

        /// <summary>
        /// [DllImport] Statement
        /// </summary>
        public string DllImportString => string.Format("[DllImport(\"{0}\", CharSet = CharSet.{1}, SetLastError = true)]", DllName, RequiresUnicode ? "Unicode" : "Auto");

        /// <summary>
        /// C# Parameter string without braces
        /// </summary>
        public string ParametersCSharpString => Parameters.Count == 0 ? "" : Parameters.Select(p => p.FunctionArg).Aggregate((s1, s2) => s1 + ", " + s2);

        /// <summary>
        /// C# Function declaration
        /// </summary>
        public string FunctionDeclaration => string.Format("public static extern {0} {1}({2});", ReturnType.DecoratedCSharpType, Name, ParametersCSharpString);

        public void AddReference(string dll, ITypeProvider typer)
        {
            ReturnType.AddReference(dll, typer);
            foreach (var arg in Parameters)
                arg.AddReference(dll, typer);
        }

        public IEnumerable<string> CSharpDefinition
        {
            get
            {
                yield return DllImportString;
                if (ReturnType.CSharpType == "bool")
                    yield return "[return: MarshalAs(UnmanagedType.Bool)]";
                yield return FunctionDeclaration;
            }
        }
    }
}
