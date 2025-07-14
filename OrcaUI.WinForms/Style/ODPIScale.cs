using OrcaUI.WinForms.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Style
{
    public static class ODPIScale
    {
        private static float dpiScale = -1;

        public static float DPIScale => UIStyles.GlobalFont ? SystemDPIScale * 100.0f / UIStyles.GlobalFontScale : SystemDPIScale;

        public static float SystemDPIScale
        {
            get
            {
                if (dpiScale < 0)
                {
                    using Bitmap bmp = new Bitmap(1, 1);
                    using Graphics g = bmp.Graphics();
                    dpiScale = g.DpiX / 96.0f;
                }

                return dpiScale;
            }
        }

        public static bool NeedSetDPIFont() => UIStyles.DPIScale && (SystemDPIScale > 1 || UIStyles.GlobalFont);


        internal static Font DPIScaleFont(this Font font, float fontSize)
        {
            if (fontSize <= 0) return font;
            if (UIStyles.DPIScale)
            {
                if (UIStyles.GlobalFont)
                {
                    byte gdiCharSet = UIStyles.GetGdiCharSet(UIStyles.GlobalFontName);
                    return new Font(UIStyles.GlobalFontName, fontSize / DPIScale, font.Style, font.Unit, gdiCharSet);
                }
                else
                {
                    return new Font(font.FontFamily, fontSize / DPIScale, font.Style, font.Unit, font.GdiCharSet);
                }
            }
            else
            {
                return new Font(font.FontFamily, fontSize, font.Style, font.Unit, font.GdiCharSet);
            }
        }


    }
}
