using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Theme
{
    public static class OUITexture
    {
        public static TextureBrush CreateTextureBrush(Image img)
        {
            TextureBrush tb = new TextureBrush(img);
            tb.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            return tb;
        }
    }
}
