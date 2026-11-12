using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Windows 11 style toggle switch.
    /// </summary>
    public sealed class MoonToggle : CheckBox, IThemeable {
        bool solidStyle = true;
        bool _hover;
        bool _pressed;

        [Browsable(true)]
        public override string Text
        {
            get { return base.Text; }
            set { }
        }

        [DefaultValue(true)]
        public bool SolidStyle
        {
            get { return solidStyle; }
            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }

        public MoonToggle()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(46, 22);
            this.Cursor = Cursors.Hand;
        }

        public void ApplyTheme(Palette palette)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            Invalidate();
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            base.OnParentBackColorChanged(e);
        }

        protected override void OnCheckedChanged(EventArgs e) { Invalidate(); base.OnCheckedChanged(e); }
        protected override void OnMouseEnter(EventArgs eventargs) { _hover = true; Invalidate(); base.OnMouseEnter(eventargs); }
        protected override void OnMouseLeave(EventArgs eventargs) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(eventargs); }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left) { _pressed = true; Invalidate(); }
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _pressed = false;
            Invalidate();
            base.OnMouseUp(mevent);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Palette p = ThemeManager.Current;
            Graphics g = pevent.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.WindowBg);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float trackW = Math.Min(Draw.S(40), Width - 3);
            float trackH = Math.Min(Draw.S(20), Height - 3);
            float x = Width - trackW - 1.5f;
            float y = (Height - trackH) / 2f;
            RectangleF track = new RectangleF(x, y, trackW, trackH);
            float radius = trackH / 2f;

            float knob = trackH * (_pressed ? 0.70f : (_hover ? 0.62f : 0.54f));
            float knobY = y + (trackH - knob) / 2f;
            float inset = (trackH - knob) / 2f;

            using (GraphicsPath path = Draw.RoundedRect(track, radius))
            {
                if (Checked)
                {
                    Color fill = !Enabled ? p.TextDisabled : (_pressed ? p.AccentPressed : (_hover ? p.AccentHover : p.Accent));
                    using (SolidBrush b = new SolidBrush(fill)) g.FillPath(b, path);
                    using (SolidBrush b = new SolidBrush(p.OnAccent))
                    {
                        g.FillEllipse(b, track.Right - inset - knob, knobY, knob, knob);
                    }
                }
                else
                {
                    Color surface = Parent != null ? Parent.BackColor : p.WindowBg;
                    Color fill = _hover ? ColorMath.Blend(surface, p.ControlHover, 0.8) : ColorMath.Blend(surface, p.InputFill, 0.5);
                    Color stroke = Enabled ? p.ToggleOff : p.TextDisabled;
                    using (SolidBrush b = new SolidBrush(fill)) g.FillPath(b, path);
                    using (Pen pen = new Pen(stroke)) g.DrawPath(pen, path);
                    using (SolidBrush b = new SolidBrush(stroke))
                    {
                        g.FillEllipse(b, track.X + inset, knobY, knob, knob);
                    }
                }
            }

            if (Focused && ShowFocusCues)
            {
                using (GraphicsPath path = Draw.RoundedRect(RectangleF.Inflate(track, 1.5f, 1.5f), radius + 1.5f))
                using (Pen pen = new Pen(p.TextPrimary))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
    }
}