using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    /// <summary>
    /// Theme colors
    /// </summary>
    public static class OUIColor
    {
        /// <summary>
        /// Blue
        /// </summary>
        public static readonly Color Blue = Color.FromArgb(80, 160, 255);

        /// <summary>
        /// Green
        /// </summary>
        public static readonly Color Green = Color.FromArgb(110, 190, 40);

        /// <summary>
        /// Red
        /// </summary>
        public static readonly Color Red = Color.FromArgb(230, 80, 80);

        /// <summary>
        /// Gray
        /// </summary>
        public static readonly Color Gray = Color.FromArgb(140, 140, 140);

        /// <summary>
        /// Orange
        /// </summary>
        public static readonly Color Orange = Color.FromArgb(220, 155, 40);

        /// <summary>
        /// Layui Green
        /// </summary>
        public static readonly Color LayuiGreen = Color.FromArgb(0, 150, 136);

        /// <summary>
        /// Layui Red
        /// </summary>
        public static readonly Color LayuiRed = Color.FromArgb(255, 87, 34);

        /// <summary>
        /// Layui Orange
        /// </summary>
        public static readonly Color LayuiOrange = Color.FromArgb(255, 184, 0);

        /// <summary>
        /// Layui Cyan
        /// </summary>
        public static readonly Color LayuiCyan = Color.FromArgb(46, 57, 79);

        /// <summary>
        /// Layui Blue
        /// </summary>
        public static readonly Color LayuiBlue = Color.FromArgb(69, 149, 255);

        /// <summary>
        /// Layui Black
        /// </summary>
        public static readonly Color LayuiBlack = Color.FromArgb(52, 55, 66);

        /// <summary>
        /// Dark Blue
        /// </summary>
        public static readonly Color DarkBlue = Color.FromArgb(14, 30, 63);

        /// <summary>
        /// White
        /// </summary>
        public static readonly Color White = Color.White;

        /// <summary>
        /// Black
        /// </summary>
        public static readonly Color Black = Color.Black;

        /// <summary>
        /// Purple
        /// </summary>
        public static readonly Color Purple = Color.FromArgb(102, 58, 183);

        /// <summary>
        /// Light Purple
        /// </summary>
        public static readonly Color LightPurple = Color.FromArgb(250, 238, 255);

        /// <summary>
        /// Transparent
        /// </summary>
        public static readonly Color Transparent = Color.Transparent;

        /// <summary>
        /// Light Blue
        /// </summary>
        public static readonly Color LightBlue = Color.FromArgb(235, 243, 255);

        /// <summary>
        /// Light Green
        /// </summary>
        public static readonly Color LightGreen = Color.FromArgb(239, 248, 232);

        /// <summary>
        /// Light Red
        /// </summary>
        public static readonly Color LightRed = Color.FromArgb(251, 238, 238);

        /// <summary>
        /// Light Gray
        /// </summary>
        public static readonly Color LightGray = Color.FromArgb(242, 242, 244);

        /// <summary>
        /// Light Orange
        /// </summary>
        public static readonly Color LightOrange = Color.FromArgb(251, 245, 233);

        /// <summary>
        /// Medium Blue
        /// </summary>
        public static readonly Color RegularBlue = Color.FromArgb(216, 233, 255);

        /// <summary>
        /// Medium Green
        /// </summary>
        public static readonly Color RegularGreen = Color.FromArgb(224, 242, 210);

        /// <summary>
        /// Medium Red
        /// </summary>
        public static readonly Color RegularRed = Color.FromArgb(248, 222, 222);

        /// <summary>
        /// Medium Gray
        /// </summary>
        public static readonly Color RegularGray = Color.FromArgb(230, 230, 232);

        /// <summary>
        /// Medium Orange
        /// </summary>
        public static readonly Color RegularOrange = Color.FromArgb(247, 234, 210);
    }

    /// <summary>
    /// Disabled colors
    /// </summary>
    public static class OUIDisableColor
    {
        /// <summary>
        /// Fill color
        /// </summary>
        public static readonly Color Fill = UIFontColor.Plain;

        /// <summary>
        /// Font color
        /// </summary>
        public static readonly Color Fore = UIFontColor.Regular;
    }

    /// <summary>
    /// Font colors
    /// </summary>
    public static class OUIFontColor
    {
        /// <summary>
        /// Primary color
        /// </summary>
        public static readonly Color Primary = Color.FromArgb(48, 48, 48);

        /// <summary>
        /// Regular color
        /// </summary>
        public static readonly Color Regular = Color.FromArgb(96, 96, 96);

        /// <summary>
        /// Secondary color
        /// </summary>
        public static readonly Color Secondary = Color.FromArgb(144, 144, 144);

        /// <summary>
        /// Other color
        /// </summary>
        public static readonly Color Plain = Color.Silver;

        /// <summary>
        /// White
        /// </summary>
        public static readonly Color White = Color.FromArgb(248, 248, 248);
    }

    /// <summary>
    /// Border colors
    /// </summary>
    public static class UIRectColorColor
    {
        /// <summary>
        /// Primary color
        /// </summary>
        public static readonly Color Primary = Color.FromArgb(0xDC, 0xDF, 0xE6);

        /// <summary>
        /// Regular color
        /// </summary>
        public static readonly Color Regular = Color.FromArgb(0xE4, 0xE7, 0xED);

        /// <summary>
        /// Secondary color
        /// </summary>
        public static readonly Color Secondary = Color.FromArgb(0xEB, 0xEE, 0xF5);

        /// <summary>
        /// Other color
        /// </summary>
        public static readonly Color Plain = Color.FromArgb(0xF2, 0xF6, 0xFC);
    }

    /// <summary>
    /// Background colors
    /// </summary>
    public static class UIBackgroundColor
    {
        /// <summary>
        /// White
        /// </summary>
        public static readonly Color White = UIColor.White;

        /// <summary>
        /// Black
        /// </summary>
        public static readonly Color Black = UIColor.Black;

        /// <summary>
        /// Transparent color
        /// </summary>
        public static readonly Color Transparent = Color.Transparent;
    }

    public static class UIStyleHelper
    {
        /// <summary>
        /// Theme color palette
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        public static UIBaseStyle Colors(this OrcaUI.WinForms.Style.OUIThemes style)
        {
            return OUIThemes.GetStyleColor(style);
        }

        public static bool IsCustom(this OUIThemes style)
        {
            return style.Equals(OUIThemes.Custom);
        }

        public static bool IsValid(this OUIThemes style)
        {
            return (int)style > 0;
        }

        public static void SetChildUIStyle(Control ctrl, OUIThemes style)
        {
            List<Control> controls = ctrl.GetUIStyleControls("IStyleInterface");
            foreach (var control in controls)
            {
                if (control is IStyleInterface item && item.Style == OUIThemes.Inherited)
                {
                    if (item is UIPage uipage && uipage.Parent is TabPage tabpage)
                    {
                        TabControl tabControl = tabpage.Parent as TabControl;
                        if (tabControl.SelectedTab == tabpage)
                        {
                            item.SetInheritedStyle(style);
                        }
                    }
                    else
                    {
                        item.SetInheritedStyle(style);
                    }
                }
            }

            FieldInfo[] fieldInfo = ctrl.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var info in fieldInfo)
            {
                if (info.FieldType.Name == "UIContextMenuStrip")
                {
                    UIContextMenuStrip context = (UIContextMenuStrip)info.GetValue(ctrl);
                    if (context != null && context.Style == UIStyle.Inherited)
                    {
                        context.SetInheritedStyle(style);
                    }
                }
            }
        }

        public static void SetChildCustomStyle(this Control ctrl, UIStyle style)
        {
            List<Control> controls = ctrl.GetUIStyleControls("IStyleInterface");
            foreach (var control in controls)
            {
                if (control is IStyleInterface item)
                {
                    if (item is UIPage uipage && uipage.Parent is TabPage tabpage)
                    {
                        TabControl tabControl = tabpage.Parent as TabControl;
                        if (tabControl.SelectedTab == tabpage)
                        {
                            item.SetStyleColor(style.Colors());
                            item.Style = UIStyle.Custom;
                        }
                    }
                    else
                    {
                        item.SetStyleColor(style.Colors());
                        item.Style = UIStyle.Custom;
                    }
                }
            }

            FieldInfo[] fieldInfo = ctrl.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var info in fieldInfo)
            {
                if (info.FieldType.Name == "UIContextMenuStrip")
                {
                    UIContextMenuStrip item = (UIContextMenuStrip)info.GetValue(ctrl);
                    if (item != null)
                    {
                        item.SetStyleColor(style.Colors());
                        item.Style = UIStyle.Custom;
                    }
                }
            }
        }

        /// <summary>
        /// Finds a list of controls that implement a specific interface
        /// </summary>
        /// <param name="ctrl">Container control</param>
        /// <param name="interfaceName">Interface name</param>
        /// <returns>List of controls</returns>
        public static List<Control> GetUIStyleControls(this Control ctrl, string interfaceName)
        {
            List<Control> values = new List<Control>();

            foreach (Control obj in ctrl.Controls)
            {
                if (obj.GetType().GetInterface(interfaceName) != null)
                {
                    values.Add(obj);
                }

                if (obj is UIPage) continue;

                if (obj.Controls.Count > 0)
                {
                    values.AddRange(obj.GetUIStyleControls(interfaceName));
                }
            }

            return values;
        }
    }






}
