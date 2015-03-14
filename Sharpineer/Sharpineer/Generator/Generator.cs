using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Sharpineer.Parser.Dll;
using Sharpineer.Parser.Header;

namespace Sharpineer.Generator
{
    public class Generator
    {
        public readonly string ClassName;
        public readonly string Namespace;
        public readonly List<string> Headers = new List<string>();
        public readonly Dictionary<string, string> DllNames = new Dictionary<string, string>();

        public Generator(string className, string @namespace, bool includeWindows = true)
        {
            ClassName = className;
            Namespace = @namespace;

            if (includeWindows)
            {
                Headers.Add("Windows.h");
                DllNames.Add("User32.dll", @"c:\windows\system32\user32.dll");
            }
        }

        public static IEnumerable<string> CSharpFileFor(string @namespace, IEnumerable<string> content)
        {
            yield return "using System;";
            yield return "using System.Collections.Generic;";
            yield return "using System.Linq;";
            yield return "using System.Runtime.InteropServices;";
            yield return "using System.Text;";
            yield return "using System.Threading.Tasks;";
            yield return "";
            yield return "namespace " + @namespace;
            yield return "{";
            foreach (var line in content)
                yield return "    " + line;
            yield return "}";
        }

        public void Generate(string basePath)
        {
            // instantiate dll parser
            var dllparser = new Dictionary<string, DllParser>();
            foreach (var kvp in DllNames)
            {
                var dparser = new DllParser(kvp.Value);
                dparser.Parse();
                dllparser.Add(kvp.Key, dparser);
            }

            var function = new List<string>();
            var enums = new List<string>();
            var structs = new List<string>();

            // parse headers
            foreach (var header in Headers)
            {
                // parse header
                var hparser = new HeaderParser(header);
                hparser.Parse();

                // annotate dll names
                foreach (var parser in dllparser)
                    hparser.NotifyDll(parser.Key, parser.Value.FunctionNames);

                // merge func names
                hparser.MergeAnsiUnicode();

                // generate structs
                foreach (var @struct in hparser.Structs.Values)
                {
                    // ignore non-referenced structs
                    if (!@struct.ReferencedDlls.Any(dllparser.ContainsKey))
                        continue;

                    if (structs.Count > 0)
                        structs.Add("");
                    structs.AddRange(@struct.CSharpDefinition);
                }

                // generate enums
                foreach (var @enum in hparser.Enums.Values)
                {
                    // ignore non-referenced enums
                    if (!@enum.ReferencedDlls.Any(dllparser.ContainsKey))
                        continue;

                    if (enums.Count > 0)
                        enums.Add("");
                    enums.AddRange(@enum.CSharpDefinition);
                }

                // generate functions
                function.Add("public static class " + ClassName);
                function.Add("{");
                foreach (var func in hparser.ExternFunctions.Values.
                    Where(f => !string.IsNullOrEmpty(f.DllName)).
                    OrderBy(f => f.Name))
                {
                    function.Add("");
                    function.Add("    " + func.DllImportString);
                    function.Add("    " + func.FunctionDeclaration);
                }
                function.Add("}");
            }

            // save lines
            File.WriteAllLines(Path.Combine(basePath, "Functions.cs"), CSharpFileFor(Namespace, function));
            File.WriteAllLines(Path.Combine(basePath, "Enums.cs"), CSharpFileFor(Namespace, enums));
            File.WriteAllLines(Path.Combine(basePath, "Structs.cs"), CSharpFileFor(Namespace, structs));
        }
    }
}
