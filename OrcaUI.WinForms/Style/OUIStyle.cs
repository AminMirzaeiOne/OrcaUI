using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Style
{
    public interface IStyleInterface
    {
        UIStyle Style { get; set; }

        string Version { get; }

        string TagString { get; set; }

        void SetStyleColor(UIBaseStyle uiColor);

        //void SetStyle(UIStyle style);
        void SetInheritedStyle(UIStyle style);

        void SetDPIScale();
    }

    /// <summary>
    /// Theme Style
    /// </summary>
    public enum OUIThemes
    {
        /// <summary>
        /// Inherit from global theme
        /// </summary>
        [Description("Inherited Global Theme")]
        Inherited = -1,

        /// <summary>
        /// Custom
        /// </summary>
        [Description("Custom")]
        Custom = 0,

        /// <summary>
        /// Blue
        /// </summary>
        [Description("Blue")]
        Blue = 1,

        /// <summary>
        /// Green
        /// </summary>
        [Description("Green")]
        Green = 2,

        /// <summary>
        /// Orange
        /// </summary>
        [Description("Orange")]
        Orange = 3,

        /// <summary>
        /// Red
        /// </summary>
        [Description("Red")]
        Red = 4,

        /// <summary>
        /// Gray
        /// </summary>
        [Description("Gray")]
        Gray = 5,

        /// <summary>
        /// Purple
        /// </summary>
        [Description("Purple")]
        Purple = 6,

        [Description("LayuiGreen")]
        LayuiGreen = 7,

        [Description("LayuiRed")]
        LayuiRed = 8,

        [Description("LayuiOrange")]
        LayuiOrange = 9,

        /// <summary>
        /// Dark Blue
        /// </summary>
        [Description("DarkBlue")]
        DarkBlue = 101,

        /// <summary>
        /// Black
        /// </summary>
        [Description("Black")]
        Black = 102,

        /// <summary>
        /// Colorful
        /// </summary>
        [Description("Colorful")]
        Colorful = 999
    }



}
