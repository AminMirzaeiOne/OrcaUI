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

    public struct CHAR_INFO
    {
        public short Char;
        public short Attributes;
    }

    public struct CONSOLE_SCREEN_BUFFER_INFO
    {
        public COORD dwSize;
        public COORD dwCursorPosition;
        public short wAttributes;
        public SMALL_RECT srWindow;
        public COORD dwMaximumWindowSize;
    }

    public struct CONSOLE_CURSOR_INFO
    {
        public int dwSize;
        public int bVisible;
    }

    public struct SID_IDENTIFIER_AUTHORITY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)] public byte[] Value;
    }

    public struct SID_AND_ATTRIBUTES
    {
        public int Sid;
        public int Attributes;
    }

    public struct WIN32_FIND_DATA
    {
        public int dwFileAttributes;
        public FILETIME ftCreationTime;
        public FILETIME ftLastAccessTime;
        public FILETIME ftLastWriteTime;
        public int nFileSizeHigh;
        public int nFileSizeLow;
        public int dwReserved0;
        public int dwReserved1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Kernel.MAX_PATH)]
        public string cFileName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public string cAlternate;
    }

    public struct COMMCONFIG
    {
        public int dwSize;
        public short wVersion;
        public short wReserved;
        public DCB dcbx;
        public int dwProviderSubType;
        public int dwProviderOffset;
        public int dwProviderSize;
        public byte wcProviderData;
    }

    public struct SERVICE_STATUS
    {
        public int dwServiceType;
        public int dwCurrentState;
        public int dwControlsAccepted;
        public int dwWin32ExitCode;
        public int dwServiceSpecificExitCode;
        public int dwCheckPoint;
        public int dwWaitHint;
    }

    public struct ENUM_SERVICE_STATUS
    {
        public string lpServiceName;
        public string lpDisplayName;
        public SERVICE_STATUS ServiceStatus;
    }

    public struct QUERY_SERVICE_LOCK_STATUS
    {
        public int fIsLocked;
        public string lpLockOwner;
        public int dwLockDuration;
    }

    public struct QUERY_SERVICE_CONFIG
    {
        public int dwServiceType;
        public int dwStartType;
        public int dwErrorControl;
        public string lpBinaryPathName;
        public string lpLoadOrderGroup;
        public int dwTagId;
        public string lpDependencies;
        public string lpServiceStartName;
        public string lpDisplayName;
    }

    public struct SERVICE_TABLE_ENTRY
    {
        public string lpServiceName;
        public int lpServiceProc;
    }

    public struct LARGE_INTEGER
    {
        public int lowpart;
        public int highpart;
    }

    public struct OSVERSIONINFO
    {
        public int dwOSVersionInfoSize;
        public int dwMajorVersion;
        public int dwMinorVersion;
        public int dwBuildNumber;
        public int dwPlatformId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] public string szCSDVersion;
    }

    public struct SYSTEM_POWER_STATUS
    {
        public byte ACLineStatus;
        public byte BatteryFlag;
        public byte BatteryLifePercent;
        public byte Reserved1;
        public int BatteryLifeTime;
        public int BatteryFullLifeTime;
    }

    public partial class AdvApi
    {
        [DllImport("AdvApi32")] public static extern int ImpersonateLoggedOnUser(HANDLE hToken);
        [DllImport("advapi32")] public static extern int IsTextUnicode(IntPtr lpBuffer, int cb, ref int lpi);
        [DllImport("advapi32")] public static extern int LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref int phToken);
        [DllImport("advapi32")] public static extern int NotifyChangeEventLog(HANDLE hEventLog, HANDLE hEvent);
        [DllImport("advapi32")] public static extern int SetThreadToken(int Thread, int Token);
        [DllImport("advapi32")] public static extern Byte GetSidSubAuthorityCount(IntPtr pSid);
        [DllImport("advapi32")] public static extern SID_IDENTIFIER_AUTHORITY GetSidIdentifierAuthority(IntPtr pSid);
        [DllImport("advapi32")] public static extern int AbortSystemShutdown(string lpMachineName);
        [DllImport("advapi32")] public static extern int AccessCheck(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int ClientToken, int DesiredAccess, GENERIC_MAPPING GenericMapping, PRIVILEGE_SET PrivilegeSet, int PrivilegeSetLength, int GrantedAccess, int Status);
        [DllImport("advapi32")] public static extern int AccessCheckAndAuditAlarm(string SubsystemName, IntPtr HandleId, string ObjectTypeName, string ObjectName, SECURITY_DESCRIPTOR SecurityDescriptor, int DesiredAccess, GENERIC_MAPPING GenericMapping, int ObjectCreation, int GrantedAccess, int AccessStatus, ref int pfGenerateOnClose);
        [DllImport("advapi32")] public static extern int AddAccessAllowedAce(ref ACL pAcl, int dwAceRevision, int AccessMask, IntPtr pSid);
        [DllImport("advapi32")] public static extern int AddAccessDeniedAce(ref ACL pAcl, int dwAceRevision, int AccessMask, IntPtr pSid);
        [DllImport("advapi32")] public static extern int AddAce(ref ACL pAcl, int dwAceRevision, int dwStartingAceIndex, IntPtr pAceList, int nAceListLength);
        [DllImport("advapi32")] public static extern int AddAuditAccessAce(ref ACL pAcl, int dwAceRevision, int dwAccessMask, IntPtr pSid, int bAuditSuccess, int bAuditFailure);
        [DllImport("advapi32")] public static extern int AdjustTokenGroups(int TokenHandle, int ResetToDefault, TOKEN_GROUPS NewState, int BufferLength, TOKEN_GROUPS PreviousState, int ReturnLength);
        [DllImport("advapi32")] public static extern int AdjustTokenPrivileges(int TokenHandle, int DisableAllPrivileges, TOKEN_PRIVILEGES NewState, int BufferLength, TOKEN_PRIVILEGES PreviousState, int ReturnLength);
        [DllImport("advapi32")] public static extern int AllocateAndInitializeSid(ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority, Byte nSubAuthorityCount, int nSubAuthority0, int nSubAuthority1, int nSubAuthority2, int nSubAuthority3, int nSubAuthority4, int nSubAuthority5, int nSubAuthority6, int nSubAuthority7, ref int lpPSid);
        [DllImport("advapi32")] public static extern int AllocateLocallyUniqueId(LARGE_INTEGER Luid);
        [DllImport("advapi32")] public static extern int AreAllAccessesGranted(int GrantedAccess, int DesiredAccess);
        [DllImport("advapi32")] public static extern int AreAnyAccessesGranted(int GrantedAccess, int DesiredAccess);
        [DllImport("advapi32")] public static extern int BackupEventLog(HANDLE hEventLog, string lpBackupFileName);
        [DllImport("advapi32")] public static extern int ChangeServiceConfig(HANDLE hService, int dwServiceType, int dwStartType, int dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, ref int lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword, string lpDisplayName);
        [DllImport("advapi32")] public static extern int ClearEventLog(HANDLE hEventLog, string lpBackupFileName);
        [DllImport("advapi32")] public static extern int CloseEventLog(HANDLE hEventLog);
        [DllImport("advapi32")] public static extern int CloseServiceHandle(HANDLE hSCObject);
        [DllImport("advapi32")] public static extern int ControlService(HANDLE hService, int dwControl, ref SERVICE_STATUS lpServiceStatus);
        [DllImport("advapi32")] public static extern int CopySid(int nDestinationSidLength, IntPtr pDestinationSid, IntPtr pSourceSid);
        [DllImport("advapi32")] public static extern int CreatePrivateObjectSecurity(ref SECURITY_DESCRIPTOR ParentDescriptor, SECURITY_DESCRIPTOR CreatorDescriptor, SECURITY_DESCRIPTOR NewDescriptor, int IsDirectoryObject, int Token, GENERIC_MAPPING GenericMapping);
        [DllImport("advapi32")] public static extern int CreateProcessAsUser(HANDLE hToken, string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, int bInheritHandles, int dwCreationFlags, string lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);
        [DllImport("advapi32")] public static extern int CreateService(HANDLE hSCManager, string lpServiceName, string lpDisplayName, int dwDesiredAccess, int dwServiceType, int dwStartType, int dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, ref int lpdwTagId, string lpDependencies, string lp, string lpPassword);
        [DllImport("advapi32")] public static extern int DeleteAce(ref ACL pAcl, int dwAceIndex);
        [DllImport("advapi32")] public static extern int DeleteService(HANDLE hService);
        [DllImport("advapi32")] public static extern int DeregisterEventSource(HANDLE hEventLog);
        [DllImport("advapi32")] public static extern int DestroyPrivateObjectSecurity(ref SECURITY_DESCRIPTOR ObjectDescriptor);
        [DllImport("advapi32")] public static extern int DuplicateToken(int ExistingTokenHandle, short ImpersonationLevel, int DuplicateTokenHandle);
        [DllImport("advapi32")] public static extern int EnumDependentServices(HANDLE hService, int dwServiceState, ref ENUM_SERVICE_STATUS lpServices, int cbBufSize, ref int pcbBytesNeeded, ref int lpServicesReturned);
        [DllImport("advapi32")] public static extern int EnumServicesStatus(HANDLE hSCManager, int dwServiceType, int dwServiceState, ref ENUM_SERVICE_STATUS lpServices, int cbBufSize, ref int pcbBytesNeeded, ref int lpServicesReturned, ref int lpResumeHandle);
        [DllImport("advapi32")] public static extern int EqualPrefixSid(IntPtr pSid1, IntPtr pSid2);
        [DllImport("advapi32")] public static extern int EqualSid(IntPtr pSid1, IntPtr pSid2);
        [DllImport("advapi32")] public static extern int FindFirstFreeAce(ref ACL pAcl, ref int pAce);
        [DllImport("advapi32")] public static extern int GetAce(ref ACL pAcl, int dwAceIndex, IntPtr pAce);
        [DllImport("advapi32")] public static extern int GetAclInformation(ref ACL pAcl, IntPtr pAclInformation, int nAclInformationLength, short dwAclInformationClass);
        [DllImport("advapi32")] public static extern int GetFileSecurity(string lpFileName, int RequestedInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor, int nLength, ref int lpnLengthNeeded);
        [DllImport("advapi32")] public static extern int GetKernelObjectSecurity(HANDLE handle, int RequestedInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor, int nLength, ref int lpnLengthNeeded);
        [DllImport("advapi32")] public static extern int GetLengthSid(IntPtr pSid);
        [DllImport("advapi32")] public static extern int GetNumberOfEventLogRecords(HANDLE hEventLog, int NumberOfRecords);
        [DllImport("advapi32")] public static extern int GetOldestEventLogRecord(HANDLE hEventLog, int OldestRecord);
        [DllImport("advapi32")] public static extern int GetPrivateObjectSecurity(ref SECURITY_DESCRIPTOR ObjectDescriptor, int SecurityInformation, SECURITY_DESCRIPTOR ResultantDescriptor, int DescriptorLength, int ReturnLength);
        [DllImport("advapi32")] public static extern int GetSecurityDescriptorControl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, short pControl, ref int lpdwRevision);
        [DllImport("advapi32")] public static extern int GetSecurityDescriptorDacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, ref int lpbDaclPresent, ref ACL pDacl, ref int lpbDaclDefaulted);
        [DllImport("advapi32")] public static extern int GetSecurityDescriptorGroup(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pGroup, ref int lpbGroupDefaulted);
        [DllImport("advapi32")] public static extern int GetSecurityDescriptorLength(ref SECURITY_DESCRIPTOR pSecurityDescriptor);
        [DllImport("advapi32")] public static extern int GetSecurityDescriptorOwner(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pOwner, ref int lpbOwnerDefaulted);
        [DllImport("advapi32")] public static extern int GetSecurityDescriptorSacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, ref int lpbSaclPresent, ref ACL pSacl, ref int lpbSaclDefaulted);
        [DllImport("advapi32")] public static extern int GetServiceDisplayName(HANDLE hSCManager, string lpServiceName, StringBuilder lpDisplayName, ref int cchBuffer);
        [DllImport("advapi32")] public static extern int GetServiceKeyName(HANDLE hSCManager, string lpDisplayName, StringBuilder lpServiceName, ref int cchBuffer);
        [DllImport("advapi32")] public static extern int GetSidLengthRequired(Byte nSubAuthorityCount);
        [DllImport("advapi32")] public static extern int GetSidSubAuthority(IntPtr pSid, int nSubAuthority);
        [DllImport("advapi32")] public static extern int GetTokenInformation(int TokenHandle, short TokenInformationClass, IntPtr TokenInformation, int TokenInformationLength, int ReturnLength);
        [DllImport("advapi32")] public static extern int GetUserName(StringBuilder lpBuffer, int nSize);
        [DllImport("advapi32")] public static extern int ImpersonateNamedPipeClient(HANDLE hNamedPipe);
        [DllImport("advapi32")] public static extern int ImpersonateSelf(short ImpersonationLevel);
        [DllImport("advapi32")] public static extern int InitializeAcl(ref ACL pAcl, int nAclLength, int dwAclRevision);
        [DllImport("advapi32")] public static extern int InitializeSecurityDescriptor(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int dwRevision);
        [DllImport("advapi32")] public static extern int InitializeSid(IntPtr Sid, ref SID_IDENTIFIER_AUTHORITY pIdentifierAuthority, Byte nSubAuthorityCount);
        [DllImport("advapi32")] public static extern int InitiateSystemShutdown(string lpMachineName, string lpMessage, int dwTimeout, int bForceAppsClosed, int bRebootAfterShutdown);
        [DllImport("advapi32")] public static extern int IsValidAcl(ref ACL pAcl);
        [DllImport("advapi32")] public static extern int IsValidSecurityDescriptor(ref SECURITY_DESCRIPTOR pSecurityDescriptor);
        [DllImport("advapi32")] public static extern int IsValidSid(IntPtr pSid);
        [DllImport("advapi32")] public static extern int LockServiceDatabase(HANDLE hSCManager);
        [DllImport("advapi32")] public static extern int LookupAccountName(string lpSystemName, string lpAccountName, int Sid, int cbSid, string ReferencedDomainName, int cbReferencedDomainName, int peUse);
        [DllImport("advapi32")] public static extern int LookupAccountSid(string lpSystemName, IntPtr Sid, string name, int cbName, string ReferencedDomainName, int cbReferencedDomainName, int peUse);
        [DllImport("advapi32")] public static extern int LookupPrivilegeDisplayName(string lpSystemName, string lpName, string lpDisplayName, int cbDisplayName, ref int lpLanguageID);
        [DllImport("advapi32")] public static extern int LookupPrivilegeName(string lpSystemName, ref LARGE_INTEGER lpLuid, string lpName, int cbName);
        [DllImport("advapi32")] public static extern int LookupPrivilegeValue(string lpSystemName, string lpName, ref LARGE_INTEGER lpLuid);
        [DllImport("advapi32")] public static extern int MakeAbsoluteSD(ref SECURITY_DESCRIPTOR pSelfRelativeSecurityDescriptor, ref SECURITY_DESCRIPTOR pAbsoluteSecurityDescriptor, ref int lpdwAbsoluteSecurityDescriptorSize, ref ACL pDacl, ref int lpdwDaclSize, ref ACL pSacl, ref int lpdwSaclSize, IntPtr pOwner, ref int lpdwOwnerSize, IntPtr pPrimaryGroup, ref int lpdwPrimaryGroupSize);
        [DllImport("advapi32")] public static extern int MakeSelfRelativeSD(ref SECURITY_DESCRIPTOR pAbsoluteSecurityDescriptor, ref SECURITY_DESCRIPTOR pSelfRelativeSecurityDescriptor, ref int lpdwBufferLength);
        [DllImport("advapi32")] public static extern int NotifyBootConfigStatus(int BootAcceptable);
        [DllImport("advapi32")] public static extern int ObjectCloseAuditAlarm(string SubsystemName, IntPtr HandleId, int GenerateOnClose);
        [DllImport("advapi32")] public static extern int ObjectPrivilegeAuditAlarm(string SubsystemName, IntPtr HandleId, int ClientToken, int DesiredAccess, PRIVILEGE_SET Privileges, int AccessGranted);
        [DllImport("advapi32")] public static extern int OpenBackupEventLog(string lpUNCServerName, string lpFileName);
        [DllImport("advapi32")] public static extern int OpenEventLog(string lpUNCServerName, string lpSourceName);
        [DllImport("advapi32")] public static extern int OpenSCManager(string lpMachineName, string lpDatabaseName, int dwDesiredAccess);
        [DllImport("advapi32")] public static extern int OpenService(HANDLE hSCManager, string lpServiceName, int dwDesiredAccess);
        [DllImport("advapi32")] public static extern int OpenThreadToken(int ThreadHandle, int DesiredAccess, int OpenAsSelf, int TokenHandle);
        [DllImport("advapi32")] public static extern int PrivilegeCheck(int ClientToken, PRIVILEGE_SET RequiredPrivileges, ref int pfResult);
        [DllImport("advapi32")] public static extern int PrivilegedServiceAuditAlarm(string SubsystemName, string ServiceName, int ClientToken, PRIVILEGE_SET Privileges, int AccessGranted);
        [DllImport("advapi32")] public static extern int QueryServiceConfig(HANDLE hService, ref QUERY_SERVICE_CONFIG lpServiceConfig, int cbBufSize, ref int pcbBytesNeeded);
        [DllImport("advapi32")] public static extern int QueryServiceLockStatus(HANDLE hSCManager, ref QUERY_SERVICE_LOCK_STATUS lpLockStatus, int cbBufSize, ref int pcbBytesNeeded);
        [DllImport("advapi32")] public static extern int QueryServiceObjectSecurity(HANDLE hService, int dwSecurityInformation, IntPtr lpSecurityDescriptor, int cbBufSize, ref int pcbBytesNeeded);
        [DllImport("advapi32")] public static extern int QueryServiceStatus(HANDLE hService, ref SERVICE_STATUS lpServiceStatus);
        [DllImport("advapi32")] public static extern int ReadEventLog(HANDLE hEventLog, int dwReadFlags, int dwRecordOffset, ref EVENTLOGRECORD lpBuffer, int nNumberOfBytesToRead, ref int pnBytesRead, ref int pnMinNumberOfBytesNeeded);
        [DllImport("advapi32")] public static extern int RegCloseKey(HANDLE hKey);
        [DllImport("advapi32")] public static extern int RegConnectRegistry(string lpMachineName, HANDLE hKey, ref int phkResult);
        [DllImport("advapi32")] public static extern int RegCreateKey(HANDLE hKey, string lpSubKey, ref int phkResult);
        [DllImport("advapi32")] public static extern int RegCreateKeyEx(HANDLE hKey, string lpSubKey, int Reserved, string lpClass, int dwOptions, int samDesired, ref SECURITY_ATTRIBUTES lpSecurityAttributes, ref int phkResult, ref int lpdwDisposition);
        [DllImport("advapi32")] public static extern int RegDeleteKey(HANDLE hKey, string lpSubKey);
        [DllImport("advapi32")] public static extern int RegDeleteValue(HANDLE hKey, string lpValueName);
        [DllImport("advapi32")] public static extern int RegEnumKey(HANDLE hKey, int dwIndex, string lpName, int cbName);
        [DllImport("advapi32")] public static extern int RegEnumKeyEx(HANDLE hKey, int dwIndex, string lpName, ref int lpcbName, ref int lpReserved, string lpClass, ref int lpcbClass, ref FILETIME lpftLastWriteTime);
        [DllImport("advapi32")] public static extern int RegEnumValue(HANDLE hKey, int dwIndex, string lpValueName, ref int lpcbValueName, ref int lpReserved, ref int lpType, Byte lpData, ref int lpcbData);
        [DllImport("advapi32")] public static extern int RegFlushKey(HANDLE hKey);
        [DllImport("advapi32")] public static extern int RegGetKeySecurity(HANDLE hKey, int SecurityInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor, ref int lpcbSecurityDescriptor);
        [DllImport("advapi32")] public static extern int RegLoadKey(HANDLE hKey, string lpSubKey, string lpFile);
        [DllImport("advapi32")] public static extern int RegNotifyChangeKeyValue(HANDLE hKey, int bWatchSubtree, int dwNotifyFilter, HANDLE hEvent, int fAsynchronus);
        [DllImport("advapi32")] public static extern int RegOpenKey(HANDLE hKey, string lpSubKey, ref int phkResult);
        [DllImport("advapi32")] public static extern int RegOpenKeyEx(HANDLE hKey, string lpSubKey, int ulOptions, int samDesired, ref int phkResult);
        [DllImport("advapi32")] public static extern int RegQueryInfoKey(HANDLE hKey, string lpClass, ref int lpcbClass, ref int lpReserved, ref int lpcSubKeys, ref int lpcbMaxSubKeyLen, ref int lpcbMaxClassLen, ref int lpcValues, ref int lpcbMaxValueNameLen, ref int lpcbMaxValueLen, ref int lpcbSecurityDescriptor, ref FILETIME lpftLastWriteTime);
        [DllImport("advapi32")] public static extern int RegQueryValue(HANDLE hKey, string lpSubKey, string lpValue, ref int lpcbValue);
        [DllImport("advapi32")] public static extern int RegQueryValueEx(HANDLE hKey, string lpValueName, ref int lpReserved, ref int lpType, IntPtr lpData, ref int lpcbData);
        [DllImport("advapi32")] public static extern int RegReplaceKey(HANDLE hKey, string lpSubKey, string lpNewFile, string lpOldFile);
        [DllImport("advapi32")] public static extern int RegRestoreKey(HANDLE hKey, string lpFile, int dwFlags);
        [DllImport("advapi32")] public static extern int RegSaveKey(HANDLE hKey, string lpFile, ref SECURITY_ATTRIBUTES lpSecurityAttributes);
        [DllImport("advapi32")] public static extern int RegSetKeySecurity(HANDLE hKey, int SecurityInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor);
        [DllImport("advapi32")] public static extern int RegSetValue(HANDLE hKey, string lpSubKey, int dwType, string lpData, int cbData);
        [DllImport("advapi32")] public static extern int RegSetValueEx(HANDLE hKey, string lpValueName, int Reserved, int dwType, IntPtr lpData, int cbData);
        [DllImport("advapi32")] public static extern int RegUnLoadKey(HANDLE hKey, string lpSubKey);
        [DllImport("advapi32")] public static extern int RegisterEventSource(string lpUNCServerName, string lpSourceName);
        [DllImport("advapi32")] public static extern int RegisterServiceCtrlHandler(string lpServiceName, ref int lpHandlerProc);
        [DllImport("advapi32")] public static extern int ReportEvent(HANDLE hEventLog, int wType, int wCategory, int dwEventID, IntPtr lpUserSid, int wNumStrings, int dwDataSize, ref int lpStrings, IntPtr lpRawData);
        [DllImport("advapi32")] public static extern int RevertToSelf();
        [DllImport("advapi32")] public static extern int SetAclInformation(ref ACL pAcl, IntPtr pAclInformation, int nAclInformationLength, short dwAclInformationClass);
        [DllImport("advapi32")] public static extern int SetFileSecurity(string lpFileName, int SecurityInformation, ref SECURITY_DESCRIPTOR pSecurityDescriptor);
        [DllImport("advapi32")] public static extern int SetKernelObjectSecurity(HANDLE handle, int SecurityInformation, SECURITY_DESCRIPTOR SecurityDescriptor);
        [DllImport("advapi32")] public static extern int SetPrivateObjectSecurity(int SecurityInformation, SECURITY_DESCRIPTOR ModificationDescriptor, SECURITY_DESCRIPTOR ObjectsSecurityDescriptor, GENERIC_MAPPING GenericMapping, int Token);
        [DllImport("advapi32")] public static extern int SetSecurityDescriptorDacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int bDaclPresent, ref ACL pDacl, int bDaclDefaulted);
        [DllImport("advapi32")] public static extern int SetSecurityDescriptorGroup(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pGroup, int bGroupDefaulted);
        [DllImport("advapi32")] public static extern int SetSecurityDescriptorOwner(ref SECURITY_DESCRIPTOR pSecurityDescriptor, IntPtr pOwner, int bOwnerDefaulted);
        [DllImport("advapi32")] public static extern int SetSecurityDescriptorSacl(ref SECURITY_DESCRIPTOR pSecurityDescriptor, int bSaclPresent, ref ACL pSacl, int bSaclDefaulted);
        [DllImport("advapi32")] public static extern int SetServiceObjectSecurity(HANDLE hService, int dwSecurityInformation, IntPtr lpSecurityDescriptor);
        [DllImport("advapi32")] public static extern int SetServiceStatus(HANDLE hServiceStatus, ref SERVICE_STATUS lpServiceStatus);
        [DllImport("advapi32")] public static extern int SetTokenInformation(int TokenHandle, short TokenInformationClass, IntPtr TokenInformation, int TokenInformationLength);
        [DllImport("advapi32")] public static extern int StartService(HANDLE hService, int dwNumServiceArgs, ref int lpServiceArgVectors);
        [DllImport("advapi32")] public static extern int StartServiceCtrlDispatcher(ref SERVICE_TABLE_ENTRY lpServiceStartTable);
        [DllImport("advapi32")] public static extern int UnlockServiceDatabase(IntPtr ScLock);
        [DllImport("advapi32")] public static extern void FreeSid(IntPtr pSid);
        [DllImport("advapi32")] public static extern void MapGenericMask(int AccessMask, GENERIC_MAPPING GenericMapping);
        [DllImport("advapi32")] public static extern int GetUserNameW(Byte lpBuffer, int nSize);
        [DllImport("advapi32")] public static extern int OpenProcessToken(int ProcessHandle, int DesiredAccess, int TokenHandle);
    }

}
