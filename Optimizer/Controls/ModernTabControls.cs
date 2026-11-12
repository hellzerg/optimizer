using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    internal enum LabelTone { Primary, Secondary, Accent, Danger, Success }

    internal static class Tones {
        internal static Color Success(Palette p)
        {
            return p.IsDark ? Color.FromArgb(108, 203, 95) : Color.FromArgb(15, 123, 15);
        }

        internal static Color Warning(Palette p)
        {
            return p.IsDark ? Color.FromArgb(252, 225, 0) : Color.FromArgb(157, 93, 0);
        }

        internal static Color Of(LabelTone tone, Palette p)
        {
            switch (tone)
            {
                case LabelTone.Secondary: return p.TextSecondary;
                case LabelTone.Accent: return p.AccentText;
                case LabelTone.Danger: return p.Danger;
                case LabelTone.Success: return Success(p);
                default: return p.TextPrimary;
            }
        }
    }

    /// <summary>
    /// Label with an explicit color role and a pinned font (the theme's legacy-font remapping is not applied to it).
    /// </summary>
    internal sealed class FluentLabel : Label, IThemeable {
        LabelTone _tone;
        Font _pinned;

        public FluentLabel(Font font, LabelTone tone = LabelTone.Primary)
        {
            AutoSize = true;
            UseMnemonic = false;
            _pinned = font;
            _tone = tone;
            base.Font = font;
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LabelTone Tone
        {
            get { return _tone; }
            set
            {
                _tone = value;
                if (ThemeManager.Current != null) ForeColor = Tones.Of(value, ThemeManager.Current);
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Font PinnedFont
        {
            get { return _pinned; }
            set { _pinned = value; base.Font = value; }
        }

        public void ApplyTheme(Palette palette)
        {
            if (!ReferenceEquals(base.Font, _pinned)) base.Font = _pinned;
            BackColor = Parent != null ? Parent.BackColor : palette.WindowBg;
            ForeColor = Tones.Of(_tone, palette);
        }
    }

    /// <summary>Plain auto-scrolling host that blends into its parent surface.</summary>
    internal sealed class ScrollHost : Panel, IThemeable {
        public ScrollHost()
        {
            AutoScroll = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        public void ApplyTheme(Palette palette)
        {
            BackColor = Parent != null ? Parent.BackColor : palette.WindowBg;
            ThemeManager.ThemeScrollbars(this);
        }
    }

    /// <summary>Thin indeterminate activity bar.</summary>
    internal sealed class BusyBar : Control, IThemeable {
        readonly Timer _timer = new Timer { Interval = 16 };
        float _phase;
        bool _running;

        public BusyBar()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            _timer.Tick += (s, e) => { _phase = (_phase + 0.012f) % 1.6f; Invalidate(); };
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Running
        {
            get { return _running; }
            set
            {
                if (_running == value) return;
                _running = value;
                _phase = 0;
                _timer.Enabled = value;
                Invalidate();
            }
        }

        public void ApplyTheme(Palette palette)
        {
            Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _timer.Dispose();
            base.Dispose(disposing);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.WindowBg);
            if (!_running) return;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            float h = Math.Min(Height, Draw.S(3));
            float y = (Height - h) / 2f;
            float w = Width;
            float seg = w * 0.3f;
            float x = (_phase - 0.3f) * w;
            RectangleF bar = RectangleF.Intersect(new RectangleF(x, y, seg, h), new RectangleF(0, y, w, h));
            if (bar.Width <= 0) return;

            using (GraphicsPath path = Draw.RoundedRect(bar, h / 2))
            using (SolidBrush b = new SolidBrush(p.Accent))
            {
                g.FillPath(b, path);
            }
        }
    }

    /// <summary>Small rounded tile showing a caption and a large value.</summary>
    internal sealed class StatTile : Control, IThemeable {
        string _caption = string.Empty, _value = "-";
        LabelTone _tone = LabelTone.Primary;

        public StatTile()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Caption { get { return _caption; } set { _caption = value ?? string.Empty; Invalidate(); } }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Value { get { return _value; } set { _value = value ?? string.Empty; Invalidate(); } }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LabelTone ValueTone { get { return _tone; } set { _tone = value; Invalidate(); } }

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

            RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(7)))
            using (SolidBrush b = new SolidBrush(p.Layer1))
            using (Pen pen = new Pen(p.IsDark ? ColorMath.Blend(p.Layer1, Color.Black, 0.35) : p.Stroke))
            {
                g.FillPath(b, path);
                g.DrawPath(pen, path);
            }

            int pad = Draw.SI(14);
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix;
            Font capFont = Typography.Get(9f, Typography.Weight.Regular);
            Font valFont = Typography.Get(16f, Typography.Weight.Display);
            int capH = TextRenderer.MeasureText(g, "Ag", capFont).Height;
            int valH = TextRenderer.MeasureText(g, "Ag", valFont).Height;
            int top = (Height - capH - valH) / 2;

            TextRenderer.DrawText(g, _caption, capFont, new Rectangle(pad, top, Width - pad * 2, capH), p.TextSecondary, flags);
            TextRenderer.DrawText(g, _value, valFont, new Rectangle(pad - Draw.SI(1), top + capH, Width - pad * 2, valH), Tones.Of(_tone, p), flags);
        }
    }

    /// <summary>Pivot header for a TabControl whose native headers are hidden; wraps into stable rows (no Win32 row rotation).</summary>
    internal sealed class PivotStrip : Control, IThemeable {
        TabControl _tabs;
        readonly List<Rectangle> _items = new List<Rectangle>();
        int _hover = -1;

        public PivotStrip()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Font = Typography.Get(10f, Typography.Weight.Semibold);
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TabControl Tabs
        {
            get { return _tabs; }
            set
            {
                _tabs = value;
                if (_tabs != null) _tabs.SelectedIndexChanged += (s, e) => Invalidate();
                Relayout();
            }
        }

        int ItemHeight { get { return Draw.SI(34); } }

        /// <summary>Recomputes the header rectangles; returns the height needed for the given width.</summary>
        public int Measure(int width)
        {
            _items.Clear();
            if (_tabs == null) return 0;
            int x = 0, y = 0, gap = Draw.SI(4), h = ItemHeight;
            foreach (TabPage page in _tabs.TabPages)
            {
                int w = TextRenderer.MeasureText(page.Text, Font, Size.Empty, TextFormatFlags.NoPrefix).Width + Draw.SI(28);
                if (x > 0 && x + w > width)
                {
                    x = 0;
                    y += h + gap;
                }
                _items.Add(new Rectangle(x, y, w, h));
                x += w + gap;
            }
            return y + h + Draw.SI(6);
        }

        public void Relayout()
        {
            Measure(Width);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Measure(Width);
        }

        public void ApplyTheme(Palette palette)
        {
            Invalidate();
        }

        int HitTest(Point pt)
        {
            for (int i = 0; i < _items.Count; i++) if (_items[i].Contains(pt)) return i;
            return -1;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            int hit = HitTest(e.Location);
            if (hit != _hover) { _hover = hit; Cursor = hit >= 0 ? Cursors.Hand : Cursors.Default; Invalidate(); }
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (_hover != -1) { _hover = -1; Invalidate(); }
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            int hit = HitTest(e.Location);
            if (hit >= 0 && _tabs != null && hit < _tabs.TabCount) _tabs.SelectedIndex = hit;
            base.OnMouseDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            Color back = Parent != null ? Parent.BackColor : p.WindowBg;
            g.Clear(back);
            if (_tabs == null) return;
            if (_items.Count != _tabs.TabCount) Measure(Width);

            using (Pen line = new Pen(p.Stroke))
            {
                g.DrawLine(line, 0, Height - 1, Width, Height - 1);
            }

            for (int i = 0; i < _items.Count; i++)
            {
                Rectangle r = _items[i];
                bool selected = i == _tabs.SelectedIndex;
                if (selected || i == _hover)
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (GraphicsPath path = Draw.RoundedRect(new RectangleF(r.X, r.Y + Draw.S(2), r.Width, r.Height - Draw.S(4)), Draw.S(5)))
                    using (SolidBrush b = new SolidBrush(selected ? ColorMath.Blend(back, p.TextPrimary, 0.07) : p.ControlHover))
                    {
                        g.FillPath(b, path);
                    }
                    g.SmoothingMode = SmoothingMode.None;
                }

                Color text = selected || i == _hover ? p.TextPrimary : p.TextSecondary;
                TextRenderer.DrawText(g, _tabs.TabPages[i].Text, Font, r, text,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix);

                if (selected)
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    float thickness = Draw.S(3), len = Math.Max(Draw.S(16), r.Width * 0.35f);
                    RectangleF bar = new RectangleF(r.X + (r.Width - len) / 2f, r.Bottom - thickness - Draw.S(2), len, thickness);
                    using (GraphicsPath path = Draw.RoundedRect(bar, thickness / 2f))
                    using (SolidBrush b = new SolidBrush(p.Accent))
                    {
                        g.FillPath(b, path);
                    }
                    g.SmoothingMode = SmoothingMode.None;
                }
            }
        }
    }

    /// <summary>Expand/collapse chevron drawn with lines (no icon font needed, works on Windows 7+).</summary>
    internal sealed class ChevronGlyph : Control, IThemeable {
        bool _expanded = true, _hover;

        public ChevronGlyph()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Cursor = Cursors.Hand;
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Expanded { get { return _expanded; } set { _expanded = value; Invalidate(); } }

        public void ApplyTheme(Palette palette)
        {
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; Invalidate(); base.OnMouseLeave(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            Color back = Parent != null ? Parent.BackColor : p.Layer1;
            g.Clear(back);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (_hover)
            {
                using (GraphicsPath hp = Draw.RoundedRect(new RectangleF(0, 0, Width - 1, Height - 1), Draw.S(4)))
                using (SolidBrush hb = new SolidBrush(ColorMath.Blend(back, p.TextPrimary, 0.08)))
                {
                    g.FillPath(hb, hp);
                }
            }

            float cx = Width / 2f, cy = Height / 2f, s = Math.Min(Width, Height) * 0.16f;
            PointF[] pts = _expanded
                ? new[] { new PointF(cx - s * 1.6f, cy - s * 0.8f), new PointF(cx, cy + s * 0.8f), new PointF(cx + s * 1.6f, cy - s * 0.8f) }
                : new[] { new PointF(cx - s * 0.8f, cy - s * 1.6f), new PointF(cx + s * 0.8f, cy), new PointF(cx - s * 0.8f, cy + s * 1.6f) };
            using (Pen pen = new Pen(p.TextSecondary, Draw.S(1.4f)) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round })
            {
                g.DrawLines(pen, pts);
            }
        }
    }

    internal sealed class BreakdownRow {
        public string Name;
        public int Items;
        public long Bytes;
        public CheckState State;
        public Color Tint;
    }

    /// <summary>
    /// Category summary for the cleaner preview: one row per category with a check box, item count, size and a share bar.
    /// </summary>
    internal sealed class CleanBreakdown : Control, IThemeable {
        readonly List<BreakdownRow> _rows = new List<BreakdownRow>();
        int _hover = -1;
        string _emptyText = string.Empty, _itemsFormat = "{0} items";

        public event EventHandler<int> RowToggled;

        public CleanBreakdown()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);
            Cursor = Cursors.Hand;
        }

        internal IList<BreakdownRow> Rows { get { return _rows; } }

        internal int RowHeight { get { return Draw.SI(32); } }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EmptyText { get { return _emptyText; } set { _emptyText = value ?? string.Empty; Invalidate(); } }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ItemsFormat { get { return _itemsFormat; } set { _itemsFormat = value ?? "{0}"; Invalidate(); } }

        internal void SetRows(IEnumerable<BreakdownRow> rows)
        {
            _rows.Clear();
            if (rows != null) _rows.AddRange(rows);
            _hover = -1;
            Invalidate();
        }

        public void ApplyTheme(Palette palette)
        {
            Invalidate();
        }

        int RowAt(Point pt)
        {
            if (pt.Y < 0) return -1;
            int i = pt.Y / RowHeight;
            return i < _rows.Count ? i : -1;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            int i = RowAt(e.Location);
            if (i != _hover) { _hover = i; Invalidate(); }
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (_hover != -1) { _hover = -1; Invalidate(); }
            base.OnMouseLeave(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button != MouseButtons.Left) return;
            int i = RowAt(e.Location);
            if (i < 0) return;
            _rows[i].State = _rows[i].State == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked;
            Invalidate();
            RowToggled?.Invoke(this, i);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            Color back = Parent != null ? Parent.BackColor : p.Layer1;
            g.Clear(back);

            const TextFormatFlags left = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix;
            const TextFormatFlags right = TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix;
            Font font = Typography.Get(10f, Typography.Weight.Regular);
            Font small = Typography.Get(9f, Typography.Weight.Regular);

            if (_rows.Count == 0)
            {
                TextRenderer.DrawText(g, _emptyText, font, new Rectangle(0, 0, Width, Height), p.TextSecondary,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.NoPrefix);
                return;
            }

            long max = 1;
            foreach (BreakdownRow r in _rows) max = Math.Max(max, r.Bytes);

            int rowH = RowHeight;
            int box = Draw.SI(16);
            int sizeW = Draw.SI(78), countW = Draw.SI(92);
            for (int i = 0; i < _rows.Count; i++)
            {
                BreakdownRow row = _rows[i];
                Rectangle rr = new Rectangle(0, i * rowH, Width, rowH);
                if (rr.Top > e.ClipRectangle.Bottom) break;

                g.SmoothingMode = SmoothingMode.AntiAlias;
                if (i == _hover)
                {
                    using (GraphicsPath hp = Draw.RoundedRect(new RectangleF(rr.X, rr.Y + 1, rr.Width - 1, rr.Height - 2), Draw.S(4)))
                    using (SolidBrush hb = new SolidBrush(ColorMath.Blend(back, p.TextPrimary, 0.06)))
                    {
                        g.FillPath(hb, hp);
                    }
                }

                // check box
                RectangleF cb = new RectangleF(Draw.SI(6), rr.Y + (rowH - box) / 2f, box, box);
                bool on = row.State != CheckState.Unchecked;
                using (GraphicsPath cp = Draw.RoundedRect(cb, Draw.S(3.5f)))
                {
                    if (on)
                    {
                        using (SolidBrush fb = new SolidBrush(p.Accent)) g.FillPath(fb, cp);
                    }
                    else
                    {
                        using (Pen op = new Pen(p.TextSecondary, Draw.S(1))) g.DrawPath(op, cp);
                    }
                }
                if (row.State == CheckState.Checked)
                {
                    using (Pen mark = new Pen(p.OnAccent, Draw.S(1.6f)) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round })
                    {
                        g.DrawLines(mark, new[]
                        {
                            new PointF(cb.X + cb.Width * 0.25f, cb.Y + cb.Height * 0.52f),
                            new PointF(cb.X + cb.Width * 0.43f, cb.Y + cb.Height * 0.70f),
                            new PointF(cb.X + cb.Width * 0.76f, cb.Y + cb.Height * 0.32f)
                        });
                    }
                }
                else if (row.State == CheckState.Indeterminate)
                {
                    using (SolidBrush mb = new SolidBrush(p.OnAccent))
                    {
                        g.FillRectangle(mb, cb.X + cb.Width * 0.27f, cb.Y + cb.Height / 2f - Draw.S(0.8f), cb.Width * 0.46f, Draw.S(1.6f));
                    }
                }

                // tint dot
                float dot = Draw.S(8);
                using (SolidBrush db = new SolidBrush(row.Tint))
                {
                    g.FillEllipse(db, cb.Right + Draw.S(12), rr.Y + (rowH - dot) / 2f, dot, dot);
                }
                g.SmoothingMode = SmoothingMode.None;

                int nameX = (int)cb.Right + Draw.SI(28);
                int sizeX = rr.Right - sizeW - Draw.SI(6);
                int countX = sizeX - countW;
                int barW = Math.Max(0, Math.Min(Draw.SI(140), (countX - nameX) / 3));
                int barX = countX - barW - Draw.SI(10);
                int nameW = Math.Max(0, (barW > 0 ? barX : countX) - nameX - Draw.SI(8));

                Color text = on ? p.TextPrimary : p.TextSecondary;
                TextRenderer.DrawText(g, row.Name, font, new Rectangle(nameX, rr.Y, nameW, rowH), text, left);

                if (barW > Draw.SI(24))
                {
                    float bh = Draw.S(4);
                    RectangleF track = new RectangleF(barX, rr.Y + (rowH - bh) / 2f, barW, bh);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (GraphicsPath tp = Draw.RoundedRect(track, bh / 2))
                    using (SolidBrush tb = new SolidBrush(ColorMath.Blend(back, p.TextPrimary, 0.12)))
                    {
                        g.FillPath(tb, tp);
                    }
                    float frac = (float)row.Bytes / max;
                    if (frac > 0)
                    {
                        RectangleF fill = new RectangleF(track.X, track.Y, Math.Max(bh, track.Width * frac), bh);
                        using (GraphicsPath fp = Draw.RoundedRect(fill, bh / 2))
                        using (SolidBrush fb = new SolidBrush(on ? row.Tint : ColorMath.Blend(back, row.Tint, 0.45)))
                        {
                            g.FillPath(fb, fp);
                        }
                    }
                    g.SmoothingMode = SmoothingMode.None;
                }

                TextRenderer.DrawText(g, string.Format(_itemsFormat, row.Items.ToString("N0")), small, new Rectangle(countX, rr.Y, countW, rowH), p.TextSecondary, right);
                TextRenderer.DrawText(g, ByteSize.FromBytes(row.Bytes).ToString(), font, new Rectangle(sizeX, rr.Y, sizeW, rowH), text, right);
            }
        }
    }
}
