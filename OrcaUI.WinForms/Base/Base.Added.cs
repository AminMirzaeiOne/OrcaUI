using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace OrcaUI.WinForms.Base
{
    public static class Base32Helper
    {
        public static readonly IntPtr TRUE = new(1);

        public static IOrderedEnumerable<string> NatualOrdering(this IEnumerable<string> strs) =>
            strs?.OrderBy(s => s, new NatualOrderingComparer());

        public static IntPtr IntPtr(this int value) => new(value);

        public static int GetPidByProcessName(string processName) =>
            Process.GetProcessesByName(processName).FirstOrDefault()?.Id ?? 0;

        public static void ReadMemoryValue(string processName, int baseAddress, ref byte[] buffer)
        {
            try
            {
                IntPtr byteAddress = Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0);
                int pid = GetPidByProcessName(processName);
                if (pid == 0) return;

                IntPtr hProcess = Kernel.OpenProcess(0x1F0FFF, false, pid);
                Kernel.ReadProcessMemory(hProcess, (IntPtr)baseAddress, byteAddress, buffer.Length, IntPtr.Zero);
                Kernel.CloseHandle(hProcess);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static int WriteMemoryValue(string processName, int baseAddress, byte[] buffer)
        {
            try
            {
                IntPtr byteAddress = Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0);
                int pid = GetPidByProcessName(processName);
                if (pid == 0) return 0;

                IntPtr hProcess = Kernel.OpenProcess(0x1F0FFF, false, pid);
                int count = 0;
                Kernel.WriteProcessMemory(hProcess, (IntPtr)baseAddress, byteAddress, buffer.Length, ref count);
                Kernel.CloseHandle(hProcess);
                return count;
            }
            catch
            {
                return 0;
            }
        }
    }

    public partial class GDI
    {
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject", CharSet = CharSet.Ansi)]
        public static extern int DeleteObject(int hObject);

        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr window, IntPtr hdcBlt, uint nFlags);
    }

    public partial class User
    {
        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr wnd, int hRgn, bool bRedraw);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool bRepaint = true);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PtInRect([In] ref RECT lprc, Point pt);

        [DllImport("user32.dll", EntryPoint = "PostMessage")]
        public static extern bool PostMessage(IntPtr handle, int msg, uint wParam, uint lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        [DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();

        [DllImport("user32.dll", SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustWindowRectEx(ref RECT lpRect, int dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu, int dwExStyle);

    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct NCCALCSIZE_PARAMS
    {
        public RECT rgrc0, rgrc1, rgrc2;
        public WINDOWPOS lppos;
    }

    public class Dwm
    {
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;

            public MARGINS(int left, int right, int top, int bottom)
            {
                leftWidth = left;
                rightWidth = right;
                topHeight = top;
                bottomHeight = bottom;
            }
        }
    }

    public partial class AdvApi
    {
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccesss, out IntPtr TokenHandle);


        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LookupPrivilegeValue(string lpSystemName, string lpName,
            [MarshalAs(UnmanagedType.Struct)] ref LUID lpLuid);

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AdjustTokenPrivileges(IntPtr TokenHandle,
            [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges,
            [MarshalAs(UnmanagedType.Struct)] ref TOKEN_PRIVILEGES NewState,
            uint BufferLength, IntPtr PreviousState, uint ReturnLength);
    }

    [Flags]
    public enum ExecutionState : uint
    {
        /// <summary>
        /// Forces the system to be in the working state by resetting the system idle timer.
        /// </summary>
        SystemRequired = 0x01,

        /// <summary>
        /// Forces the display to be on by resetting the display idle timer.
        /// </summary>
        DisplayRequired = 0x02,

        /// <summary>
        /// This value is not supported. If <see cref="UserPresent"/> is combined with other esFlags values, the call will fail and none of the specified states will be set.
        /// </summary>
        [Obsolete("This value is not supported.")]
        UserPresent = 0x04,

        /// <summary>
        /// Enables away mode. This value must be specified with <see cref="Continuous"/>.
        /// <para />
        /// Away mode should be used only by media-recording and media-distribution applications that must perform critical background processing on desktop computers while the computer appears to be sleeping.
        /// </summary>
        AwaymodeRequired = 0x40,

        /// <summary>
        /// Informs the system that the state being set should remain in effect until the next call that uses <see cref="Continuous"/> and one of the other state flags is cleared.
        /// </summary>
        Continuous = 0x80000000,
    }

    public partial class Kernel
    {
        [DllImport("kernel32")]
        public static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern Int32 CompareStringEx(string localeName, int flags, string str1, int count1, string str2,
                int count2, IntPtr versionInformation, IntPtr reserved, int param);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, IntPtr dwThreadId);

        [DllImport("kernel32")]
        public static extern bool WritePrivateProfileString(byte[] section, byte[] key, byte[] val, string filePath);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(byte[] section, byte[] key, byte[] def, byte[] retVal, int size, string filePath);

        //Opens an existing process object and returns the process handle
        [DllImportAttribute("kernel32.dll", EntryPoint = "OpenProcess")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        //Read byte set data from the specified memory
        [DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int nSize, IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CopyFile(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);
    }

    internal class NatualOrderingComparer : IComparer<string>
    {
        private const int SORT_DIGITSASNUMBERS = 0x00000008;
        private const string LOCALE_NAME_INVARIANT = "";
        private readonly string _locale;

        public NatualOrderingComparer() : this(CultureInfo.CurrentCulture) { }

        public NatualOrderingComparer(CultureInfo cultureInfo) =>
            _locale = cultureInfo.IsNeutralCulture ? LOCALE_NAME_INVARIANT : cultureInfo.Name;

        public int Compare(string x, string y) =>
            Kernel.CompareStringEx(_locale, SORT_DIGITSASNUMBERS, x, x.Length, y, y.Length, IntPtr.Zero, IntPtr.Zero, 0) - 2;
    }

    public partial class WinMM
    {
        [DllImport("winmm.dll")]
        public static extern int timeSetEvent(int uDelay, int uResolution, TimerSetEventCallback fptc, int dwUser, int uFlags);

        public delegate void TimerSetEventCallback(int uTimerID, uint uMsg, uint dwUser, UIntPtr dw1, UIntPtr dw2);
    }


}
