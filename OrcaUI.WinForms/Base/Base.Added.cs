using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

}
