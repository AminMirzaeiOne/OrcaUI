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

    public struct LOGPEN
    {
        public int lopnStyle;
        public POINT lopnWidth;
        public uint lopnColor;
    }

    public struct PALETTEENTRY
    {
        public byte peRed;
        public byte peGreen;
        public byte peBlue;
        public byte peFlags;
    }

    public struct LOGPALETTE
    {
        public short palVersion;
        public short palNumEntries;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] public PALETTEENTRY palPalEntry;
    }

    public struct LOGFONT
    {
        public int lfHeight;
        public int lfWidth;
        public int lfEscapement;
        public int lfOrientation;
        public int lfWeight;
        public byte lfItalic;
        public byte lfUnderline;
        public byte lfStrikeOut;
        public byte lfCharSet;
        public byte lfOutPrecision;
        public byte lfClipPrecision;
        public byte lfQuality;
        public byte lfPitchAndFamily;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string lfFaceName;
    }

    public struct TT_HHEA
    {
        public uint Version;
        public Int16 Ascender;
        public Int16 Descender;
        public Int16 LineGap;
        public UInt16 advanceWidthMax;
        public Int16 minLeftSideBearing;
        public Int16 minRightSideBearing;
        public Int16 xMaxExtent;
        public Int16 caretSlopeRise;
        public Int16 caretSlopeRun;
        public Int16 caretOffset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] public Int16[] reserved;
        public Int16 metricDataFormat;
        public UInt16 numberOfHMetrics;
    }

    public struct PANOSE
    {
        public byte bFamilyType;
        public byte bSerifStyle;
        public byte bWeight;
        public byte bProportion;
        public byte bContrast;
        public byte bStrokeVariation;
        public byte bArmStyle;
        public byte bLetterform;
        public byte bMidline;
        public byte bXHeight;
    }

    public struct DEVMODE
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string dmDeviceName;
        public short dmSpecVersion;
        public short dmDriverVersion;
        public short dmSize;
        public short dmDriverExtra;
        public int dmFields;
        public short dmOrientation;
        public short dmPaperSize;
        public short dmPaperLength;
        public short dmPaperWidth;
        public short dmScale;
        public short dmCopies;
        public short dmDefaultSource;
        public short dmPrintQuality;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = GDI.CCHFORMNAME)] public string dmFormName;
        public short dmUnusedPadding;
        public int dmBitsPerPel;
        public int dmPelsWidth;
        public int dmPelsHeight;
        public int dmDisplayFlags;
        public int dmDisplayFrequency;
    }

    public struct RGNDATAHEADER
    {
        public int dwSize;
        public int iType;
        public int nCount;
        public int nRgnSize;
        public RECT rcBound;
    }

    public struct RGNDATA
    {
        public RGNDATAHEADER rdh;
        public byte Buffer;
    }

    public struct ABC
    {
        public int abcA;
        public int abcB;
        public int abcC;
    }

    public struct ABCFLOAT
    {
        public double abcfA;
        public double abcfB;
        public double abcfC;
    }

    public struct POLYTEXT
    {
        public int x;
        public int y;
        public int n;
        public string lpStr;
        public int uiFlags;
        public RECT rcl;
        public int pdx;
    }

    public struct FIXED
    {
        public short fract;
        public short Value;
    }

    public struct MAT2
    {
        public FIXED eM11;
        public FIXED eM12;
        public FIXED eM21;
        public FIXED eM22;
    }

    public struct GLYPHMETRICS
    {
        public int gmBlackBoxX;
        public int gmBlackBoxY;
        public POINT gmptGlyphOrigin;
        public short gmCellIncX;
        public short gmCellIncY;
    }

    public struct POINTFX
    {
        public FIXED x;
        public FIXED y;
    }

    public struct RASTERIZER_STATUS
    {
        public short nSize;
        public short wFlags;
        public short nLanguageID;
    }

    public struct COLORADJUSTMENT
    {
        public short caSize;
        public short caFlags;
        public short caIlluminantIndex;
        public short caRedGamma;
        public short caGreenGamma;
        public short caBlueGamma;
        public short caReferenceBlack;
        public short caReferenceWhite;
        public short caContrast;
        public short caBrightness;
        public short caColorfulness;
        public short caRedGreenTint;
    }


}
