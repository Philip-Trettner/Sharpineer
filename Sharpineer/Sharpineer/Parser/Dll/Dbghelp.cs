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
        [Flags]
        public enum SymFlag : uint
        {
            VALUEPRESENT = 0x00000001,
            REGISTER = 0x00000008,
            REGREL = 0x00000010,
            FRAMEREL = 0x00000020,
            PARAMETER = 0x00000040,
            LOCAL = 0x00000080,
            CONSTANT = 0x00000100,
            EXPORT = 0x00000200,
            FORWARDER = 0x00000400,
            FUNCTION = 0x00000800,
            VIRTUAL = 0x00001000,
            THUNK = 0x00002000,
            TLSREL = 0x00004000,
        }
        [Flags]
        public enum SymTagEnum : uint
        {
            Null,
            Exe,
            Compiland,
            CompilandDetails,
            CompilandEnv,
            Function,
            Block,
            Data,
            Annotation,
            Label,
            PublicSymbol,
            UDT,
            Enum,
            FunctionType,
            PointerType,
            ArrayType,
            BaseType,
            Typedef,
            BaseClass,
            Friend,
            FunctionArgType,
            FuncDebugStart,
            FuncDebugEnd,
            UsingNamespace,
            VTableShape,
            VTable,
            Custom,
            Thunk,
            CustomType,
            ManagedType,
            Dimension
        };
        [StructLayout(LayoutKind.Sequential)]
        public struct SYMBOL_INFO
        {
            public uint SizeOfStruct;
            public uint TypeIndex;
            public ulong Reserved1;
            public ulong Reserved2;
            public uint Reserved3;
            public uint Size;
            public ulong ModBase;
            public SymFlag Flags;
            public ulong Value;
            public ulong Address;
            public uint Register;
            public uint Scope;
            public SymTagEnum Tag;
            public int NameLen;
            public int MaxNameLen;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
            public string Name;
        };

        [StructLayout(LayoutKind.Sequential)]
        public class _MODLOAD_DATA
        {
            uint ssize;
            uint ssig;
            IntPtr data;
            uint size;
            uint flags;
        }

        public delegate bool SymEnumSymbolsProc(
            [MarshalAs(UnmanagedType.Struct)]
            SYMBOL_INFO pSymInfo,
            UInt32 SymbolSize,
            IntPtr UserContext
        );

        [DllImport("dbghelp.dll", EntryPoint = "SymInitializeW", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern bool SymInitialize(
            IntPtr process,
            [MarshalAs(UnmanagedType.LPTStr)]
            string searchPath,
            bool invadeProcess);

        [DllImport("dbghelp.dll", EntryPoint = "SymCleanup", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern bool SymCleanup(IntPtr process);

        [DllImport("DbgHelp.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern bool SymEnumSymbols(
            IntPtr hProcess,
            UInt64 BaseOfDll,
            [MarshalAs(UnmanagedType.LPTStr)]
            string Mask,
            SymEnumSymbolsProc EnumSymbolsCallback,
            IntPtr UserContext
            );
        [DllImport("DbgHelp.dll", EntryPoint = "SymLoadModuleExW", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
        public static extern UInt64 SymLoadModuleEx(
                                        IntPtr hProcess,
                                        IntPtr hFile,
                                    [MarshalAs(UnmanagedType.LPTStr)]
                                        string ImageName,
                                    [MarshalAs(UnmanagedType.LPTStr)]
                                        string ModuleName,
                                        UInt64 BaseOfDll,
                                        uint DllSize,
                                    [MarshalAs(UnmanagedType.LPStruct)]
                                        _MODLOAD_DATA Data,
                                        uint Flags
                                    );

    }
}
