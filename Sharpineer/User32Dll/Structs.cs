using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace User32Dll
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Luid /* _LUID, _LUID */
    {
        public uint /* DWORD */ LowPart;
        public int /* LONG */ HighPart;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct SecurityQualityOfService /* _SECURITY_QUALITY_OF_SERVICE, _SECURITY_QUALITY_OF_SERVICE */
    {
        public uint /* DWORD */ Length;
        public SecurityImpersonationLevel /* SECURITY_IMPERSONATION_LEVEL */ ImpersonationLevel;
        public byte /* SECURITY_CONTEXT_TRACKING_MODE */ ContextTrackingMode;
        public byte /* BOOLEAN */ EffectiveOnly;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hinstance /* HINSTANCE__, HINSTANCE__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hrgn /* HRGN__, HRGN__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hwinsta /* HWINSTA__, HWINSTA__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hkl /* HKL__, HKL__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hwnd /* HWND__, HWND__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hhook /* HHOOK__, HHOOK__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Haccel /* HACCEL__, HACCEL__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hbitmap /* HBITMAP__, HBITMAP__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hbrush /* HBRUSH__, HBRUSH__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hdc /* HDC__, HDC__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hdesk /* HDESK__, HDESK__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hicon /* HICON__, HICON__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hmenu /* HMENU__, HMENU__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hwineventhook /* HWINEVENTHOOK__, HWINEVENTHOOK__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hmonitor /* HMONITOR__, HMONITOR__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Rect /* tagRECT, tagRECT */
    {
        public int /* LONG */ left;
        public int /* LONG */ top;
        public int /* LONG */ right;
        public int /* LONG */ bottom;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Point /* tagPOINT, tagPOINT */
    {
        public int /* LONG */ x;
        public int /* LONG */ y;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Pointl /* _POINTL, _POINTL */
    {
        public int /* LONG */ x;
        public int /* LONG */ y;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Size /* tagSIZE, tagSIZE */
    {
        public int /* LONG */ cx;
        public int /* LONG */ cy;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Points /* tagPOINTS, tagPOINTS */
    {
        public short /* SHORT */ x;
        public short /* SHORT */ y;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct SecurityAttributes /* _SECURITY_ATTRIBUTES, _SECURITY_ATTRIBUTES */
    {
        public uint /* DWORD */ nLength;
        public IntPtr /* void * */ lpSecurityDescriptor;
        public bool bInheritHandle;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct devicemodeA /* _devicemodeA, _devicemodeA */
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] /*  [32] */ dmDeviceName;
        public ushort /* WORD */ dmSpecVersion;
        public ushort /* WORD */ dmDriverVersion;
        public ushort /* WORD */ dmSize;
        public ushort /* WORD */ dmDriverExtra;
        public uint /* DWORD */ dmFields;
        public short dmOrientation;
        public short dmPaperSize;
        public short dmPaperLength;
        public short dmPaperWidth;
        public short dmScale;
        public short dmCopies;
        public short dmDefaultSource;
        public short dmPrintQuality;
        [MarshalAs(UnmanagedType.Struct)]
        public Pointl /* POINTL */ dmPosition;
        public uint /* DWORD */ dmDisplayOrientation;
        public uint /* DWORD */ dmDisplayFixedOutput;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] /*  [32] */ dmFormName;
        public ushort /* WORD */ dmLogPixels;
        public uint /* DWORD */ dmBitsPerPel;
        public uint /* DWORD */ dmPelsWidth;
        public uint /* DWORD */ dmPelsHeight;
        public uint /* DWORD */ dmDisplayFlags;
        public uint /* DWORD */ dmNup;
        public uint /* DWORD */ dmDisplayFrequency;
        public uint /* DWORD */ dmICMMethod;
        public uint /* DWORD */ dmICMIntent;
        public uint /* DWORD */ dmMediaType;
        public uint /* DWORD */ dmDitherType;
        public uint /* DWORD */ dmReserved1;
        public uint /* DWORD */ dmReserved2;
        public uint /* DWORD */ dmPanningWidth;
        public uint /* DWORD */ dmPanningHeight;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct devicemodeW /* _devicemodeW, _devicemodeW */
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public char[] /*  [32] */ dmDeviceName;
        public string dmDeviceNameStr => Encoding.Unicode.GetString(dmDeviceName);
        public ushort /* WORD */ dmSpecVersion;
        public ushort /* WORD */ dmDriverVersion;
        public ushort /* WORD */ dmSize;
        public ushort /* WORD */ dmDriverExtra;
        public uint /* DWORD */ dmFields;
        public short dmOrientation;
        public short dmPaperSize;
        public short dmPaperLength;
        public short dmPaperWidth;
        public short dmScale;
        public short dmCopies;
        public short dmDefaultSource;
        public short dmPrintQuality;
        [MarshalAs(UnmanagedType.Struct)]
        public Pointl /* POINTL */ dmPosition;
        public uint /* DWORD */ dmDisplayOrientation;
        public uint /* DWORD */ dmDisplayFixedOutput;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public char[] /*  [32] */ dmFormName;
        public string dmFormNameStr => Encoding.Unicode.GetString(dmFormName);
        public ushort /* WORD */ dmLogPixels;
        public uint /* DWORD */ dmBitsPerPel;
        public uint /* DWORD */ dmPelsWidth;
        public uint /* DWORD */ dmPelsHeight;
        public uint /* DWORD */ dmDisplayFlags;
        public uint /* DWORD */ dmNup;
        public uint /* DWORD */ dmDisplayFrequency;
        public uint /* DWORD */ dmICMMethod;
        public uint /* DWORD */ dmICMIntent;
        public uint /* DWORD */ dmMediaType;
        public uint /* DWORD */ dmDitherType;
        public uint /* DWORD */ dmReserved1;
        public uint /* DWORD */ dmReserved2;
        public uint /* DWORD */ dmPanningWidth;
        public uint /* DWORD */ dmPanningHeight;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayDevicea /* _DISPLAY_DEVICEA, _DISPLAY_DEVICEA */
    {
        public uint /* DWORD */ cb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] /*  [32] */ DeviceName;
        public string DeviceNameStr => Encoding.ASCII.GetString(DeviceName);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] /*  [128] */ DeviceString;
        public string DeviceStringStr => Encoding.ASCII.GetString(DeviceString);
        public uint /* DWORD */ StateFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] /*  [128] */ DeviceID;
        public string DeviceIDStr => Encoding.ASCII.GetString(DeviceID);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] /*  [128] */ DeviceKey;
        public string DeviceKeyStr => Encoding.ASCII.GetString(DeviceKey);
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayDevicew /* _DISPLAY_DEVICEW, _DISPLAY_DEVICEW */
    {
        public uint /* DWORD */ cb;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public char[] /*  [32] */ DeviceName;
        public string DeviceNameStr => Encoding.Unicode.GetString(DeviceName);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public char[] /*  [128] */ DeviceString;
        public string DeviceStringStr => Encoding.Unicode.GetString(DeviceString);
        public uint /* DWORD */ StateFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public char[] /*  [128] */ DeviceID;
        public string DeviceIDStr => Encoding.Unicode.GetString(DeviceID);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public char[] /*  [128] */ DeviceKey;
        public string DeviceKeyStr => Encoding.Unicode.GetString(DeviceKey);
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayconfigRational /* DISPLAYCONFIG_RATIONAL, DISPLAYCONFIG_RATIONAL */
    {
        public uint /* UINT32 */ Numerator;
        public uint /* UINT32 */ Denominator;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Displayconfig2dregion /* DISPLAYCONFIG_2DREGION, DISPLAYCONFIG_2DREGION */
    {
        public uint /* UINT32 */ cx;
        public uint /* UINT32 */ cy;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayconfigVideoSignalInfo /* DISPLAYCONFIG_VIDEO_SIGNAL_INFO, DISPLAYCONFIG_VIDEO_SIGNAL_INFO */
    {
        public ulong /* UINT64 */ pixelRate;
        [MarshalAs(UnmanagedType.Struct)]
        public DisplayconfigRational hSyncFreq;
        [MarshalAs(UnmanagedType.Struct)]
        public DisplayconfigRational vSyncFreq;
        [MarshalAs(UnmanagedType.Struct)]
        public Displayconfig2dregion activeSize;
        [MarshalAs(UnmanagedType.Struct)]
        public Displayconfig2dregion totalSize;
        public uint /* UINT32 */ videoStandard;
        public uint /* UINT32 */ vSyncFreqDivider;
        public uint /* UINT32 */ reserved;
        [MarshalAs(UnmanagedType.Struct)]
        public DisplayconfigVideoSignalInfo::(anonymous struct at c:\program files (x86)\windows kits\8.1\include\um\wingdi.h:2839:9) /* struct (anonymous struct at C:\Program Files (x86)\Windows Kits\8.1\include\um\wingdi.h:2839:9) */ AdditionalSignalInfo;
        public uint /* UINT32 */ videoStandard;
        public uint /* UINT32 */ vSyncFreqDivider;
        public uint /* UINT32 */ reserved;
        public uint /* UINT32 */ videoStandard;
        public DisplayconfigScanlineOrdering scanLineOrdering;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayconfigSourceMode /* DISPLAYCONFIG_SOURCE_MODE, DISPLAYCONFIG_SOURCE_MODE */
    {
        public uint /* UINT32 */ width;
        public uint /* UINT32 */ height;
        public DisplayconfigPixelformat pixelFormat;
        [MarshalAs(UnmanagedType.Struct)]
        public Pointl /* POINTL */ position;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayconfigTargetMode /* DISPLAYCONFIG_TARGET_MODE, DISPLAYCONFIG_TARGET_MODE */
    {
        [MarshalAs(UnmanagedType.Struct)]
        public DisplayconfigVideoSignalInfo targetVideoSignalInfo;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayconfigModeInfo /* DISPLAYCONFIG_MODE_INFO, DISPLAYCONFIG_MODE_INFO */
    {
        public DisplayconfigModeInfoType infoType;
        public uint /* UINT32 */ id;
        [MarshalAs(UnmanagedType.Struct)]
        public Luid /* LUID */ adapterId;
        [MarshalAs(UnmanagedType.Struct)]
        public DisplayconfigTargetMode targetMode;
        [MarshalAs(UnmanagedType.Struct)]
        public DisplayconfigSourceMode sourceMode;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayconfigPathSourceInfo /* DISPLAYCONFIG_PATH_SOURCE_INFO, DISPLAYCONFIG_PATH_SOURCE_INFO */
    {
        [MarshalAs(UnmanagedType.Struct)]
        public Luid /* LUID */ adapterId;
        public uint /* UINT32 */ id;
        public uint /* UINT32 */ modeInfoIdx;
        public uint /* UINT32 */ statusFlags;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayconfigPathTargetInfo /* DISPLAYCONFIG_PATH_TARGET_INFO, DISPLAYCONFIG_PATH_TARGET_INFO */
    {
        [MarshalAs(UnmanagedType.Struct)]
        public Luid /* LUID */ adapterId;
        public uint /* UINT32 */ id;
        public uint /* UINT32 */ modeInfoIdx;
        public DisplayconfigVideoOutputTechnology outputTechnology;
        public DisplayconfigRotation rotation;
        public DisplayconfigScaling scaling;
        [MarshalAs(UnmanagedType.Struct)]
        public DisplayconfigRational refreshRate;
        public DisplayconfigScanlineOrdering scanLineOrdering;
        public bool targetAvailable;
        public uint /* UINT32 */ statusFlags;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayconfigPathInfo /* DISPLAYCONFIG_PATH_INFO, DISPLAYCONFIG_PATH_INFO */
    {
        [MarshalAs(UnmanagedType.Struct)]
        public DisplayconfigPathSourceInfo sourceInfo;
        [MarshalAs(UnmanagedType.Struct)]
        public DisplayconfigPathTargetInfo targetInfo;
        public uint /* UINT32 */ flags;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayconfigDeviceInfoHeader /* DISPLAYCONFIG_DEVICE_INFO_HEADER, DISPLAYCONFIG_DEVICE_INFO_HEADER */
    {
        public DisplayconfigDeviceInfoType type;
        public uint /* UINT32 */ size;
        [MarshalAs(UnmanagedType.Struct)]
        public Luid /* LUID */ adapterId;
        public uint /* UINT32 */ id;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Blendfunction /* _BLENDFUNCTION, _BLENDFUNCTION */
    {
        public byte BlendOp;
        public byte BlendFlags;
        public byte SourceConstantAlpha;
        public byte AlphaFormat;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Mousemovepoint /* tagMOUSEMOVEPOINT, tagMOUSEMOVEPOINT */
    {
        public int x;
        public int y;
        public uint /* DWORD */ time;
        public ulong /* ULONG_PTR */ dwExtraInfo;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Wndclassexa /* tagWNDCLASSEXA, tagWNDCLASSEXA */
    {
        public uint /* UINT */ cbSize;
        public uint /* UINT */ style;
        public IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hinstance /* HINSTANCE */ hInstance;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HICON */ hIcon;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HCURSOR */ hCursor;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbrush /* HBRUSH */ hbrBackground;
        public IntPtr /* const char * */ lpszMenuName;
        public IntPtr /* const char * */ lpszClassName;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HICON */ hIconSm;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Wndclassexw /* tagWNDCLASSEXW, tagWNDCLASSEXW */
    {
        public uint /* UINT */ cbSize;
        public uint /* UINT */ style;
        public IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hinstance /* HINSTANCE */ hInstance;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HICON */ hIcon;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HCURSOR */ hCursor;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbrush /* HBRUSH */ hbrBackground;
        public IntPtr /* const wchar_t * */ lpszMenuName;
        public IntPtr /* const wchar_t * */ lpszClassName;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HICON */ hIconSm;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Wndclassa /* tagWNDCLASSA, tagWNDCLASSA */
    {
        public uint /* UINT */ style;
        public IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hinstance /* HINSTANCE */ hInstance;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HICON */ hIcon;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HCURSOR */ hCursor;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbrush /* HBRUSH */ hbrBackground;
        public IntPtr /* const char * */ lpszMenuName;
        public IntPtr /* const char * */ lpszClassName;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Wndclassw /* tagWNDCLASSW, tagWNDCLASSW */
    {
        public uint /* UINT */ style;
        public IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hinstance /* HINSTANCE */ hInstance;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HICON */ hIcon;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HCURSOR */ hCursor;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbrush /* HBRUSH */ hbrBackground;
        public IntPtr /* const wchar_t * */ lpszMenuName;
        public IntPtr /* const wchar_t * */ lpszClassName;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Msg /* tagMSG, tagMSG */
    {
        public IntPtr /* HWND */ hwnd;
        public uint /* UINT */ message;
        public ulong /* WPARAM */ wParam;
        public long /* LPARAM */ lParam;
        public uint /* DWORD */ time;
        [MarshalAs(UnmanagedType.Struct)]
        public Point /* POINT */ pt;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Trackmouseevent /* tagTRACKMOUSEEVENT, tagTRACKMOUSEEVENT */
    {
        public uint /* DWORD */ cbSize;
        public uint /* DWORD */ dwFlags;
        public IntPtr /* HWND */ hwndTrack;
        public uint /* DWORD */ dwHoverTime;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Accel /* tagACCEL, tagACCEL */
    {
        public byte fVirt;
        public ushort /* WORD */ key;
        public ushort /* WORD */ cmd;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Paintstruct /* tagPAINTSTRUCT, tagPAINTSTRUCT */
    {
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hdc /* HDC */ hdc;
        public bool fErase;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcPaint;
        public bool fRestore;
        public bool fIncUpdate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] /*  [32] */ rgbReserved;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Windowplacement /* tagWINDOWPLACEMENT, tagWINDOWPLACEMENT */
    {
        public uint /* UINT */ length;
        public uint /* UINT */ flags;
        public uint /* UINT */ showCmd;
        [MarshalAs(UnmanagedType.Struct)]
        public Point /* POINT */ ptMinPosition;
        [MarshalAs(UnmanagedType.Struct)]
        public Point /* POINT */ ptMaxPosition;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcNormalPosition;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Mouseinput /* tagMOUSEINPUT, tagMOUSEINPUT */
    {
        public int /* LONG */ dx;
        public int /* LONG */ dy;
        public uint /* DWORD */ mouseData;
        public uint /* DWORD */ dwFlags;
        public uint /* DWORD */ time;
        public ulong /* ULONG_PTR */ dwExtraInfo;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Keybdinput /* tagKEYBDINPUT, tagKEYBDINPUT */
    {
        public ushort /* WORD */ wVk;
        public ushort /* WORD */ wScan;
        public uint /* DWORD */ dwFlags;
        public uint /* DWORD */ time;
        public ulong /* ULONG_PTR */ dwExtraInfo;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hardwareinput /* tagHARDWAREINPUT, tagHARDWAREINPUT */
    {
        public uint /* DWORD */ uMsg;
        public ushort /* WORD */ wParamL;
        public ushort /* WORD */ wParamH;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Input /* tagINPUT, tagINPUT */
    {
        public uint /* DWORD */ type;
        [MarshalAs(UnmanagedType.Struct)]
        public Mouseinput /* MOUSEINPUT */ mi;
        [MarshalAs(UnmanagedType.Struct)]
        public Keybdinput /* KEYBDINPUT */ ki;
        [MarshalAs(UnmanagedType.Struct)]
        public Hardwareinput /* HARDWAREINPUT */ hi;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Htouchinput /* HTOUCHINPUT__, HTOUCHINPUT__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Touchinput /* tagTOUCHINPUT, tagTOUCHINPUT */
    {
        public int /* LONG */ x;
        public int /* LONG */ y;
        public IntPtr /* void * */ hSource;
        public uint /* DWORD */ dwID;
        public uint /* DWORD */ dwFlags;
        public uint /* DWORD */ dwMask;
        public uint /* DWORD */ dwTime;
        public ulong /* ULONG_PTR */ dwExtraInfo;
        public uint /* DWORD */ cxContact;
        public uint /* DWORD */ cyContact;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct PointerInfo /* tagPOINTER_INFO, tagPOINTER_INFO */
    {
        public uint /* POINTER_INPUT_TYPE */ pointerType;
        public uint /* UINT32 */ pointerId;
        public uint /* UINT32 */ frameId;
        public uint /* POINTER_FLAGS */ pointerFlags;
        public IntPtr /* void * */ sourceDevice;
        public IntPtr /* HWND */ hwndTarget;
        [MarshalAs(UnmanagedType.Struct)]
        public Point /* POINT */ ptPixelLocation;
        [MarshalAs(UnmanagedType.Struct)]
        public Point /* POINT */ ptHimetricLocation;
        [MarshalAs(UnmanagedType.Struct)]
        public Point /* POINT */ ptPixelLocationRaw;
        [MarshalAs(UnmanagedType.Struct)]
        public Point /* POINT */ ptHimetricLocationRaw;
        public uint /* DWORD */ dwTime;
        public uint /* UINT32 */ historyCount;
        public int /* INT32 */ InputData;
        public uint /* DWORD */ dwKeyStates;
        public ulong /* UINT64 */ PerformanceCount;
        public PointerButtonChangeType /* POINTER_BUTTON_CHANGE_TYPE */ ButtonChangeType;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct PointerTouchInfo /* tagPOINTER_TOUCH_INFO, tagPOINTER_TOUCH_INFO */
    {
        [MarshalAs(UnmanagedType.Struct)]
        public PointerInfo /* POINTER_INFO */ pointerInfo;
        public uint /* TOUCH_FLAGS */ touchFlags;
        public uint /* TOUCH_MASK */ touchMask;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcContact;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcContactRaw;
        public uint /* UINT32 */ orientation;
        public uint /* UINT32 */ pressure;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct PointerPenInfo /* tagPOINTER_PEN_INFO, tagPOINTER_PEN_INFO */
    {
        [MarshalAs(UnmanagedType.Struct)]
        public PointerInfo /* POINTER_INFO */ pointerInfo;
        public uint /* PEN_FLAGS */ penFlags;
        public uint /* PEN_MASK */ penMask;
        public uint /* UINT32 */ pressure;
        public uint /* UINT32 */ rotation;
        public int /* INT32 */ tiltX;
        public int /* INT32 */ tiltY;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct TouchHitTestingProximityEvaluation /* tagTOUCH_HIT_TESTING_PROXIMITY_EVALUATION, tagTOUCH_HIT_TESTING_PROXIMITY_EVALUATION */
    {
        public ushort /* UINT16 */ score;
        [MarshalAs(UnmanagedType.Struct)]
        public Point /* POINT */ adjustedPoint;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct InputTransform /* tagINPUT_TRANSFORM, tagINPUT_TRANSFORM */
    {
        public UNKNOWN /* float, float */ _11;
        public UNKNOWN /* float, float */ _12;
        public UNKNOWN /* float, float */ _13;
        public UNKNOWN /* float, float */ _14;
        public UNKNOWN /* float, float */ _21;
        public UNKNOWN /* float, float */ _22;
        public UNKNOWN /* float, float */ _23;
        public UNKNOWN /* float, float */ _24;
        public UNKNOWN /* float, float */ _31;
        public UNKNOWN /* float, float */ _32;
        public UNKNOWN /* float, float */ _33;
        public UNKNOWN /* float, float */ _34;
        public UNKNOWN /* float, float */ _41;
        public UNKNOWN /* float, float */ _42;
        public UNKNOWN /* float, float */ _43;
        public UNKNOWN /* float, float */ _44;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public UNKNOWN[][] /*  [4] */ m;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Lastinputinfo /* tagLASTINPUTINFO, tagLASTINPUTINFO */
    {
        public uint /* UINT */ cbSize;
        public uint /* DWORD */ dwTime;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Tpmparams /* tagTPMPARAMS, tagTPMPARAMS */
    {
        public uint /* UINT */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcExclude;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Menuinfo /* tagMENUINFO, tagMENUINFO */
    {
        public uint /* DWORD */ cbSize;
        public uint /* DWORD */ fMask;
        public uint /* DWORD */ dwStyle;
        public uint /* UINT */ cyMax;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbrush /* HBRUSH */ hbrBack;
        public uint /* DWORD */ dwContextHelpID;
        public ulong /* ULONG_PTR */ dwMenuData;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Menuiteminfoa /* tagMENUITEMINFOA, tagMENUITEMINFOA */
    {
        public uint /* UINT */ cbSize;
        public uint /* UINT */ fMask;
        public uint /* UINT */ fType;
        public uint /* UINT */ fState;
        public uint /* UINT */ wID;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hmenu /* HMENU */ hSubMenu;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmpChecked;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmpUnchecked;
        public ulong /* ULONG_PTR */ dwItemData;
        public IntPtr /* char * */ dwTypeData;
        public uint /* UINT */ cch;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmpItem;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Menuiteminfow /* tagMENUITEMINFOW, tagMENUITEMINFOW */
    {
        public uint /* UINT */ cbSize;
        public uint /* UINT */ fMask;
        public uint /* UINT */ fType;
        public uint /* UINT */ fState;
        public uint /* UINT */ wID;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hmenu /* HMENU */ hSubMenu;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmpChecked;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmpUnchecked;
        public ulong /* ULONG_PTR */ dwItemData;
        public IntPtr /* wchar_t * */ dwTypeData;
        public uint /* UINT */ cch;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmpItem;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Drawtextparams /* tagDRAWTEXTPARAMS, tagDRAWTEXTPARAMS */
    {
        public uint /* UINT */ cbSize;
        public int iTabLength;
        public int iLeftMargin;
        public int iRightMargin;
        public uint /* UINT */ uiLengthDrawn;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Iconinfo /* _ICONINFO, _ICONINFO */
    {
        public bool fIcon;
        public uint /* DWORD */ xHotspot;
        public uint /* DWORD */ yHotspot;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmMask;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmColor;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Iconinfoexa /* _ICONINFOEXA, _ICONINFOEXA */
    {
        public uint /* DWORD */ cbSize;
        public bool fIcon;
        public uint /* DWORD */ xHotspot;
        public uint /* DWORD */ yHotspot;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmMask;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmColor;
        public ushort /* WORD */ wResID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public byte[] /*  [260] */ szModName;
        public string szModNameStr => Encoding.ASCII.GetString(szModName);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public byte[] /*  [260] */ szResName;
        public string szResNameStr => Encoding.ASCII.GetString(szResName);
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Iconinfoexw /* _ICONINFOEXW, _ICONINFOEXW */
    {
        public uint /* DWORD */ cbSize;
        public bool fIcon;
        public uint /* DWORD */ xHotspot;
        public uint /* DWORD */ yHotspot;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmMask;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hbitmap /* HBITMAP */ hbmColor;
        public ushort /* WORD */ wResID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public char[] /*  [260] */ szModName;
        public string szModNameStr => Encoding.Unicode.GetString(szModName);
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public char[] /*  [260] */ szResName;
        public string szResNameStr => Encoding.Unicode.GetString(szResName);
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Scrollinfo /* tagSCROLLINFO, tagSCROLLINFO */
    {
        public uint /* UINT */ cbSize;
        public uint /* UINT */ fMask;
        public int nMin;
        public int nMax;
        public uint /* UINT */ nPage;
        public int nPos;
        public int nTrackPos;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Monitorinfo /* tagMONITORINFO, tagMONITORINFO */
    {
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcMonitor;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcWork;
        public uint /* DWORD */ dwFlags;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Guithreadinfo /* tagGUITHREADINFO, tagGUITHREADINFO */
    {
        public uint /* DWORD */ cbSize;
        public uint /* DWORD */ flags;
        public IntPtr /* HWND */ hwndActive;
        public IntPtr /* HWND */ hwndFocus;
        public IntPtr /* HWND */ hwndCapture;
        public IntPtr /* HWND */ hwndMenuOwner;
        public IntPtr /* HWND */ hwndMoveSize;
        public IntPtr /* HWND */ hwndCaret;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcCaret;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Cursorinfo /* tagCURSORINFO, tagCURSORINFO */
    {
        public uint /* DWORD */ cbSize;
        public uint /* DWORD */ flags;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hicon /* HCURSOR */ hCursor;
        [MarshalAs(UnmanagedType.Struct)]
        public Point /* POINT */ ptScreenPos;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Windowinfo /* tagWINDOWINFO, tagWINDOWINFO */
    {
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcWindow;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcClient;
        public uint /* DWORD */ dwStyle;
        public uint /* DWORD */ dwExStyle;
        public uint /* DWORD */ dwWindowStatus;
        public uint /* UINT */ cxWindowBorders;
        public uint /* UINT */ cyWindowBorders;
        public ushort /* ATOM */ atomWindowType;
        public ushort /* WORD */ wCreatorVersion;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Titlebarinfo /* tagTITLEBARINFO, tagTITLEBARINFO */
    {
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcTitleBar;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] /*  [6] */ rgstate;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Menubarinfo /* tagMENUBARINFO, tagMENUBARINFO */
    {
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcBar;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hmenu /* HMENU */ hMenu;
        public IntPtr /* HWND */ hwndMenu;
        public bool fBarFocused;
        public bool fFocused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Scrollbarinfo /* tagSCROLLBARINFO, tagSCROLLBARINFO */
    {
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcScrollBar;
        public int dxyLineButton;
        public int xyThumbTop;
        public int xyThumbBottom;
        public int reserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] /*  [6] */ rgstate;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Comboboxinfo /* tagCOMBOBOXINFO, tagCOMBOBOXINFO */
    {
        public uint /* DWORD */ cbSize;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcItem;
        [MarshalAs(UnmanagedType.Struct)]
        public Rect /* RECT */ rcButton;
        public uint /* DWORD */ stateButton;
        public IntPtr /* HWND */ hwndCombo;
        public IntPtr /* HWND */ hwndItem;
        public IntPtr /* HWND */ hwndList;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Alttabinfo /* tagALTTABINFO, tagALTTABINFO */
    {
        public uint /* DWORD */ cbSize;
        public int cItems;
        public int cColumns;
        public int cRows;
        public int iColFocus;
        public int iRowFocus;
        public int cxItem;
        public int cyItem;
        [MarshalAs(UnmanagedType.Struct)]
        public Point /* POINT */ ptStart;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hrawinput /* HRAWINPUT__, HRAWINPUT__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Rawinputheader /* tagRAWINPUTHEADER, tagRAWINPUTHEADER */
    {
        public uint /* DWORD */ dwType;
        public uint /* DWORD */ dwSize;
        public IntPtr /* void * */ hDevice;
        public ulong /* WPARAM */ wParam;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Rawmouse /* tagRAWMOUSE, tagRAWMOUSE */
    {
        public ushort /* USHORT */ usFlags;
        public uint /* ULONG */ ulButtons;
        public ushort /* USHORT */ usButtonFlags;
        public ushort /* USHORT */ usButtonData;
        public uint /* ULONG */ ulRawButtons;
        public int /* LONG */ lLastX;
        public int /* LONG */ lLastY;
        public uint /* ULONG */ ulExtraInformation;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Rawkeyboard /* tagRAWKEYBOARD, tagRAWKEYBOARD */
    {
        public ushort /* USHORT */ MakeCode;
        public ushort /* USHORT */ Flags;
        public ushort /* USHORT */ Reserved;
        public ushort /* USHORT */ VKey;
        public uint /* UINT */ Message;
        public uint /* ULONG */ ExtraInformation;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Rawhid /* tagRAWHID, tagRAWHID */
    {
        public uint /* DWORD */ dwSizeHid;
        public uint /* DWORD */ dwCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] /*  [1] */ bRawData;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Rawinput /* tagRAWINPUT, tagRAWINPUT */
    {
        [MarshalAs(UnmanagedType.Struct)]
        public Rawinputheader /* RAWINPUTHEADER */ header;
        [MarshalAs(UnmanagedType.Struct)]
        public Rawmouse /* RAWMOUSE */ mouse;
        [MarshalAs(UnmanagedType.Struct)]
        public Rawkeyboard /* RAWKEYBOARD */ keyboard;
        [MarshalAs(UnmanagedType.Struct)]
        public Rawhid /* RAWHID */ hid;
        [MarshalAs(UnmanagedType.Struct)]
        public RAWINPUT::(anonymous union at C:\Program Files (x86)\Windows Kits\8.1\include\um\winuser.h:14302:5) /* union (anonymous union at C:\Program Files (x86)\Windows Kits\8.1\include\um\winuser.h:14302:5) */ data;
        [MarshalAs(UnmanagedType.Struct)]
        public Rawmouse /* RAWMOUSE */ mouse;
        [MarshalAs(UnmanagedType.Struct)]
        public Rawkeyboard /* RAWKEYBOARD */ keyboard;
        [MarshalAs(UnmanagedType.Struct)]
        public Rawhid /* RAWHID */ hid;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Rawinputdevice /* tagRAWINPUTDEVICE, tagRAWINPUTDEVICE */
    {
        public ushort /* USHORT */ usUsagePage;
        public ushort /* USHORT */ usUsage;
        public uint /* DWORD */ dwFlags;
        public IntPtr /* HWND */ hwndTarget;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Rawinputdevicelist /* tagRAWINPUTDEVICELIST, tagRAWINPUTDEVICELIST */
    {
        public IntPtr /* void * */ hDevice;
        public uint /* DWORD */ dwType;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct PointerDeviceInfo /* tagPOINTER_DEVICE_INFO, tagPOINTER_DEVICE_INFO */
    {
        public uint /* DWORD */ displayOrientation;
        public IntPtr /* void * */ device;
        public PointerDeviceType /* POINTER_DEVICE_TYPE */ pointerDeviceType;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hmonitor /* HMONITOR */ monitor;
        public uint /* ULONG */ startingCursorId;
        public ushort /* USHORT */ maxActiveContacts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 520)]
        public char[] /*  [520] */ productString;
        public string productStringStr => Encoding.Unicode.GetString(productString);
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct PointerDeviceProperty /* tagPOINTER_DEVICE_PROPERTY, tagPOINTER_DEVICE_PROPERTY */
    {
        public int /* INT32 */ logicalMin;
        public int /* INT32 */ logicalMax;
        public int /* INT32 */ physicalMin;
        public int /* INT32 */ physicalMax;
        public uint /* UINT32 */ unit;
        public uint /* UINT32 */ unitExponent;
        public ushort /* USHORT */ usagePageId;
        public ushort /* USHORT */ usageId;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct PointerDeviceCursorInfo /* tagPOINTER_DEVICE_CURSOR_INFO, tagPOINTER_DEVICE_CURSOR_INFO */
    {
        public uint /* UINT32 */ cursorId;
        public PointerDeviceCursorType /* POINTER_DEVICE_CURSOR_TYPE */ cursor;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Changefilterstruct /* tagCHANGEFILTERSTRUCT, tagCHANGEFILTERSTRUCT */
    {
        public uint /* DWORD */ cbSize;
        public uint /* DWORD */ ExtStatus;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hgestureinfo /* HGESTUREINFO__, HGESTUREINFO__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Gestureinfo /* tagGESTUREINFO, tagGESTUREINFO */
    {
        public uint /* UINT */ cbSize;
        public uint /* DWORD */ dwFlags;
        public uint /* DWORD */ dwID;
        public IntPtr /* HWND */ hwndTarget;
        [MarshalAs(UnmanagedType.Struct)]
        public Points /* POINTS */ ptsLocation;
        public uint /* DWORD */ dwInstanceID;
        public uint /* DWORD */ dwSequenceID;
        public ulong /* ULONGLONG */ ullArguments;
        public uint /* UINT */ cbExtraArgs;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Gestureconfig /* tagGESTURECONFIG, tagGESTURECONFIG */
    {
        public uint /* DWORD */ dwID;
        public uint /* DWORD */ dwWant;
        public uint /* DWORD */ dwBlock;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct InputMessageSource /* tagINPUT_MESSAGE_SOURCE, tagINPUT_MESSAGE_SOURCE */
    {
        public InputMessageDeviceType /* INPUT_MESSAGE_DEVICE_TYPE */ deviceType;
        public InputMessageOriginId /* INPUT_MESSAGE_ORIGIN_ID */ originId;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hconvlist /* HCONVLIST__, HCONVLIST__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hconv /* HCONV__, HCONV__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hsz /* HSZ__, HSZ__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Hddedata /* HDDEDATA__, HDDEDATA__ */
    {
        public int unused;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Convcontext /* tagCONVCONTEXT, tagCONVCONTEXT */
    {
        public uint /* UINT */ cb;
        public uint /* UINT */ wFlags;
        public uint /* UINT */ wCountryID;
        public int iCodePage;
        public uint /* DWORD */ dwLangID;
        public uint /* DWORD */ dwSecurity;
        [MarshalAs(UnmanagedType.Struct)]
        public SecurityQualityOfService /* SECURITY_QUALITY_OF_SERVICE */ qos;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct Convinfo /* tagCONVINFO, tagCONVINFO */
    {
        public uint /* DWORD */ cb;
        public ulong /* DWORD_PTR */ hUser;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hconv /* HCONV */ hConvPartner;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hsz /* HSZ */ hszSvcPartner;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hsz /* HSZ */ hszServiceReq;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hsz /* HSZ */ hszTopic;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hsz /* HSZ */ hszItem;
        public uint /* UINT */ wFmt;
        public uint /* UINT */ wType;
        public uint /* UINT */ wStatus;
        public uint /* UINT */ wConvst;
        public uint /* UINT */ wLastError;
        [MarshalAs(UnmanagedType.LPStruct)]
        public Hconvlist /* HCONVLIST */ hConvList;
        [MarshalAs(UnmanagedType.Struct)]
        public Convcontext /* CONVCONTEXT */ ConvCtxt;
        public IntPtr /* HWND */ hwnd;
        public IntPtr /* HWND */ hwndPartner;
    }
}
