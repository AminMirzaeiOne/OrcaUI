﻿using System;
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

    public static class OUIZoomScale
    {
        public static Rectangle Create(Control control)
        {
            if (control is IZoomScale ctrl)
            {
                if (ctrl.ZoomScaleRect.Width > 0 || ctrl.ZoomScaleRect.Height > 0)
                {
                    return ctrl.ZoomScaleRect;
                }
                else
                {
                    int Width = control.Width;
                    int Height = control.Height;
                    int XInterval = 0;
                    int YInterval = 0;
                    if (control.Parent != null)
                    {
                        if ((control.Anchor & AnchorStyles.Left) == AnchorStyles.Left)
                        {
                            XInterval = control.Left;
                        }

                        if ((control.Anchor & AnchorStyles.Right) == AnchorStyles.Right)
                        {
                            XInterval = control.Parent.Width - control.Right;
                        }

                        if ((control.Anchor & AnchorStyles.Top) == AnchorStyles.Top)
                        {
                            YInterval = control.Top;
                        }

                        if ((control.Anchor & AnchorStyles.Bottom) == AnchorStyles.Bottom)
                        {
                            YInterval = control.Parent.Height - control.Bottom;
                        }
                    }

                    return new Rectangle(XInterval, YInterval, Width, Height);
                }
            }
            else
            {
                return new Rectangle(control.Left, control.Top, control.Width, control.Height);
            }
        }

        public static int Calc(int size, float scale)
        {
            return (int)(size * scale + 0.5);
        }

        public static Size Calc(Size size, float scale)
        {
            return new Size(Calc(size.Width, scale), Calc(size.Height, scale));
        }

        /// <summary>
        /// Set the control zoom scale
        /// </summary>
        /// <param name="control">Control</param>
        /// <param name="scale">Zoom scale</param>
        internal static void SetZoomScale(Control control, float scale)
        {
            if (scale.EqualsFloat(0)) return;

            if (control is IZoomScale ctrl)
            {
                if (ctrl.ZoomScaleDisabled)
                {
                    return;
                }

                // Set the zoom parameters for the control
                ctrl.ZoomScaleRect = UIZoomScale.Create(control);

                // Apply custom zoom scaling, e.g., UIAvatar
                ctrl.SetZoomScale(scale);

                if (control.Dock == DockStyle.Fill)
                {
                    return;
                }

                var rect = ctrl.ZoomScaleRect;
                switch (control.Dock)
                {
                    case DockStyle.None:
                        control.Height = Calc(rect.Height, scale);
                        control.Width = Calc(rect.Width, scale);

                        if (control.Parent != null)
                        {
                            if ((control.Anchor & AnchorStyles.Left) == AnchorStyles.Left)
                            {
                                control.Left = Calc(rect.Left, scale);
                            }

                            if ((control.Anchor & AnchorStyles.Right) == AnchorStyles.Right)
                            {
                                int right = Calc(rect.Left, scale);
                                control.Left = control.Parent.Width - right - control.Width;
                            }

                            if ((control.Anchor & AnchorStyles.Top) == AnchorStyles.Top)
                            {
                                if (control.Parent is UIForm form && form.ShowTitle)
                                    control.Top = Calc(rect.Top - form.TitleHeight, scale) + form.TitleHeight;
                                else
                                    control.Top = Calc(rect.Top, scale);
                            }

                            if ((control.Anchor & AnchorStyles.Bottom) == AnchorStyles.Bottom)
                            {
                                int bottom = Calc(rect.Top, scale);
                                control.Top = control.Parent.Height - bottom - control.Height;
                            }
                        }

                        break;
                    case DockStyle.Top:
                        control.Height = Calc(rect.Height, scale);
                        break;
                    case DockStyle.Bottom:
                        control.Height = Calc(rect.Height, scale);
                        break;
                    case DockStyle.Left:
                        control.Width = Calc(rect.Width, scale);
                        break;
                    case DockStyle.Right:
                        control.Width = Calc(rect.Width, scale);
                        break;
                    case DockStyle.Fill:
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
