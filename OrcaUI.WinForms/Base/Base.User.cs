using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Base
{
    public struct CBTACTIVATESTRUCT
    {
        public int fMouse;
        public HWND hwndActive;
    }

    public struct EVENTMSG
    {
        public int message;
        public int paramL;
        public int paramH;
        public int time;
        public HWND hwnd;
    }

    public struct WINDOWPOS
    {
        public HWND hwnd;
        public HWND hwndInsertAfter;
        public int x;
        public int y;
        public int cx;
        public int cy;
        public int flags;
    }

    public struct ACCEL
    {
        public byte fVirt;
        public short key;
        public short cmd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PAINTSTRUCT
    {
        public IntPtr hdc;
        public bool fErase;
        public RECT rcPaint;
        public bool fRestore;
        public bool fIncUpdate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] rgbReserved;
    }

    public struct CREATESTRUCT
    {
        public int lpCreateParams;
        public HANDLE hInstance;
        public HANDLE hMenu;
        public HWND hwndParent;
        public int cy;
        public int cx;
        public int y;
        public int x;
        public int style;
        public string lpszName;
        public string lpszClass;
        public int ExStyle;
    }

    public struct WINDOWPLACEMENT
    {
        public int Length;
        public int flags;
        public int showCmd;
        public POINT ptMinPosition;
        public POINT ptMaxPosition;
        public RECT rcNormalPosition;
    }

    public struct MSG
    {
        public HWND hwnd;
        public int message;
        public int wParam;
        public int lParam;
        public int time;
        public POINT pt;
    }

    public struct DLGTEMPLATE
    {
        public int style;
        public int dwExtendedStyle;
        public short cdit;
        public short x;
        public short y;
        public short cx;
        public short cy;
    }

    public struct ICONINFO
    {
        public int fIcon;
        public int xHotspot;
        public int yHotspot;
        public HANDLE hbmMask;
        public HANDLE hbmColor;
    }

    public struct SECURITY_QUALITY_OF_SERVICE
    {
        public int Length;
        public short Impersonationlevel;
        public short ContextTrackingMode;
        public int EffectiveOnly;
    }


    public struct CONVCONTEXT
    {
        public int cb;
        public int wFlags;
        public int wCountryID;
        public int iCodePage;
        public int dwLangID;
        public int dwSecurity;
        public SECURITY_QUALITY_OF_SERVICE qos;
    }

    public struct CONVINFO
    {
        public int cb;
        public HANDLE hUser;
        public HANDLE hConvPartner;
        public HANDLE hszSvcPartner;
        public HANDLE hszServiceReq;
        public HANDLE hszTopic;
        public HANDLE hszItem;
        public int wFmt;
        public int wType;
        public int wStatus;
        public int wConvst;
        public int wLastError;
        public HANDLE hConvList;
        public CONVCONTEXT ConvCtxt;
        public HWND hwnd;
        public HWND hwndPartner;
    }

    public struct DDEML_MSG_HOOK_DATA
    {
        public int uiLo;
        public int uiHi;
        public int cbData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public int Data;
    }

    public struct DRAWTEXTPARAMS
    {
        public int cbSize;
        public int iTabLength;
        public int iLeftMargin;
        public int iRightMargin;
        public int uiLengthDrawn;
    }

    public struct MENUITEMINFO
    {
        public int cbSize;
        public int fMask;
        public int fType;
        public int fState;
        public int wID;
        public HANDLE hSubMenu;
        public HANDLE hbmpChecked;
        public HANDLE hbmpUnchecked;
        public int dwItemData;
        public string dwTypeData;
        public int cch;
    }


}
