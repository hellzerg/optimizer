using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Collapsible Fluent navigation pane that mirrors the pages of a <see cref="TabControl"/>.
    /// Page titles come from the tab pages themselves, so translations keep working.
    /// </summary>
    public sealed class SidebarNav : Control, IThemeable {
        TabControl _tabs;
        bool _collapsed;
        int _expandedWidth = 240;
        int _hover = -2;
        int _pressed = -2;
        readonly ToolTip _tip = new ToolTip();
        readonly List<TabPage> _items = new List<TabPage>();
        readonly Dictionary<string, Glyph> _glyphs = new Dictionary<string, Glyph>(StringComparer.OrdinalIgnoreCase);

        const int MenuIndex = -1;

        public enum Glyph {
            Default, Shield, Windows, Gear, Apps, Rocket, Download, Broom, Pulse, Globe, Wrench, Chip, Puzzle, Options,
            Refresh, Search, Power, Help, Heart, Code, Chat, Document, Bug, Bulb, User, Lock, Eye, Drive
        }

        public SidebarNav()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);
            Dock = DockStyle.Left;
            Width = _expandedWidth;
            TabStop = true;
            Font = Typography.Get(10F, Typography.Weight.Regular);
        }

        [Category("Behavior")]
        [DefaultValue(null)]
        public TabControl TabControl
        {
            get { return _tabs; }
            set
            {
                if (_tabs == value) return;
                if (_tabs != null)
                {
                    _tabs.SelectedIndexChanged -= Tabs_Changed;
                    _tabs.ControlAdded -= Tabs_ControlChanged;
                    _tabs.ControlRemoved -= Tabs_ControlChanged;
                }
                _tabs = value;
                if (_tabs != null)
                {
                    _tabs.SelectedIndexChanged += Tabs_Changed;
                    _tabs.ControlAdded += Tabs_ControlChanged;
                    _tabs.ControlRemoved += Tabs_ControlChanged;
                }
                RefreshItems();
            }
        }

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Collapsed
        {
            get { return _collapsed; }
            set
            {
                if (_collapsed == value) return;
                _collapsed = value;
                Width = _collapsed ? CollapsedWidth : Draw.SI(_expandedWidth);
                Invalidate();
                CollapsedChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        [Category("Layout")]
        [DefaultValue(240)]
        public int ExpandedWidth
        {
            get { return _expandedWidth; }
            set { _expandedWidth = Math.Max(120, value); if (!_collapsed) Width = Draw.SI(_expandedWidth); }
        }

        public event EventHandler CollapsedChanged;

        int CollapsedWidth { get { return Draw.SI(56); } }
        int ItemHeight { get { return Draw.SI(40); } }
        int TopOffset { get { return Draw.SI(8); } }

        public void SetGlyph(TabPage page, Glyph glyph)
        {
            if (page == null) return;
            _glyphs[page.Name] = glyph;
            Invalidate();
        }

        public Glyph GetGlyph(TabPage page)
        {
            Glyph glyph;
            return page != null && _glyphs.TryGetValue(page.Name, out glyph) ? glyph : Glyph.Default;
        }

        /// <summary>
        /// Paints a navigation glyph at any size (glyphs are authored on a 16px grid and scaled uniformly).
        /// </summary>
        public static void PaintGlyph(Graphics g, Glyph glyph, Rectangle bounds, Color color)
        {
            int baseSize = Draw.SI(16);
            float scale = Math.Min(bounds.Width, bounds.Height) / (float)baseSize;
            GraphicsState state = g.Save();
            try
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.TranslateTransform(bounds.X, bounds.Y);
                g.ScaleTransform(scale, scale);
                DrawGlyph(g, glyph, new Rectangle(0, 0, baseSize, baseSize), color);
            }
            finally
            {
                g.Restore(state);
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            _boldFont = null;
            base.OnFontChanged(e);
        }

        Font _boldFont;
        Font SelectedFont
        {
            get { return _boldFont ?? (_boldFont = Typography.Emphasize(Font)); }
        }

        public void RefreshItems()
        {
            foreach (TabPage p in _items) p.TextChanged -= Page_TextChanged;
            _items.Clear();
            if (_tabs != null)
            {
                // Controls (not TabPages) is already current when ControlAdded/ControlRemoved fire.
                foreach (Control c in _tabs.Controls)
                {
                    TabPage p = c as TabPage;
                    if (p == null) continue;
                    _items.Add(p);
                    p.TextChanged += Page_TextChanged;
                }
            }
            Invalidate();
        }

        void Page_TextChanged(object sender, EventArgs e) { Invalidate(); }
        void Tabs_Changed(object sender, EventArgs e) { Invalidate(); }
        void Tabs_ControlChanged(object sender, ControlEventArgs e)
        {
            RefreshItems();
        }

        public void ApplyTheme(Palette palette)
        {
            BackColor = palette.Sidebar;
            ForeColor = palette.TextPrimary;
            Invalidate();
        }

        Rectangle ItemRect(int index)
        {
            int pad = Draw.SI(4);
            int y = TopOffset + (index + 1) * (ItemHeight + Draw.SI(2));
            if (index == MenuIndex) y = TopOffset;
            return new Rectangle(pad, y, Width - pad * 2, ItemHeight);
        }

        int HitTest(Point pt)
        {
            if (ItemRect(MenuIndex).Contains(pt)) return MenuIndex;
            for (int i = 0; i < _items.Count; i++)
                if (ItemRect(i).Contains(pt)) return i;
            return -2;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int h = HitTest(e.Location);
            if (h != _hover)
            {
                _hover = h;
                Cursor = h != -2 ? Cursors.Hand : Cursors.Default;
                if (_collapsed && h >= 0) _tip.SetToolTip(this, _items[h].Text);
                else _tip.SetToolTip(this, null);
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hover = -2;
            _pressed = -2;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button != MouseButtons.Left) return;
            _pressed = HitTest(e.Location);
            Focus();
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            int h = HitTest(e.Location);
            if (e.Button == MouseButtons.Left && h == _pressed) Activate(h);
            _pressed = -2;
            Invalidate();
        }

        void Activate(int index)
        {
            if (index == MenuIndex) Collapsed = !Collapsed;
            else if (index >= 0 && _tabs != null && index < _items.Count) _tabs.SelectedTab = _items[index];
        }

        protected override bool IsInputKey(Keys keyData)
        {
            Keys k = keyData & Keys.KeyCode;
            return k == Keys.Up || k == Keys.Down || base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (_tabs == null || _items.Count == 0) return;
            int sel = _items.IndexOf(_tabs.SelectedTab);
            if (e.KeyCode == Keys.Down) { Activate(Math.Min(_items.Count - 1, sel + 1)); e.Handled = true; }
            else if (e.KeyCode == Keys.Up) { Activate(Math.Max(0, sel - 1)); e.Handled = true; }
        }

        protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); Invalidate(); }
        protected override void OnLostFocus(EventArgs e) { base.OnLostFocus(e); Invalidate(); }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(p.Sidebar);

            DrawItem(g, p, MenuIndex, null, false);

            TabPage selected = _tabs != null ? _tabs.SelectedTab : null;
            for (int i = 0; i < _items.Count; i++)
                DrawItem(g, p, i, _items[i], _items[i] == selected);

            using (Pen line = new Pen(p.Stroke))
                g.DrawLine(line, Width - 1, 0, Width - 1, Height);
        }

        void DrawItem(Graphics g, Palette p, int index, TabPage page, bool selected)
        {
            Rectangle r = ItemRect(index);
            bool hover = _hover == index;
            bool pressed = _pressed == index && hover;

            if (selected || hover)
            {
                Color fill = selected ? p.ControlFill : p.ControlHover;
                if (pressed) fill = p.ControlPressed;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(5)))
                using (SolidBrush b = new SolidBrush(fill))
                    g.FillPath(b, path);
            }

            if (selected)
            {
                float barH = Draw.S(16);
                RectangleF bar = new RectangleF(r.Left, r.Top + (r.Height - barH) / 2f, Draw.S(3), barH);
                using (GraphicsPath path = Draw.RoundedRect(bar, Draw.S(1.5f)))
                using (SolidBrush b = new SolidBrush(p.Accent))
                    g.FillPath(b, path);
            }

            if (Focused && selected && ShowFocusCues)
            {
                using (Pen fp = new Pen(p.TextPrimary, 1f))
                using (GraphicsPath path = Draw.RoundedRect(new RectangleF(r.X + 0.5f, r.Y + 0.5f, r.Width - 1, r.Height - 1), Draw.S(5)))
                    g.DrawPath(fp, path);
            }

            int iconSize = Draw.SI(16);
            Rectangle icon = new Rectangle(r.Left + (CollapsedWidth - Draw.SI(8) - iconSize) / 2, r.Top + (r.Height - iconSize) / 2, iconSize, iconSize);
            Color fg = selected ? p.TextPrimary : (pressed ? p.TextSecondary : p.TextPrimary);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            Glyph glyph = Glyph.Default;
            if (index == MenuIndex) DrawHamburger(g, icon, fg);
            else
            {
                if (page != null && !_glyphs.TryGetValue(page.Name, out glyph)) glyph = Glyph.Default;
                DrawGlyph(g, glyph, icon, selected ? p.AccentText : fg);
            }
            g.SmoothingMode = SmoothingMode.None;

            if (!_collapsed && page != null)
            {
                int tx = r.Left + CollapsedWidth - Draw.SI(4);
                Rectangle tr = new Rectangle(tx, r.Top, r.Right - tx - Draw.SI(8), r.Height);
                TextRenderer.DrawText(g, page.Text, selected ? SelectedFont : Font, tr, fg,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
            }
        }

        static void DrawHamburger(Graphics g, Rectangle r, Color c)
        {
            using (Pen pen = new Pen(c, Draw.S(1.4f)))
            {
                float y0 = r.Top + r.Height * 0.25f;
                float step = r.Height * 0.25f;
                for (int i = 0; i < 3; i++)
                    g.DrawLine(pen, r.Left + 1, y0 + i * step, r.Right - 1, y0 + i * step);
            }
        }

        static void DrawGlyph(Graphics g, Glyph glyph, Rectangle r, Color c)
        {
            float w = r.Width, h = r.Height, x = r.X, y = r.Y;
            using (Pen pen = new Pen(c, Draw.S(1.3f)) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round })
            using (SolidBrush brush = new SolidBrush(c))
            {
                switch (glyph)
                {
                    case Glyph.Shield:
                        using (GraphicsPath gp = new GraphicsPath())
                        {
                            gp.AddLines(new[] {
                                new PointF(x + w / 2, y + 1), new PointF(x + w - 2, y + h * 0.22f), new PointF(x + w - 2, y + h * 0.5f) });
                            gp.AddBezier(new PointF(x + w - 2, y + h * 0.5f), new PointF(x + w - 2, y + h * 0.78f), new PointF(x + w * 0.7f, y + h - 2), new PointF(x + w / 2, y + h - 1));
                            gp.AddBezier(new PointF(x + w / 2, y + h - 1), new PointF(x + w * 0.3f, y + h - 2), new PointF(x + 2, y + h * 0.78f), new PointF(x + 2, y + h * 0.5f));
                            gp.AddLines(new[] { new PointF(x + 2, y + h * 0.5f), new PointF(x + 2, y + h * 0.22f) });
                            gp.CloseFigure();
                            g.DrawPath(pen, gp);
                        }
                        break;
                    case Glyph.Windows:
                        {
                            float gap = Draw.S(1.5f);
                            float s = (w - 2 - gap) / 2;
                            g.FillRectangle(brush, x + 1, y + 1, s, s);
                            g.FillRectangle(brush, x + 1 + s + gap, y + 1, s, s);
                            g.FillRectangle(brush, x + 1, y + 1 + s + gap, s, s);
                            g.FillRectangle(brush, x + 1 + s + gap, y + 1 + s + gap, s, s);
                        }
                        break;
                    case Glyph.Gear:
                    case Glyph.Options:
                        {
                            float cx = x + w / 2, cy = y + h / 2;
                            float ro = w / 2 - 1, ri = w * 0.34f;
                            for (int i = 0; i < 8; i++)
                            {
                                double a = i * Math.PI / 4;
                                g.DrawLine(pen, cx + (float)Math.Cos(a) * ri, cy + (float)Math.Sin(a) * ri, cx + (float)Math.Cos(a) * ro, cy + (float)Math.Sin(a) * ro);
                            }
                            g.DrawEllipse(pen, cx - ri, cy - ri, ri * 2, ri * 2);
                            float rc = w * 0.13f;
                            g.DrawEllipse(pen, cx - rc, cy - rc, rc * 2, rc * 2);
                        }
                        break;
                    case Glyph.Apps:
                        {
                            float s = w * 0.36f;
                            g.DrawRectangle(pen, x + 1, y + 1, s, s);
                            g.DrawRectangle(pen, x + w - 1 - s, y + 1, s, s);
                            g.DrawRectangle(pen, x + 1, y + h - 1 - s, s, s);
                            g.DrawRectangle(pen, x + w - 1 - s, y + h - 1 - s, s, s);
                        }
                        break;
                    case Glyph.Rocket:
                        {
                            g.DrawPolygon(pen, new[] { new PointF(x + w / 2, y + 1), new PointF(x + w * 0.75f, y + h * 0.55f), new PointF(x + w / 2, y + h * 0.7f), new PointF(x + w * 0.25f, y + h * 0.55f) });
                            g.DrawLine(pen, x + w * 0.3f, y + h * 0.65f, x + w * 0.18f, y + h - 1);
                            g.DrawLine(pen, x + w * 0.7f, y + h * 0.65f, x + w * 0.82f, y + h - 1);
                            g.DrawLine(pen, x + w / 2, y + h * 0.78f, x + w / 2, y + h - 1);
                        }
                        break;
                    case Glyph.Download:
                        g.DrawLine(pen, x + w / 2, y + 1, x + w / 2, y + h * 0.68f);
                        g.DrawLines(pen, new[] { new PointF(x + w * 0.22f, y + h * 0.42f), new PointF(x + w / 2, y + h * 0.7f), new PointF(x + w * 0.78f, y + h * 0.42f) });
                        g.DrawLine(pen, x + 1, y + h - 1, x + w - 1, y + h - 1);
                        break;
                    case Glyph.Broom:
                        g.DrawLine(pen, x + w - 2, y + 1, x + w * 0.45f, y + h * 0.55f);
                        g.DrawPolygon(pen, new[] { new PointF(x + w * 0.3f, y + h * 0.42f), new PointF(x + w * 0.6f, y + h * 0.72f), new PointF(x + w * 0.35f, y + h - 1), new PointF(x + 1, y + h * 0.7f) });
                        break;
                    case Glyph.Pulse:
                        g.DrawLines(pen, new[] {
                            new PointF(x + 1, y + h / 2), new PointF(x + w * 0.3f, y + h / 2), new PointF(x + w * 0.42f, y + 2),
                            new PointF(x + w * 0.58f, y + h - 2), new PointF(x + w * 0.7f, y + h / 2), new PointF(x + w - 1, y + h / 2) });
                        break;
                    case Glyph.Globe:
                        g.DrawEllipse(pen, x + 1, y + 1, w - 2, h - 2);
                        g.DrawEllipse(pen, x + w * 0.3f, y + 1, w * 0.4f, h - 2);
                        g.DrawLine(pen, x + 1, y + h / 2, x + w - 1, y + h / 2);
                        break;
                    case Glyph.Lock:
                        {
                            RectangleF body = new RectangleF(x + w * 0.16f, y + h * 0.44f, w * 0.68f, h * 0.52f);
                            using (GraphicsPath bp = Draw.RoundedRect(body, Draw.S(2f))) g.DrawPath(pen, bp);
                            float sw = w * 0.44f;
                            using (GraphicsPath sp = new GraphicsPath())
                            {
                                sp.AddLine(x + (w - sw) / 2, body.Top, x + (w - sw) / 2, y + h * 0.3f);
                                sp.AddArc(x + (w - sw) / 2, y + 1, sw, sw, 180, 180);
                                sp.AddLine(x + (w + sw) / 2, y + h * 0.3f, x + (w + sw) / 2, body.Top);
                                g.DrawPath(pen, sp);
                            }
                            float kd = Draw.S(2.2f);
                            g.FillEllipse(brush, x + w / 2 - kd / 2, body.Top + body.Height * 0.38f, kd, kd);
                        }
                        break;
                    case Glyph.Wrench:
                        g.DrawLine(pen, x + 2, y + h - 2, x + w * 0.6f, y + h * 0.4f);
                        g.DrawArc(pen, x + w * 0.45f, y + 1, w * 0.5f, h * 0.5f, 120, 270);
                        break;
                    case Glyph.Chip:
                        g.DrawRectangle(pen, x + w * 0.22f, y + h * 0.22f, w * 0.56f, h * 0.56f);
                        for (int i = 0; i < 3; i++)
                        {
                            float o = w * (0.33f + i * 0.17f);
                            g.DrawLine(pen, x + o, y + 1, x + o, y + h * 0.22f);
                            g.DrawLine(pen, x + o, y + h * 0.78f, x + o, y + h - 1);
                            g.DrawLine(pen, x + 1, y + o, x + w * 0.22f, y + o);
                            g.DrawLine(pen, x + w * 0.78f, y + o, x + w - 1, y + o);
                        }
                        break;
                    case Glyph.Puzzle:
                        g.DrawRectangle(pen, x + 1, y + h * 0.3f, w * 0.7f, h * 0.68f);
                        g.DrawEllipse(pen, x + w * 0.24f, y + 1, w * 0.24f, h * 0.29f);
                        g.DrawEllipse(pen, x + w * 0.71f, y + h * 0.52f, w * 0.27f, h * 0.24f);
                        break;
                    case Glyph.Refresh:
                        {
                            RectangleF rr = new RectangleF(x + 2, y + 2, w - 4, h - 4);
                            g.DrawArc(pen, rr, -60, 300);
                            float ax = x + w / 2 + (float)Math.Cos(-Math.PI / 3) * rr.Width / 2;
                            float ay = y + h / 2 + (float)Math.Sin(-Math.PI / 3) * rr.Height / 2;
                            g.DrawLines(pen, new[] { new PointF(ax - w * 0.3f, ay - h * 0.08f), new PointF(ax, ay), new PointF(ax + w * 0.02f, ay - h * 0.3f) });
                        }
                        break;
                    case Glyph.Search:
                        g.DrawEllipse(pen, x + 1, y + 1, w * 0.62f, h * 0.62f);
                        g.DrawLine(pen, x + w * 0.56f, y + h * 0.56f, x + w - 1.5f, y + h - 1.5f);
                        break;
                    case Glyph.Power:
                        g.DrawArc(pen, x + 1.5f, y + 2.5f, w - 3, h - 3, -50, 280);
                        g.DrawLine(pen, x + w / 2, y + 1, x + w / 2, y + h * 0.45f);
                        break;
                    case Glyph.Help:
                        g.DrawEllipse(pen, x + 1, y + 1, w - 2, h - 2);
                        g.DrawArc(pen, x + w * 0.36f, y + h * 0.24f, w * 0.28f, h * 0.26f, 180, 230);
                        g.DrawLine(pen, x + w / 2, y + h * 0.5f, x + w / 2, y + h * 0.6f);
                        g.FillEllipse(brush, x + w / 2 - w * 0.06f, y + h * 0.7f, w * 0.12f, h * 0.12f);
                        break;
                    case Glyph.Heart:
                        using (GraphicsPath gp = new GraphicsPath())
                        {
                            PointF bottom = new PointF(x + w / 2, y + h - 2);
                            PointF mid = new PointF(x + w / 2, y + h * 0.3f);
                            gp.AddBezier(bottom, new PointF(x - w * 0.05f, y + h * 0.5f), new PointF(x + w * 0.15f, y - h * 0.05f), mid);
                            gp.AddBezier(mid, new PointF(x + w * 0.85f, y - h * 0.05f), new PointF(x + w * 1.05f, y + h * 0.5f), bottom);
                            gp.CloseFigure();
                            g.DrawPath(pen, gp);
                        }
                        break;
                    case Glyph.Code:
                        g.DrawLines(pen, new[] { new PointF(x + w * 0.3f, y + h * 0.25f), new PointF(x + 1, y + h / 2), new PointF(x + w * 0.3f, y + h * 0.75f) });
                        g.DrawLines(pen, new[] { new PointF(x + w * 0.7f, y + h * 0.25f), new PointF(x + w - 1, y + h / 2), new PointF(x + w * 0.7f, y + h * 0.75f) });
                        g.DrawLine(pen, x + w * 0.58f, y + h * 0.15f, x + w * 0.42f, y + h * 0.85f);
                        break;
                    case Glyph.Chat:
                        using (GraphicsPath gp = Draw.RoundedRect(new RectangleF(x + 1, y + 2, w - 2, h * 0.62f), w * 0.15f))
                        {
                            g.DrawPath(pen, gp);
                        }
                        g.DrawLines(pen, new[] { new PointF(x + w * 0.3f, y + 2 + h * 0.62f), new PointF(x + w * 0.25f, y + h - 1.5f), new PointF(x + w * 0.5f, y + 2 + h * 0.62f) });
                        break;
                    case Glyph.Document:
                        g.DrawLines(pen, new[] {
                            new PointF(x + w * 0.62f, y + 1), new PointF(x + w * 0.18f, y + 1), new PointF(x + w * 0.18f, y + h - 1),
                            new PointF(x + w * 0.82f, y + h - 1), new PointF(x + w * 0.82f, y + h * 0.3f), new PointF(x + w * 0.62f, y + 1),
                            new PointF(x + w * 0.62f, y + h * 0.3f), new PointF(x + w * 0.82f, y + h * 0.3f) });
                        g.DrawLine(pen, x + w * 0.33f, y + h * 0.55f, x + w * 0.67f, y + h * 0.55f);
                        g.DrawLine(pen, x + w * 0.33f, y + h * 0.75f, x + w * 0.67f, y + h * 0.75f);
                        break;
                    case Glyph.Bug:
                        g.DrawEllipse(pen, x + w * 0.28f, y + h * 0.3f, w * 0.44f, h * 0.62f);
                        g.DrawArc(pen, x + w * 0.35f, y + h * 0.12f, w * 0.3f, h * 0.3f, 180, 180);
                        g.DrawLine(pen, x + w / 2, y + h * 0.45f, x + w / 2, y + h * 0.88f);
                        g.DrawLine(pen, x + 1, y + h * 0.45f, x + w * 0.28f, y + h * 0.52f);
                        g.DrawLine(pen, x + w - 1, y + h * 0.45f, x + w * 0.72f, y + h * 0.52f);
                        g.DrawLine(pen, x + 1, y + h * 0.85f, x + w * 0.3f, y + h * 0.75f);
                        g.DrawLine(pen, x + w - 1, y + h * 0.85f, x + w * 0.7f, y + h * 0.75f);
                        break;
                    case Glyph.Bulb:
                        g.DrawArc(pen, x + w * 0.2f, y + 1, w * 0.6f, h * 0.6f, 135, 270);
                        g.DrawLine(pen, x + w * 0.29f, y + h * 0.52f, x + w * 0.38f, y + h * 0.72f);
                        g.DrawLine(pen, x + w * 0.71f, y + h * 0.52f, x + w * 0.62f, y + h * 0.72f);
                        g.DrawLine(pen, x + w * 0.38f, y + h * 0.75f, x + w * 0.62f, y + h * 0.75f);
                        g.DrawLine(pen, x + w * 0.42f, y + h - 1.5f, x + w * 0.58f, y + h - 1.5f);
                        break;
                    case Glyph.Eye:
                        using (GraphicsPath ep = new GraphicsPath())
                        {
                            PointF el = new PointF(x + 0.5f, y + h / 2), er = new PointF(x + w - 0.5f, y + h / 2);
                            ep.AddBezier(el, new PointF(x + w * 0.25f, y + h * 0.1f), new PointF(x + w * 0.75f, y + h * 0.1f), er);
                            ep.AddBezier(er, new PointF(x + w * 0.75f, y + h * 0.9f), new PointF(x + w * 0.25f, y + h * 0.9f), el);
                            ep.CloseFigure();
                            g.DrawPath(pen, ep);
                        }
                        g.DrawEllipse(pen, x + w * 0.35f, y + h * 0.35f, w * 0.3f, h * 0.3f);
                        break;
                    case Glyph.Drive:
                        using (GraphicsPath dp = Draw.RoundedRect(new RectangleF(x + 1, y + h * 0.2f, w - 2, h * 0.6f), w * 0.14f))
                        {
                            g.DrawPath(pen, dp);
                        }
                        g.DrawLine(pen, x + 1, y + h * 0.52f, x + w - 1, y + h * 0.52f);
                        g.DrawLine(pen, x + w * 0.18f, y + h * 0.66f, x + w * 0.42f, y + h * 0.66f);
                        g.FillEllipse(brush, x + w * 0.68f, y + h * 0.6f, w * 0.13f, h * 0.13f);
                        break;
                    case Glyph.User:
                        g.DrawEllipse(pen, x + w * 0.32f, y + 1, w * 0.36f, h * 0.38f);
                        g.DrawArc(pen, x + w * 0.12f, y + h * 0.5f, w * 0.76f, h * 0.9f, 180, 180);
                        break;
                    default:
                        g.DrawEllipse(pen, x + 2, y + 2, w - 4, h - 4);
                        break;
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                TabControl = null;
                _tip.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
