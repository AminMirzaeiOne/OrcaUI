using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Base
{
    public struct XFORM
    {
        public double eM11;
        public double eM12;
        public double eM21;
        public double eM22;
        public double eDx;
        public double eDy;
    }

    public struct BITMAP
    {
        public int bmType;
        public int bmWidth;
        public int bmHeight;
        public int bmWidthBytes;
        public short bmPlanes;
        public short bmBitsPixel;
        public int bmBits;
    }

    public struct RGBTRIPLE
    {
        public byte rgbtBlue;
        public byte rgbtGreen;
        public byte rgbtRed;
    }

    public struct RGBQUAD
    {
        public byte rgbBlue;
        public byte rgbGreen;
        public byte rgbRed;
        public byte rgbReserved;
    }

    public struct BITMAPCOREHEADER
    {
        public int bcSize;
        public short bcWidth;
        public short bcHeight;
        public short bcPlanes;
        public short bcBitCount;
    }

    public struct BITMAPINFOHEADER
    {
        public int biSize;
        public int biWidth;
        public int biHeight;
        public short biPlanes;
        public short biBitCount;
        public int biCompression;
        public int biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public int biClrUsed;
        public int biClrImportant;
    }

    public struct BITMAPINFO
    {
        public BITMAPINFOHEADER bmiHeader;
        public RGBQUAD bmiColors;
    }

    public struct BITMAPCOREINFO
    {
        public BITMAPCOREHEADER bmciHeader;
        public RGBTRIPLE bmciColors;
    }

    public struct BITMAPFILEHEADER
    {
        public short bfType;
        public int bfSize;
        public short bfReserved1;
        public short bfReserved2;
        public int bfOffBits;
    }

    public struct HANDLETABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public int objectHandle;
    }

    public struct METARECORD
    {
        public int rdSize;
        public short rdFunction;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public short rdParm;
    }

    public struct METAFILEPICT
    {
        public int mm;
        public int xExt;
        public int yExt;
        public HANDLE hMF;
    }

    public struct ENHMETARECORD
    {
        public int iType;
        public int nSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public int dParm;
    }

    public struct ENHMETAHEADER
    {
        public int iType;
        public int nSize;
        public RECT rclBounds;
        public RECT rclFrame;
        public int dSignature;
        public int nVersion;
        public int nBytes;
        public int nRecords;
        public short nHandles;
        public short sReserved;
        public int nDescription;
        public int offDescription;
        public int nPalEntries;
        public SIZE szlDevice;
        public SIZE szlMillimeters;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct TEXTMETRICW
    {
        public int tmHeight;
        public int tmAscent;
        public int tmDescent;
        public int tmInternalLeading;
        public int tmExternalLeading;
        public int tmAveCharWidth;
        public int tmMaxCharWidth;
        public int tmWeight;
        public int tmOverhang;
        public int tmDigitizedAspectX;
        public int tmDigitizedAspectY;
        public ushort tmFirstChar;
        public ushort tmLastChar;
        public ushort tmDefaultChar;
        public ushort tmBreakChar;
        public byte tmItalic;
        public byte tmUnderlined;
        public byte tmStruckOut;
        public byte tmPitchAndFamily;
        public byte tmCharSet;
    }

    public struct NEWTEXTMETRIC
    {
        public int tmHeight;
        public int tmAscent;
        public int tmDescent;
        public int tmInternalLeading;
        public int tmExternalLeading;
        public int tmAveCharWidth;
        public int tmMaxCharWidth;
        public int tmWeight;
        public int tmOverhang;
        public int tmDigitizedAspectX;
        public int tmDigitizedAspectY;
        public byte tmFirstChar;
        public byte tmLastChar;
        public byte tmDefaultChar;
        public byte tmBreakChar;
        public byte tmItalic;
        public byte tmUnderlined;
        public byte tmStruckOut;
        public byte tmPitchAndFamily;
        public byte tmCharSet;
        public int ntmFlags;
        public int ntmSizeEM;
        public int ntmCellHeight;
        public int ntmAveWidth;
    }

    public struct LOGBRUSH
    {
        public int lbStyle;
        public uint lbColor;
        public int lbHatch;
    }


}
