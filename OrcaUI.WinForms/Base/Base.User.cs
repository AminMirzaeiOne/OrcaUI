using System;
using System.Collections.Generic;
using System.Linq;
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



}
