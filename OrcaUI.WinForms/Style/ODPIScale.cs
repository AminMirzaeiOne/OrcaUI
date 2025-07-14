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
    }
}
