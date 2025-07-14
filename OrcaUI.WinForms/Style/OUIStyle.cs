using System;
using System.Collections.Generic;
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
}
