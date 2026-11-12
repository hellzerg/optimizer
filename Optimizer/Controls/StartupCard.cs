using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Optimizer {
    internal enum StartupCardAction {
        LocateFile,
        LocateKey,
        Delete,
        Toggle
    }

    internal sealed class StartupCardActionEventArgs : EventArgs {
        internal StartupCardActionEventArgs(StartupCardAction action) { Action = action; }
        internal StartupCardAction Action { get; private set; }
    }

    /// <summary>
    /// Owner-drawn row for a single startup entry: selection box, program icon, name and command line,
    /// source badge and inline actions. Fully painted (no child controls) so long lists stay cheap.
    /// </summary>
    internal sealed class StartupCard : Control, IThemeable {
        const int HitNone = -1;
        const int HitCheck = 0;
        const int HitLocate = 1;
        const int HitRegistry = 2;
        const int HitDelete = 3;
        const int HitToggle = 4;

        readonly StartupItem _item;
        readonly string _badge;
        bool _checked;
        bool _hover;
        int _hot = HitNone;
        int _pressed = HitNone;
        Image _icon;
        bool _missing;

        Rectangle _checkRect, _iconRect, _textRect, _badgeRect, _toggleRect;
        readonly Rectangle[] _actions = new Rectangle[4];

        internal event EventHandler CheckedChanged;
        internal event EventHandler<StartupCardActionEventArgs> ActionInvoked;

        internal StartupCard(StartupItem item)
        {
            _item = item;
            _badge = BadgeText(item);
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);
            TabStop = true;
            Height = Draw.SI(64);
            Margin = new Padding(0);
        }

        internal StartupItem Item { get { return _item; } }

        internal string Badge { get { return _badge; } }

        internal bool CanLocateKey { get { return _item is RegistryStartupItem; } }

        internal bool CanToggle { get { return _item.CanToggle; } }

        internal bool IsItemEnabled { get { return !_item.CanToggle || _item.Enabled; } }

        /// <summary>Call after the item's Enabled state was changed or re-read.</summary>
        internal void RefreshState() { Invalidate(); }

        /// <summary>Tooltip texts for the inline actions (translated by the owner).</summary>
        internal static string LocateFileText = "Locate file";
        internal static string LocateKeyText = "Find in Registry";
        internal static string DeleteText = "Delete";
        internal static string MissingText = "File not found";
        internal static string EnabledTipText = "Enabled at sign-in \u2014 click to disable";
        internal static string DisabledTipText = "Disabled \u2014 click to enable";
        internal static string DisabledText = "Disabled";

        internal ToolTip Tips { get; set; }

        internal bool Checked
        {
            get { return _checked; }
            set
            {
                if (_checked == value) return;
                _checked = value;
                Invalidate();
                EventHandler h = CheckedChanged;
                if (h != null) h(this, EventArgs.Empty);
            }
        }

        /// <summary>Program icon; the card does not own it (icons are cached and shared).</summary>
        internal void SetIcon(Image icon, bool missing)
        {
            _icon = icon;
            _missing = missing;
            Invalidate();
        }

        internal static string BadgeText(StartupItem item)
        {
            string type = item.StartupType == StartupItemType.RunOnce ? "RunOnce" : "Run";
            switch (item.RegistryLocation)
            {
                case StartupItemLocation.HKCU: return "HKCU \u00b7 " + type;
                case StartupItemLocation.HKLM: return "HKLM \u00b7 " + type;
                case StartupItemLocation.HKLMWoW: return "HKLM 32-bit \u00b7 " + type;
                case StartupItemLocation.CUStartupFolder: return "Startup folder \u00b7 User";
                case StartupItemLocation.LMStartupFolder: return "Startup folder \u00b7 All users";
                default: return item.ToString();
            }
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

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRects();
        }

        void UpdateRects()
        {
            int h = Height;
            int pad = Draw.SI(14);

            int box = Draw.SI(18);
            _checkRect = new Rectangle(pad, (h - box) / 2, box, box);

            int icon = Draw.SI(32);
            _iconRect = new Rectangle(_checkRect.Right + Draw.SI(14), (h - icon) / 2, icon, icon);

            int btn = Draw.SI(32);
            int gap = Draw.SI(4);
            int right = Width - Draw.SI(10);
            _actions[HitDelete] = new Rectangle(right - btn, (h - btn) / 2, btn, btn);
            _actions[HitRegistry] = new Rectangle(_actions[HitDelete].Left - gap - btn, (h - btn) / 2, btn, btn);
            _actions[HitLocate] = new Rectangle(_actions[HitRegistry].Left - gap - btn, (h - btn) / 2, btn, btn);

            // the switch column is reserved whenever the OS supports it, so badges stay aligned across rows
            int badgeRight = _actions[HitLocate].Left - Draw.SI(16);
            if (StartupApproval.IsSupported)
            {
                int tw = Draw.SI(40), th = Draw.SI(20);
                _toggleRect = new Rectangle(badgeRight - tw, (h - th) / 2, tw, th);
                badgeRight = _toggleRect.Left - Draw.SI(20);
            }
            else
            {
                _toggleRect = Rectangle.Empty;
            }

            Size badge = TextRenderer.MeasureText(_badge, BadgeFont, Size.Empty, TextFormatFlags.NoPadding | TextFormatFlags.SingleLine);
            int bw = badge.Width + Draw.SI(20);
            int bh = Draw.SI(24);
            // fixed-width slot keeps badges aligned as a column; long texts simply grow left
            int slot = Math.Max(bw, Draw.SI(176));
            int bx = badgeRight - slot;
            _badgeRect = new Rectangle(bx, (h - bh) / 2, bw, bh);

            int tx = _iconRect.Right + Draw.SI(14);
            _textRect = new Rectangle(tx, 0, Math.Max(0, bx - Draw.SI(16) - tx), h);
        }

        static Font NameFont { get { return Typography.Get(10.5f, Typography.Weight.Semibold); } }
        static Font DetailFont { get { return Typography.Get(9f, Typography.Weight.Regular); } }
        static Font BadgeFont { get { return Typography.Get(8.5f, Typography.Weight.Regular); } }

        int HitTest(Point pt)
        {
            if (_actions[HitDelete].Contains(pt)) return HitDelete;
            if (CanLocateKey && _actions[HitRegistry].Contains(pt)) return HitRegistry;
            if (_actions[HitLocate].Contains(pt)) return HitLocate;
            if (CanToggle && Rectangle.Inflate(_toggleRect, Draw.SI(6), Draw.SI(8)).Contains(pt)) return HitToggle;
            return ClientRectangle.Contains(pt) ? HitCheck : HitNone;
        }

        string TipFor(int hit)
        {
            switch (hit)
            {
                case HitLocate: return LocateFileText;
                case HitRegistry: return LocateKeyText;
                case HitDelete: return DeleteText;
                case HitToggle: return _item.Enabled ? EnabledTipText : DisabledTipText;
            }
            if (_textRect.Contains(PointToClient(Cursor.Position)))
            {
                return _missing ? MissingText + Environment.NewLine + _item.FileLocation : _item.FileLocation;
            }
            return null;
        }

        void SetHot(int hot)
        {
            if (_hot == hot) return;
            _hot = hot;
            if (Tips != null) Tips.SetToolTip(this, TipFor(hot));
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }

        protected override void OnMouseLeave(EventArgs e)
        {
            _hover = false;
            _pressed = HitNone;
            SetHot(HitNone);
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            int hit = HitTest(e.Location);
            // the text area shows its own tooltip, so treat it as a separate hot zone
            if (hit == HitCheck && _textRect.Contains(e.Location)) hit = HitCheck + 100;
            SetHot(hit);
            Cursor = hit == HitLocate || hit == HitRegistry || hit == HitDelete || hit == HitToggle ? Cursors.Hand : Cursors.Default;
            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Focus();
                _pressed = HitTest(e.Location);
                Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            int pressed = _pressed;
            _pressed = HitNone;
            Invalidate();

            if (e.Button == MouseButtons.Left && pressed != HitNone && pressed == HitTest(e.Location))
            {
                switch (pressed)
                {
                    case HitCheck: Checked = !Checked; break;
                    case HitLocate: Raise(StartupCardAction.LocateFile); break;
                    case HitRegistry: Raise(StartupCardAction.LocateKey); break;
                    case HitDelete: Raise(StartupCardAction.Delete); break;
                    case HitToggle:
                        Raise(StartupCardAction.Toggle);
                        if (Tips != null) Tips.SetToolTip(this, TipFor(HitToggle));
                        break;
                }
            }
            base.OnMouseUp(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { Checked = !Checked; e.Handled = true; }
            else if (e.KeyCode == Keys.Delete) { Raise(StartupCardAction.Delete); e.Handled = true; }
            base.OnKeyDown(e);
        }

        protected override void OnGotFocus(EventArgs e) { Invalidate(); base.OnGotFocus(e); }
        protected override void OnLostFocus(EventArgs e) { Invalidate(); base.OnLostFocus(e); }

        void Raise(StartupCardAction action)
        {
            EventHandler<StartupCardActionEventArgs> h = ActionInvoked;
            if (h != null) h(this, new StartupCardActionEventArgs(action));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.WindowBg);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color fill = _hover ? p.Layer1Hover : p.Layer1;
            Color stroke = _checked ? p.Accent : (p.IsDark ? ColorMath.Blend(p.Layer1, Color.Black, 0.35) : p.Stroke);

            RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(6)))
            using (SolidBrush b = new SolidBrush(fill))
            using (Pen pen = new Pen(stroke))
            {
                g.FillPath(b, path);
                g.DrawPath(pen, path);
            }

            if (Focused && ShowFocusCues)
            {
                RectangleF fr = new RectangleF(1.5f, 1.5f, Width - 3.5f, Height - 3.5f);
                using (GraphicsPath path = Draw.RoundedRect(fr, Draw.S(5)))
                using (Pen pen = new Pen(p.TextPrimary, Draw.S(1.5f)))
                {
                    g.DrawPath(pen, path);
                }
            }

            PaintCheck(g, p);
            PaintIcon(g, p);
            PaintText(g, p, fill);
            PaintBadge(g, p);
            if (CanToggle) PaintToggle(g, p, fill);

            PaintAction(g, p, HitLocate, fill);
            if (CanLocateKey) PaintAction(g, p, HitRegistry, fill);
            PaintAction(g, p, HitDelete, fill);
        }

        void PaintCheck(Graphics g, Palette p)
        {
            RectangleF r = new RectangleF(_checkRect.X + 0.5f, _checkRect.Y + 0.5f, _checkRect.Width - 1f, _checkRect.Height - 1f);
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(4)))
            {
                if (_checked)
                {
                    using (SolidBrush b = new SolidBrush(_hover ? p.AccentHover : p.Accent)) g.FillPath(b, path);
                    float s = _checkRect.Width;
                    using (Pen pen = new Pen(p.OnAccent, Draw.S(1.6f)) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round })
                    {
                        g.DrawLines(pen, new[] {
                            new PointF(_checkRect.X + s * 0.26f, _checkRect.Y + s * 0.52f),
                            new PointF(_checkRect.X + s * 0.43f, _checkRect.Y + s * 0.69f),
                            new PointF(_checkRect.X + s * 0.75f, _checkRect.Y + s * 0.33f) });
                    }
                }
                else
                {
                    using (SolidBrush b = new SolidBrush(_hover ? p.ControlHover : p.ControlFill)) g.FillPath(b, path);
                    using (Pen pen = new Pen(_hover ? p.TextSecondary : p.StrokeStrong)) g.DrawPath(pen, path);
                }
            }
        }

        void PaintIcon(Graphics g, Palette p)
        {
            if (_icon != null)
            {
                InterpolationMode old = g.InterpolationMode;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                if (IsItemEnabled)
                {
                    g.DrawImage(_icon, _iconRect);
                }
                else
                {
                    using (ImageAttributes ia = new ImageAttributes())
                    {
                        ia.SetColorMatrix(new ColorMatrix { Matrix33 = 0.4f });
                        g.DrawImage(_icon, _iconRect, 0, 0, _icon.Width, _icon.Height, GraphicsUnit.Pixel, ia);
                    }
                }
                g.InterpolationMode = old;
                return;
            }

            // generic application glyph while loading or when no icon could be extracted
            Rectangle r = Rectangle.Inflate(_iconRect, -Draw.SI(3), -Draw.SI(4));
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(3)))
            using (SolidBrush b = new SolidBrush(p.ControlFill))
            using (Pen pen = new Pen(p.TextSecondary, Draw.S(1.2f)))
            {
                g.FillPath(b, path);
                g.DrawPath(pen, path);
                float bar = r.Top + Draw.S(6);
                g.DrawLine(pen, r.Left, bar, r.Right, bar);
            }
        }

        void PaintText(Graphics g, Palette p, Color fill)
        {
            if (_textRect.Width <= 0) return;

            Font nameFont = NameFont;
            Font detailFont = DetailFont;
            int nameH = TextRenderer.MeasureText(g, "Ag", nameFont, Size.Empty, TextFormatFlags.NoPadding).Height;
            int detailH = TextRenderer.MeasureText(g, "Ag", detailFont, Size.Empty, TextFormatFlags.NoPadding).Height;
            int gap = Draw.SI(2);
            int top = (Height - nameH - gap - detailH) / 2;

            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.SingleLine
                | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix;

            Rectangle nameRect = new Rectangle(_textRect.Left, top, _textRect.Width, nameH);
            if (IsItemEnabled)
            {
                TextRenderer.DrawText(g, _item.Name, nameFont, nameRect, p.TextPrimary, fill, flags);
            }
            else
            {
                // dimmed name followed by a small "Disabled" pill
                Font pillFont = BadgeFont;
                Size pill = TextRenderer.MeasureText(g, DisabledText, pillFont, Size.Empty, TextFormatFlags.NoPadding | TextFormatFlags.SingleLine);
                int pw = pill.Width + Draw.SI(14);
                int ph = Math.Min(nameH, pill.Height + Draw.SI(4));
                int pillGap = Draw.SI(8);
                int maxName = Math.Max(0, nameRect.Width - pw - pillGap);
                int nameW = Math.Min(maxName, TextRenderer.MeasureText(g, _item.Name, nameFont, Size.Empty,
                    TextFormatFlags.SingleLine | TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix).Width + 1);
                TextRenderer.DrawText(g, _item.Name, nameFont, new Rectangle(nameRect.Left, nameRect.Top, nameW, nameH), p.TextSecondary, fill, flags);

                if (nameRect.Width >= pw)
                {
                    Rectangle pr = new Rectangle(nameRect.Left + nameW + (nameW > 0 ? pillGap : 0), nameRect.Top + (nameH - ph) / 2, pw, ph);
                    Color pf = p.IsDark ? ColorMath.Blend(fill, Color.White, 0.08) : ColorMath.Blend(fill, Color.Black, 0.06);
                    using (GraphicsPath path = Draw.RoundedRect(new RectangleF(pr.X + 0.5f, pr.Y + 0.5f, pr.Width - 1f, pr.Height - 1f), Draw.S(4)))
                    using (SolidBrush b = new SolidBrush(pf))
                    {
                        g.FillPath(b, path);
                    }
                    TextRenderer.DrawText(g, DisabledText, pillFont, pr, p.TextSecondary, pf,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix);
                }
            }

            Rectangle detailRect = new Rectangle(_textRect.Left, nameRect.Bottom + gap, _textRect.Width, detailH);
            if (_missing)
            {
                string tag = MissingText + "  \u00b7  ";
                int tw = TextRenderer.MeasureText(g, tag, detailFont, Size.Empty, TextFormatFlags.SingleLine | TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix).Width;
                TextRenderer.DrawText(g, tag, detailFont, detailRect, p.Danger, fill, flags);
                detailRect = new Rectangle(detailRect.Left + tw, detailRect.Top, Math.Max(0, detailRect.Width - tw), detailRect.Height);
            }
            TextRenderer.DrawText(g, _item.FileLocation, detailFont, detailRect, p.TextSecondary, fill, flags | TextFormatFlags.PathEllipsis);
        }

        void PaintBadge(Graphics g, Palette p)
        {
            if (_badgeRect.Left < _textRect.Left) return;

            Color fill = p.IsDark ? ColorMath.Blend(p.Layer1, Color.White, 0.06) : ColorMath.Blend(p.Layer1, Color.Black, 0.04);
            RectangleF r = new RectangleF(_badgeRect.X + 0.5f, _badgeRect.Y + 0.5f, _badgeRect.Width - 1f, _badgeRect.Height - 1f);
            using (GraphicsPath path = Draw.RoundedRect(r, r.Height / 2f))
            using (SolidBrush b = new SolidBrush(fill))
            using (Pen pen = new Pen(p.Stroke))
            {
                g.FillPath(b, path);
                g.DrawPath(pen, path);
            }

            TextRenderer.DrawText(g, _badge, BadgeFont, _badgeRect, p.TextSecondary, fill,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix);
        }

        void PaintToggle(Graphics g, Palette p, Color cardFill)
        {
            bool on = _item.Enabled;
            bool hot = _hot == HitToggle;
            bool pressed = hot && _pressed == HitToggle;

            RectangleF track = new RectangleF(_toggleRect.X + 0.5f, _toggleRect.Y + 0.5f, _toggleRect.Width - 1f, _toggleRect.Height - 1f);
            float radius = track.Height / 2f;
            float knob = track.Height * (pressed ? 0.70f : (hot ? 0.62f : 0.54f));
            float inset = (track.Height - knob) / 2f;
            float knobY = track.Y + inset;

            using (GraphicsPath path = Draw.RoundedRect(track, radius))
            {
                if (on)
                {
                    using (SolidBrush b = new SolidBrush(pressed ? p.AccentPressed : (hot ? p.AccentHover : p.Accent))) g.FillPath(b, path);
                    using (SolidBrush b = new SolidBrush(p.OnAccent)) g.FillEllipse(b, track.Right - inset - knob, knobY, knob, knob);
                }
                else
                {
                    Color fill = hot ? ColorMath.Blend(cardFill, p.ControlHover, 0.8) : ColorMath.Blend(cardFill, p.InputFill, 0.5);
                    using (SolidBrush b = new SolidBrush(fill)) g.FillPath(b, path);
                    using (Pen pen = new Pen(p.ToggleOff)) g.DrawPath(pen, path);
                    using (SolidBrush b = new SolidBrush(p.ToggleOff)) g.FillEllipse(b, track.X + inset, knobY, knob, knob);
                }
            }
        }

        void PaintAction(Graphics g, Palette p, int hit, Color cardFill)
        {
            Rectangle r = _actions[hit];
            bool hot = _hot == hit;
            bool pressed = hot && _pressed == hit;

            if (hot)
            {
                RectangleF rf = new RectangleF(r.X + 0.5f, r.Y + 0.5f, r.Width - 1f, r.Height - 1f);
                using (GraphicsPath path = Draw.RoundedRect(rf, Draw.S(4)))
                using (SolidBrush b = new SolidBrush(pressed ? p.ControlPressed : (p.IsDark ? ColorMath.Blend(cardFill, Color.White, 0.08) : ColorMath.Blend(cardFill, Color.Black, 0.06))))
                {
                    g.FillPath(b, path);
                }
            }

            Color c = hot ? (hit == HitDelete ? p.Danger : p.TextPrimary) : p.TextSecondary;
            int s = Draw.SI(16);
            Rectangle glyph = new Rectangle(r.X + (r.Width - s) / 2, r.Y + (r.Height - s) / 2, s, s);

            using (Pen pen = new Pen(c, Draw.S(1.3f)) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                float x = glyph.X, y = glyph.Y, w = glyph.Width, h = glyph.Height;
                switch (hit)
                {
                    case HitLocate:
                        // folder
                        using (GraphicsPath gp = new GraphicsPath())
                        {
                            gp.AddLines(new[] {
                                new PointF(x + 1, y + h * 0.82f), new PointF(x + 1, y + h * 0.18f), new PointF(x + w * 0.38f, y + h * 0.18f),
                                new PointF(x + w * 0.5f, y + h * 0.32f), new PointF(x + w - 1, y + h * 0.32f), new PointF(x + w - 1, y + h * 0.82f) });
                            gp.CloseFigure();
                            g.DrawPath(pen, gp);
                        }
                        g.DrawLine(pen, x + 1, y + h * 0.45f, x + w - 1, y + h * 0.45f);
                        break;
                    case HitRegistry:
                        // registry editor "cubes"
                        {
                            float q = w * 0.36f;
                            g.DrawRectangle(pen, x + 1, y + h - 1 - q, q, q);
                            g.DrawRectangle(pen, x + 1 + q, y + h - 1 - q, q, q);
                            g.DrawRectangle(pen, x + 1, y + h - 1 - 2 * q, q, q);
                            g.DrawRectangle(pen, x + w - 1 - q, y + 1, q, q);
                        }
                        break;
                    case HitDelete:
                        // trash can
                        g.DrawLine(pen, x + 1, y + h * 0.22f, x + w - 1, y + h * 0.22f);
                        g.DrawLines(pen, new[] { new PointF(x + w * 0.36f, y + h * 0.22f), new PointF(x + w * 0.36f, y + 1), new PointF(x + w * 0.64f, y + 1), new PointF(x + w * 0.64f, y + h * 0.22f) });
                        g.DrawLines(pen, new[] { new PointF(x + w * 0.18f, y + h * 0.22f), new PointF(x + w * 0.25f, y + h - 1), new PointF(x + w * 0.75f, y + h - 1), new PointF(x + w * 0.82f, y + h * 0.22f) });
                        g.DrawLine(pen, x + w * 0.42f, y + h * 0.4f, x + w * 0.42f, y + h * 0.8f);
                        g.DrawLine(pen, x + w * 0.58f, y + h * 0.4f, x + w * 0.58f, y + h * 0.8f);
                        break;
                }
            }
        }
    }

    /// <summary>
    /// Scrollable vertical list of <see cref="StartupCard"/>s. Cards always span the client width
    /// (so no horizontal scrolling); hidden cards are skipped and an empty-state message is painted instead.
    /// </summary>
    public sealed class StartupList : Panel, IThemeable {
        string _emptyText = string.Empty;
        readonly List<Control> _order = new List<Control>();

        public StartupList()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            AutoScroll = true;
        }

        public string EmptyText
        {
            get { return _emptyText; }
            set { _emptyText = value ?? string.Empty; Invalidate(); }
        }

        /// <summary>Display order (top to bottom) of the cards; controls not listed keep collection order after them.</summary>
        internal void SetOrder(IEnumerable<Control> order)
        {
            _order.Clear();
            _order.AddRange(order);
            PerformLayout();
            Invalidate();
        }

        public void ApplyTheme(Palette palette)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            ThemeManager.ThemeScrollbars(this);
            Invalidate();
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            base.OnParentBackColorChanged(e);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            int gap = Draw.SI(6);
            int y = AutoScrollPosition.Y;
            int width = Math.Max(0, ClientSize.Width - Draw.SI(2));

            HashSet<Control> placed = new HashSet<Control>();
            foreach (Control c in _order)
            {
                if (c.Parent != this) continue;
                placed.Add(c);
                y = Place(c, y, width, gap);
            }
            foreach (Control c in Controls)
            {
                if (placed.Contains(c)) continue;
                y = Place(c, y, width, gap);
            }

            base.OnLayout(levent);
        }

        static int Place(Control c, int y, int width, int gap)
        {
            if (!LayoutUtil.IsShown(c)) return y;
            LayoutUtil.Arrange(c, new Rectangle(0, y, width, c.Height));
            return y + c.Height + gap;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_emptyText.Length == 0) return;

            foreach (Control c in Controls)
            {
                if (LayoutUtil.IsShown(c)) return;
            }

            Palette p = ThemeManager.Current;
            Rectangle r = new Rectangle(0, Draw.SI(48), ClientSize.Width, Draw.SI(60));
            TextRenderer.DrawText(e.Graphics, _emptyText, Typography.Get(11f, Typography.Weight.Regular), r, p.TextSecondary,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.Top | TextFormatFlags.WordBreak | TextFormatFlags.NoPrefix);
        }
    }

    /// <summary>
    /// Resolves the program behind a startup command line and extracts its icon. Runs off the UI thread;
    /// results are handed back to the UI thread and cached there.
    /// </summary>
    internal static class StartupIcons {
        // UI-thread only
        static readonly Dictionary<string, Image> _cache = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);

        internal sealed class Result {
            internal string Path;
            internal bool Missing;
            internal Image Icon;
        }

        internal static bool TryGetCached(string path, out Image icon)
        {
            return _cache.TryGetValue(path ?? string.Empty, out icon);
        }

        /// <summary>Stores a freshly extracted icon; returns the instance to use (an existing one wins).</summary>
        internal static Image Store(string path, Image icon)
        {
            Image existing;
            if (_cache.TryGetValue(path, out existing))
            {
                if (icon != null && !ReferenceEquals(icon, existing)) icon.Dispose();
                return existing;
            }
            _cache[path] = icon;
            return icon;
        }

        /// <summary>Best-effort executable path for an entry; null when nothing usable is found.</summary>
        internal static string ResolvePath(StartupItem item)
        {
            try
            {
                string s = item.FileLocation;
                FolderStartupItem folder = item as FolderStartupItem;
                if (string.IsNullOrWhiteSpace(s) && folder != null) s = folder.Shortcut;
                if (string.IsNullOrWhiteSpace(s)) return null;

                s = Environment.ExpandEnvironmentVariables(s.Trim());
                string path;

                if (s.StartsWith("\""))
                {
                    int end = s.IndexOf('"', 1);
                    path = end > 1 ? s.Substring(1, end - 1) : s.Trim('"');
                }
                else if (File.Exists(s))
                {
                    path = s;
                }
                else
                {
                    int i = s.IndexOf(".exe", StringComparison.OrdinalIgnoreCase);
                    if (i >= 0) path = s.Substring(0, i + 4);
                    else
                    {
                        int space = s.IndexOf(' ');
                        path = space > 0 ? s.Substring(0, space) : s;
                    }
                }

                path = path.Trim();
                if (path.Length == 0 || path.IndexOfAny(System.IO.Path.GetInvalidPathChars()) >= 0) return null;

                if (!System.IO.Path.IsPathRooted(path))
                {
                    string found = SearchPath(path);
                    return found;
                }
                return path;
            }
            catch
            {
                return null;
            }
        }

        static string SearchPath(string file)
        {
            List<string> dirs = new List<string> { Environment.SystemDirectory, Environment.GetFolderPath(Environment.SpecialFolder.Windows) };
            string env = Environment.GetEnvironmentVariable("PATH");
            if (!string.IsNullOrEmpty(env)) dirs.AddRange(env.Split(';'));

            foreach (string dir in dirs)
            {
                if (string.IsNullOrWhiteSpace(dir)) continue;
                try
                {
                    string candidate = System.IO.Path.Combine(dir.Trim(), file);
                    if (File.Exists(candidate)) return candidate;
                    if (!System.IO.Path.HasExtension(candidate) && File.Exists(candidate + ".exe")) return candidate + ".exe";
                }
                catch { }
            }
            return null;
        }

        /// <summary>Background-thread work: existence check plus icon extraction for one resolved path.</summary>
        internal static Result Load(string path)
        {
            Result result = new Result { Path = path };
            if (string.IsNullOrEmpty(path)) return result;

            try
            {
                if (!File.Exists(path))
                {
                    result.Missing = !Directory.Exists(path);
                    return result;
                }

                using (Icon icon = Icon.ExtractAssociatedIcon(path))
                {
                    if (icon != null) result.Icon = icon.ToBitmap();
                }
            }
            catch
            {
                result.Icon = null;
            }
            return result;
        }
    }
}
