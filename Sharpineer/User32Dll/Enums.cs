using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace User32Dll
{
    public enum SecurityImpersonationLevel /* _SECURITY_IMPERSONATION_LEVEL */
    {
        Anonymous = 0,
        Identification = 1,
        Impersonation = 2,
        Delegation = 3,
    }
    
    public enum PointerButtonChangeType /* tagPOINTER_BUTTON_CHANGE_TYPE */
    {
        None = 0,
        FirstbuttonDown = 1,
        FirstbuttonUp = 2,
        SecondbuttonDown = 3,
        SecondbuttonUp = 4,
        ThirdbuttonDown = 5,
        ThirdbuttonUp = 6,
        FourthbuttonDown = 7,
        FourthbuttonUp = 8,
        FifthbuttonDown = 9,
        FifthbuttonUp = 10,
    }
    
    public enum FeedbackType /* tagFEEDBACK_TYPE */
    {
        TouchContactvisualization = 1,
        PenBarrelvisualization = 2,
        PenTap = 3,
        PenDoubletap = 4,
        PenPressandhold = 5,
        PenRighttap = 6,
        TouchTap = 7,
        TouchDoubletap = 8,
        TouchPressandhold = 9,
        TouchRighttap = 10,
        GesturePressandtap = 11,
        Max = -1,
    }
    
    public enum PointerDeviceType /* tagPOINTER_DEVICE_TYPE */
    {
        IntegratedPen = 1,
        ExternalPen = 2,
        Touch = 3,
        TouchPad = 4,
        Max = -1,
    }
    
    public enum PointerDeviceCursorType /* tagPOINTER_DEVICE_CURSOR_TYPE */
    {
        Unknown = 0,
        Tip = 1,
        Eraser = 2,
        Max = -1,
    }
    
    [Flags]
    public enum InputMessageDeviceType /* tagINPUT_MESSAGE_DEVICE_TYPE */
    {
        Unavailable = 0,
        Keyboard = 1,
        Mouse = 2,
        Touch = 4,
        Pen = 8,
        Touchpad = 16,
    }
    
    [Flags]
    public enum InputMessageOriginId /* tagINPUT_MESSAGE_ORIGIN_ID */
    {
        Unavailable = 0,
        Hardware = 1,
        Injected = 2,
        System = 4,
    }
    
    [Flags]
    public enum ArState /* tagAR_STATE */
    {
        Enabled = 0,
        Disabled = 1,
        Suppressed = 2,
        Remotesession = 4,
        Multimon = 8,
        Nosensor = 16,
        NotSupported = 32,
        Docked = 64,
        Laptop = 128,
    }
    
    [Flags]
    public enum OrientationPreference /* ORIENTATION_PREFERENCE */
    {
        None = 0,
        Landscape = 1,
        Portrait = 2,
        LandscapeFlipped = 4,
        PortraitFlipped = 8,
    }
}
