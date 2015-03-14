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
        public static extern Hkl /* HKL */ ActivateKeyboardLayout(Hkl /* HKL */ @hkl, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AddClipboardFormatListener(IntPtr /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AdjustWindowRect(Rect /* LPRECT */ @lpRect, uint /* DWORD */ @dwStyle, bool @bMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AdjustWindowRectEx(Rect /* LPRECT */ @lpRect, uint /* DWORD */ @dwStyle, bool @bMenu, uint /* DWORD */ @dwExStyle);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AllowSetForegroundWindow(uint /* DWORD */ @dwProcessId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AnimateWindow(IntPtr /* HWND */ @hWnd, uint /* DWORD */ @dwTime, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AnyPopup();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AppendMenu(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uFlags, ulong /* UINT_PTR */ @uIDNewItem, IntPtr /* const wchar_t * */ @lpNewItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ ArrangeIconicWindows(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool AttachThreadInput(uint /* DWORD */ @idAttach, uint /* DWORD */ @idAttachTo, bool @fAttach);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ BeginDeferWindowPos(int @nNumWindows);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hdc /* HDC */ BeginPaint(IntPtr /* HWND */ @hWnd, Paintstruct /* LPPAINTSTRUCT */ @lpPaint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool BlockInput(bool @fBlockIt);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool BringWindowToTop(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int BroadcastSystemMessage(uint /* DWORD */ @flags, IntPtr /* unsigned long * */ @lpInfo, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int BroadcastSystemMessageEx(uint /* DWORD */ @flags, IntPtr /* unsigned long * */ @lpInfo, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam, Bsminfo /* PBSMINFO */ @pbsmInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CalculatePopupWindowPosition(Point /* const POINT * */ @anchorPoint, Size /* const SIZE * */ @windowSize, uint /* UINT */ @flags, Rect /* RECT * */ @excludeRect, Rect /* RECT * */ @popupWindowPosition);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CallMsgFilter(Msg /* LPMSG */ @lpMsg, int @nCode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ CallNextHookEx(Hhook /* HHOOK */ @hhk, int @nCode, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ CallWindowProc(IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpPrevWndFunc, IntPtr /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CancelShutdown();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ CascadeWindows(IntPtr /* HWND */ @hwndParent, uint /* UINT */ @wHow, Rect /* const RECT * */ @lpRect, uint /* UINT */ @cKids, IntPtr /* HWND__ *const * */ @lpKids);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ChangeClipboardChain(IntPtr /* HWND */ @hWndRemove, IntPtr /* HWND */ @hWndNewNext);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ ChangeDisplaySettings(devicemodeW /* DEVMODEW * */ @lpDevMode, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ ChangeDisplaySettingsEx(IntPtr /* const wchar_t * */ @lpszDeviceName, devicemodeW /* DEVMODEW * */ @lpDevMode, IntPtr /* HWND */ @hwnd, uint /* DWORD */ @dwflags, IntPtr /* void * */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ChangeMenu(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @cmd, IntPtr /* const wchar_t * */ @lpszNewItem, uint /* UINT */ @cmdInsert, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ChangeWindowMessageFilter(uint /* UINT */ @message, uint /* DWORD */ @dwFlag);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ChangeWindowMessageFilterEx(IntPtr /* HWND */ @hwnd, uint /* UINT */ @message, uint /* DWORD */ @action, Changefilterstruct /* PCHANGEFILTERSTRUCT */ @pChangeFilterStruct);
    
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
        public static extern bool CheckDlgButton(IntPtr /* HWND */ @hDlg, int @nIDButton, uint /* UINT */ @uCheck);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ CheckMenuItem(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uIDCheckItem, uint /* UINT */ @uCheck);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CheckMenuRadioItem(Hmenu /* HMENU */ @hmenu, uint /* UINT */ @first, uint /* UINT */ @last, uint /* UINT */ @check, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CheckRadioButton(IntPtr /* HWND */ @hDlg, int @nIDFirstButton, int @nIDLastButton, int @nIDCheckButton);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ ChildWindowFromPoint(IntPtr /* HWND */ @hWndParent, Point /* POINT */ @Point);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ ChildWindowFromPointEx(IntPtr /* HWND */ @hwnd, Point /* POINT */ @pt, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ClientToScreen(IntPtr /* HWND */ @hWnd, Point /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ClipCursor(Rect /* const RECT * */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseClipboard();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseDesktop(Hdesk /* HDESK */ @hDesktop);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseGestureInfoHandle(Hgestureinfo /* HGESTUREINFO */ @hGestureInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseTouchInputHandle(Htouchinput /* HTOUCHINPUT */ @hTouchInput);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseWindow(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CloseWindowStation(Hwinsta /* HWINSTA */ @hWinSta);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int CopyAcceleratorTable(Haccel /* HACCEL */ @hAccelSrc, Accel /* LPACCEL */ @lpAccelDst, int @cAccelEntries);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HICON */ CopyIcon(Hicon /* HICON */ @hIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ CopyImage(IntPtr /* void * */ @h, uint /* UINT */ @type, int @cx, int @cy, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CopyRect(Rect /* LPRECT */ @lprcDst, Rect /* const RECT * */ @lprcSrc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int CountClipboardFormats();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Haccel /* HACCEL */ CreateAcceleratorTable(Accel /* LPACCEL */ @paccel, int @cAccel);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool CreateCaret(IntPtr /* HWND */ @hWnd, Hbitmap /* HBITMAP */ @hBitmap, int @nWidth, int @nHeight);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HCURSOR */ CreateCursor(Hinstance /* HINSTANCE */ @hInst, int @xHotSpot, int @yHotSpot, int @nWidth, int @nHeight, IntPtr /* const void * */ @pvANDPlane, IntPtr /* const void * */ @pvXORPlane);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hdesk /* HDESK */ CreateDesktop(IntPtr /* const wchar_t * */ @lpszDesktop, IntPtr /* const wchar_t * */ @lpszDevice, devicemodeW /* DEVMODEW * */ @pDevmode, uint /* DWORD */ @dwFlags, uint /* ACCESS_MASK */ @dwDesiredAccess, SecurityAttributes /* LPSECURITY_ATTRIBUTES */ @lpsa);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hdesk /* HDESK */ CreateDesktopEx(IntPtr /* const wchar_t * */ @lpszDesktop, IntPtr /* const wchar_t * */ @lpszDevice, devicemodeW /* DEVMODEW * */ @pDevmode, uint /* DWORD */ @dwFlags, uint /* ACCESS_MASK */ @dwDesiredAccess, SecurityAttributes /* LPSECURITY_ATTRIBUTES */ @lpsa, uint /* ULONG */ @ulHeapSize, IntPtr /* void * */ @pvoid);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ CreateDialogIndirectParam(Hinstance /* HINSTANCE */ @hInstance, Dlgtemplate /* LPCDLGTEMPLATEW */ @lpTemplate, IntPtr /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ CreateDialogParam(Hinstance /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpTemplateName, IntPtr /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HICON */ CreateIcon(Hinstance /* HINSTANCE */ @hInstance, int @nWidth, int @nHeight, byte @cPlanes, byte @cBitsPixel, IntPtr /* const unsigned char * */ @lpbANDbits, IntPtr /* const unsigned char * */ @lpbXORbits);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HICON */ CreateIconFromResource(IntPtr /* unsigned char * */ @presbits, uint /* DWORD */ @dwResSize, bool @fIcon, uint /* DWORD */ @dwVer);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HICON */ CreateIconFromResourceEx(IntPtr /* unsigned char * */ @presbits, uint /* DWORD */ @dwResSize, bool @fIcon, uint /* DWORD */ @dwVer, int @cxDesired, int @cyDesired, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HICON */ CreateIconIndirect(Iconinfo /* PICONINFO */ @piconinfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ CreateMDIWindow(IntPtr /* const wchar_t * */ @lpClassName, IntPtr /* const wchar_t * */ @lpWindowName, uint /* DWORD */ @dwStyle, int @X, int @Y, int @nWidth, int @nHeight, IntPtr /* HWND */ @hWndParent, Hinstance /* HINSTANCE */ @hInstance, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hmenu /* HMENU */ CreateMenu();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hmenu /* HMENU */ CreatePopupMenu();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ CreateWindowEx(uint /* DWORD */ @dwExStyle, IntPtr /* const wchar_t * */ @lpClassName, IntPtr /* const wchar_t * */ @lpWindowName, uint /* DWORD */ @dwStyle, int @X, int @Y, int @nWidth, int @nHeight, IntPtr /* HWND */ @hWndParent, Hmenu /* HMENU */ @hMenu, Hinstance /* HINSTANCE */ @hInstance, IntPtr /* void * */ @lpParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hwinsta /* HWINSTA */ CreateWindowStation(IntPtr /* const wchar_t * */ @lpwinsta, uint /* DWORD */ @dwFlags, uint /* ACCESS_MASK */ @dwDesiredAccess, SecurityAttributes /* LPSECURITY_ATTRIBUTES */ @lpsa);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeAbandonTransaction(uint /* DWORD */ @idInst, Hconv /* HCONV */ @hConv, uint /* DWORD */ @idTransaction);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* unsigned char * */ DdeAccessData(Hddedata /* HDDEDATA */ @hData, IntPtr /* unsigned long * */ @pcbDataSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hddedata /* HDDEDATA */ DdeAddData(Hddedata /* HDDEDATA */ @hData, IntPtr /* unsigned char * */ @pSrc, uint /* DWORD */ @cb, uint /* DWORD */ @cbOff);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hddedata /* HDDEDATA */ DdeClientTransaction(IntPtr /* unsigned char * */ @pData, uint /* DWORD */ @cbData, Hconv /* HCONV */ @hConv, Hsz /* HSZ */ @hszItem, uint /* UINT */ @wFmt, uint /* UINT */ @wType, uint /* DWORD */ @dwTimeout, IntPtr /* unsigned long * */ @pdwResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DdeCmpStringHandles(Hsz /* HSZ */ @hsz1, Hsz /* HSZ */ @hsz2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hconv /* HCONV */ DdeConnect(uint /* DWORD */ @idInst, Hsz /* HSZ */ @hszService, Hsz /* HSZ */ @hszTopic, Convcontext /* PCONVCONTEXT */ @pCC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hconvlist /* HCONVLIST */ DdeConnectList(uint /* DWORD */ @idInst, Hsz /* HSZ */ @hszService, Hsz /* HSZ */ @hszTopic, Hconvlist /* HCONVLIST */ @hConvList, Convcontext /* PCONVCONTEXT */ @pCC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hddedata /* HDDEDATA */ DdeCreateDataHandle(uint /* DWORD */ @idInst, IntPtr /* unsigned char * */ @pSrc, uint /* DWORD */ @cb, uint /* DWORD */ @cbOff, Hsz /* HSZ */ @hszItem, uint /* UINT */ @wFmt, uint /* UINT */ @afCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hsz /* HSZ */ DdeCreateStringHandle(uint /* DWORD */ @idInst, IntPtr /* const wchar_t * */ @psz, int @iCodePage);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeDisconnect(Hconv /* HCONV */ @hConv);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeDisconnectList(Hconvlist /* HCONVLIST */ @hConvList);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeEnableCallback(uint /* DWORD */ @idInst, Hconv /* HCONV */ @hConv, uint /* UINT */ @wCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeFreeDataHandle(Hddedata /* HDDEDATA */ @hData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeFreeStringHandle(uint /* DWORD */ @idInst, Hsz /* HSZ */ @hsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ DdeGetData(Hddedata /* HDDEDATA */ @hData, IntPtr /* unsigned char * */ @pDst, uint /* DWORD */ @cbMax, uint /* DWORD */ @cbOff);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ DdeGetLastError(uint /* DWORD */ @idInst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeImpersonateClient(Hconv /* HCONV */ @hConv);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ DdeInitialize(IntPtr /* unsigned long * */ @pidInst, IntPtr /* HDDEDATA__ *(*)(unsigned int, unsigned int, HCONV__ *, HSZ__ *, HSZ__ *, HDDEDATA__ *, unsigned long long, unsigned long long) */ @pfnCallback, uint /* DWORD */ @afCmd, uint /* DWORD */ @ulRes);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeKeepStringHandle(uint /* DWORD */ @idInst, Hsz /* HSZ */ @hsz);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hddedata /* HDDEDATA */ DdeNameService(uint /* DWORD */ @idInst, Hsz /* HSZ */ @hsz1, Hsz /* HSZ */ @hsz2, uint /* UINT */ @afCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdePostAdvise(uint /* DWORD */ @idInst, Hsz /* HSZ */ @hszTopic, Hsz /* HSZ */ @hszItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ DdeQueryConvInfo(Hconv /* HCONV */ @hConv, uint /* DWORD */ @idTransaction, Convinfo /* PCONVINFO */ @pConvInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hconv /* HCONV */ DdeQueryNextServer(Hconvlist /* HCONVLIST */ @hConvList, Hconv /* HCONV */ @hConvPrev);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ DdeQueryString(uint /* DWORD */ @idInst, Hsz /* HSZ */ @hsz, IntPtr /* wchar_t * */ @psz, uint /* DWORD */ @cchMax, int @iCodePage);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hconv /* HCONV */ DdeReconnect(Hconv /* HCONV */ @hConv);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeSetQualityOfService(IntPtr /* HWND */ @hwndClient, SecurityQualityOfService /* const SECURITY_QUALITY_OF_SERVICE * */ @pqosNew, SecurityQualityOfService /* PSECURITY_QUALITY_OF_SERVICE */ @pqosPrev);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeSetUserHandle(Hconv /* HCONV */ @hConv, uint /* DWORD */ @id, ulong /* DWORD_PTR */ @hUser);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeUnaccessData(Hddedata /* HDDEDATA */ @hData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DdeUninitialize(uint /* DWORD */ @idInst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefDlgProc(IntPtr /* HWND */ @hDlg, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ DeferWindowPos(IntPtr /* void * */ @hWinPosInfo, IntPtr /* HWND */ @hWnd, IntPtr /* HWND */ @hWndInsertAfter, int @x, int @y, int @cx, int @cy, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefFrameProc(IntPtr /* HWND */ @hWnd, IntPtr /* HWND */ @hWndMDIClient, uint /* UINT */ @uMsg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefMDIChildProc(IntPtr /* HWND */ @hWnd, uint /* UINT */ @uMsg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefRawInputProc(IntPtr /* tagRAWINPUT ** */ @paRawInput, int /* INT */ @nInput, uint /* UINT */ @cbSizeHeader);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DefWindowProc(IntPtr /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DeleteMenu(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DeregisterShellHookWindow(IntPtr /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyAcceleratorTable(Haccel /* HACCEL */ @hAccel);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyCaret();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyCursor(Hicon /* HCURSOR */ @hCursor);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyIcon(Hicon /* HICON */ @hIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyMenu(Hmenu /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DestroyWindow(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* INT_PTR */ DialogBoxIndirectParam(Hinstance /* HINSTANCE */ @hInstance, Dlgtemplate /* LPCDLGTEMPLATEW */ @hDialogTemplate, IntPtr /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* INT_PTR */ DialogBoxParam(Hinstance /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpTemplateName, IntPtr /* HWND */ @hWndParent, IntPtr /* long long (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpDialogFunc, long /* LPARAM */ @dwInitParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void DisableProcessWindowsGhosting();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ DispatchMessage(Msg /* const MSG * */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ DisplayConfigGetDeviceInfo(DisplayconfigDeviceInfoHeader @requestPacket);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ DisplayConfigSetDeviceInfo(DisplayconfigDeviceInfoHeader @setPacket);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DlgDirList(IntPtr /* HWND */ @hDlg, IntPtr /* wchar_t * */ @lpPathSpec, int @nIDListBox, int @nIDStaticPath, uint /* UINT */ @uFileType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DlgDirListComboBox(IntPtr /* HWND */ @hDlg, IntPtr /* wchar_t * */ @lpPathSpec, int @nIDComboBox, int @nIDStaticPath, uint /* UINT */ @uFiletype);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DlgDirSelectComboBoxEx(IntPtr /* HWND */ @hwndDlg, IntPtr /* wchar_t * */ @lpString, int @cchOut, int @idComboBox);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DlgDirSelectEx(IntPtr /* HWND */ @hwndDlg, IntPtr /* wchar_t * */ @lpString, int @chCount, int @idListBox);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DragDetect(IntPtr /* HWND */ @hwnd, Point /* POINT */ @pt);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ DragObject(IntPtr /* HWND */ @hwndParent, IntPtr /* HWND */ @hwndFrom, uint /* UINT */ @fmt, ulong /* ULONG_PTR */ @data, Hicon /* HCURSOR */ @hcur);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawAnimatedRects(IntPtr /* HWND */ @hwnd, int @idAni, Rect /* const RECT * */ @lprcFrom, Rect /* const RECT * */ @lprcTo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawCaption(IntPtr /* HWND */ @hwnd, Hdc /* HDC */ @hdc, Rect /* const RECT * */ @lprect, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawEdge(Hdc /* HDC */ @hdc, Rect /* LPRECT */ @qrc, uint /* UINT */ @edge, uint /* UINT */ @grfFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawFocusRect(Hdc /* HDC */ @hDC, Rect /* const RECT * */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawFrameControl(Hdc /* HDC */ @, Rect /* LPRECT */ @, uint /* UINT */ @, uint /* UINT */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawIcon(Hdc /* HDC */ @hDC, int @X, int @Y, Hicon /* HICON */ @hIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawIconEx(Hdc /* HDC */ @hdc, int @xLeft, int @yTop, Hicon /* HICON */ @hIcon, int @cxWidth, int @cyWidth, uint /* UINT */ @istepIfAniCur, Hbrush /* HBRUSH */ @hbrFlickerFreeDraw, uint /* UINT */ @diFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawMenuBar(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool DrawState(Hdc /* HDC */ @hdc, Hbrush /* HBRUSH */ @hbrFore, IntPtr /* int (*)(HDC__ *, long long, unsigned long long, int, int) */ @qfnCallBack, long /* LPARAM */ @lData, ulong /* WPARAM */ @wData, int @x, int @y, int @cx, int @cy, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DrawText(Hdc /* HDC */ @hdc, IntPtr /* const wchar_t * */ @lpchText, int @cchText, Rect /* LPRECT */ @lprc, uint /* UINT */ @format);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DrawTextEx(Hdc /* HDC */ @hdc, IntPtr /* wchar_t * */ @lpchText, int @cchText, Rect /* LPRECT */ @lprc, uint /* UINT */ @format, Drawtextparams /* LPDRAWTEXTPARAMS */ @lpdtp);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EmptyClipboard();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnableMenuItem(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uIDEnableItem, uint /* UINT */ @uEnable);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnableMouseInPointer(bool @fEnable);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnableScrollBar(IntPtr /* HWND */ @hWnd, uint /* UINT */ @wSBflags, uint /* UINT */ @wArrows);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnableWindow(IntPtr /* HWND */ @hWnd, bool @bEnable);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndDeferWindowPos(IntPtr /* void * */ @hWinPosInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndDialog(IntPtr /* HWND */ @hDlg, long /* INT_PTR */ @nResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndMenu();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EndPaint(IntPtr /* HWND */ @hWnd, Paintstruct /* const PAINTSTRUCT * */ @lpPaint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumChildWindows(IntPtr /* HWND */ @hWndParent, IntPtr /* int (*)(HWND__ *, long long) */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ EnumClipboardFormats(uint /* UINT */ @format);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDesktops(Hwinsta /* HWINSTA */ @hwinsta, IntPtr /* int (*)(wchar_t *, long long) */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDesktopWindows(Hdesk /* HDESK */ @hDesktop, IntPtr /* int (*)(HWND__ *, long long) */ @lpfn, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDisplayDevices(IntPtr /* const wchar_t * */ @lpDevice, uint /* DWORD */ @iDevNum, DisplayDevicew /* PDISPLAY_DEVICEW */ @lpDisplayDevice, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDisplayMonitors(Hdc /* HDC */ @hdc, Rect /* LPCRECT */ @lprcClip, IntPtr /* int (*)(HMONITOR__ *, HDC__ *, tagRECT *, long long) */ @lpfnEnum, long /* LPARAM */ @dwData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDisplaySettings(IntPtr /* const wchar_t * */ @lpszDeviceName, uint /* DWORD */ @iModeNum, devicemodeW /* DEVMODEW * */ @lpDevMode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDisplaySettingsEx(IntPtr /* const wchar_t * */ @lpszDeviceName, uint /* DWORD */ @iModeNum, devicemodeW /* DEVMODEW * */ @lpDevMode, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int EnumProps(IntPtr /* HWND */ @hWnd, IntPtr /* int (*)(HWND__ *, const wchar_t *, void *) */ @lpEnumFunc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int EnumPropsEx(IntPtr /* HWND */ @hWnd, IntPtr /* int (*)(HWND__ *, wchar_t *, void *, unsigned long long) */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumThreadWindows(uint /* DWORD */ @dwThreadId, IntPtr /* int (*)(HWND__ *, long long) */ @lpfn, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumWindows(IntPtr /* int (*)(HWND__ *, long long) */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumWindowStations(IntPtr /* int (*)(wchar_t *, long long) */ @lpEnumFunc, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EqualRect(Rect /* const RECT * */ @lprc1, Rect /* const RECT * */ @lprc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EvaluateProximityToPolygon(uint /* UINT32 */ @numVertices, Point /* const POINT * */ @controlPolygon, TouchHitTestingInput /* const TOUCH_HIT_TESTING_INPUT * */ @pHitTestingInput, TouchHitTestingProximityEvaluation /* TOUCH_HIT_TESTING_PROXIMITY_EVALUATION * */ @pProximityEval);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EvaluateProximityToRect(Rect /* const RECT * */ @controlBoundingBox, TouchHitTestingInput /* const TOUCH_HIT_TESTING_INPUT * */ @pHitTestingInput, TouchHitTestingProximityEvaluation /* TOUCH_HIT_TESTING_PROXIMITY_EVALUATION * */ @pProximityEval);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ExcludeUpdateRgn(Hdc /* HDC */ @hDC, IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ExitWindowsEx(uint /* UINT */ @uFlags, uint /* DWORD */ @dwReason);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FillRect(Hdc /* HDC */ @hDC, Rect /* const RECT * */ @lprc, Hbrush /* HBRUSH */ @hbr);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ FindWindow(IntPtr /* const wchar_t * */ @lpClassName, IntPtr /* const wchar_t * */ @lpWindowName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ FindWindowEx(IntPtr /* HWND */ @hWndParent, IntPtr /* HWND */ @hWndChildAfter, IntPtr /* const wchar_t * */ @lpszClass, IntPtr /* const wchar_t * */ @lpszWindow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool FlashWindow(IntPtr /* HWND */ @hWnd, bool @bInvert);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool FlashWindowEx(Flashwinfo /* PFLASHWINFO */ @pfwi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FrameRect(Hdc /* HDC */ @hDC, Rect /* const RECT * */ @lprc, Hbrush /* HBRUSH */ @hbr);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool FreeDDElParam(uint /* UINT */ @msg, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetActiveWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetAltTabInfo(IntPtr /* HWND */ @hwnd, int @iItem, Alttabinfo /* PALTTABINFO */ @pati, IntPtr /* wchar_t * */ @pszItemText, uint /* UINT */ @cchItemText);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetAncestor(IntPtr /* HWND */ @hwnd, uint /* UINT */ @gaFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern short /* SHORT */ GetAsyncKeyState(int @vKey);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetAutoRotationState(IntPtr /* tagAR_STATE * */ @pState);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetCapture();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetCaretBlinkTime();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetCaretPos(Point /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetCIMSSM(InputMessageSource /* INPUT_MESSAGE_SOURCE * */ @inputMessageSource);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClassInfo(Hinstance /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpClassName, Wndclassw /* LPWNDCLASSW */ @lpWndClass);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClassInfoEx(Hinstance /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpszClass, Wndclassexw /* LPWNDCLASSEXW */ @lpwcx);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetClassLong(IntPtr /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ulong /* ULONG_PTR */ GetClassLongPtr(IntPtr /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetClassName(IntPtr /* HWND */ @hWnd, IntPtr /* wchar_t * */ @lpClassName, int @nMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ GetClassWord(IntPtr /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClientRect(IntPtr /* HWND */ @hWnd, Rect /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ GetClipboardData(uint /* UINT */ @uFormat);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetClipboardFormatName(uint /* UINT */ @format, IntPtr /* wchar_t * */ @lpszFormatName, int @cchMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetClipboardOwner();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetClipboardSequenceNumber();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetClipboardViewer();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetClipCursor(Rect /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetComboBoxInfo(IntPtr /* HWND */ @hwndCombo, Comboboxinfo /* PCOMBOBOXINFO */ @pcbi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetCurrentInputMessageSource(InputMessageSource /* INPUT_MESSAGE_SOURCE * */ @inputMessageSource);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HCURSOR */ GetCursor();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetCursorInfo(Cursorinfo /* PCURSORINFO */ @pci);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetCursorPos(Point /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hdc /* HDC */ GetDC(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hdc /* HDC */ GetDCEx(IntPtr /* HWND */ @hWnd, Hrgn /* HRGN */ @hrgnClip, uint /* DWORD */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetDesktopWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetDialogBaseUnits();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetDisplayAutoRotationPreferences(IntPtr /* ORIENTATION_PREFERENCE * */ @pOrientation);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetDisplayConfigBufferSizes(uint /* UINT32 */ @flags, IntPtr /* unsigned int * */ @numPathArrayElements, IntPtr /* unsigned int * */ @numModeInfoArrayElements);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetDlgCtrlID(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetDlgItem(IntPtr /* HWND */ @hDlg, int @nIDDlgItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetDlgItemInt(IntPtr /* HWND */ @hDlg, int @nIDDlgItem, IntPtr /* int * */ @lpTranslated, bool @bSigned);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetDlgItemText(IntPtr /* HWND */ @hDlg, int @nIDDlgItem, IntPtr /* wchar_t * */ @lpString, int @cchMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetDoubleClickTime();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetFocus();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetForegroundWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetGestureConfig(IntPtr /* HWND */ @hwnd, uint /* DWORD */ @dwReserved, uint /* DWORD */ @dwFlags, IntPtr /* unsigned int * */ @pcIDs, Gestureconfig /* PGESTURECONFIG */ @pGestureConfig, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetGestureExtraArgs(Hgestureinfo /* HGESTUREINFO */ @hGestureInfo, uint /* UINT */ @cbExtraArgs, IntPtr /* unsigned char * */ @pExtraArgs);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetGestureInfo(Hgestureinfo /* HGESTUREINFO */ @hGestureInfo, Gestureinfo /* PGESTUREINFO */ @pGestureInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetGuiResources(IntPtr /* void * */ @hProcess, uint /* DWORD */ @uiFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetGUIThreadInfo(uint /* DWORD */ @idThread, Guithreadinfo /* PGUITHREADINFO */ @pgui);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetIconInfo(Hicon /* HICON */ @hIcon, Iconinfo /* PICONINFO */ @piconinfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetIconInfoEx(Hicon /* HICON */ @hicon, Iconinfoexw /* PICONINFOEXW */ @piconinfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetInputState();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetKBCodePage();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hkl /* HKL */ GetKeyboardLayout(uint /* DWORD */ @idThread);
    
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
        public static extern IntPtr /* HWND */ GetLastActivePopup(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetLastInputInfo(Lastinputinfo /* PLASTINPUTINFO */ @plii);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetLayeredWindowAttributes(IntPtr /* HWND */ @hwnd, IntPtr /* unsigned long * */ @pcrKey, IntPtr /* unsigned char * */ @pbAlpha, IntPtr /* unsigned long * */ @pdwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetListBoxInfo(IntPtr /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hmenu /* HMENU */ GetMenu(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMenuBarInfo(IntPtr /* HWND */ @hwnd, int /* LONG */ @idObject, int /* LONG */ @idItem, Menubarinfo /* PMENUBARINFO */ @pmbi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetMenuCheckMarkDimensions();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetMenuContextHelpId(Hmenu /* HMENU */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetMenuDefaultItem(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @fByPos, uint /* UINT */ @gmdiFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMenuInfo(Hmenu /* HMENU */ @, Menuinfo /* LPMENUINFO */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetMenuItemCount(Hmenu /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetMenuItemID(Hmenu /* HMENU */ @hMenu, int @nPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMenuItemInfo(Hmenu /* HMENU */ @hmenu, uint /* UINT */ @item, bool @fByPosition, Menuiteminfow /* LPMENUITEMINFOW */ @lpmii);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMenuItemRect(IntPtr /* HWND */ @hWnd, Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uItem, Rect /* LPRECT */ @lprcItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetMenuState(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uId, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetMenuString(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uIDItem, IntPtr /* wchar_t * */ @lpString, int @cchMax, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMessage(Msg /* LPMSG */ @lpMsg, IntPtr /* HWND */ @hWnd, uint /* UINT */ @wMsgFilterMin, uint /* UINT */ @wMsgFilterMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ GetMessageExtraInfo();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetMessagePos();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetMessageTime();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMonitorInfo(Hmonitor /* HMONITOR */ @hMonitor, Monitorinfo /* LPMONITORINFO */ @lpmi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetMouseMovePointsEx(uint /* UINT */ @cbSize, Mousemovepoint /* LPMOUSEMOVEPOINT */ @lppt, Mousemovepoint /* LPMOUSEMOVEPOINT */ @lpptBuf, int @nBufPoints, uint /* DWORD */ @resolution);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetNextDlgGroupItem(IntPtr /* HWND */ @hDlg, IntPtr /* HWND */ @hCtl, bool @bPrevious);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetNextDlgTabItem(IntPtr /* HWND */ @hDlg, IntPtr /* HWND */ @hCtl, bool @bPrevious);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetOpenClipboardWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetParent(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPhysicalCursorPos(Point /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerCursorId(uint /* UINT32 */ @pointerId, IntPtr /* unsigned int * */ @cursorId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerDevice(IntPtr /* void * */ @device, PointerDeviceInfo /* POINTER_DEVICE_INFO * */ @pointerDevice);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerDeviceCursors(IntPtr /* void * */ @device, IntPtr /* unsigned int * */ @cursorCount, PointerDeviceCursorInfo /* POINTER_DEVICE_CURSOR_INFO * */ @deviceCursors);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerDeviceProperties(IntPtr /* void * */ @device, IntPtr /* unsigned int * */ @propertyCount, PointerDeviceProperty /* POINTER_DEVICE_PROPERTY * */ @pointerProperties);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerDeviceRects(IntPtr /* void * */ @device, Rect /* RECT * */ @pointerDeviceRect, Rect /* RECT * */ @displayRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerDevices(IntPtr /* unsigned int * */ @deviceCount, PointerDeviceInfo /* POINTER_DEVICE_INFO * */ @pointerDevices);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerFrameInfo(uint /* UINT32 */ @pointerId, IntPtr /* unsigned int * */ @pointerCount, PointerInfo /* POINTER_INFO * */ @pointerInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerFrameInfoHistory(uint /* UINT32 */ @pointerId, IntPtr /* unsigned int * */ @entriesCount, IntPtr /* unsigned int * */ @pointerCount, PointerInfo /* POINTER_INFO * */ @pointerInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerFramePenInfo(uint /* UINT32 */ @pointerId, IntPtr /* unsigned int * */ @pointerCount, PointerPenInfo /* POINTER_PEN_INFO * */ @penInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerFramePenInfoHistory(uint /* UINT32 */ @pointerId, IntPtr /* unsigned int * */ @entriesCount, IntPtr /* unsigned int * */ @pointerCount, PointerPenInfo /* POINTER_PEN_INFO * */ @penInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerFrameTouchInfo(uint /* UINT32 */ @pointerId, IntPtr /* unsigned int * */ @pointerCount, PointerTouchInfo /* POINTER_TOUCH_INFO * */ @touchInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerFrameTouchInfoHistory(uint /* UINT32 */ @pointerId, IntPtr /* unsigned int * */ @entriesCount, IntPtr /* unsigned int * */ @pointerCount, PointerTouchInfo /* POINTER_TOUCH_INFO * */ @touchInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerInfo(uint /* UINT32 */ @pointerId, PointerInfo /* POINTER_INFO * */ @pointerInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerInfoHistory(uint /* UINT32 */ @pointerId, IntPtr /* unsigned int * */ @entriesCount, PointerInfo /* POINTER_INFO * */ @pointerInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerInputTransform(uint /* UINT32 */ @pointerId, uint /* UINT32 */ @historyCount, InputTransform /* INPUT_TRANSFORM * */ @inputTransform);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerPenInfo(uint /* UINT32 */ @pointerId, PointerPenInfo /* POINTER_PEN_INFO * */ @penInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerPenInfoHistory(uint /* UINT32 */ @pointerId, IntPtr /* unsigned int * */ @entriesCount, PointerPenInfo /* POINTER_PEN_INFO * */ @penInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerTouchInfo(uint /* UINT32 */ @pointerId, PointerTouchInfo /* POINTER_TOUCH_INFO * */ @touchInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerTouchInfoHistory(uint /* UINT32 */ @pointerId, IntPtr /* unsigned int * */ @entriesCount, PointerTouchInfo /* POINTER_TOUCH_INFO * */ @touchInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPointerType(uint /* UINT32 */ @pointerId, IntPtr /* unsigned long * */ @pointerType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetPriorityClipboardFormat(IntPtr /* unsigned int * */ @paFormatPriorityList, int @cFormats);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetProcessDefaultLayout(IntPtr /* unsigned long * */ @pdwDefaultLayout);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hwinsta /* HWINSTA */ GetProcessWindowStation();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ GetProp(IntPtr /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetQueueStatus(uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputBuffer(Rawinput /* PRAWINPUT */ @pData, IntPtr /* unsigned int * */ @pcbSize, uint /* UINT */ @cbSizeHeader);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputData(Hrawinput /* HRAWINPUT */ @hRawInput, uint /* UINT */ @uiCommand, IntPtr /* void * */ @pData, IntPtr /* unsigned int * */ @pcbSize, uint /* UINT */ @cbSizeHeader);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputDeviceInfo(IntPtr /* void * */ @hDevice, uint /* UINT */ @uiCommand, IntPtr /* void * */ @pData, IntPtr /* unsigned int * */ @pcbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRawInputDeviceList(Rawinputdevicelist /* PRAWINPUTDEVICELIST */ @pRawInputDeviceList, IntPtr /* unsigned int * */ @puiNumDevices, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetRawPointerDeviceData(uint /* UINT32 */ @pointerId, uint /* UINT32 */ @historyCount, uint /* UINT32 */ @propertiesCount, PointerDeviceProperty /* POINTER_DEVICE_PROPERTY * */ @pProperties, IntPtr /* long * */ @pValues);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetRegisteredRawInputDevices(Rawinputdevice /* PRAWINPUTDEVICE */ @pRawInputDevices, IntPtr /* unsigned int * */ @puiNumDevices, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetScrollBarInfo(IntPtr /* HWND */ @hwnd, int /* LONG */ @idObject, Scrollbarinfo /* PSCROLLBARINFO */ @psbi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetScrollInfo(IntPtr /* HWND */ @hwnd, int @nBar, Scrollinfo /* LPSCROLLINFO */ @lpsi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetScrollPos(IntPtr /* HWND */ @hWnd, int @nBar);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetScrollRange(IntPtr /* HWND */ @hWnd, int @nBar, IntPtr /* int * */ @lpMinPos, IntPtr /* int * */ @lpMaxPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetShellWindow();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hmenu /* HMENU */ GetSubMenu(Hmenu /* HMENU */ @hMenu, int @nPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetSysColor(int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hbrush /* HBRUSH */ GetSysColorBrush(int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hmenu /* HMENU */ GetSystemMenu(IntPtr /* HWND */ @hWnd, bool @bRevert);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetSystemMetrics(int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetTabbedTextExtent(Hdc /* HDC */ @hdc, IntPtr /* const wchar_t * */ @lpString, int @chCount, int @nTabPositions, IntPtr /* const int * */ @lpnTabStopPositions);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hdesk /* HDESK */ GetThreadDesktop(uint /* DWORD */ @dwThreadId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetTitleBarInfo(IntPtr /* HWND */ @hwnd, Titlebarinfo /* PTITLEBARINFO */ @pti);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetTopWindow(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetTouchInputInfo(Htouchinput /* HTOUCHINPUT */ @hTouchInput, uint /* UINT */ @cInputs, Touchinput /* PTOUCHINPUT */ @pInputs, int @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetUnpredictedMessagePos();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetUpdatedClipboardFormats(IntPtr /* unsigned int * */ @lpuiFormats, uint /* UINT */ @cFormats, IntPtr /* unsigned int * */ @pcFormatsOut);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetUpdateRect(IntPtr /* HWND */ @hWnd, Rect /* LPRECT */ @lpRect, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetUpdateRgn(IntPtr /* HWND */ @hWnd, Hrgn /* HRGN */ @hRgn, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetUserObjectInformation(IntPtr /* void * */ @hObj, int @nIndex, IntPtr /* void * */ @pvInfo, uint /* DWORD */ @nLength, IntPtr /* unsigned long * */ @lpnLengthNeeded);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetUserObjectSecurity(IntPtr /* void * */ @hObj, IntPtr /* unsigned long * */ @pSIRequested, IntPtr /* void * */ @pSID, uint /* DWORD */ @nLength, IntPtr /* unsigned long * */ @lpnLengthNeeded);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ GetWindow(IntPtr /* HWND */ @hWnd, uint /* UINT */ @uCmd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetWindowContextHelpId(IntPtr /* HWND */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hdc /* HDC */ GetWindowDC(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowDisplayAffinity(IntPtr /* HWND */ @hWnd, IntPtr /* unsigned long * */ @pdwAffinity);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowFeedbackSetting(IntPtr /* HWND */ @hwnd, FeedbackType /* FEEDBACK_TYPE */ @feedback, uint /* DWORD */ @dwFlags, IntPtr /* unsigned int * */ @pSize, IntPtr /* void * */ @config);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowInfo(IntPtr /* HWND */ @hwnd, Windowinfo /* PWINDOWINFO */ @pwi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ GetWindowLong(IntPtr /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LONG_PTR */ GetWindowLongPtr(IntPtr /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ GetWindowModuleFileName(IntPtr /* HWND */ @hwnd, IntPtr /* wchar_t * */ @pszFileName, uint /* UINT */ @cchFileNameMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowPlacement(IntPtr /* HWND */ @hWnd, Windowplacement /* WINDOWPLACEMENT * */ @lpwndpl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr /* HWND */ @hWnd, Rect /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowRgn(IntPtr /* HWND */ @hWnd, Hrgn /* HRGN */ @hRgn);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowRgnBox(IntPtr /* HWND */ @hWnd, Rect /* LPRECT */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr /* HWND */ @hWnd, IntPtr /* wchar_t * */ @lpString, int @nMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowTextLength(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ GetWindowThreadProcessId(IntPtr /* HWND */ @hWnd, IntPtr /* unsigned long * */ @lpdwProcessId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ GetWindowWord(IntPtr /* HWND */ @hWnd, int @nIndex);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GrayString(Hdc /* HDC */ @hDC, Hbrush /* HBRUSH */ @hBrush, IntPtr /* int (*)(HDC__ *, long long, int) */ @lpOutputFunc, long /* LPARAM */ @lpData, int @nCount, int @X, int @Y, int @nWidth, int @nHeight);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool HideCaret(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool HiliteMenuItem(IntPtr /* HWND */ @hWnd, Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uIDHiliteItem, uint /* UINT */ @uHilite);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ImpersonateDdeClientWindow(IntPtr /* HWND */ @hWndClient, IntPtr /* HWND */ @hWndServer);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InflateRect(Rect /* LPRECT */ @lprc, int @dx, int @dy);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InitializeTouchInjection(uint /* UINT32 */ @maxCount, uint /* DWORD */ @dwMode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InjectTouchInput(uint /* UINT32 */ @count, PointerTouchInfo /* const POINTER_TOUCH_INFO * */ @contacts);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InSendMessage();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ InSendMessageEx(IntPtr /* void * */ @lpReserved);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InsertMenu(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags, ulong /* UINT_PTR */ @uIDNewItem, IntPtr /* const wchar_t * */ @lpNewItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InsertMenuItem(Hmenu /* HMENU */ @hmenu, uint /* UINT */ @item, bool @fByPosition, Menuiteminfow /* LPCMENUITEMINFOW */ @lpmi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int InternalGetWindowText(IntPtr /* HWND */ @hWnd, IntPtr /* wchar_t * */ @pString, int @cchMaxCount);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IntersectRect(Rect /* LPRECT */ @lprcDst, Rect /* const RECT * */ @lprcSrc1, Rect /* const RECT * */ @lprcSrc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InvalidateRect(IntPtr /* HWND */ @hWnd, Rect /* const RECT * */ @lpRect, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InvalidateRgn(IntPtr /* HWND */ @hWnd, Hrgn /* HRGN */ @hRgn, bool @bErase);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InvertRect(Hdc /* HDC */ @hDC, Rect /* const RECT * */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool IsCharAlpha(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool IsCharAlphaNumeric(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool IsCharLower(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool IsCharUpper(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsChild(IntPtr /* HWND */ @hWndParent, IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsClipboardFormatAvailable(uint /* UINT */ @format);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsDialogMessage(IntPtr /* HWND */ @hDlg, Msg /* LPMSG */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ IsDlgButtonChecked(IntPtr /* HWND */ @hDlg, int @nIDButton);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsGUIThread(bool @bConvert);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsHungAppWindow(IntPtr /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsIconic(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsImmersiveProcess(IntPtr /* void * */ @hProcess);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsMenu(Hmenu /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsMouseInPointerEnabled();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsProcessDPIAware();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsRectEmpty(Rect /* const RECT * */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsTouchWindow(IntPtr /* HWND */ @hwnd, IntPtr /* unsigned long * */ @pulFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindow(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindowEnabled(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindowUnicode(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWindowVisible(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWinEventHookInstalled(uint /* DWORD */ @event);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsWow64Message();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool IsZoomed(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void keybd_event(byte @bVk, byte @bScan, uint /* DWORD */ @dwFlags, ulong /* ULONG_PTR */ @dwExtraInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool KillTimer(IntPtr /* HWND */ @hWnd, ulong /* UINT_PTR */ @uIDEvent);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Haccel /* HACCEL */ LoadAccelerators(Hinstance /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpTableName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hbitmap /* HBITMAP */ LoadBitmap(Hinstance /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpBitmapName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HCURSOR */ LoadCursor(Hinstance /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpCursorName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HCURSOR */ LoadCursorFromFile(IntPtr /* const wchar_t * */ @lpFileName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HICON */ LoadIcon(Hinstance /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpIconName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ LoadImage(Hinstance /* HINSTANCE */ @hInst, IntPtr /* const wchar_t * */ @name, uint /* UINT */ @type, int @cx, int @cy, uint /* UINT */ @fuLoad);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hkl /* HKL */ LoadKeyboardLayout(IntPtr /* const wchar_t * */ @pwszKLID, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hmenu /* HMENU */ LoadMenu(Hinstance /* HINSTANCE */ @hInstance, IntPtr /* const wchar_t * */ @lpMenuName);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hmenu /* HMENU */ LoadMenuIndirect(IntPtr /* const void * */ @lpMenuTemplate);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LoadString(Hinstance /* HINSTANCE */ @hInstance, uint /* UINT */ @uID, IntPtr /* wchar_t * */ @lpBuffer, int @cchBufferMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool LockSetForegroundWindow(uint /* UINT */ @uLockCode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool LockWindowUpdate(IntPtr /* HWND */ @hWndLock);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool LockWorkStation();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool LogicalToPhysicalPoint(IntPtr /* HWND */ @hWnd, Point /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool LogicalToPhysicalPointForPerMonitorDPI(IntPtr /* HWND */ @hWnd, Point /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LookupIconIdFromDirectory(IntPtr /* unsigned char * */ @presbits, bool @fIcon);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int LookupIconIdFromDirectoryEx(IntPtr /* unsigned char * */ @presbits, bool @fIcon, int @cxDesired, int @cyDesired, uint /* UINT */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool MapDialogRect(IntPtr /* HWND */ @hDlg, Rect /* LPRECT */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ MapVirtualKey(uint /* UINT */ @uCode, uint /* UINT */ @uMapType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ MapVirtualKeyEx(uint /* UINT */ @uCode, uint /* UINT */ @uMapType, Hkl /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MapWindowPoints(IntPtr /* HWND */ @hWndFrom, IntPtr /* HWND */ @hWndTo, Point /* LPPOINT */ @lpPoints, uint /* UINT */ @cPoints);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MenuItemFromPoint(IntPtr /* HWND */ @hWnd, Hmenu /* HMENU */ @hMenu, Point /* POINT */ @ptScreen);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool MessageBeep(uint /* UINT */ @uType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MessageBox(IntPtr /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpText, IntPtr /* const wchar_t * */ @lpCaption, uint /* UINT */ @uType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MessageBoxEx(IntPtr /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpText, IntPtr /* const wchar_t * */ @lpCaption, uint /* UINT */ @uType, ushort /* WORD */ @wLanguageId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int MessageBoxIndirect(Msgboxparamsw /* const MSGBOXPARAMSW * */ @lpmbp);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ModifyMenu(Hmenu /* HMENU */ @hMnu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags, ulong /* UINT_PTR */ @uIDNewItem, IntPtr /* const wchar_t * */ @lpNewItem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hmonitor /* HMONITOR */ MonitorFromPoint(Point /* POINT */ @pt, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hmonitor /* HMONITOR */ MonitorFromRect(Rect /* LPCRECT */ @lprc, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hmonitor /* HMONITOR */ MonitorFromWindow(IntPtr /* HWND */ @hwnd, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void mouse_event(uint /* DWORD */ @dwFlags, uint /* DWORD */ @dx, uint /* DWORD */ @dy, uint /* DWORD */ @dwData, ulong /* ULONG_PTR */ @dwExtraInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool MoveWindow(IntPtr /* HWND */ @hWnd, int @X, int @Y, int @nWidth, int @nHeight, bool @bRepaint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ MsgWaitForMultipleObjects(uint /* DWORD */ @nCount, IntPtr /* void *const * */ @pHandles, bool @fWaitAll, uint /* DWORD */ @dwMilliseconds, uint /* DWORD */ @dwWakeMask);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ MsgWaitForMultipleObjectsEx(uint /* DWORD */ @nCount, IntPtr /* void *const * */ @pHandles, uint /* DWORD */ @dwMilliseconds, uint /* DWORD */ @dwWakeMask, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void NotifyWinEvent(uint /* DWORD */ @event, IntPtr /* HWND */ @hwnd, int /* LONG */ @idObject, int /* LONG */ @idChild);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ OemKeyScan(ushort /* WORD */ @wOemChar);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OemToChar(IntPtr /* const char * */ @pSrc, IntPtr /* wchar_t * */ @pDst);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OemToCharBuff(IntPtr /* const char * */ @lpszSrc, IntPtr /* wchar_t * */ @lpszDst, uint /* DWORD */ @cchDstLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OffsetRect(Rect /* LPRECT */ @lprc, int @dx, int @dy);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OpenClipboard(IntPtr /* HWND */ @hWndNewOwner);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hdesk /* HDESK */ OpenDesktop(IntPtr /* const wchar_t * */ @lpszDesktop, uint /* DWORD */ @dwFlags, bool @fInherit, uint /* ACCESS_MASK */ @dwDesiredAccess);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OpenIcon(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hdesk /* HDESK */ OpenInputDesktop(uint /* DWORD */ @dwFlags, bool @fInherit, uint /* ACCESS_MASK */ @dwDesiredAccess);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hwinsta /* HWINSTA */ OpenWindowStation(IntPtr /* const wchar_t * */ @lpszWinSta, bool @fInherit, uint /* ACCESS_MASK */ @dwDesiredAccess);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ PackDDElParam(uint /* UINT */ @msg, ulong /* UINT_PTR */ @uiLo, ulong /* UINT_PTR */ @uiHi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ PackTouchHitTestingProximityEvaluation(TouchHitTestingInput /* const TOUCH_HIT_TESTING_INPUT * */ @pHitTestingInput, TouchHitTestingProximityEvaluation /* const TOUCH_HIT_TESTING_PROXIMITY_EVALUATION * */ @pProximityEval);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PaintDesktop(Hdc /* HDC */ @hdc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PeekMessage(Msg /* LPMSG */ @lpMsg, IntPtr /* HWND */ @hWnd, uint /* UINT */ @wMsgFilterMin, uint /* UINT */ @wMsgFilterMax, uint /* UINT */ @wRemoveMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PhysicalToLogicalPoint(IntPtr /* HWND */ @hWnd, Point /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PhysicalToLogicalPointForPerMonitorDPI(IntPtr /* HWND */ @hWnd, Point /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostMessage(IntPtr /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void PostQuitMessage(int @nExitCode);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostThreadMessage(uint /* DWORD */ @idThread, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PrintWindow(IntPtr /* HWND */ @hwnd, Hdc /* HDC */ @hdcBlt, uint /* UINT */ @nFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ PrivateExtractIcons(IntPtr /* const wchar_t * */ @szFileName, int @nIconIndex, int @cxIcon, int @cyIcon, IntPtr /* HICON__ ** */ @phicon, IntPtr /* unsigned int * */ @piconid, uint /* UINT */ @nIcons, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PtInRect(Rect /* const RECT * */ @lprc, Point /* POINT */ @pt);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ QueryDisplayConfig(uint /* UINT32 */ @flags, IntPtr /* unsigned int * */ @numPathArrayElements, DisplayconfigPathInfo @pathArray, IntPtr /* unsigned int * */ @numModeInfoArrayElements, DisplayconfigModeInfo @modeInfoArray, IntPtr /* DISPLAYCONFIG_TOPOLOGY_ID * */ @currentTopologyId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ RealChildWindowFromPoint(IntPtr /* HWND */ @hwndParent, Point /* POINT */ @ptParentClientCoords);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ RealGetWindowClass(IntPtr /* HWND */ @hwnd, IntPtr /* wchar_t * */ @ptszClassName, uint /* UINT */ @cchClassNameMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RedrawWindow(IntPtr /* HWND */ @hWnd, Rect /* const RECT * */ @lprcUpdate, Hrgn /* HRGN */ @hrgnUpdate, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* ATOM */ RegisterClass(Wndclassw /* const WNDCLASSW * */ @lpWndClass);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* ATOM */ RegisterClassEx(Wndclassexw /* const WNDCLASSEXW * */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ RegisterClipboardFormat(IntPtr /* const wchar_t * */ @lpszFormat);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ RegisterDeviceNotification(IntPtr /* void * */ @hRecipient, IntPtr /* void * */ @NotificationFilter, uint /* DWORD */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr /* HWND */ @hWnd, int @id, uint /* UINT */ @fsModifiers, uint /* UINT */ @vk);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterPointerDeviceNotifications(IntPtr /* HWND */ @window, bool @notifyRange);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterPointerInputTarget(IntPtr /* HWND */ @hwnd, uint /* POINTER_INPUT_TYPE */ @pointerType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ RegisterPowerSettingNotification(IntPtr /* void * */ @hRecipient, Guid /* LPCGUID */ @PowerSettingGuid, uint /* DWORD */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterRawInputDevices(Rawinputdevice /* PCRAWINPUTDEVICE */ @pRawInputDevices, uint /* UINT */ @uiNumDevices, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterShellHookWindow(IntPtr /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ RegisterSuspendResumeNotification(IntPtr /* void * */ @hRecipient, uint /* DWORD */ @Flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterTouchHitTestingWindow(IntPtr /* HWND */ @hwnd, uint /* ULONG */ @value);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RegisterTouchWindow(IntPtr /* HWND */ @hwnd, uint /* ULONG */ @ulFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ RegisterWindowMessage(IntPtr /* const wchar_t * */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ReleaseCapture();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ReleaseDC(IntPtr /* HWND */ @hWnd, Hdc /* HDC */ @hDC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RemoveClipboardFormatListener(IntPtr /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RemoveMenu(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ RemoveProp(IntPtr /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ReplyMessage(long /* LRESULT */ @lResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ ReuseDDElParam(long /* LPARAM */ @lParam, uint /* UINT */ @msgIn, uint /* UINT */ @msgOut, ulong /* UINT_PTR */ @uiLo, ulong /* UINT_PTR */ @uiHi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ScreenToClient(IntPtr /* HWND */ @hWnd, Point /* LPPOINT */ @lpPoint);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ScrollDC(Hdc /* HDC */ @hDC, int @dx, int @dy, Rect /* const RECT * */ @lprcScroll, Rect /* const RECT * */ @lprcClip, Hrgn /* HRGN */ @hrgnUpdate, Rect /* LPRECT */ @lprcUpdate);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ScrollWindow(IntPtr /* HWND */ @hWnd, int @XAmount, int @YAmount, Rect /* const RECT * */ @lpRect, Rect /* const RECT * */ @lpClipRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ScrollWindowEx(IntPtr /* HWND */ @hWnd, int @dx, int @dy, Rect /* const RECT * */ @prcScroll, Rect /* const RECT * */ @prcClip, Hrgn /* HRGN */ @hrgnUpdate, Rect /* LPRECT */ @prcUpdate, uint /* UINT */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ SendDlgItemMessage(IntPtr /* HWND */ @hDlg, int @nIDDlgItem, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* UINT */ SendInput(uint /* UINT */ @cInputs, Input /* LPINPUT */ @pInputs, int @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ SendMessage(IntPtr /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SendMessageCallback(IntPtr /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam, IntPtr /* void (*)(HWND__ *, unsigned int, unsigned long long, long long) */ @lpResultCallBack, ulong /* ULONG_PTR */ @dwData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LRESULT */ SendMessageTimeout(IntPtr /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam, uint /* UINT */ @fuFlags, uint /* UINT */ @uTimeout, IntPtr /* unsigned long long * */ @lpdwResult);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SendNotifyMessage(IntPtr /* HWND */ @hWnd, uint /* UINT */ @Msg, ulong /* WPARAM */ @wParam, long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ SetActiveWindow(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ SetCapture(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetCaretBlinkTime(uint /* UINT */ @uMSeconds);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetCaretPos(int @X, int @Y);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ SetClassLong(IntPtr /* HWND */ @hWnd, int @nIndex, int /* LONG */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ulong /* ULONG_PTR */ SetClassLongPtr(IntPtr /* HWND */ @hWnd, int @nIndex, long /* LONG_PTR */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ SetClassWord(IntPtr /* HWND */ @hWnd, int @nIndex, ushort /* WORD */ @wNewWord);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* void * */ SetClipboardData(uint /* UINT */ @uFormat, IntPtr /* void * */ @hMem);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ SetClipboardViewer(IntPtr /* HWND */ @hWndNewViewer);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ulong /* UINT_PTR */ SetCoalescableTimer(IntPtr /* HWND */ @hWnd, ulong /* UINT_PTR */ @nIDEvent, uint /* UINT */ @uElapse, IntPtr /* void (*)(HWND__ *, unsigned int, unsigned long long, unsigned long) */ @lpTimerFunc, uint /* ULONG */ @uToleranceDelay);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hicon /* HCURSOR */ SetCursor(Hicon /* HCURSOR */ @hCursor);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetCursorPos(int @X, int @Y);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SetDebugErrorLevel(uint /* DWORD */ @dwLevel);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDisplayAutoRotationPreferences(OrientationPreference @orientation);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ SetDisplayConfig(uint /* UINT32 */ @numPathArrayElements, DisplayconfigPathInfo @pathArray, uint /* UINT32 */ @numModeInfoArrayElements, DisplayconfigModeInfo @modeInfoArray, uint /* UINT32 */ @flags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDlgItemInt(IntPtr /* HWND */ @hDlg, int @nIDDlgItem, uint /* UINT */ @uValue, bool @bSigned);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDlgItemText(IntPtr /* HWND */ @hDlg, int @nIDDlgItem, IntPtr /* const wchar_t * */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDoubleClickTime(uint /* UINT */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ SetFocus(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetGestureConfig(IntPtr /* HWND */ @hwnd, uint /* DWORD */ @dwReserved, uint /* UINT */ @cIDs, Gestureconfig /* PGESTURECONFIG */ @pGestureConfig, uint /* UINT */ @cbSize);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetKeyboardState(IntPtr /* unsigned char * */ @lpKeyState);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SetLastErrorEx(uint /* DWORD */ @dwErrCode, uint /* DWORD */ @dwType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetLayeredWindowAttributes(IntPtr /* HWND */ @hwnd, uint /* COLORREF */ @crKey, byte @bAlpha, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenu(IntPtr /* HWND */ @hWnd, Hmenu /* HMENU */ @hMenu);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenuContextHelpId(Hmenu /* HMENU */ @, uint /* DWORD */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenuDefaultItem(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uItem, uint /* UINT */ @fByPos);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenuInfo(Hmenu /* HMENU */ @, Menuinfo /* LPCMENUINFO */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenuItemBitmaps(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uPosition, uint /* UINT */ @uFlags, Hbitmap /* HBITMAP */ @hBitmapUnchecked, Hbitmap /* HBITMAP */ @hBitmapChecked);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMenuItemInfo(Hmenu /* HMENU */ @hmenu, uint /* UINT */ @item, bool @fByPositon, Menuiteminfow /* LPCMENUITEMINFOW */ @lpmii);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LPARAM */ SetMessageExtraInfo(long /* LPARAM */ @lParam);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetMessageQueue(int @cMessagesMax);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ SetParent(IntPtr /* HWND */ @hWndChild, IntPtr /* HWND */ @hWndNewParent);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetPhysicalCursorPos(int @X, int @Y);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetProcessDefaultLayout(uint /* DWORD */ @dwDefaultLayout);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetProcessDPIAware();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetProcessRestrictionExemption(bool @fEnableExemption);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetProcessWindowStation(Hwinsta /* HWINSTA */ @hWinSta);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetProp(IntPtr /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpString, IntPtr /* void * */ @hData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetRect(Rect /* LPRECT */ @lprc, int @xLeft, int @yTop, int @xRight, int @yBottom);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetRectEmpty(Rect /* LPRECT */ @lprc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetScrollInfo(IntPtr /* HWND */ @hwnd, int @nBar, Scrollinfo /* LPCSCROLLINFO */ @lpsi, bool @redraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetScrollPos(IntPtr /* HWND */ @hWnd, int @nBar, int @nPos, bool @bRedraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetScrollRange(IntPtr /* HWND */ @hWnd, int @nBar, int @nMinPos, int @nMaxPos, bool @bRedraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetSysColors(int @cElements, IntPtr /* const int * */ @lpaElements, IntPtr /* const unsigned long * */ @lpaRgbValues);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetSystemCursor(Hicon /* HCURSOR */ @hcur, uint /* DWORD */ @id);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetThreadDesktop(Hdesk /* HDESK */ @hDesktop);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ulong /* UINT_PTR */ SetTimer(IntPtr /* HWND */ @hWnd, ulong /* UINT_PTR */ @nIDEvent, uint /* UINT */ @uElapse, IntPtr /* void (*)(HWND__ *, unsigned int, unsigned long long, unsigned long) */ @lpTimerFunc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetUserObjectInformation(IntPtr /* void * */ @hObj, int @nIndex, IntPtr /* void * */ @pvInfo, uint /* DWORD */ @nLength);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetUserObjectSecurity(IntPtr /* void * */ @hObj, IntPtr /* unsigned long * */ @pSIRequested, IntPtr /* void * */ @pSID);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowContextHelpId(IntPtr /* HWND */ @, uint /* DWORD */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowDisplayAffinity(IntPtr /* HWND */ @hWnd, uint /* DWORD */ @dwAffinity);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowFeedbackSetting(IntPtr /* HWND */ @hwnd, FeedbackType /* FEEDBACK_TYPE */ @feedback, uint /* DWORD */ @dwFlags, uint /* UINT32 */ @size, IntPtr /* const void * */ @configuration);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ SetWindowLong(IntPtr /* HWND */ @hWnd, int @nIndex, int /* LONG */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long /* LONG_PTR */ SetWindowLongPtr(IntPtr /* HWND */ @hWnd, int @nIndex, long /* LONG_PTR */ @dwNewLong);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowPlacement(IntPtr /* HWND */ @hWnd, Windowplacement /* const WINDOWPLACEMENT * */ @lpwndpl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr /* HWND */ @hWnd, IntPtr /* HWND */ @hWndInsertAfter, int @X, int @Y, int @cx, int @cy, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SetWindowRgn(IntPtr /* HWND */ @hWnd, Hrgn /* HRGN */ @hRgn, bool @bRedraw);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hhook /* HHOOK */ SetWindowsHook(int @nFilterType, IntPtr /* long long (*)(int, unsigned long long, long long) */ @pfnFilterProc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hhook /* HHOOK */ SetWindowsHookEx(int @idHook, IntPtr /* long long (*)(int, unsigned long long, long long) */ @lpfn, Hinstance /* HINSTANCE */ @hmod, uint /* DWORD */ @dwThreadId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetWindowText(IntPtr /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @lpString);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ SetWindowWord(IntPtr /* HWND */ @hWnd, int @nIndex, ushort /* WORD */ @wNewWord);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Hwineventhook /* HWINEVENTHOOK */ SetWinEventHook(uint /* DWORD */ @eventMin, uint /* DWORD */ @eventMax, Hinstance /* HMODULE */ @hmodWinEventProc, IntPtr /* void (*)(HWINEVENTHOOK__ *, unsigned long, HWND__ *, long, long, unsigned long, unsigned long) */ @pfnWinEventProc, uint /* DWORD */ @idProcess, uint /* DWORD */ @idThread, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowCaret(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ShowCursor(bool @bShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowOwnedPopups(IntPtr /* HWND */ @hWnd, bool @fShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowScrollBar(IntPtr /* HWND */ @hWnd, int @wBar, bool @bShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowWindow(IntPtr /* HWND */ @hWnd, int @nCmdShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShowWindowAsync(IntPtr /* HWND */ @hWnd, int @nCmdShow);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShutdownBlockReasonCreate(IntPtr /* HWND */ @hWnd, IntPtr /* const wchar_t * */ @pwszReason);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShutdownBlockReasonDestroy(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ShutdownBlockReasonQuery(IntPtr /* HWND */ @hWnd, IntPtr /* wchar_t * */ @pwszBuff, IntPtr /* unsigned long * */ @pcchBuff);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SkipPointerFrameMessages(uint /* UINT32 */ @pointerId);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SoundSentry();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SubtractRect(Rect /* LPRECT */ @lprcDst, Rect /* const RECT * */ @lprcSrc1, Rect /* const RECT * */ @lprcSrc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SwapMouseButton(bool @fSwap);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SwitchDesktop(Hdesk /* HDESK */ @hDesktop);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SwitchToThisWindow(IntPtr /* HWND */ @hwnd, bool @fUnknown);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SystemParametersInfo(uint /* UINT */ @uiAction, uint /* UINT */ @uiParam, IntPtr /* void * */ @pvParam, uint /* UINT */ @fWinIni);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int /* LONG */ TabbedTextOut(Hdc /* HDC */ @hdc, int @x, int @y, IntPtr /* const wchar_t * */ @lpString, int @chCount, int @nTabPositions, IntPtr /* const int * */ @lpnTabStopPositions, int @nTabOrigin);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern ushort /* WORD */ TileWindows(IntPtr /* HWND */ @hwndParent, uint /* UINT */ @wHow, Rect /* const RECT * */ @lpRect, uint /* UINT */ @cKids, IntPtr /* HWND__ *const * */ @lpKids);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToAscii(uint /* UINT */ @uVirtKey, uint /* UINT */ @uScanCode, IntPtr /* const unsigned char * */ @lpKeyState, IntPtr /* unsigned short * */ @lpChar, uint /* UINT */ @uFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToAsciiEx(uint /* UINT */ @uVirtKey, uint /* UINT */ @uScanCode, IntPtr /* const unsigned char * */ @lpKeyState, IntPtr /* unsigned short * */ @lpChar, uint /* UINT */ @uFlags, Hkl /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToUnicode(uint /* UINT */ @wVirtKey, uint /* UINT */ @wScanCode, IntPtr /* const unsigned char * */ @lpKeyState, IntPtr /* wchar_t * */ @pwszBuff, int @cchBuff, uint /* UINT */ @wFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ToUnicodeEx(uint /* UINT */ @wVirtKey, uint /* UINT */ @wScanCode, IntPtr /* const unsigned char * */ @lpKeyState, IntPtr /* wchar_t * */ @pwszBuff, int @cchBuff, uint /* UINT */ @wFlags, Hkl /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TrackMouseEvent(Trackmouseevent /* LPTRACKMOUSEEVENT */ @lpEventTrack);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TrackPopupMenu(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uFlags, int @x, int @y, int @nReserved, IntPtr /* HWND */ @hWnd, Rect /* const RECT * */ @prcRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TrackPopupMenuEx(Hmenu /* HMENU */ @hMenu, uint /* UINT */ @uFlags, int @x, int @y, IntPtr /* HWND */ @hwnd, Tpmparams /* LPTPMPARAMS */ @lptpm);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int TranslateAccelerator(IntPtr /* HWND */ @hWnd, Haccel /* HACCEL */ @hAccTable, Msg /* LPMSG */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TranslateMDISysAccel(IntPtr /* HWND */ @hWndClient, Msg /* LPMSG */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool TranslateMessage(Msg /* const MSG * */ @lpMsg);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnhookWindowsHook(int @nCode, IntPtr /* long long (*)(int, unsigned long long, long long) */ @pfnFilterProc);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnhookWindowsHookEx(Hhook /* HHOOK */ @hhk);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnhookWinEvent(Hwineventhook /* HWINEVENTHOOK */ @hWinEventHook);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnionRect(Rect /* LPRECT */ @lprcDst, Rect /* const RECT * */ @lprcSrc1, Rect /* const RECT * */ @lprcSrc2);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnloadKeyboardLayout(Hkl /* HKL */ @hkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnpackDDElParam(uint /* UINT */ @msg, long /* LPARAM */ @lParam, IntPtr /* unsigned long long * */ @puiLo, IntPtr /* unsigned long long * */ @puiHi);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterClass(IntPtr /* const wchar_t * */ @lpClassName, Hinstance /* HINSTANCE */ @hInstance);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterDeviceNotification(IntPtr /* void * */ @Handle);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr /* HWND */ @hWnd, int @id);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterPointerInputTarget(IntPtr /* HWND */ @hwnd, uint /* POINTER_INPUT_TYPE */ @pointerType);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterPowerSettingNotification(IntPtr /* void * */ @Handle);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterSuspendResumeNotification(IntPtr /* void * */ @Handle);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UnregisterTouchWindow(IntPtr /* HWND */ @hwnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UpdateLayeredWindow(IntPtr /* HWND */ @hWnd, Hdc /* HDC */ @hdcDst, Point /* POINT * */ @pptDst, Size /* SIZE * */ @psize, Hdc /* HDC */ @hdcSrc, Point /* POINT * */ @pptSrc, uint /* COLORREF */ @crKey, Blendfunction /* BLENDFUNCTION * */ @pblend, uint /* DWORD */ @dwFlags);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UpdateLayeredWindowIndirect(IntPtr /* HWND */ @hWnd, Updatelayeredwindowinfo /* const UPDATELAYEREDWINDOWINFO * */ @pULWInfo);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UpdateWindow(IntPtr /* HWND */ @hWnd);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool UserHandleGrantAccess(IntPtr /* void * */ @hUserHandle, IntPtr /* void * */ @hJob, bool @bGrant);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ValidateRect(IntPtr /* HWND */ @hWnd, Rect /* const RECT * */ @lpRect);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool ValidateRgn(IntPtr /* HWND */ @hWnd, Hrgn /* HRGN */ @hRgn);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern short /* SHORT */ VkKeyScan(char /* WCHAR */ @ch);
    
        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern short /* SHORT */ VkKeyScanEx(char /* WCHAR */ @ch, Hkl /* HKL */ @dwhkl);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern uint /* DWORD */ WaitForInputIdle(IntPtr /* void * */ @hProcess, uint /* DWORD */ @dwMilliseconds);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool WaitMessage();
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ WindowFromDC(Hdc /* HDC */ @hDC);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ WindowFromPhysicalPoint(Point /* POINT */ @Point);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr /* HWND */ WindowFromPoint(Point /* POINT */ @Point);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool WinHelp(IntPtr /* HWND */ @hWndMain, IntPtr /* const wchar_t * */ @lpszHelp, uint /* UINT */ @uCommand, ulong /* ULONG_PTR */ @dwData);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int wsprintf(IntPtr /* wchar_t * */ @, IntPtr /* const wchar_t * */ @);
    
        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int wvsprintf(IntPtr /* wchar_t * */ @, IntPtr /* const wchar_t * */ @, IntPtr /* char * */ @arglist);
    }
}
