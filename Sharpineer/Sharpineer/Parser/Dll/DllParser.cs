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
        public DllParser(string path)
        {
            dllPath = path;
        }

        public void Parse()
        {
            var processId = new IntPtr(Process.GetCurrentProcess().Id);
            Dbghelp.SymInitialize(processId, null, false);
            Dbghelp.SymEnumSymbols(processId, 0, "*", callback, IntPtr.Zero);
        }

        public bool callback(
            [param: MarshalAs(UnmanagedType.LPStruct)] Dbghelp.SYMBOL_INFOW pSymInfo,
            UInt32 SymbolSize,
            IntPtr UserContext
            )
        {
            return true;
        }
    }
}
