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

    public struct BY_HANDLE_FILE_INFORMATION
    {
        public int dwFileAttributes;
        public FILETIME ftCreationTime;
        public FILETIME ftLastAccessTime;
        public FILETIME ftLastWriteTime;
        public int dwVolumeSerialNumber;
        public int nFileSizeHigh;
        public int nFileSizeLow;
        public int nNumberOfLinks;
        public int nFileIndexHigh;
        public int nFileIndexLow;
    }

    public struct MEMORY_BASIC_INFORMATION
    {
        public int BaseAddress;
        public int AllocationBase;
        public int AllocationProtect;
        public int RegionSize;
        public int State;
        public int Protect;
        public int lType;
    }

    public struct EVENTLOGRECORD
    {
        public int Length;
        public int Reserved;
        public int RecordNumber;
        public int TimeGenerated;
        public int TimeWritten;
        public int EventID;
        public short EventType;
        public short NumStrings;
        public short EventCategory;
        public short ReservedFlags;
        public int ClosingRecordNumber;
        public int StringOffset;
        public int UserSidLength;
        public int UserSidOffset;
        public int DataLength;
        public int DataOffset;
    }

    public struct TOKEN_GROUPS
    {
        public int GroupCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public SID_AND_ATTRIBUTES[] Groups;
    }

    public struct TOKEN_PRIVILEGES
    {
        public int PrivilegeCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public LUID_AND_ATTRIBUTES[] Privileges;
    }

    public struct CONTEXT
    {
        public double FltF0;
        public double FltF1;
        public double FltF2;
        public double FltF3;
        public double FltF4;
        public double FltF5;
        public double FltF6;
        public double FltF7;
        public double FltF8;
        public double FltF9;
        public double FltF10;
        public double FltF11;
        public double FltF12;
        public double FltF13;
        public double FltF14;
        public double FltF15;
        public double FltF16;
        public double FltF17;
        public double FltF18;
        public double FltF19;
        public double FltF20;
        public double FltF21;
        public double FltF22;
        public double FltF23;
        public double FltF24;
        public double FltF25;
        public double FltF26;
        public double FltF27;
        public double FltF28;
        public double FltF29;
        public double FltF30;
        public double FltF31;
        public double IntV0;
        public double IntT0;
        public double IntT1;
        public double IntT2;
        public double IntT3;
        public double IntT4;
        public double IntT5;
        public double IntT6;
        public double IntT7;
        public double IntS0;
        public double IntS1;
        public double IntS2;
        public double IntS3;
        public double IntS4;
        public double IntS5;
        public double IntFp;
        public double IntA0;
        public double IntA1;
        public double IntA2;
        public double IntA3;
        public double IntA4;
        public double IntA5;
        public double IntT8;
        public double IntT9;
        public double IntT10;
        public double IntT11;
        public double IntRa;
        public double IntT12;
        public double IntAt;
        public double IntGp;
        public double IntSp;
        public double IntZero;
        public double Fpcr;
        public double SoftFpcr;
        public double Fir;
        public int Psr;
        public int ContextFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] public int[] Fill;
    }

    public struct EXCEPTION_POINTERS
    {
        public EXCEPTION_RECORD pExceptionRecord;
        public CONTEXT ContextRecord;
    }

    public struct LDT_ENTRY
    {
        public short LimitLow;
        public short BaseLow;
        public int HighWord;
    }

    public struct TIME_ZONE_INFORMATION
    {
        public int Bias;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public short[] StandardName;
        public SYSTEMTIME StandardDate;
        public int StandardBias;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public short[] DaylightName;
        public SYSTEMTIME DaylightDate;
        public int DaylightBias;
    }

    public struct STARTUPINFO
    {
        public int cb;
        public string lpReserved;
        public string lpDesktop;
        public string lpTitle;
        public int dwX;
        public int dwY;
        public int dwXSize;
        public int dwYSize;
        public int dwXCountChars;
        public int dwYCountChars;
        public int dwFillAttribute;
        public int dwFlags;
        public short wShowWindow;
        public short cbReserved2;
        public int lpReserved2;
        public HANDLE hStdInput;
        public HANDLE hStdOutput;
        public HANDLE hStdError;
    }

    public struct CPINFO
    {
        public int MaxCharSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Kernel.MAX_DEFAULTCHAR)] public byte[] DefaultChar;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Kernel.MAX_LEADBYTES)] public byte[] LeadByte;
    }

    public struct NUMBERFMT
    {
        public int NumDigits;
        public int LeadingZero;
        public int Grouping;
        public string lpDecimalSep;
        public string lpThousandSep;
        public int NegativeOrder;
    }

    public struct CURRENCYFMT
    {
        public int NumDigits;
        public int LeadingZero;
        public int Grouping;
        public string lpDecimalSep;
        public string lpThousandSep;
        public int NegativeOrder;
        public int PositiveOrder;
        public string lpCurrencySymbol;
    }

    public struct COORD
    {
        public short x;
        public short y;
    }

    public struct SMALL_RECT
    {
        public short Left;
        public short Top;
        public short Right;
        public short Bottom;
    }

}
