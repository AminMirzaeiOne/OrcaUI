using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Theme
{
    public interface IZoomScale
    {
        /// <summary>
        /// Set the control zoom scale
        /// </summary>
        /// <param name="scale">Zoom scale</param>
        void SetZoomScale(float scale);

        /// <summary>
        /// Position of the control in its container before zoom
        /// </summary>
        Rectangle ZoomScaleRect { get; set; }

        /// <summary>
        /// Disable the control from following form zoom
        /// </summary>
        bool ZoomScaleDisabled { get; set; }
    }
}
