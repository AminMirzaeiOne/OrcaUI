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


}
