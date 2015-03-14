using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace User32Dll
{
    public enum SECURITY_IMPERSONATION_LEVEL /* _SECURITY_IMPERSONATION_LEVEL */
    {
        Anonymous = 0,
        Identification = 1,
        Impersonation = 2,
        Delegation = 3,
    }
    
    public enum DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY /* DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY */
    {
        OTHER = -1,
        HD15 = 0,
        SVIDEO = 1,
        COMPOSITE_VIDEO = 2,
        COMPONENT_VIDEO = 3,
        DVI = 4,
        HDMI = 5,
        LVDS = 6,
        D_JPN = 8,
        SDI = 9,
        DISPLAYPORT_EXTERNAL = 10,
        DISPLAYPORT_EMBEDDED = 11,
        UDI_EXTERNAL = 12,
        UDI_EMBEDDED = 13,
        SDTVDONGLE = 14,
        MIRACAST = 15,
        INTERNAL = -2147483648,
        FORCE_UINT32 = -1,
    }
    
    public enum DISPLAYCONFIG_SCANLINE_ORDERING /* DISPLAYCONFIG_SCANLINE_ORDERING */
    {
        UNSPECIFIED = 0,
        PROGRESSIVE = 1,
        INTERLACED = 2,
        INTERLACED_UPPERFIELDFIRST = 2,
        INTERLACED_LOWERFIELDFIRST = 3,
        FORCE_UINT32 = -1,
    }
    
    public enum DISPLAYCONFIG_SCALING /* DISPLAYCONFIG_SCALING */
    {
        IDENTITY = 1,
        CENTERED = 2,
        STRETCHED = 3,
        ASPECTRATIOCENTEREDMAX = 4,
        CUSTOM = 5,
        PREFERRED = 128,
        FORCE_UINT32 = -1,
    }
    
    public enum DISPLAYCONFIG_ROTATION /* DISPLAYCONFIG_ROTATION */
    {
        IDENTITY = 1,
        ROTATE90 = 2,
        ROTATE180 = 3,
        ROTATE270 = 4,
        FORCE_UINT32 = -1,
    }
    
    public enum DISPLAYCONFIG_MODE_INFO_TYPE /* DISPLAYCONFIG_MODE_INFO_TYPE */
    {
        SOURCE = 1,
        TARGET = 2,
        FORCE_UINT32 = -1,
    }
    
    public enum DISPLAYCONFIG_PIXELFORMAT /* DISPLAYCONFIG_PIXELFORMAT */
    {
        PIXELFORMAT_8BPP = 1,
        PIXELFORMAT_16BPP = 2,
        PIXELFORMAT_24BPP = 3,
        PIXELFORMAT_32BPP = 4,
        PIXELFORMAT_NONGDI = 5,
        PIXELFORMAT_FORCE_UINT32 = -1,
    }
    
    public enum DISPLAYCONFIG_TOPOLOGY_ID /* DISPLAYCONFIG_TOPOLOGY_ID */
    {
        INTERNAL = 1,
        CLONE = 2,
        EXTEND = 4,
        EXTERNAL = 8,
        FORCE_UINT32 = -1,
    }
    
    public enum DISPLAYCONFIG_DEVICE_INFO_TYPE /* DISPLAYCONFIG_DEVICE_INFO_TYPE */
    {
        GET_SOURCE_NAME = 1,
        GET_TARGET_NAME = 2,
        GET_TARGET_PREFERRED_MODE = 3,
        GET_ADAPTER_NAME = 4,
        SET_TARGET_PERSISTENCE = 5,
        GET_TARGET_BASE_TYPE = 6,
        FORCE_UINT32 = -1,
    }
}
