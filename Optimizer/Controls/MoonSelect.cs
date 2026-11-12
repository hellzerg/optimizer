using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Flat combo box with a Fluent border and chevron, painted over the native control.
    /// </summary>
    public sealed class MoonSelect : ComboBox, IThemeable {
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        bool _hover;

        Color borderColor = Color.Blue;
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        public MoonSelect()
        {
            FlatStyle = FlatStyle.Flat;
        }

        public void ApplyTheme(Palette palette)
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = palette.InputFill;
            ForeColor = palette.TextPrimary;
            BorderColor = palette.Stroke;
            if (IsHandleCreated) WindowChrome.ApplyComboTheme(this, palette);
            Invalidate();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            WindowChrome.ApplyComboTheme(this, ThemeManager.Current);
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnGotFocus(EventArgs e) { Invalidate(); base.OnGotFocus(e); }
        protected override void OnLostFocus(EventArgs e) { Invalidate(); base.OnLostFocus(e); }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT && DropDownStyle != ComboBoxStyle.Simple)
            {
                Palette p = ThemeManager.Current;
                Color surface = Parent != null ? Parent.BackColor : p.WindowBg;

                using (var g = Graphics.FromHwnd(Handle))
                {
                    Rectangle button = new Rectangle(Width - buttonWidth - 2, 1, buttonWidth + 1, Height - 2);
                    using (SolidBrush b = new SolidBrush(BackColor)) g.FillRectangle(b, button);

                    // corners outside the rounded border take the surface color
                    using (Pen pen = new Pen(surface, 3)) g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
                    using (Pen pen = new Pen(BackColor, 2)) g.DrawRectangle(pen, 2, 2, Width - 5, Height - 5);

                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
                    using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(4)))
                    using (Pen pen = new Pen(_hover || Focused ? ColorMath.Blend(BorderColor, p.TextSecondary, 0.35) : BorderColor))
                    {
                        g.DrawPath(pen, path);
                    }

                    if (Focused || DroppedDown)
                    {
                        using (Pen pen = new Pen(p.Accent, Draw.S(2)))
                        {
                            float y = Height - Draw.S(1.5f);
                            g.DrawLine(pen, Draw.S(3), y, Width - Draw.S(4), y);
                        }
                    }

                    float cx = button.Left + button.Width / 2f;
                    float cy = Height / 2f;
                    float s = Draw.S(3.5f);
                    using (Pen pen = new Pen(Enabled ? p.TextSecondary : p.TextDisabled, Draw.S(1.3f)))
                    {
                        pen.StartCap = pen.EndCap = LineCap.Round;
                        g.DrawLines(pen, new[] { new PointF(cx - s, cy - s / 2), new PointF(cx, cy + s / 2), new PointF(cx + s, cy - s / 2) });
                    }
                }
            }
        }
    }
}