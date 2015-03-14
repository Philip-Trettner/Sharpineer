using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace User32Dll
{
    public static class User32
    {
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HKL /* HKL */ ActivateKeyboardLayout([MarshalAs(UnmanagedType.Struct)] HKL /* HKL */ @hkl, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddClipboardFormatListener([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lpRect, uint /* DWORD */ @dwStyle, bool @bMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRectEx([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lpRect, uint /* DWORD */ @dwStyle, bool @bMenu, uint /* DWORD */ @dwExStyle);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllowSetForegroundWindow(uint /* DWORD */ @dwProcessId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AnimateWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* DWORD */ @dwTime, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AnyPopup();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AppendMenu([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uFlags, ulong /* UINT_PTR */ @uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpNewItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ ArrangeIconicWindows([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AttachThreadInput(uint /* DWORD */ @idAttach, uint /* DWORD */ @idAttachTo, bool @fAttach);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void *, HDWP */ BeginDeferWindowPos(int @nNumWindows);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDC /* HDC */ BeginPaint([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref PAINTSTRUCT /* LPPAINTSTRUCT */ @lpPaint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BlockInput(bool @fBlockIt);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BringWindowToTop([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int BroadcastSystemMessage(uint /* DWORD */ @flags, IntPtr /* unsigned long *, LPDWORD */ @lpInfo, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int BroadcastSystemMessageEx(uint /* DWORD */ @flags, IntPtr /* unsigned long *, LPDWORD */ @lpInfo, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam, [MarshalAs(UnmanagedType.LPStruct)] ref BSMINFO /* PBSMINFO */ @pbsmInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CalculatePopupWindowPosition([MarshalAs(UnmanagedType.LPStruct)] ref POINT /* const POINT * */ @anchorPoint, [MarshalAs(UnmanagedType.LPStruct)] ref SIZE /* const SIZE * */ @windowSize, uint /* UINT */ @flags, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* RECT * */ @excludeRect, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* RECT * */ @popupWindowPosition);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CallMsgFilter([MarshalAs(UnmanagedType.LPStruct)] ref MSG /* LPMSG */ @lpMsg, int @nCode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ CallNextHookEx([MarshalAs(UnmanagedType.Struct)] HHOOK /* HHOOK */ @hhk, int @nCode, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ CallWindowProc(IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long), WNDPROC */ @lpPrevWndFunc, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CancelShutdown();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ CascadeWindows([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwndParent, uint /* UINT */ @wHow, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lpRect, uint /* UINT */ @cKids, IntPtr /* HWND__ *const *, const HWND * */ @lpKids);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeClipboardChain([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndRemove, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndNewNext);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ ChangeDisplaySettings([MarshalAs(UnmanagedType.LPStruct)] ref devicemodeW /* DEVMODEW * */ @lpDevMode, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ ChangeDisplaySettingsEx([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszDeviceName, [MarshalAs(UnmanagedType.LPStruct)] ref devicemodeW /* DEVMODEW * */ @lpDevMode, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, uint /* DWORD */ @dwflags, IntPtr /* void *, LPVOID */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeMenu([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @cmd, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszNewItem, uint /* UINT */ @cmdInsert, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeWindowMessageFilter(uint /* UINT */ @message, uint /* DWORD */ @dwFlag);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ChangeWindowMessageFilterEx([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, uint /* UINT */ @message, uint /* DWORD */ @action, [MarshalAs(UnmanagedType.LPStruct)] ref CHANGEFILTERSTRUCT /* PCHANGEFILTERSTRUCT */ @pChangeFilterStruct);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern string /* wchar_t *, LPWSTR */ CharLower([MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ CharLowerBuff([MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpsz, uint /* DWORD */ @cchLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern string /* wchar_t *, LPWSTR */ CharNext([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern string /* char *, LPSTR */ CharNextExA(ushort /* WORD */ @CodePage, [MarshalAs(UnmanagedType.LPTStr)] string /* const char *, LPCSTR */ @lpCurrentChar, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern string /* wchar_t *, LPWSTR */ CharPrev([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszStart, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszCurrent);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern string /* char *, LPSTR */ CharPrevExA(ushort /* WORD */ @CodePage, [MarshalAs(UnmanagedType.LPTStr)] string /* const char *, LPCSTR */ @lpStart, [MarshalAs(UnmanagedType.LPTStr)] string /* const char *, LPCSTR */ @lpCurrentChar, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CharToOem([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @pSrc, [MarshalAs(UnmanagedType.LPTStr)] string /* char *, LPSTR */ @pDst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CharToOemBuff([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszSrc, [MarshalAs(UnmanagedType.LPTStr)] string /* char *, LPSTR */ @lpszDst, uint /* DWORD */ @cchDstLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern string /* wchar_t *, LPWSTR */ CharUpper([MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ CharUpperBuff([MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpsz, uint /* DWORD */ @cchLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckDlgButton([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, int @nIDButton, uint /* UINT */ @uCheck);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ CheckMenuItem([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uIDCheckItem, uint /* UINT */ @uCheck);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckMenuRadioItem([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hmenu, uint /* UINT */ @first, uint /* UINT */ @last, uint /* UINT */ @check, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CheckRadioButton([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, int @nIDFirstButton, int @nIDLastButton, int @nIDCheckButton);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ ChildWindowFromPoint([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndParent, [MarshalAs(UnmanagedType.Struct)] POINT /* POINT */ @Point);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ ChildWindowFromPointEx([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, [MarshalAs(UnmanagedType.Struct)] POINT /* POINT */ @pt, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClientToScreen([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClipCursor([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseClipboard();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseDesktop([MarshalAs(UnmanagedType.Struct)] HDESK /* HDESK */ @hDesktop);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseGestureInfoHandle([MarshalAs(UnmanagedType.Struct)] HGESTUREINFO /* HGESTUREINFO */ @hGestureInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseTouchInputHandle([MarshalAs(UnmanagedType.Struct)] HTOUCHINPUT /* HTOUCHINPUT */ @hTouchInput);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseWindowStation([MarshalAs(UnmanagedType.Struct)] HWINSTA /* HWINSTA */ @hWinSta);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int CopyAcceleratorTable([MarshalAs(UnmanagedType.Struct)] HACCEL /* HACCEL */ @hAccelSrc, [MarshalAs(UnmanagedType.LPStruct)] ref ACCEL /* LPACCEL */ @lpAccelDst, int @cAccelEntries);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ CopyIcon([MarshalAs(UnmanagedType.Struct)] HICON /* HICON */ @hIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void *, HANDLE */ CopyImage(IntPtr /* void *, HANDLE */ @h, uint /* UINT */ @type, int @cx, int @cy, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprcDst, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcSrc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int CountClipboardFormats();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HACCEL /* HACCEL */ CreateAcceleratorTable([MarshalAs(UnmanagedType.LPStruct)] ref ACCEL /* LPACCEL */ @paccel, int @cAccel);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateCaret([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HBITMAP /* HBITMAP */ @hBitmap, int @nWidth, int @nHeight);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HCURSOR */ CreateCursor([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInst, int @xHotSpot, int @yHotSpot, int @nWidth, int @nHeight, IntPtr /* const void *, const void * */ @pvANDPlane, IntPtr /* const void *, const void * */ @pvXORPlane);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDESK /* HDESK */ CreateDesktop([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszDevice, [MarshalAs(UnmanagedType.LPStruct)] ref devicemodeW /* DEVMODEW * */ @pDevmode, uint /* DWORD */ @dwFlags, uint /* ACCESS_MASK */ @dwDesiredAccess, [MarshalAs(UnmanagedType.LPStruct)] ref SECURITY_ATTRIBUTES /* LPSECURITY_ATTRIBUTES */ @lpsa);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDESK /* HDESK */ CreateDesktopEx([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszDesktop, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszDevice, [MarshalAs(UnmanagedType.LPStruct)] ref devicemodeW /* DEVMODEW * */ @pDevmode, uint /* DWORD */ @dwFlags, uint /* ACCESS_MASK */ @dwDesiredAccess, [MarshalAs(UnmanagedType.LPStruct)] ref SECURITY_ATTRIBUTES /* LPSECURITY_ATTRIBUTES */ @lpsa, uint /* ULONG */ @ulHeapSize, IntPtr /* void *, PVOID */ @pvoid);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ CreateDialogIndirectParam([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPStruct)] ref DLGTEMPLATE /* LPCDLGTEMPLATEW */ @lpTemplate, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long), DLGPROC */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ CreateDialogParam([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpTemplateName, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long), DLGPROC */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ CreateIcon([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, int @nWidth, int @nHeight, byte @cPlanes, byte @cBitsPixel, IntPtr /* const unsigned char *, const BYTE * */ @lpbANDbits, IntPtr /* const unsigned char *, const BYTE * */ @lpbXORbits);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ CreateIconFromResource(IntPtr /* unsigned char *, PBYTE */ @presbits, uint /* DWORD */ @dwResSize, bool @fIcon, uint /* DWORD */ @dwVer);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ CreateIconFromResourceEx(IntPtr /* unsigned char *, PBYTE */ @presbits, uint /* DWORD */ @dwResSize, bool @fIcon, uint /* DWORD */ @dwVer, int @cxDesired, int @cyDesired, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ CreateIconIndirect([MarshalAs(UnmanagedType.LPStruct)] ref ICONINFO /* PICONINFO */ @piconinfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ CreateMDIWindow([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpWindowName, uint /* DWORD */ @dwStyle, int @X, int @Y, int @nWidth, int @nHeight, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndParent, [MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ CreateMenu();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ CreatePopupMenu();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ CreateWindowEx(uint /* DWORD */ @dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpWindowName, uint /* DWORD */ @dwStyle, int @X, int @Y, int @nWidth, int @nHeight, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndParent, [MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, [MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* void *, LPVOID */ @lpParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWINSTA /* HWINSTA */ CreateWindowStation([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpwinsta, uint /* DWORD */ @dwFlags, uint /* ACCESS_MASK */ @dwDesiredAccess, [MarshalAs(UnmanagedType.LPStruct)] ref SECURITY_ATTRIBUTES /* LPSECURITY_ATTRIBUTES */ @lpsa);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeAbandonTransaction(uint /* DWORD */ @idInst, [MarshalAs(UnmanagedType.Struct)] HCONV /* HCONV */ @hConv, uint /* DWORD */ @idTransaction);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* unsigned char *, LPBYTE */ DdeAccessData([MarshalAs(UnmanagedType.Struct)] HDDEDATA /* HDDEDATA */ @hData, IntPtr /* unsigned long *, LPDWORD */ @pcbDataSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDDEDATA /* HDDEDATA */ DdeAddData([MarshalAs(UnmanagedType.Struct)] HDDEDATA /* HDDEDATA */ @hData, IntPtr /* unsigned char *, LPBYTE */ @pSrc, uint /* DWORD */ @cb, uint /* DWORD */ @cbOff);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDDEDATA /* HDDEDATA */ DdeClientTransaction(IntPtr /* unsigned char *, LPBYTE */ @pData, uint /* DWORD */ @cbData, [MarshalAs(UnmanagedType.Struct)] HCONV /* HCONV */ @hConv, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hszItem, uint /* UINT */ @wFmt, uint /* UINT */ @wType, uint /* DWORD */ @dwTimeout, IntPtr /* unsigned long *, LPDWORD */ @pdwResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DdeCmpStringHandles([MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hsz1, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hsz2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HCONV /* HCONV */ DdeConnect(uint /* DWORD */ @idInst, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hszService, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hszTopic, [MarshalAs(UnmanagedType.LPStruct)] ref CONVCONTEXT /* PCONVCONTEXT */ @pCC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HCONVLIST /* HCONVLIST */ DdeConnectList(uint /* DWORD */ @idInst, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hszService, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hszTopic, [MarshalAs(UnmanagedType.Struct)] HCONVLIST /* HCONVLIST */ @hConvList, [MarshalAs(UnmanagedType.LPStruct)] ref CONVCONTEXT /* PCONVCONTEXT */ @pCC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDDEDATA /* HDDEDATA */ DdeCreateDataHandle(uint /* DWORD */ @idInst, IntPtr /* unsigned char *, LPBYTE */ @pSrc, uint /* DWORD */ @cb, uint /* DWORD */ @cbOff, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hszItem, uint /* UINT */ @wFmt, uint /* UINT */ @afCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HSZ /* HSZ */ DdeCreateStringHandle(uint /* DWORD */ @idInst, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @psz, int @iCodePage);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeDisconnect([MarshalAs(UnmanagedType.Struct)] HCONV /* HCONV */ @hConv);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeDisconnectList([MarshalAs(UnmanagedType.Struct)] HCONVLIST /* HCONVLIST */ @hConvList);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeEnableCallback(uint /* DWORD */ @idInst, [MarshalAs(UnmanagedType.Struct)] HCONV /* HCONV */ @hConv, uint /* UINT */ @wCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeFreeDataHandle([MarshalAs(UnmanagedType.Struct)] HDDEDATA /* HDDEDATA */ @hData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeFreeStringHandle(uint /* DWORD */ @idInst, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ DdeGetData([MarshalAs(UnmanagedType.Struct)] HDDEDATA /* HDDEDATA */ @hData, IntPtr /* unsigned char *, LPBYTE */ @pDst, uint /* DWORD */ @cbMax, uint /* DWORD */ @cbOff);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ DdeGetLastError(uint /* DWORD */ @idInst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeImpersonateClient([MarshalAs(UnmanagedType.Struct)] HCONV /* HCONV */ @hConv);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ DdeInitialize(IntPtr /* unsigned long *, LPDWORD */ @pidInst, IntPtr /* HDDEDATA__ *(*)(unsigned int, unsigned int, HCONV__ *, HSZ__ *, HSZ__ *, HDDEDATA__ *, unsigned long long, unsigned long long), PFNCALLBACK */ @pfnCallback, uint /* DWORD */ @afCmd, uint /* DWORD */ @ulRes);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeKeepStringHandle(uint /* DWORD */ @idInst, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDDEDATA /* HDDEDATA */ DdeNameService(uint /* DWORD */ @idInst, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hsz1, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hsz2, uint /* UINT */ @afCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdePostAdvise(uint /* DWORD */ @idInst, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hszTopic, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hszItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ DdeQueryConvInfo([MarshalAs(UnmanagedType.Struct)] HCONV /* HCONV */ @hConv, uint /* DWORD */ @idTransaction, [MarshalAs(UnmanagedType.LPStruct)] ref CONVINFO /* PCONVINFO */ @pConvInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HCONV /* HCONV */ DdeQueryNextServer([MarshalAs(UnmanagedType.Struct)] HCONVLIST /* HCONVLIST */ @hConvList, [MarshalAs(UnmanagedType.Struct)] HCONV /* HCONV */ @hConvPrev);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ DdeQueryString(uint /* DWORD */ @idInst, [MarshalAs(UnmanagedType.Struct)] HSZ /* HSZ */ @hsz, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @psz, uint /* DWORD */ @cchMax, int @iCodePage);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HCONV /* HCONV */ DdeReconnect([MarshalAs(UnmanagedType.Struct)] HCONV /* HCONV */ @hConv);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeSetQualityOfService([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwndClient, [MarshalAs(UnmanagedType.LPStruct)] ref SECURITY_QUALITY_OF_SERVICE /* const SECURITY_QUALITY_OF_SERVICE * */ @pqosNew, [MarshalAs(UnmanagedType.LPStruct)] ref SECURITY_QUALITY_OF_SERVICE /* PSECURITY_QUALITY_OF_SERVICE */ @pqosPrev);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeSetUserHandle([MarshalAs(UnmanagedType.Struct)] HCONV /* HCONV */ @hConv, uint /* DWORD */ @id, ulong /* DWORD_PTR */ @hUser);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeUnaccessData([MarshalAs(UnmanagedType.Struct)] HDDEDATA /* HDDEDATA */ @hData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DdeUninitialize(uint /* DWORD */ @idInst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefDlgProc([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void *, HDWP */ DeferWindowPos(IntPtr /* void *, HDWP */ @hWinPosInfo, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndInsertAfter, int @x, int @y, int @cx, int @cy, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefFrameProc([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndMDIClient, uint /* UINT */ @uMsg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefMDIChildProc([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @uMsg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefRawInputProc(IntPtr /* tagRAWINPUT **, PRAWINPUT * */ @paRawInput, int /* INT */ @nInput, uint /* UINT */ @cbSizeHeader);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefWindowProc([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteMenu([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeregisterShellHookWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyAcceleratorTable([MarshalAs(UnmanagedType.Struct)] HACCEL /* HACCEL */ @hAccel);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyCaret();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyCursor([MarshalAs(UnmanagedType.Struct)] HICON /* HCURSOR */ @hCursor);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyIcon([MarshalAs(UnmanagedType.Struct)] HICON /* HICON */ @hIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyMenu([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DestroyWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* INT_PTR */ DialogBoxIndirectParam([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPStruct)] ref DLGTEMPLATE /* LPCDLGTEMPLATEW */ @hDialogTemplate, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long), DLGPROC */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* INT_PTR */ DialogBoxParam([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpTemplateName, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long), DLGPROC */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void DisableProcessWindowsGhosting();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DispatchMessage([MarshalAs(UnmanagedType.LPStruct)] ref MSG /* const MSG * */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ DisplayConfigGetDeviceInfo([MarshalAs(UnmanagedType.LPStruct)] ref DISPLAYCONFIG_DEVICE_INFO_HEADER @requestPacket);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ DisplayConfigSetDeviceInfo([MarshalAs(UnmanagedType.LPStruct)] ref DISPLAYCONFIG_DEVICE_INFO_HEADER @setPacket);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DlgDirList([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpPathSpec, int @nIDListBox, int @nIDStaticPath, uint /* UINT */ @uFileType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DlgDirListComboBox([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpPathSpec, int @nIDComboBox, int @nIDStaticPath, uint /* UINT */ @uFiletype);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DlgDirSelectComboBoxEx([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwndDlg, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpString, int @cchOut, int @idComboBox);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DlgDirSelectEx([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwndDlg, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpString, int @chCount, int @idListBox);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DragDetect([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, [MarshalAs(UnmanagedType.Struct)] POINT /* POINT */ @pt);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ DragObject([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwndParent, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwndFrom, uint /* UINT */ @fmt, ulong /* ULONG_PTR */ @data, [MarshalAs(UnmanagedType.Struct)] HICON /* HCURSOR */ @hcur);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawAnimatedRects([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, int @idAni, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcFrom, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcTo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawCaption([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, [MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdc, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprect, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawEdge([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdc, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @qrc, uint /* UINT */ @edge, uint /* UINT */ @grfFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawFocusRect([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hDC, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawIcon([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hDC, int @X, int @Y, [MarshalAs(UnmanagedType.Struct)] HICON /* HICON */ @hIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawIconEx([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdc, int @xLeft, int @yTop, [MarshalAs(UnmanagedType.Struct)] HICON /* HICON */ @hIcon, int @cxWidth, int @cyWidth, uint /* UINT */ @istepIfAniCur, [MarshalAs(UnmanagedType.Struct)] HBRUSH /* HBRUSH */ @hbrFlickerFreeDraw, uint /* UINT */ @diFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawMenuBar([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DrawState([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdc, [MarshalAs(UnmanagedType.Struct)] HBRUSH /* HBRUSH */ @hbrFore, IntPtr /* int (*)(HDC__ *, long long, unsigned long long, int, int), DRAWSTATEPROC */ @qfnCallBack, long /* LPARAM */ @lData, ulong /* WPARAM */ @wData, int @x, int @y, int @cx, int @cy, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DrawText([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdc, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpchText, int @cchText, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprc, uint /* UINT */ @format);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DrawTextEx([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdc, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpchText, int @cchText, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprc, uint /* UINT */ @format, [MarshalAs(UnmanagedType.LPStruct)] ref DRAWTEXTPARAMS /* LPDRAWTEXTPARAMS */ @lpdtp);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EmptyClipboard();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableMenuItem([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uIDEnableItem, uint /* UINT */ @uEnable);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableScrollBar([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @wSBflags, uint /* UINT */ @wArrows);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnableWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, bool @bEnable);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndDeferWindowPos(IntPtr /* void *, HDWP */ @hWinPosInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndDialog([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, long /* INT_PTR */ @nResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndMenu();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EndPaint([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref PAINTSTRUCT /* const PAINTSTRUCT * */ @lpPaint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndParent, IntPtr /* int (*)(HWND__ *, long long), WNDENUMPROC */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ EnumClipboardFormats(uint /* UINT */ @format);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDesktops([MarshalAs(UnmanagedType.Struct)] HWINSTA /* HWINSTA */ @hwinsta, IntPtr /* int (*)(wchar_t *, long long), DESKTOPENUMPROCW */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDesktopWindows([MarshalAs(UnmanagedType.Struct)] HDESK /* HDESK */ @hDesktop, IntPtr /* int (*)(HWND__ *, long long), WNDENUMPROC */ @lpfn, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevices([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpDevice, uint /* DWORD */ @iDevNum, [MarshalAs(UnmanagedType.LPStruct)] ref DISPLAY_DEVICEW /* PDISPLAY_DEVICEW */ @lpDisplayDevice, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayMonitors([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdc, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPCRECT */ @lprcClip, IntPtr /* int (*)(HMONITOR__ *, HDC__ *, tagRECT *, long long), MONITORENUMPROC */ @lpfnEnum, long /* LPARAM */ @dwData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettings([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszDeviceName, uint /* DWORD */ @iModeNum, [MarshalAs(UnmanagedType.LPStruct)] ref devicemodeW /* DEVMODEW * */ @lpDevMode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettingsEx([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszDeviceName, uint /* DWORD */ @iModeNum, [MarshalAs(UnmanagedType.LPStruct)] ref devicemodeW /* DEVMODEW * */ @lpDevMode, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int EnumProps([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, IntPtr /* int (*)(HWND__ *, const wchar_t *, void *), PROPENUMPROCW */ @lpEnumFunc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int EnumPropsEx([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, IntPtr /* int (*)(HWND__ *, wchar_t *, void *, unsigned long long), PROPENUMPROCEXW */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumThreadWindows(uint /* DWORD */ @dwThreadId, IntPtr /* int (*)(HWND__ *, long long), WNDENUMPROC */ @lpfn, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindows(IntPtr /* int (*)(HWND__ *, long long), WNDENUMPROC */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindowStations(IntPtr /* int (*)(wchar_t *, long long), WINSTAENUMPROCW */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EqualRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprc1, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ExcludeUpdateRgn([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hDC, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ExitWindowsEx(uint /* UINT */ @uFlags, uint /* DWORD */ @dwReason);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FillRect([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hDC, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprc, [MarshalAs(UnmanagedType.Struct)] HBRUSH /* HBRUSH */ @hbr);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ FindWindow([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpWindowName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ FindWindowEx([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndParent, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndChildAfter, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszClass, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszWindow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlashWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, bool @bInvert);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlashWindowEx([MarshalAs(UnmanagedType.LPStruct)] ref FLASHWINFO /* PFLASHWINFO */ @pfwi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FrameRect([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hDC, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprc, [MarshalAs(UnmanagedType.Struct)] HBRUSH /* HBRUSH */ @hbr);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeDDElParam(uint /* UINT */ @msg, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetActiveWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetAltTabInfo([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, int @iItem, [MarshalAs(UnmanagedType.LPStruct)] ref ALTTABINFO /* PALTTABINFO */ @pati, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @pszItemText, uint /* UINT */ @cchItemText);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetAncestor([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, uint /* UINT */ @gaFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern short /* SHORT */ GetAsyncKeyState(int @vKey);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetCapture();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetCaretBlinkTime();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCaretPos([MarshalAs(UnmanagedType.LPStruct)] ref POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfo([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpClassName, [MarshalAs(UnmanagedType.LPStruct)] ref WNDCLASSW /* LPWNDCLASSW */ @lpWndClass);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClassInfoEx([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszClass, [MarshalAs(UnmanagedType.LPStruct)] ref WNDCLASSEXW /* LPWNDCLASSEXW */ @lpwcx);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetClassLong([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ulong /* ULONG_PTR */ GetClassLongPtr([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetClassName([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpClassName, int @nMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ GetClassWord([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClientRect([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void *, HANDLE */ GetClipboardData(uint /* UINT */ @uFormat);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetClipboardFormatName(uint /* UINT */ @format, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpszFormatName, int @cchMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetClipboardOwner();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetClipboardSequenceNumber();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetClipboardViewer();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClipCursor([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetComboBoxInfo([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwndCombo, [MarshalAs(UnmanagedType.LPStruct)] ref COMBOBOXINFO /* PCOMBOBOXINFO */ @pcbi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HCURSOR */ GetCursor();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorInfo([MarshalAs(UnmanagedType.LPStruct)] ref CURSORINFO /* PCURSORINFO */ @pci);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos([MarshalAs(UnmanagedType.LPStruct)] ref POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDC /* HDC */ GetDC([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDC /* HDC */ GetDCEx([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HRGN /* HRGN */ @hrgnClip, uint /* DWORD */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetDesktopWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetDialogBaseUnits();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetDisplayConfigBufferSizes(uint /* UINT32 */ @flags, IntPtr /* unsigned int *, UINT32 * */ @numPathArrayElements, IntPtr /* unsigned int *, UINT32 * */ @numModeInfoArrayElements);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetDlgCtrlID([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetDlgItem([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, int @nIDDlgItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetDlgItemInt([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, int @nIDDlgItem, IntPtr /* int *, BOOL * */ @lpTranslated, bool @bSigned);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetDlgItemText([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, int @nIDDlgItem, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpString, int @cchMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetDoubleClickTime();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetFocus();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetForegroundWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetGestureConfig([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, uint /* DWORD */ @dwReserved, uint /* DWORD */ @dwFlags, IntPtr /* unsigned int *, PUINT */ @pcIDs, [MarshalAs(UnmanagedType.LPStruct)] ref GESTURECONFIG /* PGESTURECONFIG */ @pGestureConfig, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetGestureExtraArgs([MarshalAs(UnmanagedType.Struct)] HGESTUREINFO /* HGESTUREINFO */ @hGestureInfo, uint /* UINT */ @cbExtraArgs, IntPtr /* unsigned char *, PBYTE */ @pExtraArgs);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetGestureInfo([MarshalAs(UnmanagedType.Struct)] HGESTUREINFO /* HGESTUREINFO */ @hGestureInfo, [MarshalAs(UnmanagedType.LPStruct)] ref GESTUREINFO /* PGESTUREINFO */ @pGestureInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetGuiResources(IntPtr /* void *, HANDLE */ @hProcess, uint /* DWORD */ @uiFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetGUIThreadInfo(uint /* DWORD */ @idThread, [MarshalAs(UnmanagedType.LPStruct)] ref GUITHREADINFO /* PGUITHREADINFO */ @pgui);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo([MarshalAs(UnmanagedType.Struct)] HICON /* HICON */ @hIcon, [MarshalAs(UnmanagedType.LPStruct)] ref ICONINFO /* PICONINFO */ @piconinfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfoEx([MarshalAs(UnmanagedType.Struct)] HICON /* HICON */ @hicon, [MarshalAs(UnmanagedType.LPStruct)] ref ICONINFOEXW /* PICONINFOEXW */ @piconinfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetInputState();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetKBCodePage();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HKL /* HKL */ GetKeyboardLayout(uint /* DWORD */ @idThread);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetKeyboardLayoutList(int @nBuff, IntPtr /* HKL__ **, HKL * */ @lpList);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetKeyboardLayoutName([MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @pwszKLID);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetKeyboardState(IntPtr /* unsigned char *, PBYTE */ @lpKeyState);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetKeyboardType(int @nTypeFlag);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetKeyNameText(int /* LONG */ @lParam, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpString, int @cchSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern short /* SHORT */ GetKeyState(int @nVirtKey);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetLastActivePopup([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetLastInputInfo([MarshalAs(UnmanagedType.LPStruct)] ref LASTINPUTINFO /* PLASTINPUTINFO */ @plii);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetLayeredWindowAttributes([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, IntPtr /* unsigned long *, COLORREF * */ @pcrKey, IntPtr /* unsigned char *, BYTE * */ @pbAlpha, IntPtr /* unsigned long *, DWORD * */ @pdwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetListBoxInfo([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ GetMenu([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuBarInfo([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, int /* LONG */ @idObject, int /* LONG */ @idItem, [MarshalAs(UnmanagedType.LPStruct)] ref MENUBARINFO /* PMENUBARINFO */ @pmbi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetMenuCheckMarkDimensions();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetMenuDefaultItem([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @fByPos, uint /* UINT */ @gmdiFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetMenuItemCount([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetMenuItemID([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, int @nPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuItemInfo([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hmenu, uint /* UINT */ @item, bool @fByPosition, [MarshalAs(UnmanagedType.LPStruct)] ref MENUITEMINFOW /* LPMENUITEMINFOW */ @lpmii);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMenuItemRect([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uItem, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprcItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetMenuState([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uId, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetMenuString([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uIDItem, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpString, int @cchMax, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMessage([MarshalAs(UnmanagedType.LPStruct)] ref MSG /* LPMSG */ @lpMsg, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @wMsgFilterMin, uint /* UINT */ @wMsgFilterMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ GetMessageExtraInfo();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetMessagePos();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetMessageTime();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorInfo([MarshalAs(UnmanagedType.Struct)] HMONITOR /* HMONITOR */ @hMonitor, [MarshalAs(UnmanagedType.LPStruct)] ref MONITORINFO /* LPMONITORINFO */ @lpmi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetMouseMovePointsEx(uint /* UINT */ @cbSize, [MarshalAs(UnmanagedType.LPStruct)] ref MOUSEMOVEPOINT /* LPMOUSEMOVEPOINT */ @lppt, [MarshalAs(UnmanagedType.LPStruct)] ref MOUSEMOVEPOINT /* LPMOUSEMOVEPOINT */ @lpptBuf, int @nBufPoints, uint /* DWORD */ @resolution);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetNextDlgGroupItem([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hCtl, bool @bPrevious);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetNextDlgTabItem([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hCtl, bool @bPrevious);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetOpenClipboardWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetParent([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPhysicalCursorPos([MarshalAs(UnmanagedType.LPStruct)] ref POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetPriorityClipboardFormat(IntPtr /* unsigned int *, UINT * */ @paFormatPriorityList, int @cFormats);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetProcessDefaultLayout(IntPtr /* unsigned long *, DWORD * */ @pdwDefaultLayout);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWINSTA /* HWINSTA */ GetProcessWindowStation();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void *, HANDLE */ GetProp([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetQueueStatus(uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputBuffer([MarshalAs(UnmanagedType.LPStruct)] ref RAWINPUT /* PRAWINPUT */ @pData, IntPtr /* unsigned int *, PUINT */ @pcbSize, uint /* UINT */ @cbSizeHeader);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputData([MarshalAs(UnmanagedType.Struct)] HRAWINPUT /* HRAWINPUT */ @hRawInput, uint /* UINT */ @uiCommand, IntPtr /* void *, LPVOID */ @pData, IntPtr /* unsigned int *, PUINT */ @pcbSize, uint /* UINT */ @cbSizeHeader);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputDeviceInfo(IntPtr /* void *, HANDLE */ @hDevice, uint /* UINT */ @uiCommand, IntPtr /* void *, LPVOID */ @pData, IntPtr /* unsigned int *, PUINT */ @pcbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputDeviceList([MarshalAs(UnmanagedType.LPStruct)] ref RAWINPUTDEVICELIST /* PRAWINPUTDEVICELIST */ @pRawInputDeviceList, IntPtr /* unsigned int *, PUINT */ @puiNumDevices, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRegisteredRawInputDevices([MarshalAs(UnmanagedType.LPStruct)] ref RAWINPUTDEVICE /* PRAWINPUTDEVICE */ @pRawInputDevices, IntPtr /* unsigned int *, PUINT */ @puiNumDevices, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollBarInfo([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, int /* LONG */ @idObject, [MarshalAs(UnmanagedType.LPStruct)] ref SCROLLBARINFO /* PSCROLLBARINFO */ @psbi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollInfo([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, int @nBar, [MarshalAs(UnmanagedType.LPStruct)] ref SCROLLINFO /* LPSCROLLINFO */ @lpsi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetScrollPos([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nBar);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetScrollRange([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nBar, IntPtr /* int *, LPINT */ @lpMinPos, IntPtr /* int *, LPINT */ @lpMaxPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetShellWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ GetSubMenu([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, int @nPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetSysColor(int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HBRUSH /* HBRUSH */ GetSysColorBrush(int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ GetSystemMenu([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, bool @bRevert);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetSystemMetrics(int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetTabbedTextExtent([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdc, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpString, int @chCount, int @nTabPositions, IntPtr /* const int *, const INT * */ @lpnTabStopPositions);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDESK /* HDESK */ GetThreadDesktop(uint /* DWORD */ @dwThreadId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTitleBarInfo([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, [MarshalAs(UnmanagedType.LPStruct)] ref TITLEBARINFO /* PTITLEBARINFO */ @pti);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetTopWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTouchInputInfo([MarshalAs(UnmanagedType.Struct)] HTOUCHINPUT /* HTOUCHINPUT */ @hTouchInput, uint /* UINT */ @cInputs, [MarshalAs(UnmanagedType.LPStruct)] ref TOUCHINPUT /* PTOUCHINPUT */ @pInputs, int @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUpdatedClipboardFormats(IntPtr /* unsigned int *, PUINT */ @lpuiFormats, uint /* UINT */ @cFormats, IntPtr /* unsigned int *, PUINT */ @pcFormatsOut);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUpdateRect([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lpRect, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetUpdateRgn([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HRGN /* HRGN */ @hRgn, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUserObjectInformation(IntPtr /* void *, HANDLE */ @hObj, int @nIndex, IntPtr /* void *, PVOID */ @pvInfo, uint /* DWORD */ @nLength, IntPtr /* unsigned long *, LPDWORD */ @lpnLengthNeeded);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetUserObjectSecurity(IntPtr /* void *, HANDLE */ @hObj, IntPtr /* unsigned long *, PSECURITY_INFORMATION */ @pSIRequested, IntPtr /* void *, PSECURITY_DESCRIPTOR */ @pSID, uint /* DWORD */ @nLength, IntPtr /* unsigned long *, LPDWORD */ @lpnLengthNeeded);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @uCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDC /* HDC */ GetWindowDC([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowDisplayAffinity([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, IntPtr /* unsigned long *, DWORD * */ @pdwAffinity);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowInfo([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, [MarshalAs(UnmanagedType.LPStruct)] ref WINDOWINFO /* PWINDOWINFO */ @pwi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetWindowLong([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LONG_PTR */ GetWindowLongPtr([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetWindowModuleFileName([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @pszFileName, uint /* UINT */ @cchFileNameMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowPlacement([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref WINDOWPLACEMENT /* WINDOWPLACEMENT * */ @lpwndpl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowRgn([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HRGN /* HRGN */ @hRgn);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowRgnBox([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpString, int @nMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowTextLength([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetWindowThreadProcessId([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, IntPtr /* unsigned long *, LPDWORD */ @lpdwProcessId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ GetWindowWord([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GrayString([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hDC, [MarshalAs(UnmanagedType.Struct)] HBRUSH /* HBRUSH */ @hBrush, IntPtr /* int (*)(HDC__ *, long long, int), GRAYSTRINGPROC */ @lpOutputFunc, long /* LPARAM */ @lpData, int @nCount, int @X, int @Y, int @nWidth, int @nHeight);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HideCaret([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool HiliteMenuItem([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uIDHiliteItem, uint /* UINT */ @uHilite);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ImpersonateDdeClientWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndClient, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndServer);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InflateRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprc, int @dx, int @dy);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InSendMessage();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ InSendMessageEx(IntPtr /* void *, LPVOID */ @lpReserved);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenu([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags, ulong /* UINT_PTR */ @uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpNewItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InsertMenuItem([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hmenu, uint /* UINT */ @item, bool @fByPosition, [MarshalAs(UnmanagedType.LPStruct)] ref MENUITEMINFOW /* LPCMENUITEMINFOW */ @lpmi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int InternalGetWindowText([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @pString, int @cchMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IntersectRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprcDst, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcSrc1, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcSrc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvalidateRect([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lpRect, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvalidateRgn([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HRGN /* HRGN */ @hRgn, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool InvertRect([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hDC, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharAlpha(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharAlphaNumeric(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharLower(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsCharUpper(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsChild([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndParent, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsClipboardFormatAvailable(uint /* UINT */ @format);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsDialogMessage([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, [MarshalAs(UnmanagedType.LPStruct)] ref MSG /* LPMSG */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ IsDlgButtonChecked([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, int @nIDButton);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsGUIThread(bool @bConvert);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsHungAppWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsIconic([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsMenu([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsProcessDPIAware();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsRectEmpty([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsTouchWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, IntPtr /* unsigned long *, PULONG */ @pulFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowEnabled([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowUnicode([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWinEventHookInstalled(uint /* DWORD */ @event);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Message();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsZoomed([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void keybd_event(byte @bVk, byte @bScan, uint /* DWORD */ @dwFlags, ulong /* ULONG_PTR */ @dwExtraInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool KillTimer([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, ulong /* UINT_PTR */ @uIDEvent);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HACCEL /* HACCEL */ LoadAccelerators([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpTableName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HBITMAP /* HBITMAP */ LoadBitmap([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpBitmapName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HCURSOR */ LoadCursor([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpCursorName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HCURSOR */ LoadCursorFromFile([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpFileName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ LoadIcon([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpIconName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void *, HANDLE */ LoadImage([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInst, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @name, uint /* UINT */ @type, int @cx, int @cy, uint /* UINT */ @fuLoad);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HKL /* HKL */ LoadKeyboardLayout([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @pwszKLID, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ LoadMenu([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpMenuName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ LoadMenuIndirect(IntPtr /* const void *, const MENUTEMPLATEW * */ @lpMenuTemplate);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LoadString([MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance, uint /* UINT */ @uID, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpBuffer, int @cchBufferMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockSetForegroundWindow(uint /* UINT */ @uLockCode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockWindowUpdate([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndLock);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LockWorkStation();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LogicalToPhysicalPoint([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LookupIconIdFromDirectory(IntPtr /* unsigned char *, PBYTE */ @presbits, bool @fIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LookupIconIdFromDirectoryEx(IntPtr /* unsigned char *, PBYTE */ @presbits, bool @fIcon, int @cxDesired, int @cyDesired, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MapDialogRect([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ MapVirtualKey(uint /* UINT */ @uCode, uint /* UINT */ @uMapType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ MapVirtualKeyEx(uint /* UINT */ @uCode, uint /* UINT */ @uMapType, [MarshalAs(UnmanagedType.Struct)] HKL /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MapWindowPoints([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndFrom, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndTo, [MarshalAs(UnmanagedType.LPStruct)] ref POINT /* LPPOINT */ @lpPoints, uint /* UINT */ @cPoints);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MenuItemFromPoint([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, [MarshalAs(UnmanagedType.Struct)] POINT /* POINT */ @ptScreen);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MessageBeep(uint /* UINT */ @uType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MessageBox([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpText, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpCaption, uint /* UINT */ @uType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MessageBoxEx([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpText, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpCaption, uint /* UINT */ @uType, ushort /* WORD */ @wLanguageId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MessageBoxIndirect([MarshalAs(UnmanagedType.LPStruct)] ref MSGBOXPARAMSW /* const MSGBOXPARAMSW * */ @lpmbp);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ModifyMenu([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMnu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags, ulong /* UINT_PTR */ @uIDNewItem, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpNewItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMONITOR /* HMONITOR */ MonitorFromPoint([MarshalAs(UnmanagedType.Struct)] POINT /* POINT */ @pt, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMONITOR /* HMONITOR */ MonitorFromRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPCRECT */ @lprc, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMONITOR /* HMONITOR */ MonitorFromWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void mouse_event(uint /* DWORD */ @dwFlags, uint /* DWORD */ @dx, uint /* DWORD */ @dy, uint /* DWORD */ @dwData, ulong /* ULONG_PTR */ @dwExtraInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @X, int @Y, int @nWidth, int @nHeight, bool @bRepaint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ MsgWaitForMultipleObjects(uint /* DWORD */ @nCount, IntPtr /* void *const *, const HANDLE * */ @pHandles, bool @fWaitAll, uint /* DWORD */ @dwMilliseconds, uint /* DWORD */ @dwWakeMask);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ MsgWaitForMultipleObjectsEx(uint /* DWORD */ @nCount, IntPtr /* void *const *, const HANDLE * */ @pHandles, uint /* DWORD */ @dwMilliseconds, uint /* DWORD */ @dwWakeMask, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void NotifyWinEvent(uint /* DWORD */ @event, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, int /* LONG */ @idObject, int /* LONG */ @idChild);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ OemKeyScan(ushort /* WORD */ @wOemChar);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OemToChar([MarshalAs(UnmanagedType.LPTStr)] string /* const char *, LPCSTR */ @pSrc, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @pDst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OemToCharBuff([MarshalAs(UnmanagedType.LPTStr)] string /* const char *, LPCSTR */ @lpszSrc, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @lpszDst, uint /* DWORD */ @cchDstLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OffsetRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprc, int @dx, int @dy);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenClipboard([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndNewOwner);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDESK /* HDESK */ OpenDesktop([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszDesktop, uint /* DWORD */ @dwFlags, bool @fInherit, uint /* ACCESS_MASK */ @dwDesiredAccess);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenIcon([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDESK /* HDESK */ OpenInputDesktop(uint /* DWORD */ @dwFlags, bool @fInherit, uint /* ACCESS_MASK */ @dwDesiredAccess);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWINSTA /* HWINSTA */ OpenWindowStation([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszWinSta, bool @fInherit, uint /* ACCESS_MASK */ @dwDesiredAccess);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ PackDDElParam(uint /* UINT */ @msg, ulong /* UINT_PTR */ @uiLo, ulong /* UINT_PTR */ @uiHi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PaintDesktop([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessage([MarshalAs(UnmanagedType.LPStruct)] ref MSG /* LPMSG */ @lpMsg, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @wMsgFilterMin, uint /* UINT */ @wMsgFilterMax, uint /* UINT */ @wRemoveMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PhysicalToLogicalPoint([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessage([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void PostQuitMessage(int @nExitCode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostThreadMessage(uint /* DWORD */ @idThread, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrintWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, [MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdcBlt, uint /* UINT */ @nFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ PrivateExtractIcons([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @szFileName, int @nIconIndex, int @cxIcon, int @cyIcon, IntPtr /* HICON__ **, HICON * */ @phicon, IntPtr /* unsigned int *, UINT * */ @piconid, uint /* UINT */ @nIcons, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PtInRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprc, [MarshalAs(UnmanagedType.Struct)] POINT /* POINT */ @pt);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ QueryDisplayConfig(uint /* UINT32 */ @flags, IntPtr /* unsigned int *, UINT32 * */ @numPathArrayElements, [MarshalAs(UnmanagedType.LPStruct)] ref DISPLAYCONFIG_PATH_INFO @pathArray, IntPtr /* unsigned int *, UINT32 * */ @numModeInfoArrayElements, [MarshalAs(UnmanagedType.LPStruct)] ref DISPLAYCONFIG_MODE_INFO @modeInfoArray, IntPtr /* DISPLAYCONFIG_TOPOLOGY_ID *, DISPLAYCONFIG_TOPOLOGY_ID * */ @currentTopologyId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ RealChildWindowFromPoint([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwndParent, [MarshalAs(UnmanagedType.Struct)] POINT /* POINT */ @ptParentClientCoords);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ RealGetWindowClass([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @ptszClassName, uint /* UINT */ @cchClassNameMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RedrawWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcUpdate, [MarshalAs(UnmanagedType.Struct)] HRGN /* HRGN */ @hrgnUpdate, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* ATOM */ RegisterClass([MarshalAs(UnmanagedType.LPStruct)] ref WNDCLASSW /* const WNDCLASSW * */ @lpWndClass);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ RegisterClipboardFormat([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszFormat);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void *, HDEVNOTIFY */ RegisterDeviceNotification(IntPtr /* void *, HANDLE */ @hRecipient, IntPtr /* void *, LPVOID */ @NotificationFilter, uint /* DWORD */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterHotKey([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @id, uint /* UINT */ @fsModifiers, uint /* UINT */ @vk);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void *, HPOWERNOTIFY */ RegisterPowerSettingNotification(IntPtr /* void *, HANDLE */ @hRecipient, [MarshalAs(UnmanagedType.LPStruct)] ref GUID /* LPCGUID */ @PowerSettingGuid, uint /* DWORD */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterRawInputDevices([MarshalAs(UnmanagedType.LPStruct)] ref RAWINPUTDEVICE /* PCRAWINPUTDEVICE */ @pRawInputDevices, uint /* UINT */ @uiNumDevices, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterShellHookWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterTouchWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, uint /* ULONG */ @ulFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ RegisterWindowMessage([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseCapture();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ReleaseDC([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hDC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveClipboardFormatListener([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RemoveMenu([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void *, HANDLE */ RemoveProp([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReplyMessage(long /* LRESULT */ @lResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ ReuseDDElParam(long /* LPARAM */ @lParam, uint /* UINT */ @msgIn, uint /* UINT */ @msgOut, ulong /* UINT_PTR */ @uiLo, ulong /* UINT_PTR */ @uiHi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScreenToClient([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollDC([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hDC, int @dx, int @dy, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcScroll, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcClip, [MarshalAs(UnmanagedType.Struct)] HRGN /* HRGN */ @hrgnUpdate, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprcUpdate);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @XAmount, int @YAmount, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lpRect, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lpClipRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ScrollWindowEx([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @dx, int @dy, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @prcScroll, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @prcClip, [MarshalAs(UnmanagedType.Struct)] HRGN /* HRGN */ @hrgnUpdate, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @prcUpdate, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ SendDlgItemMessage([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, int @nIDDlgItem, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ SendInput(uint /* UINT */ @cInputs, [MarshalAs(UnmanagedType.LPStruct)] ref INPUT /* LPINPUT */ @pInputs, int @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ SendMessage([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendMessageCallback([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam, IntPtr /* void (*)(HWND__ *, unsigned int, unsigned long long, long long), SENDASYNCPROC */ @lpResultCallBack, ulong /* ULONG_PTR */ @dwData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ SendMessageTimeout([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam, uint /* UINT */ @fuFlags, uint /* UINT */ @uTimeout, IntPtr /* unsigned long long *, PDWORD_PTR */ @lpdwResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SendNotifyMessage([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ SetActiveWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ SetCapture([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCaretBlinkTime(uint /* UINT */ @uMSeconds);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCaretPos(int @X, int @Y);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ SetClassLong([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex, int /* LONG */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ulong /* ULONG_PTR */ SetClassLongPtr([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex, long /* LONG_PTR */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ SetClassWord([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex, ushort /* WORD */ @wNewWord);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void *, HANDLE */ SetClipboardData(uint /* UINT */ @uFormat, IntPtr /* void *, HANDLE */ @hMem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ SetClipboardViewer([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndNewViewer);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HCURSOR */ SetCursor([MarshalAs(UnmanagedType.Struct)] HICON /* HCURSOR */ @hCursor);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCursorPos(int @X, int @Y);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SetDebugErrorLevel(uint /* DWORD */ @dwLevel);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ SetDisplayConfig(uint /* UINT32 */ @numPathArrayElements, [MarshalAs(UnmanagedType.LPStruct)] ref DISPLAYCONFIG_PATH_INFO @pathArray, uint /* UINT32 */ @numModeInfoArrayElements, [MarshalAs(UnmanagedType.LPStruct)] ref DISPLAYCONFIG_MODE_INFO @modeInfoArray, uint /* UINT32 */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDlgItemInt([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, int @nIDDlgItem, uint /* UINT */ @uValue, bool @bSigned);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDlgItemText([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hDlg, int @nIDDlgItem, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ SetFocus([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetGestureConfig([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, uint /* DWORD */ @dwReserved, uint /* UINT */ @cIDs, [MarshalAs(UnmanagedType.LPStruct)] ref GESTURECONFIG /* PGESTURECONFIG */ @pGestureConfig, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetKeyboardState(IntPtr /* unsigned char *, LPBYTE */ @lpKeyState);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SetLastErrorEx(uint /* DWORD */ @dwErrCode, uint /* DWORD */ @dwType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetLayeredWindowAttributes([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, uint /* COLORREF */ @crKey, byte @bAlpha, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenu([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuDefaultItem([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uItem, uint /* UINT */ @fByPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuItemBitmaps([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags, [MarshalAs(UnmanagedType.Struct)] HBITMAP /* HBITMAP */ @hBitmapUnchecked, [MarshalAs(UnmanagedType.Struct)] HBITMAP /* HBITMAP */ @hBitmapChecked);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMenuItemInfo([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hmenu, uint /* UINT */ @item, bool @fByPositon, [MarshalAs(UnmanagedType.LPStruct)] ref MENUITEMINFOW /* LPCMENUITEMINFOW */ @lpmii);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ SetMessageExtraInfo(long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMessageQueue(int @cMessagesMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ SetParent([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndChild, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndNewParent);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPhysicalCursorPos(int @X, int @Y);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessDefaultLayout(uint /* DWORD */ @dwDefaultLayout);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessDPIAware();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProcessWindowStation([MarshalAs(UnmanagedType.Struct)] HWINSTA /* HWINSTA */ @hWinSta);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetProp([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpString, IntPtr /* void *, HANDLE */ @hData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprc, int @xLeft, int @yTop, int @xRight, int @yBottom);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetRectEmpty([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetScrollInfo([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, int @nBar, [MarshalAs(UnmanagedType.LPStruct)] ref SCROLLINFO /* LPCSCROLLINFO */ @lpsi, bool @redraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetScrollPos([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nBar, int @nPos, bool @bRedraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetScrollRange([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nBar, int @nMinPos, int @nMaxPos, bool @bRedraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSysColors(int @cElements, IntPtr /* const int *, const INT * */ @lpaElements, IntPtr /* const unsigned long *, const COLORREF * */ @lpaRgbValues);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemCursor([MarshalAs(UnmanagedType.Struct)] HICON /* HCURSOR */ @hcur, uint /* DWORD */ @id);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadDesktop([MarshalAs(UnmanagedType.Struct)] HDESK /* HDESK */ @hDesktop);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ulong /* UINT_PTR */ SetTimer([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, ulong /* UINT_PTR */ @nIDEvent, uint /* UINT */ @uElapse, IntPtr /* void (*)(HWND__ *, unsigned int, unsigned long long, unsigned long), TIMERPROC */ @lpTimerFunc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetUserObjectInformation(IntPtr /* void *, HANDLE */ @hObj, int @nIndex, IntPtr /* void *, PVOID */ @pvInfo, uint /* DWORD */ @nLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetUserObjectSecurity(IntPtr /* void *, HANDLE */ @hObj, IntPtr /* unsigned long *, PSECURITY_INFORMATION */ @pSIRequested, IntPtr /* void *, PSECURITY_DESCRIPTOR */ @pSID);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowDisplayAffinity([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, uint /* DWORD */ @dwAffinity);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ SetWindowLong([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex, int /* LONG */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LONG_PTR */ SetWindowLongPtr([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex, long /* LONG_PTR */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPlacement([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref WINDOWPLACEMENT /* const WINDOWPLACEMENT * */ @lpwndpl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndInsertAfter, int @X, int @Y, int @cx, int @cy, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetWindowRgn([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HRGN /* HRGN */ @hRgn, bool @bRedraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HHOOK /* HHOOK */ SetWindowsHook(int @nFilterType, IntPtr /* long long (*)(int, unsigned long long, long long), HOOKPROC */ @pfnFilterProc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HHOOK /* HHOOK */ SetWindowsHookEx(int @idHook, IntPtr /* long long (*)(int, unsigned long long, long long), HOOKPROC */ @lpfn, [MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hmod, uint /* DWORD */ @dwThreadId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowText([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ SetWindowWord([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nIndex, ushort /* WORD */ @wNewWord);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWINEVENTHOOK /* HWINEVENTHOOK */ SetWinEventHook(uint /* DWORD */ @eventMin, uint /* DWORD */ @eventMax, [MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HMODULE */ @hmodWinEventProc, IntPtr /* void (*)(HWINEVENTHOOK__ *, unsigned long, HWND__ *, long, long, unsigned long, unsigned long), WINEVENTPROC */ @pfnWinEventProc, uint /* DWORD */ @idProcess, uint /* DWORD */ @idThread, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowCaret([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ShowCursor(bool @bShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowOwnedPopups([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, bool @fShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowScrollBar([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @wBar, bool @bShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nCmdShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindowAsync([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @nCmdShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShutdownBlockReasonCreate([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @pwszReason);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShutdownBlockReasonDestroy([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShutdownBlockReasonQuery([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @pwszBuff, IntPtr /* unsigned long *, DWORD * */ @pcchBuff);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SoundSentry();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SubtractRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprcDst, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcSrc1, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcSrc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwapMouseButton(bool @fSwap);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwitchDesktop([MarshalAs(UnmanagedType.Struct)] HDESK /* HDESK */ @hDesktop);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SwitchToThisWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, bool @fUnknown);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfo(uint /* UINT */ @uiAction, uint /* UINT */ @uiParam, IntPtr /* void *, PVOID */ @pvParam, uint /* UINT */ @fWinIni);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ TabbedTextOut([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdc, int @x, int @y, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpString, int @chCount, int @nTabPositions, IntPtr /* const int *, const INT * */ @lpnTabStopPositions, int @nTabOrigin);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ TileWindows([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwndParent, uint /* UINT */ @wHow, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lpRect, uint /* UINT */ @cKids, IntPtr /* HWND__ *const *, const HWND * */ @lpKids);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToAscii(uint /* UINT */ @uVirtKey, uint /* UINT */ @uScanCode, IntPtr /* const unsigned char *, const BYTE * */ @lpKeyState, IntPtr /* unsigned short *, LPWORD */ @lpChar, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToAsciiEx(uint /* UINT */ @uVirtKey, uint /* UINT */ @uScanCode, IntPtr /* const unsigned char *, const BYTE * */ @lpKeyState, IntPtr /* unsigned short *, LPWORD */ @lpChar, uint /* UINT */ @uFlags, [MarshalAs(UnmanagedType.Struct)] HKL /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToUnicode(uint /* UINT */ @wVirtKey, uint /* UINT */ @wScanCode, IntPtr /* const unsigned char *, const BYTE * */ @lpKeyState, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @pwszBuff, int @cchBuff, uint /* UINT */ @wFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToUnicodeEx(uint /* UINT */ @wVirtKey, uint /* UINT */ @wScanCode, IntPtr /* const unsigned char *, const BYTE * */ @lpKeyState, [MarshalAs(UnmanagedType.LPWStr)] string /* wchar_t *, LPWSTR */ @pwszBuff, int @cchBuff, uint /* UINT */ @wFlags, [MarshalAs(UnmanagedType.Struct)] HKL /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackMouseEvent([MarshalAs(UnmanagedType.LPStruct)] ref TRACKMOUSEEVENT /* LPTRACKMOUSEEVENT */ @lpEventTrack);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackPopupMenu([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uFlags, int @x, int @y, int @nReserved, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @prcRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TrackPopupMenuEx([MarshalAs(UnmanagedType.Struct)] HMENU /* HMENU */ @hMenu, uint /* UINT */ @uFlags, int @x, int @y, [MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd, [MarshalAs(UnmanagedType.LPStruct)] ref TPMPARAMS /* LPTPMPARAMS */ @lptpm);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int TranslateAccelerator([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HACCEL /* HACCEL */ @hAccTable, [MarshalAs(UnmanagedType.LPStruct)] ref MSG /* LPMSG */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMDISysAccel([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndClient, [MarshalAs(UnmanagedType.LPStruct)] ref MSG /* LPMSG */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage([MarshalAs(UnmanagedType.LPStruct)] ref MSG /* const MSG * */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHook(int @nCode, IntPtr /* long long (*)(int, unsigned long long, long long), HOOKPROC */ @pfnFilterProc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx([MarshalAs(UnmanagedType.Struct)] HHOOK /* HHOOK */ @hhk);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWinEvent([MarshalAs(UnmanagedType.Struct)] HWINEVENTHOOK /* HWINEVENTHOOK */ @hWinEventHook);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnionRect([MarshalAs(UnmanagedType.LPStruct)] ref RECT /* LPRECT */ @lprcDst, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcSrc1, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lprcSrc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnloadKeyboardLayout([MarshalAs(UnmanagedType.Struct)] HKL /* HKL */ @hkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnpackDDElParam(uint /* UINT */ @msg, long /* LPARAM */ @lParam, IntPtr /* unsigned long long *, PUINT_PTR */ @puiLo, IntPtr /* unsigned long long *, PUINT_PTR */ @puiHi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterClass([MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpClassName, [MarshalAs(UnmanagedType.Struct)] HINSTANCE /* HINSTANCE */ @hInstance);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterDeviceNotification(IntPtr /* void *, HDEVNOTIFY */ @Handle);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterHotKey([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, int @id);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterPowerSettingNotification(IntPtr /* void *, HPOWERNOTIFY */ @Handle);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnregisterTouchWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateLayeredWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdcDst, [MarshalAs(UnmanagedType.LPStruct)] ref POINT /* POINT * */ @pptDst, [MarshalAs(UnmanagedType.LPStruct)] ref SIZE /* SIZE * */ @psize, [MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hdcSrc, [MarshalAs(UnmanagedType.LPStruct)] ref POINT /* POINT * */ @pptSrc, uint /* COLORREF */ @crKey, [MarshalAs(UnmanagedType.LPStruct)] ref BLENDFUNCTION /* BLENDFUNCTION * */ @pblend, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateLayeredWindowIndirect([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref UPDATELAYEREDWINDOWINFO /* const UPDATELAYEREDWINDOWINFO * */ @pULWInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateWindow([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UserHandleGrantAccess(IntPtr /* void *, HANDLE */ @hUserHandle, IntPtr /* void *, HANDLE */ @hJob, bool @bGrant);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ValidateRect([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.LPStruct)] ref RECT /* const RECT * */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ValidateRgn([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWnd, [MarshalAs(UnmanagedType.Struct)] HRGN /* HRGN */ @hRgn);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern short /* SHORT */ VkKeyScan(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern short /* SHORT */ VkKeyScanEx(char /* WCHAR */ @ch, [MarshalAs(UnmanagedType.Struct)] HKL /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ WaitForInputIdle(IntPtr /* void *, HANDLE */ @hProcess, uint /* DWORD */ @dwMilliseconds);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitMessage();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ WindowFromDC([MarshalAs(UnmanagedType.Struct)] HDC /* HDC */ @hDC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ WindowFromPhysicalPoint([MarshalAs(UnmanagedType.Struct)] POINT /* POINT */ @Point);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ WindowFromPoint([MarshalAs(UnmanagedType.Struct)] POINT /* POINT */ @Point);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WinHelp([MarshalAs(UnmanagedType.Struct)] HWND /* HWND */ @hWndMain, [MarshalAs(UnmanagedType.LPWStr)] string /* const wchar_t *, LPCWSTR */ @lpszHelp, uint /* UINT */ @uCommand, ulong /* ULONG_PTR */ @dwData);
    }
}
