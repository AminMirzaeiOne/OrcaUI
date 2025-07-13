using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Base
{
    public struct DRAGINFO
    {
        public int uSize;
        public POINT pt;
        public int fNC;
        public string lpFileList;
        public int grfKeyState;
    }

    public struct APPBARDATA
    {
        public int cbSize;
        public HWND hwnd;
        public int uCallbackMessage;
        public int uEdge;
        public RECT rc;
        public int lParam;
    }

    public struct SHFILEOPSTRUCT
    {
        public HWND hwnd;
        public int wFunc;
        public string pFrom;
        public string pTo;
        public short fFlags;
        public int fAnyOperationsAborted;
        public HANDLE hNameMappings;
        public string lpszProgressTitle;
    }

    public struct NOTIFYICONDATA
    {
        public int cbSize;
        public HWND hwnd;
        public int uID;
        public int uFlags;
        public int uCallbackMessage;
        public HANDLE hIcon;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] public string szTip;
    }

    public struct SHFILEINFO
    {
        public HANDLE hIcon;
        public int iIcon;
        public int dwAttributes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Kernel.MAX_PATH)] public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)] public string szTypeName;
    }


}
