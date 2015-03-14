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
        public static extern HKL /* HKL */ ActivateKeyboardLayout(HKL /* HKL */ @hkl, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AddClipboardFormatListener(HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AdjustWindowRect(RECT /* LPRECT */ @lpRect, uint /* DWORD */ @dwStyle, bool @bMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AdjustWindowRectEx(RECT /* LPRECT */ @lpRect, uint /* DWORD */ @dwStyle, bool @bMenu, uint /* DWORD */ @dwExStyle);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AllowSetForegroundWindow(uint /* DWORD */ @dwProcessId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AnimateWindow(HWND /* HWND */ @hWnd, uint /* DWORD */ @dwTime, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AnyPopup();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AppendMenu(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uFlags, ulong /* UINT_PTR */ @uIDNewItem, IntPtr /* const wchar_t * */ @lpNewItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ ArrangeIconicWindows(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AttachThreadInput(uint /* DWORD */ @idAttach, uint /* DWORD */ @idAttachTo, bool @fAttach);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ BeginDeferWindowPos(int @nNumWindows);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDC /* HDC */ BeginPaint(HWND /* HWND */ @hWnd, PAINTSTRUCT /* LPPAINTSTRUCT */ @lpPaint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool BlockInput(bool @fBlockIt);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool BringWindowToTop(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int BroadcastSystemMessage(uint /* DWORD */ @flags, IntPtr /* unsigned long * */ @lpInfo, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int BroadcastSystemMessageEx(uint /* DWORD */ @flags, IntPtr /* unsigned long * */ @lpInfo, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam, BSMINFO /* PBSMINFO */ @pbsmInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CalculatePopupWindowPosition(POINT /* const POINT * */ @anchorPoint, SIZE /* const SIZE * */ @windowSize, uint /* UINT */ @flags, RECT /* RECT * */ @excludeRect, RECT /* RECT * */ @popupWindowPosition);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CallMsgFilter(MSG /* LPMSG */ @lpMsg, int @nCode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ CallNextHookEx(HHOOK /* HHOOK */ @hhk, int @nCode, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ CallWindowProc(IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpPrevWndFunc, HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CancelShutdown();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ CascadeWindows(HWND /* HWND */ @hwndParent, uint /* UINT */ @wHow, RECT /* const RECT * */ @lpRect, uint /* UINT */ @cKids, IntPtr /* HWND__ *const * */ @lpKids);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ChangeClipboardChain(HWND /* HWND */ @hWndRemove, HWND /* HWND */ @hWndNewNext);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ ChangeDisplaySettings(devicemodeW /* DEVMODEW * */ @lpDevMode, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ ChangeDisplaySettingsEx(IntPtr /* const wchar_t * */ @lpszDeviceName, devicemodeW /* DEVMODEW * */ @lpDevMode, HWND /* HWND */ @hwnd, uint /* DWORD */ @dwflags, IntPtr /* void * */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ChangeMenu(HMENU /* HMENU */ @hMenu, uint /* UINT */ @cmd, IntPtr /* const wchar_t * */ @lpszNewItem, uint /* UINT */ @cmdInsert, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ChangeWindowMessageFilter(uint /* UINT */ @message, uint /* DWORD */ @dwFlag);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ChangeWindowMessageFilterEx(HWND /* HWND */ @hwnd, uint /* UINT */ @message, uint /* DWORD */ @action, CHANGEFILTERSTRUCT /* PCHANGEFILTERSTRUCT */ @pChangeFilterStruct);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* wchar_t * */ CharLower(IntPtr /* wchar_t * */ @lpsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ CharLowerBuff(IntPtr /* wchar_t * */ @lpsz, uint /* DWORD */ @cchLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* wchar_t * */ CharNext(IntPtr /* const wchar_t * */ @lpsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* char * */ CharNextExA(ushort /* WORD */ @CodePage, IntPtr /* const char * */ @lpCurrentChar, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* wchar_t * */ CharPrev(IntPtr /* const wchar_t * */ @lpszStart, IntPtr /* const wchar_t * */ @lpszCurrent);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* char * */ CharPrevExA(ushort /* WORD */ @CodePage, IntPtr /* const char * */ @lpStart, IntPtr /* const char * */ @lpCurrentChar, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CharToOem(IntPtr /* const wchar_t * */ @pSrc, IntPtr /* char * */ @pDst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CharToOemBuff(IntPtr /* const wchar_t * */ @lpszSrc, IntPtr /* char * */ @lpszDst, uint /* DWORD */ @cchDstLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* wchar_t * */ CharUpper(IntPtr /* wchar_t * */ @lpsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ CharUpperBuff(IntPtr /* wchar_t * */ @lpsz, uint /* DWORD */ @cchLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CheckDlgButton(HWND /* HWND */ @hDlg, int @nIDButton, uint /* UINT */ @uCheck);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ CheckMenuItem(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uIDCheckItem, uint /* UINT */ @uCheck);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CheckMenuRadioItem(HMENU /* HMENU */ @hmenu, uint /* UINT */ @first, uint /* UINT */ @last, uint /* UINT */ @check, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CheckRadioButton(HWND /* HWND */ @hDlg, int @nIDFirstButton, int @nIDLastButton, int @nIDCheckButton);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ ChildWindowFromPoint(HWND /* HWND */ @hWndParent, POINT /* POINT */ @Point);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ ChildWindowFromPointEx(HWND /* HWND */ @hwnd, POINT /* POINT */ @pt, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ClientToScreen(HWND /* HWND */ @hWnd, POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ClipCursor(RECT /* const RECT * */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseClipboard();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseDesktop(HDESK /* HDESK */ @hDesktop);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseGestureInfoHandle(HGESTUREINFO /* HGESTUREINFO */ @hGestureInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseTouchInputHandle(HTOUCHINPUT /* HTOUCHINPUT */ @hTouchInput);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseWindow(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseWindowStation(HWINSTA /* HWINSTA */ @hWinSta);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int CopyAcceleratorTable(HACCEL /* HACCEL */ @hAccelSrc, ACCEL /* LPACCEL */ @lpAccelDst, int @cAccelEntries);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ CopyIcon(HICON /* HICON */ @hIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ CopyImage(IntPtr /* void * */ @h, uint /* UINT */ @type, int @cx, int @cy, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CopyRect(RECT /* LPRECT */ @lprcDst, RECT /* const RECT * */ @lprcSrc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int CountClipboardFormats();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HACCEL /* HACCEL */ CreateAcceleratorTable(ACCEL /* LPACCEL */ @paccel, int @cAccel);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CreateCaret(HWND /* HWND */ @hWnd, HBITMAP /* HBITMAP */ @hBitmap, int @nWidth, int @nHeight);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HCURSOR */ CreateCursor(HINSTANCE /* HINSTANCE */ @hInst, int @xHotSpot, int @yHotSpot, int @nWidth, int @nHeight, IntPtr /* const void * */ @pvANDPlane, IntPtr /* const void * */ @pvXORPlane);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDESK /* HDESK */ CreateDesktop(IntPtr /* const wchar_t * */ @lpszDesktop, IntPtr /* const wchar_t * */ @lpszDevice, devicemodeW /* DEVMODEW * */ @pDevmode, uint /* DWORD */ @dwFlags, uint /* ACCESS_MASK */ @dwDesiredAccess, SECURITY_ATTRIBUTES /* LPSECURITY_ATTRIBUTES */ @lpsa);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDESK /* HDESK */ CreateDesktopEx(IntPtr /* const wchar_t * */ @lpszDesktop, IntPtr /* const wchar_t * */ @lpszDevice, devicemodeW /* DEVMODEW * */ @pDevmode, uint /* DWORD */ @dwFlags, uint /* ACCESS_MASK */ @dwDesiredAccess, SECURITY_ATTRIBUTES /* LPSECURITY_ATTRIBUTES */ @lpsa, uint /* ULONG */ @ulHeapSize, IntPtr /* void * */ @pvoid);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ CreateDialogIndirectParam(HINSTANCE /* HINSTANCE */ @hInstance, DLGTEMPLATE /* LPCDLGTEMPLATEW */ @lpTemplate, HWND /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ CreateDialogParam(HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpTemplateName, HWND /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ CreateIcon(HINSTANCE /* HINSTANCE */ @hInstance, int @nWidth, int @nHeight, byte @cPlanes, byte @cBitsPixel, IntPtr /* const unsigned char * */ @lpbANDbits, IntPtr /* const unsigned char * */ @lpbXORbits);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ CreateIconFromResource(IntPtr /* unsigned char * */ @presbits, uint /* DWORD */ @dwResSize, bool @fIcon, uint /* DWORD */ @dwVer);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ CreateIconFromResourceEx(IntPtr /* unsigned char * */ @presbits, uint /* DWORD */ @dwResSize, bool @fIcon, uint /* DWORD */ @dwVer, int @cxDesired, int @cyDesired, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ CreateIconIndirect(ICONINFO /* PICONINFO */ @piconinfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ CreateMDIWindow(IntPtr /* const wchar_t * */ @lpClassName, IntPtr /* const wchar_t * */ @lpWindowName, uint /* DWORD */ @dwStyle, int @X, int @Y, int @nWidth, int @nHeight, HWND /* HWND */ @hWndParent, HINSTANCE /* HINSTANCE */ @hInstance, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ CreateMenu();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ CreatePopupMenu();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ CreateWindowEx(uint /* DWORD */ @dwExStyle, IntPtr /* const wchar_t * */ @lpClassName, IntPtr /* const wchar_t * */ @lpWindowName, uint /* DWORD */ @dwStyle, int @X, int @Y, int @nWidth, int @nHeight, HWND /* HWND */ @hWndParent, HMENU /* HMENU */ @hMenu, HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* void * */ @lpParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWINSTA /* HWINSTA */ CreateWindowStation(IntPtr /* const wchar_t * */ @lpwinsta, uint /* DWORD */ @dwFlags, uint /* ACCESS_MASK */ @dwDesiredAccess, SECURITY_ATTRIBUTES /* LPSECURITY_ATTRIBUTES */ @lpsa);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeAbandonTransaction(uint /* DWORD */ @idInst, HCONV /* HCONV */ @hConv, uint /* DWORD */ @idTransaction);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* unsigned char * */ DdeAccessData(HDDEDATA /* HDDEDATA */ @hData, IntPtr /* unsigned long * */ @pcbDataSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDDEDATA /* HDDEDATA */ DdeAddData(HDDEDATA /* HDDEDATA */ @hData, IntPtr /* unsigned char * */ @pSrc, uint /* DWORD */ @cb, uint /* DWORD */ @cbOff);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDDEDATA /* HDDEDATA */ DdeClientTransaction(IntPtr /* unsigned char * */ @pData, uint /* DWORD */ @cbData, HCONV /* HCONV */ @hConv, HSZ /* HSZ */ @hszItem, uint /* UINT */ @wFmt, uint /* UINT */ @wType, uint /* DWORD */ @dwTimeout, IntPtr /* unsigned long * */ @pdwResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DdeCmpStringHandles(HSZ /* HSZ */ @hsz1, HSZ /* HSZ */ @hsz2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HCONV /* HCONV */ DdeConnect(uint /* DWORD */ @idInst, HSZ /* HSZ */ @hszService, HSZ /* HSZ */ @hszTopic, CONVCONTEXT /* PCONVCONTEXT */ @pCC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HCONVLIST /* HCONVLIST */ DdeConnectList(uint /* DWORD */ @idInst, HSZ /* HSZ */ @hszService, HSZ /* HSZ */ @hszTopic, HCONVLIST /* HCONVLIST */ @hConvList, CONVCONTEXT /* PCONVCONTEXT */ @pCC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDDEDATA /* HDDEDATA */ DdeCreateDataHandle(uint /* DWORD */ @idInst, IntPtr /* unsigned char * */ @pSrc, uint /* DWORD */ @cb, uint /* DWORD */ @cbOff, HSZ /* HSZ */ @hszItem, uint /* UINT */ @wFmt, uint /* UINT */ @afCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HSZ /* HSZ */ DdeCreateStringHandle(uint /* DWORD */ @idInst, IntPtr /* const wchar_t * */ @psz, int @iCodePage);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeDisconnect(HCONV /* HCONV */ @hConv);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeDisconnectList(HCONVLIST /* HCONVLIST */ @hConvList);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeEnableCallback(uint /* DWORD */ @idInst, HCONV /* HCONV */ @hConv, uint /* UINT */ @wCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeFreeDataHandle(HDDEDATA /* HDDEDATA */ @hData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeFreeStringHandle(uint /* DWORD */ @idInst, HSZ /* HSZ */ @hsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ DdeGetData(HDDEDATA /* HDDEDATA */ @hData, IntPtr /* unsigned char * */ @pDst, uint /* DWORD */ @cbMax, uint /* DWORD */ @cbOff);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ DdeGetLastError(uint /* DWORD */ @idInst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeImpersonateClient(HCONV /* HCONV */ @hConv);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ DdeInitialize(IntPtr /* unsigned long * */ @pidInst, IntPtr /* HDDEDATA__ *(*)(unsigned int, unsigned int, HCONV__ *, HSZ__ *, HSZ__ *, HDDEDATA__ *, unsigned long long, unsigned long long) */ @pfnCallback, uint /* DWORD */ @afCmd, uint /* DWORD */ @ulRes);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeKeepStringHandle(uint /* DWORD */ @idInst, HSZ /* HSZ */ @hsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDDEDATA /* HDDEDATA */ DdeNameService(uint /* DWORD */ @idInst, HSZ /* HSZ */ @hsz1, HSZ /* HSZ */ @hsz2, uint /* UINT */ @afCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdePostAdvise(uint /* DWORD */ @idInst, HSZ /* HSZ */ @hszTopic, HSZ /* HSZ */ @hszItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ DdeQueryConvInfo(HCONV /* HCONV */ @hConv, uint /* DWORD */ @idTransaction, CONVINFO /* PCONVINFO */ @pConvInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HCONV /* HCONV */ DdeQueryNextServer(HCONVLIST /* HCONVLIST */ @hConvList, HCONV /* HCONV */ @hConvPrev);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ DdeQueryString(uint /* DWORD */ @idInst, HSZ /* HSZ */ @hsz, IntPtr /* wchar_t * */ @psz, uint /* DWORD */ @cchMax, int @iCodePage);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HCONV /* HCONV */ DdeReconnect(HCONV /* HCONV */ @hConv);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeSetQualityOfService(HWND /* HWND */ @hwndClient, SECURITY_QUALITY_OF_SERVICE /* const SECURITY_QUALITY_OF_SERVICE * */ @pqosNew, SECURITY_QUALITY_OF_SERVICE /* PSECURITY_QUALITY_OF_SERVICE */ @pqosPrev);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeSetUserHandle(HCONV /* HCONV */ @hConv, uint /* DWORD */ @id, ulong /* DWORD_PTR */ @hUser);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeUnaccessData(HDDEDATA /* HDDEDATA */ @hData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeUninitialize(uint /* DWORD */ @idInst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefDlgProc(HWND /* HWND */ @hDlg, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ DeferWindowPos(IntPtr /* void * */ @hWinPosInfo, HWND /* HWND */ @hWnd, HWND /* HWND */ @hWndInsertAfter, int @x, int @y, int @cx, int @cy, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefFrameProc(HWND /* HWND */ @hWnd, HWND /* HWND */ @hWndMDIClient, uint /* UINT */ @uMsg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefMDIChildProc(HWND /* HWND */ @hWnd, uint /* UINT */ @uMsg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefRawInputProc(IntPtr /* tagRAWINPUT ** */ @paRawInput, int /* INT */ @nInput, uint /* UINT */ @cbSizeHeader);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefWindowProc(HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DeleteMenu(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DeregisterShellHookWindow(HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyAcceleratorTable(HACCEL /* HACCEL */ @hAccel);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyCaret();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyCursor(HICON /* HCURSOR */ @hCursor);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyIcon(HICON /* HICON */ @hIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyMenu(HMENU /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyWindow(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* INT_PTR */ DialogBoxIndirectParam(HINSTANCE /* HINSTANCE */ @hInstance, DLGTEMPLATE /* LPCDLGTEMPLATEW */ @hDialogTemplate, HWND /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* INT_PTR */ DialogBoxParam(HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpTemplateName, HWND /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void DisableProcessWindowsGhosting();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DispatchMessage(MSG /* const MSG * */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ DisplayConfigGetDeviceInfo(DISPLAYCONFIG_DEVICE_INFO_HEADER @requestPacket);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ DisplayConfigSetDeviceInfo(DISPLAYCONFIG_DEVICE_INFO_HEADER @setPacket);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DlgDirList(HWND /* HWND */ @hDlg, IntPtr /* wchar_t * */ @lpPathSpec, int @nIDListBox, int @nIDStaticPath, uint /* UINT */ @uFileType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DlgDirListComboBox(HWND /* HWND */ @hDlg, IntPtr /* wchar_t * */ @lpPathSpec, int @nIDComboBox, int @nIDStaticPath, uint /* UINT */ @uFiletype);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DlgDirSelectComboBoxEx(HWND /* HWND */ @hwndDlg, IntPtr /* wchar_t * */ @lpString, int @cchOut, int @idComboBox);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DlgDirSelectEx(HWND /* HWND */ @hwndDlg, IntPtr /* wchar_t * */ @lpString, int @chCount, int @idListBox);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DragDetect(HWND /* HWND */ @hwnd, POINT /* POINT */ @pt);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ DragObject(HWND /* HWND */ @hwndParent, HWND /* HWND */ @hwndFrom, uint /* UINT */ @fmt, ulong /* ULONG_PTR */ @data, HICON /* HCURSOR */ @hcur);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawAnimatedRects(HWND /* HWND */ @hwnd, int @idAni, RECT /* const RECT * */ @lprcFrom, RECT /* const RECT * */ @lprcTo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawCaption(HWND /* HWND */ @hwnd, HDC /* HDC */ @hdc, RECT /* const RECT * */ @lprect, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawEdge(HDC /* HDC */ @hdc, RECT /* LPRECT */ @qrc, uint /* UINT */ @edge, uint /* UINT */ @grfFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawFocusRect(HDC /* HDC */ @hDC, RECT /* const RECT * */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawFrameControl(HDC /* HDC */ @, RECT /* LPRECT */ @, uint /* UINT */ @, uint /* UINT */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawIcon(HDC /* HDC */ @hDC, int @X, int @Y, HICON /* HICON */ @hIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawIconEx(HDC /* HDC */ @hdc, int @xLeft, int @yTop, HICON /* HICON */ @hIcon, int @cxWidth, int @cyWidth, uint /* UINT */ @istepIfAniCur, HBRUSH /* HBRUSH */ @hbrFlickerFreeDraw, uint /* UINT */ @diFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawMenuBar(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawState(HDC /* HDC */ @hdc, HBRUSH /* HBRUSH */ @hbrFore, IntPtr /* int (*)(HDC__ *, long long, unsigned long long, int, int) */ @qfnCallBack, long /* LPARAM */ @lData, ulong /* WPARAM */ @wData, int @x, int @y, int @cx, int @cy, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DrawText(HDC /* HDC */ @hdc, IntPtr /* const wchar_t * */ @lpchText, int @cchText, RECT /* LPRECT */ @lprc, uint /* UINT */ @format);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DrawTextEx(HDC /* HDC */ @hdc, IntPtr /* wchar_t * */ @lpchText, int @cchText, RECT /* LPRECT */ @lprc, uint /* UINT */ @format, DRAWTEXTPARAMS /* LPDRAWTEXTPARAMS */ @lpdtp);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EmptyClipboard();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnableMenuItem(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uIDEnableItem, uint /* UINT */ @uEnable);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnableScrollBar(HWND /* HWND */ @hWnd, uint /* UINT */ @wSBflags, uint /* UINT */ @wArrows);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnableWindow(HWND /* HWND */ @hWnd, bool @bEnable);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndDeferWindowPos(IntPtr /* void * */ @hWinPosInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndDialog(HWND /* HWND */ @hDlg, long /* INT_PTR */ @nResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndMenu();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndPaint(HWND /* HWND */ @hWnd, PAINTSTRUCT /* const PAINTSTRUCT * */ @lpPaint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumChildWindows(HWND /* HWND */ @hWndParent, IntPtr /* int (*)(HWND__ *, long long) */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ EnumClipboardFormats(uint /* UINT */ @format);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDesktops(HWINSTA /* HWINSTA */ @hwinsta, IntPtr /* int (*)(wchar_t *, long long) */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDesktopWindows(HDESK /* HDESK */ @hDesktop, IntPtr /* int (*)(HWND__ *, long long) */ @lpfn, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDisplayDevices(IntPtr /* const wchar_t * */ @lpDevice, uint /* DWORD */ @iDevNum, DISPLAY_DEVICEW /* PDISPLAY_DEVICEW */ @lpDisplayDevice, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDisplayMonitors(HDC /* HDC */ @hdc, RECT /* LPCRECT */ @lprcClip, IntPtr /* int (*)(HMONITOR__ *, HDC__ *, tagRECT *, long long) */ @lpfnEnum, long /* LPARAM */ @dwData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDisplaySettings(IntPtr /* const wchar_t * */ @lpszDeviceName, uint /* DWORD */ @iModeNum, devicemodeW /* DEVMODEW * */ @lpDevMode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDisplaySettingsEx(IntPtr /* const wchar_t * */ @lpszDeviceName, uint /* DWORD */ @iModeNum, devicemodeW /* DEVMODEW * */ @lpDevMode, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int EnumProps(HWND /* HWND */ @hWnd, IntPtr /* int (*)(HWND__ *, const wchar_t *, void *) */ @lpEnumFunc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int EnumPropsEx(HWND /* HWND */ @hWnd, IntPtr /* int (*)(HWND__ *, wchar_t *, void *, unsigned long long) */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumThreadWindows(uint /* DWORD */ @dwThreadId, IntPtr /* int (*)(HWND__ *, long long) */ @lpfn, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumWindows(IntPtr /* int (*)(HWND__ *, long long) */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumWindowStations(IntPtr /* int (*)(wchar_t *, long long) */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EqualRect(RECT /* const RECT * */ @lprc1, RECT /* const RECT * */ @lprc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ExcludeUpdateRgn(HDC /* HDC */ @hDC, HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ExitWindowsEx(uint /* UINT */ @uFlags, uint /* DWORD */ @dwReason);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FillRect(HDC /* HDC */ @hDC, RECT /* const RECT * */ @lprc, HBRUSH /* HBRUSH */ @hbr);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ FindWindow(IntPtr /* const wchar_t * */ @lpClassName, IntPtr /* const wchar_t * */ @lpWindowName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ FindWindowEx(HWND /* HWND */ @hWndParent, HWND /* HWND */ @hWndChildAfter, IntPtr /* const wchar_t * */ @lpszClass, IntPtr /* const wchar_t * */ @lpszWindow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool FlashWindow(HWND /* HWND */ @hWnd, bool @bInvert);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool FlashWindowEx(FLASHWINFO /* PFLASHWINFO */ @pfwi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FrameRect(HDC /* HDC */ @hDC, RECT /* const RECT * */ @lprc, HBRUSH /* HBRUSH */ @hbr);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool FreeDDElParam(uint /* UINT */ @msg, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetActiveWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetAltTabInfo(HWND /* HWND */ @hwnd, int @iItem, ALTTABINFO /* PALTTABINFO */ @pati, IntPtr /* wchar_t * */ @pszItemText, uint /* UINT */ @cchItemText);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetAncestor(HWND /* HWND */ @hwnd, uint /* UINT */ @gaFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern short /* SHORT */ GetAsyncKeyState(int @vKey);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetCapture();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetCaretBlinkTime();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetCaretPos(POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClassInfo(HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpClassName, WNDCLASSW /* LPWNDCLASSW */ @lpWndClass);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClassInfoEx(HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpszClass, WNDCLASSEXW /* LPWNDCLASSEXW */ @lpwcx);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetClassLong(HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ulong /* ULONG_PTR */ GetClassLongPtr(HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetClassName(HWND /* HWND */ @hWnd, IntPtr /* wchar_t * */ @lpClassName, int @nMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ GetClassWord(HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClientRect(HWND /* HWND */ @hWnd, RECT /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ GetClipboardData(uint /* UINT */ @uFormat);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetClipboardFormatName(uint /* UINT */ @format, IntPtr /* wchar_t * */ @lpszFormatName, int @cchMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetClipboardOwner();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetClipboardSequenceNumber();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetClipboardViewer();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClipCursor(RECT /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetComboBoxInfo(HWND /* HWND */ @hwndCombo, COMBOBOXINFO /* PCOMBOBOXINFO */ @pcbi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HCURSOR */ GetCursor();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetCursorInfo(CURSORINFO /* PCURSORINFO */ @pci);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetCursorPos(POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDC /* HDC */ GetDC(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDC /* HDC */ GetDCEx(HWND /* HWND */ @hWnd, HRGN /* HRGN */ @hrgnClip, uint /* DWORD */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetDesktopWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetDialogBaseUnits();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetDisplayConfigBufferSizes(uint /* UINT32 */ @flags, IntPtr /* unsigned int * */ @numPathArrayElements, IntPtr /* unsigned int * */ @numModeInfoArrayElements);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetDlgCtrlID(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetDlgItem(HWND /* HWND */ @hDlg, int @nIDDlgItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetDlgItemInt(HWND /* HWND */ @hDlg, int @nIDDlgItem, IntPtr /* int * */ @lpTranslated, bool @bSigned);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetDlgItemText(HWND /* HWND */ @hDlg, int @nIDDlgItem, IntPtr /* wchar_t * */ @lpString, int @cchMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetDoubleClickTime();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetFocus();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetForegroundWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetGestureConfig(HWND /* HWND */ @hwnd, uint /* DWORD */ @dwReserved, uint /* DWORD */ @dwFlags, IntPtr /* unsigned int * */ @pcIDs, GESTURECONFIG /* PGESTURECONFIG */ @pGestureConfig, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetGestureExtraArgs(HGESTUREINFO /* HGESTUREINFO */ @hGestureInfo, uint /* UINT */ @cbExtraArgs, IntPtr /* unsigned char * */ @pExtraArgs);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetGestureInfo(HGESTUREINFO /* HGESTUREINFO */ @hGestureInfo, GESTUREINFO /* PGESTUREINFO */ @pGestureInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetGuiResources(IntPtr /* void * */ @hProcess, uint /* DWORD */ @uiFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetGUIThreadInfo(uint /* DWORD */ @idThread, GUITHREADINFO /* PGUITHREADINFO */ @pgui);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetIconInfo(HICON /* HICON */ @hIcon, ICONINFO /* PICONINFO */ @piconinfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetIconInfoEx(HICON /* HICON */ @hicon, ICONINFOEXW /* PICONINFOEXW */ @piconinfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetInputState();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetKBCodePage();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HKL /* HKL */ GetKeyboardLayout(uint /* DWORD */ @idThread);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetKeyboardLayoutList(int @nBuff, IntPtr /* HKL__ ** */ @lpList);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetKeyboardLayoutName(IntPtr /* wchar_t * */ @pwszKLID);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetKeyboardState(IntPtr /* unsigned char * */ @lpKeyState);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetKeyboardType(int @nTypeFlag);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetKeyNameText(int /* LONG */ @lParam, IntPtr /* wchar_t * */ @lpString, int @cchSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern short /* SHORT */ GetKeyState(int @nVirtKey);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetLastActivePopup(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetLastInputInfo(LASTINPUTINFO /* PLASTINPUTINFO */ @plii);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetLayeredWindowAttributes(HWND /* HWND */ @hwnd, IntPtr /* unsigned long * */ @pcrKey, IntPtr /* unsigned char * */ @pbAlpha, IntPtr /* unsigned long * */ @pdwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetListBoxInfo(HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ GetMenu(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMenuBarInfo(HWND /* HWND */ @hwnd, int /* LONG */ @idObject, int /* LONG */ @idItem, MENUBARINFO /* PMENUBARINFO */ @pmbi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetMenuCheckMarkDimensions();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetMenuContextHelpId(HMENU /* HMENU */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetMenuDefaultItem(HMENU /* HMENU */ @hMenu, uint /* UINT */ @fByPos, uint /* UINT */ @gmdiFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMenuInfo(HMENU /* HMENU */ @, MENUINFO /* LPMENUINFO */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetMenuItemCount(HMENU /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetMenuItemID(HMENU /* HMENU */ @hMenu, int @nPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMenuItemInfo(HMENU /* HMENU */ @hmenu, uint /* UINT */ @item, bool @fByPosition, MENUITEMINFOW /* LPMENUITEMINFOW */ @lpmii);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMenuItemRect(HWND /* HWND */ @hWnd, HMENU /* HMENU */ @hMenu, uint /* UINT */ @uItem, RECT /* LPRECT */ @lprcItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetMenuState(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uId, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetMenuString(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uIDItem, IntPtr /* wchar_t * */ @lpString, int @cchMax, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMessage(MSG /* LPMSG */ @lpMsg, HWND /* HWND */ @hWnd, uint /* UINT */ @wMsgFilterMin, uint /* UINT */ @wMsgFilterMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ GetMessageExtraInfo();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetMessagePos();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetMessageTime();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMonitorInfo(HMONITOR /* HMONITOR */ @hMonitor, MONITORINFO /* LPMONITORINFO */ @lpmi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetMouseMovePointsEx(uint /* UINT */ @cbSize, MOUSEMOVEPOINT /* LPMOUSEMOVEPOINT */ @lppt, MOUSEMOVEPOINT /* LPMOUSEMOVEPOINT */ @lpptBuf, int @nBufPoints, uint /* DWORD */ @resolution);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetNextDlgGroupItem(HWND /* HWND */ @hDlg, HWND /* HWND */ @hCtl, bool @bPrevious);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetNextDlgTabItem(HWND /* HWND */ @hDlg, HWND /* HWND */ @hCtl, bool @bPrevious);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetOpenClipboardWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetParent(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPhysicalCursorPos(POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetPriorityClipboardFormat(IntPtr /* unsigned int * */ @paFormatPriorityList, int @cFormats);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetProcessDefaultLayout(IntPtr /* unsigned long * */ @pdwDefaultLayout);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWINSTA /* HWINSTA */ GetProcessWindowStation();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ GetProp(HWND /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetQueueStatus(uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputBuffer(RAWINPUT /* PRAWINPUT */ @pData, IntPtr /* unsigned int * */ @pcbSize, uint /* UINT */ @cbSizeHeader);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputData(HRAWINPUT /* HRAWINPUT */ @hRawInput, uint /* UINT */ @uiCommand, IntPtr /* void * */ @pData, IntPtr /* unsigned int * */ @pcbSize, uint /* UINT */ @cbSizeHeader);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputDeviceInfo(IntPtr /* void * */ @hDevice, uint /* UINT */ @uiCommand, IntPtr /* void * */ @pData, IntPtr /* unsigned int * */ @pcbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputDeviceList(RAWINPUTDEVICELIST /* PRAWINPUTDEVICELIST */ @pRawInputDeviceList, IntPtr /* unsigned int * */ @puiNumDevices, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRegisteredRawInputDevices(RAWINPUTDEVICE /* PRAWINPUTDEVICE */ @pRawInputDevices, IntPtr /* unsigned int * */ @puiNumDevices, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetScrollBarInfo(HWND /* HWND */ @hwnd, int /* LONG */ @idObject, SCROLLBARINFO /* PSCROLLBARINFO */ @psbi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetScrollInfo(HWND /* HWND */ @hwnd, int @nBar, SCROLLINFO /* LPSCROLLINFO */ @lpsi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetScrollPos(HWND /* HWND */ @hWnd, int @nBar);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetScrollRange(HWND /* HWND */ @hWnd, int @nBar, IntPtr /* int * */ @lpMinPos, IntPtr /* int * */ @lpMaxPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetShellWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ GetSubMenu(HMENU /* HMENU */ @hMenu, int @nPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetSysColor(int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HBRUSH /* HBRUSH */ GetSysColorBrush(int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ GetSystemMenu(HWND /* HWND */ @hWnd, bool @bRevert);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetSystemMetrics(int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetTabbedTextExtent(HDC /* HDC */ @hdc, IntPtr /* const wchar_t * */ @lpString, int @chCount, int @nTabPositions, IntPtr /* const int * */ @lpnTabStopPositions);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDESK /* HDESK */ GetThreadDesktop(uint /* DWORD */ @dwThreadId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetTitleBarInfo(HWND /* HWND */ @hwnd, TITLEBARINFO /* PTITLEBARINFO */ @pti);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetTopWindow(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetTouchInputInfo(HTOUCHINPUT /* HTOUCHINPUT */ @hTouchInput, uint /* UINT */ @cInputs, TOUCHINPUT /* PTOUCHINPUT */ @pInputs, int @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetUpdatedClipboardFormats(IntPtr /* unsigned int * */ @lpuiFormats, uint /* UINT */ @cFormats, IntPtr /* unsigned int * */ @pcFormatsOut);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetUpdateRect(HWND /* HWND */ @hWnd, RECT /* LPRECT */ @lpRect, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetUpdateRgn(HWND /* HWND */ @hWnd, HRGN /* HRGN */ @hRgn, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetUserObjectInformation(IntPtr /* void * */ @hObj, int @nIndex, IntPtr /* void * */ @pvInfo, uint /* DWORD */ @nLength, IntPtr /* unsigned long * */ @lpnLengthNeeded);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetUserObjectSecurity(IntPtr /* void * */ @hObj, IntPtr /* unsigned long * */ @pSIRequested, IntPtr /* void * */ @pSID, uint /* DWORD */ @nLength, IntPtr /* unsigned long * */ @lpnLengthNeeded);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ GetWindow(HWND /* HWND */ @hWnd, uint /* UINT */ @uCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetWindowContextHelpId(HWND /* HWND */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDC /* HDC */ GetWindowDC(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowDisplayAffinity(HWND /* HWND */ @hWnd, IntPtr /* unsigned long * */ @pdwAffinity);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowInfo(HWND /* HWND */ @hwnd, WINDOWINFO /* PWINDOWINFO */ @pwi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetWindowLong(HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LONG_PTR */ GetWindowLongPtr(HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetWindowModuleFileName(HWND /* HWND */ @hwnd, IntPtr /* wchar_t * */ @pszFileName, uint /* UINT */ @cchFileNameMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowPlacement(HWND /* HWND */ @hWnd, WINDOWPLACEMENT /* WINDOWPLACEMENT * */ @lpwndpl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowRect(HWND /* HWND */ @hWnd, RECT /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowRgn(HWND /* HWND */ @hWnd, HRGN /* HRGN */ @hRgn);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowRgnBox(HWND /* HWND */ @hWnd, RECT /* LPRECT */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(HWND /* HWND */ @hWnd, IntPtr /* wchar_t * */ @lpString, int @nMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowTextLength(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetWindowThreadProcessId(HWND /* HWND */ @hWnd, IntPtr /* unsigned long * */ @lpdwProcessId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ GetWindowWord(HWND /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GrayString(HDC /* HDC */ @hDC, HBRUSH /* HBRUSH */ @hBrush, IntPtr /* int (*)(HDC__ *, long long, int) */ @lpOutputFunc, long /* LPARAM */ @lpData, int @nCount, int @X, int @Y, int @nWidth, int @nHeight);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool HideCaret(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool HiliteMenuItem(HWND /* HWND */ @hWnd, HMENU /* HMENU */ @hMenu, uint /* UINT */ @uIDHiliteItem, uint /* UINT */ @uHilite);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ImpersonateDdeClientWindow(HWND /* HWND */ @hWndClient, HWND /* HWND */ @hWndServer);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InflateRect(RECT /* LPRECT */ @lprc, int @dx, int @dy);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InSendMessage();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ InSendMessageEx(IntPtr /* void * */ @lpReserved);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InsertMenu(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags, ulong /* UINT_PTR */ @uIDNewItem, IntPtr /* const wchar_t * */ @lpNewItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InsertMenuItem(HMENU /* HMENU */ @hmenu, uint /* UINT */ @item, bool @fByPosition, MENUITEMINFOW /* LPCMENUITEMINFOW */ @lpmi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int InternalGetWindowText(HWND /* HWND */ @hWnd, IntPtr /* wchar_t * */ @pString, int @cchMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IntersectRect(RECT /* LPRECT */ @lprcDst, RECT /* const RECT * */ @lprcSrc1, RECT /* const RECT * */ @lprcSrc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InvalidateRect(HWND /* HWND */ @hWnd, RECT /* const RECT * */ @lpRect, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InvalidateRgn(HWND /* HWND */ @hWnd, HRGN /* HRGN */ @hRgn, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InvertRect(HDC /* HDC */ @hDC, RECT /* const RECT * */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool IsCharAlpha(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool IsCharAlphaNumeric(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool IsCharLower(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool IsCharUpper(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsChild(HWND /* HWND */ @hWndParent, HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsClipboardFormatAvailable(uint /* UINT */ @format);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsDialogMessage(HWND /* HWND */ @hDlg, MSG /* LPMSG */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ IsDlgButtonChecked(HWND /* HWND */ @hDlg, int @nIDButton);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsGUIThread(bool @bConvert);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsHungAppWindow(HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsIconic(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsMenu(HMENU /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsProcessDPIAware();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsRectEmpty(RECT /* const RECT * */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsTouchWindow(HWND /* HWND */ @hwnd, IntPtr /* unsigned long * */ @pulFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindow(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindowEnabled(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindowUnicode(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindowVisible(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWinEventHookInstalled(uint /* DWORD */ @event);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWow64Message();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsZoomed(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void keybd_event(byte @bVk, byte @bScan, uint /* DWORD */ @dwFlags, ulong /* ULONG_PTR */ @dwExtraInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool KillTimer(HWND /* HWND */ @hWnd, ulong /* UINT_PTR */ @uIDEvent);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HACCEL /* HACCEL */ LoadAccelerators(HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpTableName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HBITMAP /* HBITMAP */ LoadBitmap(HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpBitmapName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HCURSOR */ LoadCursor(HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpCursorName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HCURSOR */ LoadCursorFromFile(IntPtr /* const wchar_t * */ @lpFileName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HICON */ LoadIcon(HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpIconName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ LoadImage(HINSTANCE /* HINSTANCE */ @hInst, IntPtr /* const wchar_t * */ @name, uint /* UINT */ @type, int @cx, int @cy, uint /* UINT */ @fuLoad);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HKL /* HKL */ LoadKeyboardLayout(IntPtr /* const wchar_t * */ @pwszKLID, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ LoadMenu(HINSTANCE /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpMenuName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMENU /* HMENU */ LoadMenuIndirect(IntPtr /* const void * */ @lpMenuTemplate);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LoadString(HINSTANCE /* HINSTANCE */ @hInstance, uint /* UINT */ @uID, IntPtr /* wchar_t * */ @lpBuffer, int @cchBufferMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool LockSetForegroundWindow(uint /* UINT */ @uLockCode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool LockWindowUpdate(HWND /* HWND */ @hWndLock);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool LockWorkStation();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool LogicalToPhysicalPoint(HWND /* HWND */ @hWnd, POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LookupIconIdFromDirectory(IntPtr /* unsigned char * */ @presbits, bool @fIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LookupIconIdFromDirectoryEx(IntPtr /* unsigned char * */ @presbits, bool @fIcon, int @cxDesired, int @cyDesired, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool MapDialogRect(HWND /* HWND */ @hDlg, RECT /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ MapVirtualKey(uint /* UINT */ @uCode, uint /* UINT */ @uMapType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ MapVirtualKeyEx(uint /* UINT */ @uCode, uint /* UINT */ @uMapType, HKL /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MapWindowPoints(HWND /* HWND */ @hWndFrom, HWND /* HWND */ @hWndTo, POINT /* LPPOINT */ @lpPoints, uint /* UINT */ @cPoints);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MenuItemFromPoint(HWND /* HWND */ @hWnd, HMENU /* HMENU */ @hMenu, POINT /* POINT */ @ptScreen);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool MessageBeep(uint /* UINT */ @uType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MessageBox(HWND /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpText, IntPtr /* const wchar_t * */ @lpCaption, uint /* UINT */ @uType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MessageBoxEx(HWND /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpText, IntPtr /* const wchar_t * */ @lpCaption, uint /* UINT */ @uType, ushort /* WORD */ @wLanguageId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MessageBoxIndirect(MSGBOXPARAMSW /* const MSGBOXPARAMSW * */ @lpmbp);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ModifyMenu(HMENU /* HMENU */ @hMnu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags, ulong /* UINT_PTR */ @uIDNewItem, IntPtr /* const wchar_t * */ @lpNewItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMONITOR /* HMONITOR */ MonitorFromPoint(POINT /* POINT */ @pt, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMONITOR /* HMONITOR */ MonitorFromRect(RECT /* LPCRECT */ @lprc, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HMONITOR /* HMONITOR */ MonitorFromWindow(HWND /* HWND */ @hwnd, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void mouse_event(uint /* DWORD */ @dwFlags, uint /* DWORD */ @dx, uint /* DWORD */ @dy, uint /* DWORD */ @dwData, ulong /* ULONG_PTR */ @dwExtraInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool MoveWindow(HWND /* HWND */ @hWnd, int @X, int @Y, int @nWidth, int @nHeight, bool @bRepaint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ MsgWaitForMultipleObjects(uint /* DWORD */ @nCount, IntPtr /* void *const * */ @pHandles, bool @fWaitAll, uint /* DWORD */ @dwMilliseconds, uint /* DWORD */ @dwWakeMask);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ MsgWaitForMultipleObjectsEx(uint /* DWORD */ @nCount, IntPtr /* void *const * */ @pHandles, uint /* DWORD */ @dwMilliseconds, uint /* DWORD */ @dwWakeMask, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void NotifyWinEvent(uint /* DWORD */ @event, HWND /* HWND */ @hwnd, int /* LONG */ @idObject, int /* LONG */ @idChild);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ OemKeyScan(ushort /* WORD */ @wOemChar);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OemToChar(IntPtr /* const char * */ @pSrc, IntPtr /* wchar_t * */ @pDst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OemToCharBuff(IntPtr /* const char * */ @lpszSrc, IntPtr /* wchar_t * */ @lpszDst, uint /* DWORD */ @cchDstLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OffsetRect(RECT /* LPRECT */ @lprc, int @dx, int @dy);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OpenClipboard(HWND /* HWND */ @hWndNewOwner);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDESK /* HDESK */ OpenDesktop(IntPtr /* const wchar_t * */ @lpszDesktop, uint /* DWORD */ @dwFlags, bool @fInherit, uint /* ACCESS_MASK */ @dwDesiredAccess);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OpenIcon(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HDESK /* HDESK */ OpenInputDesktop(uint /* DWORD */ @dwFlags, bool @fInherit, uint /* ACCESS_MASK */ @dwDesiredAccess);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWINSTA /* HWINSTA */ OpenWindowStation(IntPtr /* const wchar_t * */ @lpszWinSta, bool @fInherit, uint /* ACCESS_MASK */ @dwDesiredAccess);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ PackDDElParam(uint /* UINT */ @msg, ulong /* UINT_PTR */ @uiLo, ulong /* UINT_PTR */ @uiHi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PaintDesktop(HDC /* HDC */ @hdc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PeekMessage(MSG /* LPMSG */ @lpMsg, HWND /* HWND */ @hWnd, uint /* UINT */ @wMsgFilterMin, uint /* UINT */ @wMsgFilterMax, uint /* UINT */ @wRemoveMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PhysicalToLogicalPoint(HWND /* HWND */ @hWnd, POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostMessage(HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void PostQuitMessage(int @nExitCode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostThreadMessage(uint /* DWORD */ @idThread, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PrintWindow(HWND /* HWND */ @hwnd, HDC /* HDC */ @hdcBlt, uint /* UINT */ @nFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ PrivateExtractIcons(IntPtr /* const wchar_t * */ @szFileName, int @nIconIndex, int @cxIcon, int @cyIcon, IntPtr /* HICON__ ** */ @phicon, IntPtr /* unsigned int * */ @piconid, uint /* UINT */ @nIcons, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PtInRect(RECT /* const RECT * */ @lprc, POINT /* POINT */ @pt);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ QueryDisplayConfig(uint /* UINT32 */ @flags, IntPtr /* unsigned int * */ @numPathArrayElements, DISPLAYCONFIG_PATH_INFO @pathArray, IntPtr /* unsigned int * */ @numModeInfoArrayElements, DISPLAYCONFIG_MODE_INFO @modeInfoArray, IntPtr /* DISPLAYCONFIG_TOPOLOGY_ID * */ @currentTopologyId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ RealChildWindowFromPoint(HWND /* HWND */ @hwndParent, POINT /* POINT */ @ptParentClientCoords);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ RealGetWindowClass(HWND /* HWND */ @hwnd, IntPtr /* wchar_t * */ @ptszClassName, uint /* UINT */ @cchClassNameMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RedrawWindow(HWND /* HWND */ @hWnd, RECT /* const RECT * */ @lprcUpdate, HRGN /* HRGN */ @hrgnUpdate, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* ATOM */ RegisterClass(WNDCLASSW /* const WNDCLASSW * */ @lpWndClass);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* ATOM */ RegisterClassEx(WNDCLASSEXW /* const WNDCLASSEXW * */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ RegisterClipboardFormat(IntPtr /* const wchar_t * */ @lpszFormat);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ RegisterDeviceNotification(IntPtr /* void * */ @hRecipient, IntPtr /* void * */ @NotificationFilter, uint /* DWORD */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterHotKey(HWND /* HWND */ @hWnd, int @id, uint /* UINT */ @fsModifiers, uint /* UINT */ @vk);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ RegisterPowerSettingNotification(IntPtr /* void * */ @hRecipient, GUID /* LPCGUID */ @PowerSettingGuid, uint /* DWORD */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterRawInputDevices(RAWINPUTDEVICE /* PCRAWINPUTDEVICE */ @pRawInputDevices, uint /* UINT */ @uiNumDevices, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterShellHookWindow(HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterTouchWindow(HWND /* HWND */ @hwnd, uint /* ULONG */ @ulFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ RegisterWindowMessage(IntPtr /* const wchar_t * */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ReleaseCapture();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ReleaseDC(HWND /* HWND */ @hWnd, HDC /* HDC */ @hDC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RemoveClipboardFormatListener(HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RemoveMenu(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ RemoveProp(HWND /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ReplyMessage(long /* LRESULT */ @lResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ ReuseDDElParam(long /* LPARAM */ @lParam, uint /* UINT */ @msgIn, uint /* UINT */ @msgOut, ulong /* UINT_PTR */ @uiLo, ulong /* UINT_PTR */ @uiHi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ScreenToClient(HWND /* HWND */ @hWnd, POINT /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ScrollDC(HDC /* HDC */ @hDC, int @dx, int @dy, RECT /* const RECT * */ @lprcScroll, RECT /* const RECT * */ @lprcClip, HRGN /* HRGN */ @hrgnUpdate, RECT /* LPRECT */ @lprcUpdate);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ScrollWindow(HWND /* HWND */ @hWnd, int @XAmount, int @YAmount, RECT /* const RECT * */ @lpRect, RECT /* const RECT * */ @lpClipRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ScrollWindowEx(HWND /* HWND */ @hWnd, int @dx, int @dy, RECT /* const RECT * */ @prcScroll, RECT /* const RECT * */ @prcClip, HRGN /* HRGN */ @hrgnUpdate, RECT /* LPRECT */ @prcUpdate, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ SendDlgItemMessage(HWND /* HWND */ @hDlg, int @nIDDlgItem, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ SendInput(uint /* UINT */ @cInputs, INPUT /* LPINPUT */ @pInputs, int @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ SendMessage(HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SendMessageCallback(HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam, IntPtr /* void (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpResultCallBack, ulong /* ULONG_PTR */ @dwData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ SendMessageTimeout(HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam, uint /* UINT */ @fuFlags, uint /* UINT */ @uTimeout, IntPtr /* unsigned long long * */ @lpdwResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SendNotifyMessage(HWND /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ SetActiveWindow(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ SetCapture(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetCaretBlinkTime(uint /* UINT */ @uMSeconds);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetCaretPos(int @X, int @Y);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ SetClassLong(HWND /* HWND */ @hWnd, int @nIndex, int /* LONG */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ulong /* ULONG_PTR */ SetClassLongPtr(HWND /* HWND */ @hWnd, int @nIndex, long /* LONG_PTR */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ SetClassWord(HWND /* HWND */ @hWnd, int @nIndex, ushort /* WORD */ @wNewWord);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ SetClipboardData(uint /* UINT */ @uFormat, IntPtr /* void * */ @hMem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ SetClipboardViewer(HWND /* HWND */ @hWndNewViewer);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HICON /* HCURSOR */ SetCursor(HICON /* HCURSOR */ @hCursor);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetCursorPos(int @X, int @Y);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SetDebugErrorLevel(uint /* DWORD */ @dwLevel);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ SetDisplayConfig(uint /* UINT32 */ @numPathArrayElements, DISPLAYCONFIG_PATH_INFO @pathArray, uint /* UINT32 */ @numModeInfoArrayElements, DISPLAYCONFIG_MODE_INFO @modeInfoArray, uint /* UINT32 */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDlgItemInt(HWND /* HWND */ @hDlg, int @nIDDlgItem, uint /* UINT */ @uValue, bool @bSigned);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDlgItemText(HWND /* HWND */ @hDlg, int @nIDDlgItem, IntPtr /* const wchar_t * */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDoubleClickTime(uint /* UINT */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ SetFocus(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetGestureConfig(HWND /* HWND */ @hwnd, uint /* DWORD */ @dwReserved, uint /* UINT */ @cIDs, GESTURECONFIG /* PGESTURECONFIG */ @pGestureConfig, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetKeyboardState(IntPtr /* unsigned char * */ @lpKeyState);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SetLastErrorEx(uint /* DWORD */ @dwErrCode, uint /* DWORD */ @dwType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetLayeredWindowAttributes(HWND /* HWND */ @hwnd, uint /* COLORREF */ @crKey, byte @bAlpha, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenu(HWND /* HWND */ @hWnd, HMENU /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenuContextHelpId(HMENU /* HMENU */ @, uint /* DWORD */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenuDefaultItem(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uItem, uint /* UINT */ @fByPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenuInfo(HMENU /* HMENU */ @, MENUINFO /* LPCMENUINFO */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenuItemBitmaps(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags, HBITMAP /* HBITMAP */ @hBitmapUnchecked, HBITMAP /* HBITMAP */ @hBitmapChecked);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenuItemInfo(HMENU /* HMENU */ @hmenu, uint /* UINT */ @item, bool @fByPositon, MENUITEMINFOW /* LPCMENUITEMINFOW */ @lpmii);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ SetMessageExtraInfo(long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMessageQueue(int @cMessagesMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ SetParent(HWND /* HWND */ @hWndChild, HWND /* HWND */ @hWndNewParent);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetPhysicalCursorPos(int @X, int @Y);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetProcessDefaultLayout(uint /* DWORD */ @dwDefaultLayout);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetProcessDPIAware();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetProcessWindowStation(HWINSTA /* HWINSTA */ @hWinSta);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetProp(HWND /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpString, IntPtr /* void * */ @hData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetRect(RECT /* LPRECT */ @lprc, int @xLeft, int @yTop, int @xRight, int @yBottom);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetRectEmpty(RECT /* LPRECT */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetScrollInfo(HWND /* HWND */ @hwnd, int @nBar, SCROLLINFO /* LPCSCROLLINFO */ @lpsi, bool @redraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetScrollPos(HWND /* HWND */ @hWnd, int @nBar, int @nPos, bool @bRedraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetScrollRange(HWND /* HWND */ @hWnd, int @nBar, int @nMinPos, int @nMaxPos, bool @bRedraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetSysColors(int @cElements, IntPtr /* const int * */ @lpaElements, IntPtr /* const unsigned long * */ @lpaRgbValues);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetSystemCursor(HICON /* HCURSOR */ @hcur, uint /* DWORD */ @id);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetThreadDesktop(HDESK /* HDESK */ @hDesktop);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ulong /* UINT_PTR */ SetTimer(HWND /* HWND */ @hWnd, ulong /* UINT_PTR */ @nIDEvent, uint /* UINT */ @uElapse, IntPtr /* void (*)(HWND__ *, unsigned int, unsigned long long, unsigned long) */ @lpTimerFunc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetUserObjectInformation(IntPtr /* void * */ @hObj, int @nIndex, IntPtr /* void * */ @pvInfo, uint /* DWORD */ @nLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetUserObjectSecurity(IntPtr /* void * */ @hObj, IntPtr /* unsigned long * */ @pSIRequested, IntPtr /* void * */ @pSID);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowContextHelpId(HWND /* HWND */ @, uint /* DWORD */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowDisplayAffinity(HWND /* HWND */ @hWnd, uint /* DWORD */ @dwAffinity);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ SetWindowLong(HWND /* HWND */ @hWnd, int @nIndex, int /* LONG */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LONG_PTR */ SetWindowLongPtr(HWND /* HWND */ @hWnd, int @nIndex, long /* LONG_PTR */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowPlacement(HWND /* HWND */ @hWnd, WINDOWPLACEMENT /* const WINDOWPLACEMENT * */ @lpwndpl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowPos(HWND /* HWND */ @hWnd, HWND /* HWND */ @hWndInsertAfter, int @X, int @Y, int @cx, int @cy, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetWindowRgn(HWND /* HWND */ @hWnd, HRGN /* HRGN */ @hRgn, bool @bRedraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HHOOK /* HHOOK */ SetWindowsHook(int @nFilterType, IntPtr /* long long (*)(int, unsigned long long, long long) */ @pfnFilterProc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HHOOK /* HHOOK */ SetWindowsHookEx(int @idHook, IntPtr /* long long (*)(int, unsigned long long, long long) */ @lpfn, HINSTANCE /* HINSTANCE */ @hmod, uint /* DWORD */ @dwThreadId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowText(HWND /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ SetWindowWord(HWND /* HWND */ @hWnd, int @nIndex, ushort /* WORD */ @wNewWord);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWINEVENTHOOK /* HWINEVENTHOOK */ SetWinEventHook(uint /* DWORD */ @eventMin, uint /* DWORD */ @eventMax, HINSTANCE /* HMODULE */ @hmodWinEventProc, IntPtr /* void (*)(HWINEVENTHOOK__ *, unsigned long, HWND__ *, long, long, unsigned long, unsigned long) */ @pfnWinEventProc, uint /* DWORD */ @idProcess, uint /* DWORD */ @idThread, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowCaret(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ShowCursor(bool @bShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowOwnedPopups(HWND /* HWND */ @hWnd, bool @fShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowScrollBar(HWND /* HWND */ @hWnd, int @wBar, bool @bShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowWindow(HWND /* HWND */ @hWnd, int @nCmdShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowWindowAsync(HWND /* HWND */ @hWnd, int @nCmdShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShutdownBlockReasonCreate(HWND /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @pwszReason);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShutdownBlockReasonDestroy(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShutdownBlockReasonQuery(HWND /* HWND */ @hWnd, IntPtr /* wchar_t * */ @pwszBuff, IntPtr /* unsigned long * */ @pcchBuff);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SoundSentry();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SubtractRect(RECT /* LPRECT */ @lprcDst, RECT /* const RECT * */ @lprcSrc1, RECT /* const RECT * */ @lprcSrc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SwapMouseButton(bool @fSwap);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SwitchDesktop(HDESK /* HDESK */ @hDesktop);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SwitchToThisWindow(HWND /* HWND */ @hwnd, bool @fUnknown);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SystemParametersInfo(uint /* UINT */ @uiAction, uint /* UINT */ @uiParam, IntPtr /* void * */ @pvParam, uint /* UINT */ @fWinIni);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ TabbedTextOut(HDC /* HDC */ @hdc, int @x, int @y, IntPtr /* const wchar_t * */ @lpString, int @chCount, int @nTabPositions, IntPtr /* const int * */ @lpnTabStopPositions, int @nTabOrigin);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ TileWindows(HWND /* HWND */ @hwndParent, uint /* UINT */ @wHow, RECT /* const RECT * */ @lpRect, uint /* UINT */ @cKids, IntPtr /* HWND__ *const * */ @lpKids);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToAscii(uint /* UINT */ @uVirtKey, uint /* UINT */ @uScanCode, IntPtr /* const unsigned char * */ @lpKeyState, IntPtr /* unsigned short * */ @lpChar, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToAsciiEx(uint /* UINT */ @uVirtKey, uint /* UINT */ @uScanCode, IntPtr /* const unsigned char * */ @lpKeyState, IntPtr /* unsigned short * */ @lpChar, uint /* UINT */ @uFlags, HKL /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToUnicode(uint /* UINT */ @wVirtKey, uint /* UINT */ @wScanCode, IntPtr /* const unsigned char * */ @lpKeyState, IntPtr /* wchar_t * */ @pwszBuff, int @cchBuff, uint /* UINT */ @wFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToUnicodeEx(uint /* UINT */ @wVirtKey, uint /* UINT */ @wScanCode, IntPtr /* const unsigned char * */ @lpKeyState, IntPtr /* wchar_t * */ @pwszBuff, int @cchBuff, uint /* UINT */ @wFlags, HKL /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TrackMouseEvent(TRACKMOUSEEVENT /* LPTRACKMOUSEEVENT */ @lpEventTrack);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TrackPopupMenu(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uFlags, int @x, int @y, int @nReserved, HWND /* HWND */ @hWnd, RECT /* const RECT * */ @prcRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TrackPopupMenuEx(HMENU /* HMENU */ @hMenu, uint /* UINT */ @uFlags, int @x, int @y, HWND /* HWND */ @hwnd, TPMPARAMS /* LPTPMPARAMS */ @lptpm);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int TranslateAccelerator(HWND /* HWND */ @hWnd, HACCEL /* HACCEL */ @hAccTable, MSG /* LPMSG */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TranslateMDISysAccel(HWND /* HWND */ @hWndClient, MSG /* LPMSG */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TranslateMessage(MSG /* const MSG * */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnhookWindowsHook(int @nCode, IntPtr /* long long (*)(int, unsigned long long, long long) */ @pfnFilterProc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnhookWindowsHookEx(HHOOK /* HHOOK */ @hhk);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnhookWinEvent(HWINEVENTHOOK /* HWINEVENTHOOK */ @hWinEventHook);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnionRect(RECT /* LPRECT */ @lprcDst, RECT /* const RECT * */ @lprcSrc1, RECT /* const RECT * */ @lprcSrc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnloadKeyboardLayout(HKL /* HKL */ @hkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnpackDDElParam(uint /* UINT */ @msg, long /* LPARAM */ @lParam, IntPtr /* unsigned long long * */ @puiLo, IntPtr /* unsigned long long * */ @puiHi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterClass(IntPtr /* const wchar_t * */ @lpClassName, HINSTANCE /* HINSTANCE */ @hInstance);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterDeviceNotification(IntPtr /* void * */ @Handle);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterHotKey(HWND /* HWND */ @hWnd, int @id);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterPowerSettingNotification(IntPtr /* void * */ @Handle);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterTouchWindow(HWND /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UpdateLayeredWindow(HWND /* HWND */ @hWnd, HDC /* HDC */ @hdcDst, POINT /* POINT * */ @pptDst, SIZE /* SIZE * */ @psize, HDC /* HDC */ @hdcSrc, POINT /* POINT * */ @pptSrc, uint /* COLORREF */ @crKey, BLENDFUNCTION /* BLENDFUNCTION * */ @pblend, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UpdateLayeredWindowIndirect(HWND /* HWND */ @hWnd, UPDATELAYEREDWINDOWINFO /* const UPDATELAYEREDWINDOWINFO * */ @pULWInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UpdateWindow(HWND /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UserHandleGrantAccess(IntPtr /* void * */ @hUserHandle, IntPtr /* void * */ @hJob, bool @bGrant);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ValidateRect(HWND /* HWND */ @hWnd, RECT /* const RECT * */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ValidateRgn(HWND /* HWND */ @hWnd, HRGN /* HRGN */ @hRgn);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern short /* SHORT */ VkKeyScan(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern short /* SHORT */ VkKeyScanEx(char /* WCHAR */ @ch, HKL /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ WaitForInputIdle(IntPtr /* void * */ @hProcess, uint /* DWORD */ @dwMilliseconds);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool WaitMessage();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ WindowFromDC(HDC /* HDC */ @hDC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ WindowFromPhysicalPoint(POINT /* POINT */ @Point);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern HWND /* HWND */ WindowFromPoint(POINT /* POINT */ @Point);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool WinHelp(HWND /* HWND */ @hWndMain, IntPtr /* const wchar_t * */ @lpszHelp, uint /* UINT */ @uCommand, ulong /* ULONG_PTR */ @dwData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int wsprintf(IntPtr /* wchar_t * */ @, IntPtr /* const wchar_t * */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int wvsprintf(IntPtr /* wchar_t * */ @, IntPtr /* const wchar_t * */ @, IntPtr /* char * */ @arglist);
    }
}
