using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sharpineer.Parser.Dll
{

    public class Dbghelp
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct SYMBOL_INFOW
        {
            uint SizeOfStruct;
            uint TypeIndex;
            UInt64 Reserved1;
            UInt64 Reserved2;
            uint Index;
            uint Size;
            UInt64 ModBase;
            uint Flags;
            UInt64 Value;
            UInt64 Address;
            uint Register;
            uint Scope;
            uint Tag;
            uint NameLen;
            uint MaxNameLen;
            [MarshalAs(UnmanagedType.LPTStr)]
            string Name;
        }
        public delegate bool SYM_ENUMERATESYMBOLS_CALLBACKW(
            [param: MarshalAs(UnmanagedType.LPStruct)]
            SYMBOL_INFOW pSymInfo,
            UInt32 SymbolSize,
            IntPtr UserContext
        );

        [DllImport("dbghelp.dll", EntryPoint = "SymInitializeW", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern bool SymInitialize(
            IntPtr process,
            [param: MarshalAs(UnmanagedType.LPTStr)]
            string searchPath,
            bool invadeProcess);

        [DllImport("dbghelp.dll", EntryPoint = "SymCleanup", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern bool SymCleanup(IntPtr process);

        [DllImport("DbgHelp.dll")]
        public static extern bool SymEnumSymbols(
            IntPtr hProcess,
            UInt64 BaseOfDll,
            [param: MarshalAs(UnmanagedType.LPTStr)]
            string Mask,
             [param: MarshalAs(UnmanagedType.FunctionPtr)]
            SYM_ENUMERATESYMBOLS_CALLBACKW EnumSymbolsCallback,
            IntPtr UserContext
            );
    }
}
