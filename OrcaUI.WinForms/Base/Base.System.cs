using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Base
{
    public struct RECT
    {
        public int Left, Top, Right, Bottom;

        public RECT(int left, int top, int right, int bottom) =>
            (Left, Top, Right, Bottom) = (left, top, right, bottom);

        public RECT(RECT rect) : this(rect.Left, rect.Top, rect.Right, rect.Bottom) { }

        public POINT TopLeft() => new(Left, Top);
        public POINT BottomRight() => new(Right, Bottom);

        public int Width
        {
            get => Right - Left;
            set => Right = Left + value;
        }

        public int Height
        {
            get => Bottom - Top;
            set => Bottom = Top + value;
        }

        public void Offset(int x, int y)
        {
            Left += x; Top += y;
            Right += x; Bottom += y;
        }

        public void Inflate(int x, int y)
        {
            Left -= x; Right += x;
            Top -= y; Bottom += y;
        }

        public void SetEmpty() => (Left, Top, Right, Bottom) = (0, 0, 0, 0);

        public void ReSet(RECT rect) =>
            (Left, Top, Right, Bottom) = (rect.Left, rect.Top, rect.Right, rect.Bottom);

        public void ReSetBounds(int x, int y, int w, int h) =>
            (Left, Top, Right, Bottom) = (x, y, x + w, y + h);
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X, Y;

        public POINT(int x, int y) => (X, Y) = (x, y);

        public void Offset(int x, int y)
        {
            X += x;
            Y += y;
        }
    }

    public struct SIZE
    {
        public int cx, cy;

        public SIZE(int x, int y) => (cx, cy) = (x, y);
    }

    public struct FILETIME
    {
        public int dwLowDateTime;
        public int dwHighDateTime;
    }

    public struct SYSTEMTIME
    {
        public short wYear;
        public short wMonth;
        public short wDayOfWeek;
        public short wDay;
        public short wHour;
        public short wMinute;
        public short wSecond;
        public short wMilliseconds;
    }



}
