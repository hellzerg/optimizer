using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Shared Fluent rendering for owner-drawn check boxes and radio buttons.
    /// </summary>
    public static class ChoicePainter {
        internal static int GlyphSize(Control c)
        {
            return Math.Min(Draw.SI(18), Math.Max(8, c.Height - 2));
        }

        internal static Size PreferredSize(ButtonBase c, Image image)
        {
            Size text = TextRenderer.MeasureText(string.IsNullOrEmpty(c.Text) ? " " : c.Text, c.Font);
            int glyph = Draw.SI(18);
            int width = glyph + Draw.SI(8) + text.Width + c.Padding.Horizontal;
            if (image != null) width += image.Width + Draw.SI(6);
            int height = Math.Max(glyph + 2, Math.Max(text.Height, image != null ? image.Height : 0)) + c.Padding.Vertical + Draw.SI(4);
            return new Size(width, height);
        }

        internal static void Paint(ButtonBase c, Graphics g, bool radio, CheckState state, bool hover, bool pressed, Image image)
        {
            Palette p = ThemeManager.Current;
            Color surface = c.Parent != null ? c.Parent.BackColor : c.BackColor;
            g.Clear(surface);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int size = GlyphSize(c);
            RectangleF box = new RectangleF(c.Padding.Left + 1.5f, (c.Height - size) / 2f, size - 1, size - 1);
            bool on = state != CheckState.Unchecked;

            if (on)
            {
                Color fill = !c.Enabled ? p.TextDisabled : (pressed ? p.AccentPressed : (hover ? p.AccentHover : p.Accent));
                using (GraphicsPath path = radio ? Ellipse(box) : Draw.RoundedRect(box, Draw.S(4)))
                using (SolidBrush b = new SolidBrush(fill))
                {
                    g.FillPath(b, path);
                }

                using (Pen pen = new Pen(p.OnAccent, Math.Max(1.4f, Draw.S(1.6f))))
                using (SolidBrush b = new SolidBrush(p.OnAccent))
                {
                    pen.StartCap = pen.EndCap = LineCap.Round;
                    pen.LineJoin = LineJoin.Round;

                    if (radio)
                    {
                        float d = box.Width * (hover ? 0.48f : 0.42f);
                        g.FillEllipse(b, box.X + (box.Width - d) / 2, box.Y + (box.Height - d) / 2, d, d);
                    }
                    else if (state == CheckState.Indeterminate)
                    {
                        g.DrawLine(pen, box.X + box.Width * 0.28f, box.Y + box.Height / 2, box.Right - box.Width * 0.28f, box.Y + box.Height / 2);
                    }
                    else
                    {
                        g.DrawLines(pen, new[]
                        {
                            new PointF(box.X + box.Width * 0.25f, box.Y + box.Height * 0.52f),
                            new PointF(box.X + box.Width * 0.43f, box.Y + box.Height * 0.70f),
                            new PointF(box.X + box.Width * 0.76f, box.Y + box.Height * 0.32f)
                        });
                    }
                }
            }
            else
            {
                Color fill = pressed ? p.ControlPressed : (hover ? p.ControlHover : ColorMath.Blend(surface, p.InputFill, 0.6));
                Color border = c.Enabled ? p.TextSecondary : p.TextDisabled;
                using (GraphicsPath path = radio ? Ellipse(box) : Draw.RoundedRect(box, Draw.S(4)))
                using (SolidBrush b = new SolidBrush(fill))
                using (Pen pen = new Pen(border))
                {
                    g.FillPath(b, path);
                    g.DrawPath(pen, path);
                }
            }

            if (c.Focused && (c is IChoice) && ((IChoice)c).FocusCues)
            {
                RectangleF fr = RectangleF.Inflate(box, 1.5f, 1.5f);
                using (GraphicsPath path = radio ? Ellipse(fr) : Draw.RoundedRect(fr, Draw.S(5)))
                using (Pen pen = new Pen(p.TextPrimary))
                {
                    g.DrawPath(pen, path);
                }
            }

            g.SmoothingMode = SmoothingMode.None;

            int x = (int)box.Right + Draw.SI(8);
            if (image != null)
            {
                g.DrawImage(image, new Rectangle(x, (c.Height - image.Height) / 2, image.Width, image.Height));
                x += image.Width + Draw.SI(6);
            }

            Rectangle textRect = new Rectangle(x, 0, Math.Max(0, c.Width - x - c.Padding.Right), c.Height);
            Color fore = c.Enabled ? c.ForeColor : p.TextDisabled;
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.EndEllipsis;
            if (!c.ShowKeyboardCuesPublic()) flags |= TextFormatFlags.HidePrefix;
            TextRenderer.DrawText(g, c.Text, c.Font, textRect, fore, flags);
        }

        static GraphicsPath Ellipse(RectangleF r)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(r);
            return path;
        }

        static bool ShowKeyboardCuesPublic(this Control c)
        {
            return (c is IChoice) && ((IChoice)c).KeyboardCues;
        }
    }

    public interface IChoice {
        bool KeyboardCues { get; }
        bool FocusCues { get; }
    }
}