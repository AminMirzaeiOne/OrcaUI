using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        internal static void SetDPIScaleFont<T>(this T control, float fontSize) where T : Control, IStyleInterface
        {
            if (!UIDPIScale.NeedSetDPIFont()) return;
            control.Font = DPIScaleFont(control.Font, fontSize);
        }

        internal static List<IStyleInterface> GetAllDPIScaleControls(this Control control)
        {
            var list = new List<IStyleInterface>();
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is IStyleInterface istyleCtrl) list.Add(istyleCtrl);

                if (ctrl is UITextBox) continue;
                if (ctrl is UIDropControl) continue;
                if (ctrl is UIListBox) continue;
                if (ctrl is UIImageListBox) continue;
                if (ctrl is UIPagination) continue;
                if (ctrl is UIRichTextBox) continue;
                if (ctrl is UITreeView) continue;
                if (ctrl is UITransfer) continue;

                if (ctrl.Controls.Count > 0)
                {
                    list.AddRange(GetAllDPIScaleControls(ctrl));
                }
            }

            return list;
        }


    }
}
