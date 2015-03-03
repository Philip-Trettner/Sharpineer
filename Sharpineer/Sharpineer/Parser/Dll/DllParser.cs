using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sharpineer.Parser.Dll
{
    class DllParser
    {
        private string dllPath;
        public List<string> FunctionNames=new List<string>();
         
        public DllParser(string path)
        {
            dllPath = path;
            
        }

        public void Parse()
        {
            var processId = Process.GetCurrentProcess().Handle;
            var succ = Dbghelp.SymInitialize(processId, null, false);
            var dllbase = Dbghelp.SymLoadModuleEx(processId, IntPtr.Zero, dllPath, null, 0, 0, null, 0);
            var err = Marshal.GetLastWin32Error();
            Dbghelp.SymEnumSymbols(processId, dllbase, "*", callback, IntPtr.Zero);
        }

        public bool callback(
            Dbghelp.SYMBOL_INFO pSymInfo,
            UInt32 SymbolSize,
            IntPtr UserContext
            )
        {
            FunctionNames.Add(pSymInfo.Name);
            return true;
        }
    }
}
