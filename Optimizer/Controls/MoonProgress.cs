using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    internal sealed class MoonProgress : ProgressBar, IThemeable {
        public MoonProgress()
        {
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void ApplyTheme(Palette palette)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.WindowBg);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float h = Math.Min(Height - 1, Draw.S(6));
            float y = (Height - h) / 2f;
            RectangleF track = new RectangleF(0.5f, y, Width - 1.5f, h);

            using (GraphicsPath path = Draw.RoundedRect(track, h / 2))
            using (SolidBrush b = new SolidBrush(p.Stroke))
            {
                g.FillPath(b, path);
            }

            int range = Math.Max(1, Maximum - Minimum);
            float fraction = Math.Max(0f, Math.Min(1f, (float)(Value - Minimum) / range));
            if (fraction <= 0) return;

            RectangleF bar = new RectangleF(track.X, track.Y, Math.Max(h, track.Width * fraction), h);
            using (GraphicsPath path = Draw.RoundedRect(bar, h / 2))
            using (SolidBrush b = new SolidBrush(p.Accent))
            {
                g.FillPath(b, path);
            }
        }
    }
}