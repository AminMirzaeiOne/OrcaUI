using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Base
{
    public struct OVERLAPPED
    {
        public int Internal;
        public int InternalHigh;
        public int offset;
        public int OffsetHigh;
        public HANDLE hEvent;
    }

    public struct SECURITY_ATTRIBUTES
    {
        public int nLength;
        public int lpSecurityDescriptor;
        public int bInheritHandle;
    }

    public struct PROCESS_INFORMATION
    {
        public HANDLE hProcess;
        public HANDLE hThread;
        public int dwProcessId;
        public int dwThreadId;
    }


}
