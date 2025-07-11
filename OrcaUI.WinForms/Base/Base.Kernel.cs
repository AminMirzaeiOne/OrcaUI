using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

    public struct COMMPROP
    {
        public short wPacketLength;
        public short wPacketVersion;
        public int dwServiceMask;
        public int dwReserved1;
        public int dwMaxTxQueue;
        public int dwMaxRxQueue;
        public int dwMaxBaud;
        public int dwProvSubType;
        public int dwProvCapabilities;
        public int dwSettableParams;
        public int dwSettableBaud;
        public short wSettableData;
        public short wSettableStopParity;
        public int dwCurrentTxQueue;
        public int dwCurrentRxQueue;
        public int dwProvSpec1;
        public int dwProvSpec2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public short[] wcProvChar;
    }


}
