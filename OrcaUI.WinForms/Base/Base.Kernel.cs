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

    public struct COMSTAT
    {
        public int fBitFields;
        public int cbInQue;
        public int cbOutQue;
    }

    public struct DCB
    {
        public int DCBlength;
        public int BaudRate;
        public int fBitFields;
        public short wReserved;
        public short XonLim;
        public short XoffLim;
        public byte ByteSize;
        public byte Parity;
        public byte StopBits;
        public byte XonChar;
        public byte XoffChar;
        public byte ErrorChar;
        public byte EofChar;
        public byte EvtChar;
        public short wReserved1;
    }

    public struct COMMTIMEOUTS
    {
        public int ReadIntervalTimeout;
        public int ReadTotalTimeoutMultiplier;
        public int ReadTotalTimeoutConstant;
        public int WriteTotalTimeoutMultiplier;
        public int WriteTotalTimeoutConstant;
    }

    public struct SYSTEM_INFO
    {
        public int dwOemID;
        public int dwPageSize;
        public int lpMinimumApplicationAddress;
        public int lpMaximumApplicationAddress;
        public int dwActiveProcessorMask;
        public int dwNumberOrfProcessors;
        public int dwProcessorType;
        public int dwAllocationGranularity;
        public int dwReserved;
    }

    public struct MEMORYSTATUS
    {
        public int dwLength;
        public int dwMemoryLoad;
        public int dwTotalPhys;
        public int dwAvailPhys;
        public int dwTotalPageFile;
        public int dwAvailPageFile;
        public int dwTotalVirtual;
        public int dwAvailVirtual;
    }

    public struct GENERIC_MAPPING
    {
        public int GenericRead;
        public int GenericWrite;
        public int GenericExecute;
        public int GenericAll;
    }

    public struct LUID
    {
        public int LowPart;
        public int HighPart;
    }

    public struct LUID_AND_ATTRIBUTES
    {
        public LUID pLuid;
        public int Attributes;
    }

    public struct ACL
    {
        public byte AclRevision;
        public byte Sbz1;
        public short AclSize;
        public short AceCount;
        public short Sbz2;
    }

    public struct ACE_HEADER
    {
        public byte AceType;
        public byte AceFlags;
        public int AceSize;
    }

    public struct SECURITY_DESCRIPTOR
    {
        public byte Revision;
        public byte Sbz1;
        public int Control;
        public int Owner;
        public int Group;
        public ACL Sacl;
        public ACL Dacl;
    }

    public struct PRIVILEGE_SET
    {
        public int PrivilegeCount;
        public int Control;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public LUID_AND_ATTRIBUTES[] Privilege;
    }

    public struct EXCEPTION_RECORD
    {
        public int ExceptionCode;
        public int ExceptionFlags;
        public int pExceptionRecord;
        public int ExceptionAddress;
        public int NumberParameters;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)] public int[] ExceptionInformation;
    }

    public struct OFSTRUCT
    {
        public byte cBytes;
        public byte fFixedDisk;
        public short nErrCode;
        public short Reserved1;
        public short Reserved2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)] public byte[] szPathName;
    }

    public struct CRITICAL_SECTION
    {
        public int pDebugInfo;
        public int LockCount;
        public int RecursionCount;
        public int pOwningThread;
        public int pLockSemaphore;
        public int Reserved;
    }

}
