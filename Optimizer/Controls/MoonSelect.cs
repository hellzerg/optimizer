using System.Drawing;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed class MoonSelect : ComboBox
    {
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        Color borderColor = Color.Blue;

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT && DropDownStyle != ComboBoxStyle.Simple)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    var adjustMent = 0;
                    if (FlatStyle == FlatStyle.Popup ||
                       (FlatStyle == FlatStyle.Flat &&
                       DropDownStyle == ComboBoxStyle.DropDownList))
                        adjustMent = 1;
                    var innerBorderWisth = 3;
                    var innerBorderColor = BackColor;
                    if (DropDownStyle == ComboBoxStyle.DropDownList &&
                        (FlatStyle == FlatStyle.System || FlatStyle == FlatStyle.Standard))
                        innerBorderColor = Color.FromArgb(0xCCCCCC);
                    if (DropDownStyle == ComboBoxStyle.DropDownList && !Enabled)
                        innerBorderColor = SystemColors.Control;

                    if (DropDownStyle == ComboBoxStyle.DropDownList || Enabled == false)
                    {
                        using (var p = new Pen(innerBorderColor, innerBorderWisth))
                        {
                            p.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                            g.DrawRectangle(p, 1, 1,
                                Width - buttonWidth - adjustMent - 1, Height - 1);
                        }
                    }
                    using (var p = new Pen(BorderColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                        g.DrawLine(p, Width - buttonWidth - adjustMent,
                            0, Width - buttonWidth - adjustMent, Height);
                    }
                }
            }
        }
    }
}
