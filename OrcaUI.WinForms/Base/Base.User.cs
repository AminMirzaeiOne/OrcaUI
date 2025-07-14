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

    public struct SCROLLINFO
    {
        public int cbSize;    // The size in bytes of the SCROLLINFO structure itself
        public int fMask;     // fMask indicates which data to set or retrieve, e.g., SIF_ALL (all data members are valid), SIF_PAGE (nPage is valid), SIF_POS (nPos is valid), SIF_RANGE (nMin and nMax are valid), SIF_TRACKPOS (nTrackPos is valid)
        public int nMin;      // Minimum scroll position
        public int nMax;      // Maximum scroll position
        public int nPage;     // Page size
        public int nPos;      // Position of the scroll box (thumb)
        public int nTrackPos; // Current position of the scroll box while being dragged; cannot be set using SetScrollInfo

        public int ScrollMax => (nMax + 1 - nPage);
    }

    public struct MSGBOXPARAMS
    {
        public int cbSize;
        public HWND hwndOwner;
        public HANDLE hInstance;
        public string lpszText;
        public string lpszCaption;
        public int dwStyle;
        public string lpszIcon;
        public int dwContextHelpId;
        public int lpfnMsgBoxCallback;
        public int dwLanguageId;
    }

    public struct MONITORINFO
    {
        public uint cbSize;
        public RECT rcMonitor;
        public RECT rcWork;
        public uint dwFlags;
    }

    public delegate int FNHookProc(int nCode, int wParam, IntPtr lParam);

    public delegate int WNDPROC(IntPtr hWnd, int msg, int wParam, int lParam);

    public class WNDCLASS
    {
        public int style = 0;
        public WNDPROC lpfnWndProc = null;
        public int cbClsExtra = 0;
        public int cbWndExtra = 0;
        public IntPtr hInstance = IntPtr.Zero;
        public IntPtr hIcon = IntPtr.Zero;
        public IntPtr hCursor = IntPtr.Zero;
        public IntPtr hbrBackground = IntPtr.Zero;
        public string lpszMenuName = null;
        public string lpszClassName = null;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct WNDCLASSEX
    {
        [MarshalAs(UnmanagedType.U4)]
        public int cbSize;
        [MarshalAs(UnmanagedType.U4)]
        public int style;
        public IntPtr lpfnWndProc; // not WndProc
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public string lpszMenuName;
        public string lpszClassName;
        public IntPtr hIconSm;

        //Use this function to make a new one with cbSize already filled in.
        public static WNDCLASSEX Build()
        {
            var nw = new WNDCLASSEX();
            nw.cbSize = Marshal.SizeOf(typeof(WNDCLASSEX));
            return nw;
        }
    }

    public struct TPMPARAMS
    {
        public int cbSize;
        public RECT rcExclude;
    }


}
