using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcaUI.WinForms.Theme
{
    /// <summary>
    /// Menu theme color
    /// </summary>
    public enum OUIMenuTheme
    {
        /// <summary>
        /// Custom
        /// </summary>
        [Description("Custom")]
        Custom,

        /// <summary>
        /// Black
        /// </summary>
        [Description("Black")]
        Black,

        /// <summary>
        /// White
        /// </summary>
        [Description("White")]
        White
    }

    public abstract class OUIMenuColor
    {
        public abstract OUIMenuTheme Theme { get; }

        // Background color of the menu
        public virtual Color BackColor => Color.FromArgb(56, 56, 56);

        // Color when a menu item is selected
        public virtual Color SelectedColor => Color.FromArgb(36, 36, 36);

        // Optional second selected color for gradients or effects
        public virtual Color SelectedColor2 => Color.FromArgb(36, 36, 36);

        // Foreground color for unselected menu items
        public virtual Color UnSelectedForeColor => Color.FromArgb(240, 240, 240);

        // Hover color for mouseover effects
        public virtual Color HoverColor => Color.FromArgb(76, 76, 76);

        // Secondary background color
        public virtual Color SecondBackColor => Color.FromArgb(66, 66, 66);

        public override string ToString()
        {
            return Style.Description();
        }
    }

    public class OUIMenuCustomColor : OUIMenuColor
    {
        public override OUIMenuTheme Theme => OUIMenuTheme.Custom;
    }

    public class OUIMenuBlackColor : OUIMenuColor
    {
        public override OUIMenuStyle Style => OUIMenuStyle.Black;
    }

    public class OUIMenuWhiteColor : OUIMenuColor
    {
        public override OUIMenuStyle Style => OUIMenuStyle.White;

        public override Color BackColor => Color.FromArgb(240, 240, 240);

        public override Color SelectedColor => Color.FromArgb(250, 250, 250);

        public override Color SelectedColor2 => Color.FromArgb(250, 250, 250);

        public override Color UnSelectedForeColor => OUIFontColor.Primary;

        public override Color HoverColor => Color.FromArgb(230, 230, 230);

        public override Color SecondBackColor => Color.FromArgb(235, 235, 235);
    }

}
