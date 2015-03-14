using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace User32Dll
{
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct LUID /* _LUID, _LUID */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ LowPart;
        [FieldOffset(4)]
        public int /* LONG */ HighPart;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct SECURITY_QUALITY_OF_SERVICE /* _SECURITY_QUALITY_OF_SERVICE, _SECURITY_QUALITY_OF_SERVICE */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ Length;
        [FieldOffset(4)]
        public SECURITY_IMPERSONATION_LEVEL /* SECURITY_IMPERSONATION_LEVEL */ ImpersonationLevel;
        [FieldOffset(8)]
        public byte /* SECURITY_CONTEXT_TRACKING_MODE */ ContextTrackingMode;
        [FieldOffset(9)]
        public byte /* BOOLEAN */ EffectiveOnly;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HINSTANCE /* HINSTANCE__, HINSTANCE__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HRGN /* HRGN__, HRGN__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HWINSTA /* HWINSTA__, HWINSTA__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HKL /* HKL__, HKL__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HWND /* HWND__, HWND__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HHOOK /* HHOOK__, HHOOK__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HACCEL /* HACCEL__, HACCEL__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HBITMAP /* HBITMAP__, HBITMAP__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HBRUSH /* HBRUSH__, HBRUSH__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HDC /* HDC__, HDC__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HDESK /* HDESK__, HDESK__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HICON /* HICON__, HICON__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HMENU /* HMENU__, HMENU__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HWINEVENTHOOK /* HWINEVENTHOOK__, HWINEVENTHOOK__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HMONITOR /* HMONITOR__, HMONITOR__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct RECT /* tagRECT, tagRECT */
    {
        [FieldOffset(0)]
        public int /* LONG */ left;
        [FieldOffset(4)]
        public int /* LONG */ top;
        [FieldOffset(8)]
        public int /* LONG */ right;
        [FieldOffset(12)]
        public int /* LONG */ bottom;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct POINT /* tagPOINT, tagPOINT */
    {
        [FieldOffset(0)]
        public int /* LONG */ x;
        [FieldOffset(4)]
        public int /* LONG */ y;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct POINTL /* _POINTL, _POINTL */
    {
        [FieldOffset(0)]
        public int /* LONG */ x;
        [FieldOffset(4)]
        public int /* LONG */ y;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct SIZE /* tagSIZE, tagSIZE */
    {
        [FieldOffset(0)]
        public int /* LONG */ cx;
        [FieldOffset(4)]
        public int /* LONG */ cy;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct POINTS /* tagPOINTS, tagPOINTS */
    {
        [FieldOffset(0)]
        public short /* SHORT */ x;
        [FieldOffset(2)]
        public short /* SHORT */ y;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct SECURITY_ATTRIBUTES /* _SECURITY_ATTRIBUTES, _SECURITY_ATTRIBUTES */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ nLength;
        [FieldOffset(8)]
        public IntPtr /* void * */ lpSecurityDescriptor;
        [FieldOffset(16)]
        public bool bInheritHandle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct devicemodeA /* _devicemodeA, _devicemodeA */
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [FieldOffset(0)]
        public byte[] /*  [32] */ dmDeviceName;
        [FieldOffset(32)]
        public ushort /* WORD */ dmSpecVersion;
        [FieldOffset(34)]
        public ushort /* WORD */ dmDriverVersion;
        [FieldOffset(36)]
        public ushort /* WORD */ dmSize;
        [FieldOffset(38)]
        public ushort /* WORD */ dmDriverExtra;
        [FieldOffset(40)]
        public uint /* DWORD */ dmFields;
        [FieldOffset(44)]
        public short dmOrientation;
        [FieldOffset(46)]
        public short dmPaperSize;
        [FieldOffset(48)]
        public short dmPaperLength;
        [FieldOffset(50)]
        public short dmPaperWidth;
        [FieldOffset(52)]
        public short dmScale;
        [FieldOffset(54)]
        public short dmCopies;
        [FieldOffset(56)]
        public short dmDefaultSource;
        [FieldOffset(58)]
        public short dmPrintQuality;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(44)]
        public POINTL /* POINTL */ dmPosition;
        [FieldOffset(52)]
        public uint /* DWORD */ dmDisplayOrientation;
        [FieldOffset(56)]
        public uint /* DWORD */ dmDisplayFixedOutput;
        [FieldOffset(60)]
        public short dmColor;
        [FieldOffset(62)]
        public short dmDuplex;
        [FieldOffset(64)]
        public short dmYResolution;
        [FieldOffset(66)]
        public short dmTTOption;
        [FieldOffset(68)]
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [FieldOffset(70)]
        public byte[] /*  [32] */ dmFormName;
        [FieldOffset(102)]
        public ushort /* WORD */ dmLogPixels;
        [FieldOffset(104)]
        public uint /* DWORD */ dmBitsPerPel;
        [FieldOffset(108)]
        public uint /* DWORD */ dmPelsWidth;
        [FieldOffset(112)]
        public uint /* DWORD */ dmPelsHeight;
        [FieldOffset(116)]
        public uint /* DWORD */ dmDisplayFlags;
        [FieldOffset(116)]
        public uint /* DWORD */ dmNup;
        [FieldOffset(120)]
        public uint /* DWORD */ dmDisplayFrequency;
        [FieldOffset(124)]
        public uint /* DWORD */ dmICMMethod;
        [FieldOffset(128)]
        public uint /* DWORD */ dmICMIntent;
        [FieldOffset(132)]
        public uint /* DWORD */ dmMediaType;
        [FieldOffset(136)]
        public uint /* DWORD */ dmDitherType;
        [FieldOffset(140)]
        public uint /* DWORD */ dmReserved1;
        [FieldOffset(144)]
        public uint /* DWORD */ dmReserved2;
        [FieldOffset(148)]
        public uint /* DWORD */ dmPanningWidth;
        [FieldOffset(152)]
        public uint /* DWORD */ dmPanningHeight;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct devicemodeW /* _devicemodeW, _devicemodeW */
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [FieldOffset(0)]
        public char[] /*  [32] */ dmDeviceName;
        public string dmDeviceNameStr => new string(dmDeviceName);
        [FieldOffset(64)]
        public ushort /* WORD */ dmSpecVersion;
        [FieldOffset(66)]
        public ushort /* WORD */ dmDriverVersion;
        [FieldOffset(68)]
        public ushort /* WORD */ dmSize;
        [FieldOffset(70)]
        public ushort /* WORD */ dmDriverExtra;
        [FieldOffset(72)]
        public uint /* DWORD */ dmFields;
        [FieldOffset(76)]
        public short dmOrientation;
        [FieldOffset(78)]
        public short dmPaperSize;
        [FieldOffset(80)]
        public short dmPaperLength;
        [FieldOffset(82)]
        public short dmPaperWidth;
        [FieldOffset(84)]
        public short dmScale;
        [FieldOffset(86)]
        public short dmCopies;
        [FieldOffset(88)]
        public short dmDefaultSource;
        [FieldOffset(90)]
        public short dmPrintQuality;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(76)]
        public POINTL /* POINTL */ dmPosition;
        [FieldOffset(84)]
        public uint /* DWORD */ dmDisplayOrientation;
        [FieldOffset(88)]
        public uint /* DWORD */ dmDisplayFixedOutput;
        [FieldOffset(92)]
        public short dmColor;
        [FieldOffset(94)]
        public short dmDuplex;
        [FieldOffset(96)]
        public short dmYResolution;
        [FieldOffset(98)]
        public short dmTTOption;
        [FieldOffset(100)]
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [FieldOffset(102)]
        public char[] /*  [32] */ dmFormName;
        public string dmFormNameStr => new string(dmFormName);
        [FieldOffset(166)]
        public ushort /* WORD */ dmLogPixels;
        [FieldOffset(168)]
        public uint /* DWORD */ dmBitsPerPel;
        [FieldOffset(172)]
        public uint /* DWORD */ dmPelsWidth;
        [FieldOffset(176)]
        public uint /* DWORD */ dmPelsHeight;
        [FieldOffset(180)]
        public uint /* DWORD */ dmDisplayFlags;
        [FieldOffset(180)]
        public uint /* DWORD */ dmNup;
        [FieldOffset(184)]
        public uint /* DWORD */ dmDisplayFrequency;
        [FieldOffset(188)]
        public uint /* DWORD */ dmICMMethod;
        [FieldOffset(192)]
        public uint /* DWORD */ dmICMIntent;
        [FieldOffset(196)]
        public uint /* DWORD */ dmMediaType;
        [FieldOffset(200)]
        public uint /* DWORD */ dmDitherType;
        [FieldOffset(204)]
        public uint /* DWORD */ dmReserved1;
        [FieldOffset(208)]
        public uint /* DWORD */ dmReserved2;
        [FieldOffset(212)]
        public uint /* DWORD */ dmPanningWidth;
        [FieldOffset(216)]
        public uint /* DWORD */ dmPanningHeight;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAY_DEVICEA /* _DISPLAY_DEVICEA, _DISPLAY_DEVICEA */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [FieldOffset(4)]
        public byte[] /*  [32] */ DeviceName;
        public string DeviceNameStr => Encoding.ASCII.GetString(DeviceName);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        [FieldOffset(36)]
        public byte[] /*  [128] */ DeviceString;
        public string DeviceStringStr => Encoding.ASCII.GetString(DeviceString);
        [FieldOffset(164)]
        public uint /* DWORD */ StateFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        [FieldOffset(168)]
        public byte[] /*  [128] */ DeviceID;
        public string DeviceIDStr => Encoding.ASCII.GetString(DeviceID);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        [FieldOffset(296)]
        public byte[] /*  [128] */ DeviceKey;
        public string DeviceKeyStr => Encoding.ASCII.GetString(DeviceKey);
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAY_DEVICEW /* _DISPLAY_DEVICEW, _DISPLAY_DEVICEW */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [FieldOffset(4)]
        public char[] /*  [32] */ DeviceName;
        public string DeviceNameStr => new string(DeviceName);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        [FieldOffset(68)]
        public char[] /*  [128] */ DeviceString;
        public string DeviceStringStr => new string(DeviceString);
        [FieldOffset(324)]
        public uint /* DWORD */ StateFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        [FieldOffset(328)]
        public char[] /*  [128] */ DeviceID;
        public string DeviceIDStr => new string(DeviceID);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        [FieldOffset(584)]
        public char[] /*  [128] */ DeviceKey;
        public string DeviceKeyStr => new string(DeviceKey);
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAYCONFIG_RATIONAL /* DISPLAYCONFIG_RATIONAL, DISPLAYCONFIG_RATIONAL */
    {
        [FieldOffset(0)]
        public uint /* UINT32 */ Numerator;
        [FieldOffset(4)]
        public uint /* UINT32 */ Denominator;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAYCONFIG_2DREGION /* DISPLAYCONFIG_2DREGION, DISPLAYCONFIG_2DREGION */
    {
        [FieldOffset(0)]
        public uint /* UINT32 */ cx;
        [FieldOffset(4)]
        public uint /* UINT32 */ cy;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAYCONFIG_VIDEO_SIGNAL_INFO /* DISPLAYCONFIG_VIDEO_SIGNAL_INFO, DISPLAYCONFIG_VIDEO_SIGNAL_INFO */
    {
        [FieldOffset(0)]
        public ulong /* UINT64 */ pixelRate;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(8)]
        public DISPLAYCONFIG_RATIONAL hSyncFreq;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public DISPLAYCONFIG_RATIONAL vSyncFreq;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public DISPLAYCONFIG_2DREGION activeSize;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public DISPLAYCONFIG_2DREGION totalSize;
        [FieldOffset(40)]
        public uint /* UINT32 */ videoStandard;
        [FieldOffset(0)]
        public uint /* UINT32 */ vSyncFreqDivider;
        [FieldOffset(0)]
        public uint /* UINT32 */ reserved;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(40)]
        public DISPLAYCONFIG_VIDEO_SIGNAL_INFO::(anonymous struct at C:\Program Files (x86)\Windows Kits\8.1\include\um\wingdi.h:2839:9) /* struct (anonymous struct at C:\Program Files (x86)\Windows Kits\8.1\include\um\wingdi.h:2839:9) */ AdditionalSignalInfo;
        [FieldOffset(40)]
        public uint /* UINT32 */ videoStandard;
        [FieldOffset(0)]
        public uint /* UINT32 */ vSyncFreqDivider;
        [FieldOffset(0)]
        public uint /* UINT32 */ reserved;
        [FieldOffset(40)]
        public uint /* UINT32 */ videoStandard;
        [FieldOffset(44)]
        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAYCONFIG_SOURCE_MODE /* DISPLAYCONFIG_SOURCE_MODE, DISPLAYCONFIG_SOURCE_MODE */
    {
        [FieldOffset(0)]
        public uint /* UINT32 */ width;
        [FieldOffset(4)]
        public uint /* UINT32 */ height;
        [FieldOffset(8)]
        public DISPLAYCONFIG_PIXELFORMAT pixelFormat;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(12)]
        public POINTL /* POINTL */ position;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAYCONFIG_TARGET_MODE /* DISPLAYCONFIG_TARGET_MODE, DISPLAYCONFIG_TARGET_MODE */
    {
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public DISPLAYCONFIG_VIDEO_SIGNAL_INFO targetVideoSignalInfo;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAYCONFIG_MODE_INFO /* DISPLAYCONFIG_MODE_INFO, DISPLAYCONFIG_MODE_INFO */
    {
        [FieldOffset(0)]
        public DISPLAYCONFIG_MODE_INFO_TYPE infoType;
        [FieldOffset(4)]
        public uint /* UINT32 */ id;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(8)]
        public LUID /* LUID */ adapterId;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public DISPLAYCONFIG_TARGET_MODE targetMode;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public DISPLAYCONFIG_SOURCE_MODE sourceMode;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAYCONFIG_PATH_SOURCE_INFO /* DISPLAYCONFIG_PATH_SOURCE_INFO, DISPLAYCONFIG_PATH_SOURCE_INFO */
    {
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public LUID /* LUID */ adapterId;
        [FieldOffset(8)]
        public uint /* UINT32 */ id;
        [FieldOffset(12)]
        public uint /* UINT32 */ modeInfoIdx;
        [FieldOffset(16)]
        public uint /* UINT32 */ statusFlags;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAYCONFIG_PATH_TARGET_INFO /* DISPLAYCONFIG_PATH_TARGET_INFO, DISPLAYCONFIG_PATH_TARGET_INFO */
    {
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public LUID /* LUID */ adapterId;
        [FieldOffset(8)]
        public uint /* UINT32 */ id;
        [FieldOffset(12)]
        public uint /* UINT32 */ modeInfoIdx;
        [FieldOffset(16)]
        public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
        [FieldOffset(20)]
        public DISPLAYCONFIG_ROTATION rotation;
        [FieldOffset(24)]
        public DISPLAYCONFIG_SCALING scaling;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(28)]
        public DISPLAYCONFIG_RATIONAL refreshRate;
        [FieldOffset(36)]
        public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
        [FieldOffset(40)]
        public bool targetAvailable;
        [FieldOffset(44)]
        public uint /* UINT32 */ statusFlags;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAYCONFIG_PATH_INFO /* DISPLAYCONFIG_PATH_INFO, DISPLAYCONFIG_PATH_INFO */
    {
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public DISPLAYCONFIG_PATH_SOURCE_INFO sourceInfo;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(20)]
        public DISPLAYCONFIG_PATH_TARGET_INFO targetInfo;
        [FieldOffset(68)]
        public uint /* UINT32 */ flags;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DISPLAYCONFIG_DEVICE_INFO_HEADER /* DISPLAYCONFIG_DEVICE_INFO_HEADER, DISPLAYCONFIG_DEVICE_INFO_HEADER */
    {
        [FieldOffset(0)]
        public DISPLAYCONFIG_DEVICE_INFO_TYPE type;
        [FieldOffset(4)]
        public uint /* UINT32 */ size;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(8)]
        public LUID /* LUID */ adapterId;
        [FieldOffset(16)]
        public uint /* UINT32 */ id;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct BLENDFUNCTION /* _BLENDFUNCTION, _BLENDFUNCTION */
    {
        [FieldOffset(0)]
        public byte BlendOp;
        [FieldOffset(1)]
        public byte BlendFlags;
        [FieldOffset(2)]
        public byte SourceConstantAlpha;
        [FieldOffset(3)]
        public byte AlphaFormat;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct MOUSEMOVEPOINT /* tagMOUSEMOVEPOINT, tagMOUSEMOVEPOINT */
    {
        [FieldOffset(0)]
        public int x;
        [FieldOffset(4)]
        public int y;
        [FieldOffset(8)]
        public uint /* DWORD */ time;
        [FieldOffset(16)]
        public ulong /* ULONG_PTR */ dwExtraInfo;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct WNDCLASSEXA /* tagWNDCLASSEXA, tagWNDCLASSEXA */
    {
        [FieldOffset(0)]
        public uint /* UINT */ cbSize;
        [FieldOffset(4)]
        public uint /* UINT */ style;
        [FieldOffset(8)]
        public IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ lpfnWndProc;
        [FieldOffset(16)]
        public int cbClsExtra;
        [FieldOffset(20)]
        public int cbWndExtra;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HINSTANCE /* HINSTANCE */ hInstance;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public HICON /* HICON */ hIcon;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(40)]
        public HICON /* HCURSOR */ hCursor;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(48)]
        public HBRUSH /* HBRUSH */ hbrBackground;
        [FieldOffset(56)]
        public IntPtr /* const char * */ lpszMenuName;
        [FieldOffset(64)]
        public IntPtr /* const char * */ lpszClassName;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(72)]
        public HICON /* HICON */ hIconSm;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct WNDCLASSEXW /* tagWNDCLASSEXW, tagWNDCLASSEXW */
    {
        [FieldOffset(0)]
        public uint /* UINT */ cbSize;
        [FieldOffset(4)]
        public uint /* UINT */ style;
        [FieldOffset(8)]
        public IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ lpfnWndProc;
        [FieldOffset(16)]
        public int cbClsExtra;
        [FieldOffset(20)]
        public int cbWndExtra;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HINSTANCE /* HINSTANCE */ hInstance;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public HICON /* HICON */ hIcon;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(40)]
        public HICON /* HCURSOR */ hCursor;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(48)]
        public HBRUSH /* HBRUSH */ hbrBackground;
        [FieldOffset(56)]
        public IntPtr /* const wchar_t * */ lpszMenuName;
        [FieldOffset(64)]
        public IntPtr /* const wchar_t * */ lpszClassName;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(72)]
        public HICON /* HICON */ hIconSm;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct WNDCLASSA /* tagWNDCLASSA, tagWNDCLASSA */
    {
        [FieldOffset(0)]
        public uint /* UINT */ style;
        [FieldOffset(8)]
        public IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ lpfnWndProc;
        [FieldOffset(16)]
        public int cbClsExtra;
        [FieldOffset(20)]
        public int cbWndExtra;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HINSTANCE /* HINSTANCE */ hInstance;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public HICON /* HICON */ hIcon;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(40)]
        public HICON /* HCURSOR */ hCursor;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(48)]
        public HBRUSH /* HBRUSH */ hbrBackground;
        [FieldOffset(56)]
        public IntPtr /* const char * */ lpszMenuName;
        [FieldOffset(64)]
        public IntPtr /* const char * */ lpszClassName;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct WNDCLASSW /* tagWNDCLASSW, tagWNDCLASSW */
    {
        [FieldOffset(0)]
        public uint /* UINT */ style;
        [FieldOffset(8)]
        public IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ lpfnWndProc;
        [FieldOffset(16)]
        public int cbClsExtra;
        [FieldOffset(20)]
        public int cbWndExtra;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HINSTANCE /* HINSTANCE */ hInstance;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public HICON /* HICON */ hIcon;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(40)]
        public HICON /* HCURSOR */ hCursor;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(48)]
        public HBRUSH /* HBRUSH */ hbrBackground;
        [FieldOffset(56)]
        public IntPtr /* const wchar_t * */ lpszMenuName;
        [FieldOffset(64)]
        public IntPtr /* const wchar_t * */ lpszClassName;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct MSG /* tagMSG, tagMSG */
    {
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public HWND /* HWND */ hwnd;
        [FieldOffset(8)]
        public uint /* UINT */ message;
        [FieldOffset(16)]
        public ulong /* WPARAM */ wParam;
        [FieldOffset(24)]
        public long /* LPARAM */ lParam;
        [FieldOffset(32)]
        public uint /* DWORD */ time;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(36)]
        public POINT /* POINT */ pt;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct TRACKMOUSEEVENT /* tagTRACKMOUSEEVENT, tagTRACKMOUSEEVENT */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [FieldOffset(4)]
        public uint /* DWORD */ dwFlags;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(8)]
        public HWND /* HWND */ hwndTrack;
        [FieldOffset(16)]
        public uint /* DWORD */ dwHoverTime;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct ACCEL /* tagACCEL, tagACCEL */
    {
        [FieldOffset(0)]
        public byte fVirt;
        [FieldOffset(2)]
        public ushort /* WORD */ key;
        [FieldOffset(4)]
        public ushort /* WORD */ cmd;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct PAINTSTRUCT /* tagPAINTSTRUCT, tagPAINTSTRUCT */
    {
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public HDC /* HDC */ hdc;
        [FieldOffset(8)]
        public bool fErase;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(12)]
        public RECT /* RECT */ rcPaint;
        [FieldOffset(28)]
        public bool fRestore;
        [FieldOffset(32)]
        public bool fIncUpdate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [FieldOffset(36)]
        public byte[] /*  [32] */ rgbReserved;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct WINDOWPLACEMENT /* tagWINDOWPLACEMENT, tagWINDOWPLACEMENT */
    {
        [FieldOffset(0)]
        public uint /* UINT */ length;
        [FieldOffset(4)]
        public uint /* UINT */ flags;
        [FieldOffset(8)]
        public uint /* UINT */ showCmd;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(12)]
        public POINT /* POINT */ ptMinPosition;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(20)]
        public POINT /* POINT */ ptMaxPosition;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(28)]
        public RECT /* RECT */ rcNormalPosition;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct MOUSEINPUT /* tagMOUSEINPUT, tagMOUSEINPUT */
    {
        [FieldOffset(0)]
        public int /* LONG */ dx;
        [FieldOffset(4)]
        public int /* LONG */ dy;
        [FieldOffset(8)]
        public uint /* DWORD */ mouseData;
        [FieldOffset(12)]
        public uint /* DWORD */ dwFlags;
        [FieldOffset(16)]
        public uint /* DWORD */ time;
        [FieldOffset(24)]
        public ulong /* ULONG_PTR */ dwExtraInfo;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct KEYBDINPUT /* tagKEYBDINPUT, tagKEYBDINPUT */
    {
        [FieldOffset(0)]
        public ushort /* WORD */ wVk;
        [FieldOffset(2)]
        public ushort /* WORD */ wScan;
        [FieldOffset(4)]
        public uint /* DWORD */ dwFlags;
        [FieldOffset(8)]
        public uint /* DWORD */ time;
        [FieldOffset(16)]
        public ulong /* ULONG_PTR */ dwExtraInfo;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HARDWAREINPUT /* tagHARDWAREINPUT, tagHARDWAREINPUT */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ uMsg;
        [FieldOffset(4)]
        public ushort /* WORD */ wParamL;
        [FieldOffset(6)]
        public ushort /* WORD */ wParamH;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct INPUT /* tagINPUT, tagINPUT */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ type;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(8)]
        public MOUSEINPUT /* MOUSEINPUT */ mi;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(8)]
        public KEYBDINPUT /* KEYBDINPUT */ ki;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(8)]
        public HARDWAREINPUT /* HARDWAREINPUT */ hi;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HTOUCHINPUT /* HTOUCHINPUT__, HTOUCHINPUT__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct TOUCHINPUT /* tagTOUCHINPUT, tagTOUCHINPUT */
    {
        [FieldOffset(0)]
        public int /* LONG */ x;
        [FieldOffset(4)]
        public int /* LONG */ y;
        [FieldOffset(8)]
        public IntPtr /* void * */ hSource;
        [FieldOffset(16)]
        public uint /* DWORD */ dwID;
        [FieldOffset(20)]
        public uint /* DWORD */ dwFlags;
        [FieldOffset(24)]
        public uint /* DWORD */ dwMask;
        [FieldOffset(28)]
        public uint /* DWORD */ dwTime;
        [FieldOffset(32)]
        public ulong /* ULONG_PTR */ dwExtraInfo;
        [FieldOffset(40)]
        public uint /* DWORD */ cxContact;
        [FieldOffset(44)]
        public uint /* DWORD */ cyContact;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct LASTINPUTINFO /* tagLASTINPUTINFO, tagLASTINPUTINFO */
    {
        [FieldOffset(0)]
        public uint /* UINT */ cbSize;
        [FieldOffset(4)]
        public uint /* DWORD */ dwTime;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct TPMPARAMS /* tagTPMPARAMS, tagTPMPARAMS */
    {
        [FieldOffset(0)]
        public uint /* UINT */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(4)]
        public RECT /* RECT */ rcExclude;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct MENUINFO /* tagMENUINFO, tagMENUINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [FieldOffset(4)]
        public uint /* DWORD */ fMask;
        [FieldOffset(8)]
        public uint /* DWORD */ dwStyle;
        [FieldOffset(12)]
        public uint /* UINT */ cyMax;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public HBRUSH /* HBRUSH */ hbrBack;
        [FieldOffset(24)]
        public uint /* DWORD */ dwContextHelpID;
        [FieldOffset(32)]
        public ulong /* ULONG_PTR */ dwMenuData;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct MENUITEMINFOA /* tagMENUITEMINFOA, tagMENUITEMINFOA */
    {
        [FieldOffset(0)]
        public uint /* UINT */ cbSize;
        [FieldOffset(4)]
        public uint /* UINT */ fMask;
        [FieldOffset(8)]
        public uint /* UINT */ fType;
        [FieldOffset(12)]
        public uint /* UINT */ fState;
        [FieldOffset(16)]
        public uint /* UINT */ wID;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HMENU /* HMENU */ hSubMenu;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public HBITMAP /* HBITMAP */ hbmpChecked;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(40)]
        public HBITMAP /* HBITMAP */ hbmpUnchecked;
        [FieldOffset(48)]
        public ulong /* ULONG_PTR */ dwItemData;
        [FieldOffset(56)]
        public IntPtr /* char * */ dwTypeData;
        [FieldOffset(64)]
        public uint /* UINT */ cch;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(72)]
        public HBITMAP /* HBITMAP */ hbmpItem;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct MENUITEMINFOW /* tagMENUITEMINFOW, tagMENUITEMINFOW */
    {
        [FieldOffset(0)]
        public uint /* UINT */ cbSize;
        [FieldOffset(4)]
        public uint /* UINT */ fMask;
        [FieldOffset(8)]
        public uint /* UINT */ fType;
        [FieldOffset(12)]
        public uint /* UINT */ fState;
        [FieldOffset(16)]
        public uint /* UINT */ wID;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HMENU /* HMENU */ hSubMenu;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public HBITMAP /* HBITMAP */ hbmpChecked;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(40)]
        public HBITMAP /* HBITMAP */ hbmpUnchecked;
        [FieldOffset(48)]
        public ulong /* ULONG_PTR */ dwItemData;
        [FieldOffset(56)]
        public IntPtr /* wchar_t * */ dwTypeData;
        [FieldOffset(64)]
        public uint /* UINT */ cch;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(72)]
        public HBITMAP /* HBITMAP */ hbmpItem;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct DRAWTEXTPARAMS /* tagDRAWTEXTPARAMS, tagDRAWTEXTPARAMS */
    {
        [FieldOffset(0)]
        public uint /* UINT */ cbSize;
        [FieldOffset(4)]
        public int iTabLength;
        [FieldOffset(8)]
        public int iLeftMargin;
        [FieldOffset(12)]
        public int iRightMargin;
        [FieldOffset(16)]
        public uint /* UINT */ uiLengthDrawn;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct ICONINFO /* _ICONINFO, _ICONINFO */
    {
        [FieldOffset(0)]
        public bool fIcon;
        [FieldOffset(4)]
        public uint /* DWORD */ xHotspot;
        [FieldOffset(8)]
        public uint /* DWORD */ yHotspot;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public HBITMAP /* HBITMAP */ hbmMask;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HBITMAP /* HBITMAP */ hbmColor;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct ICONINFOEXA /* _ICONINFOEXA, _ICONINFOEXA */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [FieldOffset(4)]
        public bool fIcon;
        [FieldOffset(8)]
        public uint /* DWORD */ xHotspot;
        [FieldOffset(12)]
        public uint /* DWORD */ yHotspot;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public HBITMAP /* HBITMAP */ hbmMask;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HBITMAP /* HBITMAP */ hbmColor;
        [FieldOffset(32)]
        public ushort /* WORD */ wResID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        [FieldOffset(34)]
        public byte[] /*  [260] */ szModName;
        public string szModNameStr => Encoding.ASCII.GetString(szModName);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        [FieldOffset(294)]
        public byte[] /*  [260] */ szResName;
        public string szResNameStr => Encoding.ASCII.GetString(szResName);
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct ICONINFOEXW /* _ICONINFOEXW, _ICONINFOEXW */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [FieldOffset(4)]
        public bool fIcon;
        [FieldOffset(8)]
        public uint /* DWORD */ xHotspot;
        [FieldOffset(12)]
        public uint /* DWORD */ yHotspot;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public HBITMAP /* HBITMAP */ hbmMask;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HBITMAP /* HBITMAP */ hbmColor;
        [FieldOffset(32)]
        public ushort /* WORD */ wResID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        [FieldOffset(34)]
        public char[] /*  [260] */ szModName;
        public string szModNameStr => new string(szModName);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        [FieldOffset(554)]
        public char[] /*  [260] */ szResName;
        public string szResNameStr => new string(szResName);
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct SCROLLINFO /* tagSCROLLINFO, tagSCROLLINFO */
    {
        [FieldOffset(0)]
        public uint /* UINT */ cbSize;
        [FieldOffset(4)]
        public uint /* UINT */ fMask;
        [FieldOffset(8)]
        public int nMin;
        [FieldOffset(12)]
        public int nMax;
        [FieldOffset(16)]
        public uint /* UINT */ nPage;
        [FieldOffset(20)]
        public int nPos;
        [FieldOffset(24)]
        public int nTrackPos;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct MONITORINFO /* tagMONITORINFO, tagMONITORINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(4)]
        public RECT /* RECT */ rcMonitor;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(20)]
        public RECT /* RECT */ rcWork;
        [FieldOffset(36)]
        public uint /* DWORD */ dwFlags;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct GUITHREADINFO /* tagGUITHREADINFO, tagGUITHREADINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [FieldOffset(4)]
        public uint /* DWORD */ flags;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(8)]
        public HWND /* HWND */ hwndActive;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public HWND /* HWND */ hwndFocus;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HWND /* HWND */ hwndCapture;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public HWND /* HWND */ hwndMenuOwner;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(40)]
        public HWND /* HWND */ hwndMoveSize;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(48)]
        public HWND /* HWND */ hwndCaret;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(56)]
        public RECT /* RECT */ rcCaret;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct CURSORINFO /* tagCURSORINFO, tagCURSORINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [FieldOffset(4)]
        public uint /* DWORD */ flags;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(8)]
        public HICON /* HCURSOR */ hCursor;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public POINT /* POINT */ ptScreenPos;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct WINDOWINFO /* tagWINDOWINFO, tagWINDOWINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(4)]
        public RECT /* RECT */ rcWindow;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(20)]
        public RECT /* RECT */ rcClient;
        [FieldOffset(36)]
        public uint /* DWORD */ dwStyle;
        [FieldOffset(40)]
        public uint /* DWORD */ dwExStyle;
        [FieldOffset(44)]
        public uint /* DWORD */ dwWindowStatus;
        [FieldOffset(48)]
        public uint /* UINT */ cxWindowBorders;
        [FieldOffset(52)]
        public uint /* UINT */ cyWindowBorders;
        [FieldOffset(56)]
        public ushort /* ATOM */ atomWindowType;
        [FieldOffset(58)]
        public ushort /* WORD */ wCreatorVersion;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct TITLEBARINFO /* tagTITLEBARINFO, tagTITLEBARINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(4)]
        public RECT /* RECT */ rcTitleBar;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        [FieldOffset(20)]
        public uint[] /*  [6] */ rgstate;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct MENUBARINFO /* tagMENUBARINFO, tagMENUBARINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(4)]
        public RECT /* RECT */ rcBar;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HMENU /* HMENU */ hMenu;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public HWND /* HWND */ hwndMenu;
        [FieldOffset(40)]
        public bool fBarFocused;
        [FieldOffset(40)]
        public bool fFocused;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct SCROLLBARINFO /* tagSCROLLBARINFO, tagSCROLLBARINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(4)]
        public RECT /* RECT */ rcScrollBar;
        [FieldOffset(20)]
        public int dxyLineButton;
        [FieldOffset(24)]
        public int xyThumbTop;
        [FieldOffset(28)]
        public int xyThumbBottom;
        [FieldOffset(32)]
        public int reserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        [FieldOffset(36)]
        public uint[] /*  [6] */ rgstate;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct COMBOBOXINFO /* tagCOMBOBOXINFO, tagCOMBOBOXINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(4)]
        public RECT /* RECT */ rcItem;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(20)]
        public RECT /* RECT */ rcButton;
        [FieldOffset(36)]
        public uint /* DWORD */ stateButton;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(40)]
        public HWND /* HWND */ hwndCombo;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(48)]
        public HWND /* HWND */ hwndItem;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(56)]
        public HWND /* HWND */ hwndList;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct ALTTABINFO /* tagALTTABINFO, tagALTTABINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [FieldOffset(4)]
        public int cItems;
        [FieldOffset(8)]
        public int cColumns;
        [FieldOffset(12)]
        public int cRows;
        [FieldOffset(16)]
        public int iColFocus;
        [FieldOffset(20)]
        public int iRowFocus;
        [FieldOffset(24)]
        public int cxItem;
        [FieldOffset(28)]
        public int cyItem;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public POINT /* POINT */ ptStart;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HRAWINPUT /* HRAWINPUT__, HRAWINPUT__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct RAWINPUTHEADER /* tagRAWINPUTHEADER, tagRAWINPUTHEADER */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ dwType;
        [FieldOffset(4)]
        public uint /* DWORD */ dwSize;
        [FieldOffset(8)]
        public IntPtr /* void * */ hDevice;
        [FieldOffset(16)]
        public ulong /* WPARAM */ wParam;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct RAWMOUSE /* tagRAWMOUSE, tagRAWMOUSE */
    {
        [FieldOffset(0)]
        public ushort /* USHORT */ usFlags;
        [FieldOffset(4)]
        public uint /* ULONG */ ulButtons;
        [FieldOffset(4)]
        public ushort /* USHORT */ usButtonFlags;
        [FieldOffset(6)]
        public ushort /* USHORT */ usButtonData;
        [FieldOffset(8)]
        public uint /* ULONG */ ulRawButtons;
        [FieldOffset(12)]
        public int /* LONG */ lLastX;
        [FieldOffset(16)]
        public int /* LONG */ lLastY;
        [FieldOffset(20)]
        public uint /* ULONG */ ulExtraInformation;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct RAWKEYBOARD /* tagRAWKEYBOARD, tagRAWKEYBOARD */
    {
        [FieldOffset(0)]
        public ushort /* USHORT */ MakeCode;
        [FieldOffset(2)]
        public ushort /* USHORT */ Flags;
        [FieldOffset(4)]
        public ushort /* USHORT */ Reserved;
        [FieldOffset(6)]
        public ushort /* USHORT */ VKey;
        [FieldOffset(8)]
        public uint /* UINT */ Message;
        [FieldOffset(12)]
        public uint /* ULONG */ ExtraInformation;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct RAWHID /* tagRAWHID, tagRAWHID */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ dwSizeHid;
        [FieldOffset(4)]
        public uint /* DWORD */ dwCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [FieldOffset(8)]
        public byte[] /*  [1] */ bRawData;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct RAWINPUT /* tagRAWINPUT, tagRAWINPUT */
    {
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public RAWINPUTHEADER /* RAWINPUTHEADER */ header;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public RAWMOUSE /* RAWMOUSE */ mouse;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public RAWKEYBOARD /* RAWKEYBOARD */ keyboard;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public RAWHID /* RAWHID */ hid;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public RAWINPUT::(anonymous union at C:\Program Files (x86)\Windows Kits\8.1\include\um\winuser.h:14302:5) /* union (anonymous union at C:\Program Files (x86)\Windows Kits\8.1\include\um\winuser.h:14302:5) */ data;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public RAWMOUSE /* RAWMOUSE */ mouse;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public RAWKEYBOARD /* RAWKEYBOARD */ keyboard;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(0)]
        public RAWHID /* RAWHID */ hid;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct RAWINPUTDEVICE /* tagRAWINPUTDEVICE, tagRAWINPUTDEVICE */
    {
        [FieldOffset(0)]
        public ushort /* USHORT */ usUsagePage;
        [FieldOffset(2)]
        public ushort /* USHORT */ usUsage;
        [FieldOffset(4)]
        public uint /* DWORD */ dwFlags;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(8)]
        public HWND /* HWND */ hwndTarget;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct RAWINPUTDEVICELIST /* tagRAWINPUTDEVICELIST, tagRAWINPUTDEVICELIST */
    {
        [FieldOffset(0)]
        public IntPtr /* void * */ hDevice;
        [FieldOffset(8)]
        public uint /* DWORD */ dwType;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct CHANGEFILTERSTRUCT /* tagCHANGEFILTERSTRUCT, tagCHANGEFILTERSTRUCT */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cbSize;
        [FieldOffset(4)]
        public uint /* DWORD */ ExtStatus;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HGESTUREINFO /* HGESTUREINFO__, HGESTUREINFO__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct GESTUREINFO /* tagGESTUREINFO, tagGESTUREINFO */
    {
        [FieldOffset(0)]
        public uint /* UINT */ cbSize;
        [FieldOffset(4)]
        public uint /* DWORD */ dwFlags;
        [FieldOffset(8)]
        public uint /* DWORD */ dwID;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public HWND /* HWND */ hwndTarget;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public POINTS /* POINTS */ ptsLocation;
        [FieldOffset(28)]
        public uint /* DWORD */ dwInstanceID;
        [FieldOffset(32)]
        public uint /* DWORD */ dwSequenceID;
        [FieldOffset(40)]
        public ulong /* ULONGLONG */ ullArguments;
        [FieldOffset(48)]
        public uint /* UINT */ cbExtraArgs;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct GESTURECONFIG /* tagGESTURECONFIG, tagGESTURECONFIG */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ dwID;
        [FieldOffset(4)]
        public uint /* DWORD */ dwWant;
        [FieldOffset(8)]
        public uint /* DWORD */ dwBlock;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HCONVLIST /* HCONVLIST__, HCONVLIST__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HCONV /* HCONV__, HCONV__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HSZ /* HSZ__, HSZ__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct HDDEDATA /* HDDEDATA__, HDDEDATA__ */
    {
        [FieldOffset(0)]
        public IntPtr handle;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct CONVCONTEXT /* tagCONVCONTEXT, tagCONVCONTEXT */
    {
        [FieldOffset(0)]
        public uint /* UINT */ cb;
        [FieldOffset(4)]
        public uint /* UINT */ wFlags;
        [FieldOffset(8)]
        public uint /* UINT */ wCountryID;
        [FieldOffset(12)]
        public int iCodePage;
        [FieldOffset(16)]
        public uint /* DWORD */ dwLangID;
        [FieldOffset(20)]
        public uint /* DWORD */ dwSecurity;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public SECURITY_QUALITY_OF_SERVICE /* SECURITY_QUALITY_OF_SERVICE */ qos;
    }
    
    [StructLayout(LayoutKind.Explicit), Serializable]
    public struct CONVINFO /* tagCONVINFO, tagCONVINFO */
    {
        [FieldOffset(0)]
        public uint /* DWORD */ cb;
        [FieldOffset(8)]
        public ulong /* DWORD_PTR */ hUser;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(16)]
        public HCONV /* HCONV */ hConvPartner;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(24)]
        public HSZ /* HSZ */ hszSvcPartner;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(32)]
        public HSZ /* HSZ */ hszServiceReq;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(40)]
        public HSZ /* HSZ */ hszTopic;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(48)]
        public HSZ /* HSZ */ hszItem;
        [FieldOffset(56)]
        public uint /* UINT */ wFmt;
        [FieldOffset(60)]
        public uint /* UINT */ wType;
        [FieldOffset(64)]
        public uint /* UINT */ wStatus;
        [FieldOffset(68)]
        public uint /* UINT */ wConvst;
        [FieldOffset(72)]
        public uint /* UINT */ wLastError;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(80)]
        public HCONVLIST /* HCONVLIST */ hConvList;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(88)]
        public CONVCONTEXT /* CONVCONTEXT */ ConvCtxt;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(128)]
        public HWND /* HWND */ hwnd;
        [MarshalAs(UnmanagedType.Struct)]
        [FieldOffset(136)]
        public HWND /* HWND */ hwndPartner;
    }
}
