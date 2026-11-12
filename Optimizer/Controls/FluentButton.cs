using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    public enum ButtonKind {
        Standard,
        Primary,
        Subtle
    }

    /// <summary>
    /// Owner-drawn Windows 11 style push button.
    /// </summary>
    public sealed class FluentButton : Button, IThemeable {
        ButtonKind _kind = ButtonKind.Standard;
        bool _hover;
        bool _pressed;

        public FluentButton()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
        }

        [DefaultValue(ButtonKind.Standard)]
        [Category("Appearance")]
        public ButtonKind Kind
        {
            get { return _kind; }
            set { _kind = value; Invalidate(); }
        }

        public void ApplyTheme(Palette palette)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(e); }

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

        protected override void OnEnabledChanged(EventArgs e) { Invalidate(); base.OnEnabledChanged(e); }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            base.OnParentBackColorChanged(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Palette p = ThemeManager.Current;
            Graphics g = pevent.Graphics;
            Color surface = Parent != null ? Parent.BackColor : p.WindowBg;
            g.Clear(surface);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color fill, border, text;
            ResolveColors(p, out fill, out border, out text);

            RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            float radius = Draw.S(4);

            using (GraphicsPath path = Draw.RoundedRect(r, radius))
            {
                if (fill.A > 0)
                {
                    using (SolidBrush b = new SolidBrush(fill)) g.FillPath(b, path);
                }
                if (border.A > 0)
                {
                    using (Pen pen = new Pen(border)) g.DrawPath(pen, path);
                }
            }

            if (Focused && ShowFocusCues)
            {
                RectangleF fr = new RectangleF(1.5f, 1.5f, Width - 3.5f, Height - 3.5f);
                using (GraphicsPath path = Draw.RoundedRect(fr, radius))
                using (Pen pen = new Pen(p.TextPrimary, Draw.S(1.5f)))
                {
                    g.DrawPath(pen, path);
                }
            }

            g.SmoothingMode = SmoothingMode.None;

            Rectangle content = new Rectangle(Padding.Left + Draw.SI(6), Padding.Top, Width - Padding.Horizontal - Draw.SI(12), Height - Padding.Vertical);

            if (Image != null)
            {
                Size isz = Image.Size;
                int textWidth = string.IsNullOrEmpty(Text) ? 0 : TextRenderer.MeasureText(g, Text, Font).Width;
                int gap = textWidth > 0 ? Draw.SI(6) : 0;
                int total = isz.Width + gap + textWidth;
                int x = content.Left + Math.Max(0, (content.Width - total) / 2);
                g.DrawImage(Image, new Rectangle(x, content.Top + (content.Height - isz.Height) / 2, isz.Width, isz.Height));
                content = new Rectangle(x + isz.Width + gap, content.Top, Math.Max(0, content.Right - (x + isz.Width + gap)), content.Height);
                TextRenderer.DrawText(g, Text, Font, content, text, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis);
                return;
            }

            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.EndEllipsis;
            if (!ShowKeyboardCues) flags |= TextFormatFlags.HidePrefix;
            TextRenderer.DrawText(g, Text, Font, content, text, flags);
        }

        void ResolveColors(Palette p, out Color fill, out Color border, out Color text)
        {
            if (!Enabled)
            {
                fill = _kind == ButtonKind.Subtle ? Color.Transparent : ColorMath.Blend(p.ControlFill, p.WindowBg, 0.5);
                border = _kind == ButtonKind.Subtle ? Color.Transparent : p.Stroke;
                text = p.TextDisabled;
                return;
            }

            switch (_kind)
            {
                case ButtonKind.Primary:
                    fill = _pressed ? p.AccentPressed : (_hover ? p.AccentHover : p.Accent);
                    border = fill;
                    text = p.OnAccent;
                    break;
                case ButtonKind.Subtle:
                    fill = _pressed ? p.ControlPressed : (_hover ? p.ControlHover : Color.Transparent);
                    border = Color.Transparent;
                    text = p.TextPrimary;
                    break;
                default:
                    fill = _pressed ? p.ControlPressed : (_hover ? p.ControlHover : p.ControlFill);
                    border = _pressed ? p.Stroke : ColorMath.Blend(p.Stroke, p.StrokeStrong, p.IsDark ? 0.25 : 0.35);
                    text = _pressed ? p.TextSecondary : p.TextPrimary;
                    break;
            }
        }
    }
}
