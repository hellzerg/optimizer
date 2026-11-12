using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        sealed class OptionsAction {
            public Button Button;
            public FluentLabel Desc;
            public string DescKey, DescFallback;
        }

        sealed class OptionsSection {
            public FluentLabel Header;
            public Control[] Blocks;
        }

        readonly List<OptionsAction> _optActions = new List<OptionsAction>();
        readonly List<LinkChip> _optChips = new List<LinkChip>();
        readonly Dictionary<Control, Func<int, int>> _optMeasure = new Dictionary<Control, Func<int, int>>();
        OptionsSection _optGeneral, _optAppearance, _optLanguage, _optUpdates, _optTrouble, _optAbout;
        CardPanel _optAccentCard, _optLangCard, _optUpdateCard, _optTroubleCard, _optAboutCard;
        FluentLabel _optAccentTitle, _optAccentHint, _optLangTitle, _optLangHint, _optAppName, _optVersion;
        AccentSwatches _optSwatches;
        bool _optLayingOut;

        void InitOptionsUi()
        {
            optionsTab.AutoScroll = true;
            optionsTab.SuspendLayout();

            ToggleCard[] general = { quickAccessToggle, autoStartToggle, autoUpdateToggle };
            foreach (ToggleCard t in general) Reparent(t, optionsTab);
            Reparent(themeModeToggle, optionsTab);

            // Appearance: dark mode + accent color card
            _optAccentCard = NewCard(optionsTab);
            _optAccentTitle = NewLabel(_optAccentCard, 10.5f, Typography.Weight.Semibold, LabelTone.Primary);
            _optAccentHint = NewLabel(_optAccentCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            Reparent(colorPicker1, _optAccentCard);
            _optSwatches = new AccentSwatches(() => colorPicker1.Color);
            _optSwatches.Picked += c => colorPicker1.Color = c;
            _optAccentCard.Controls.Add(_optSwatches);
            colorPicker1.ColorChanged += (s, e) => _optSwatches.Invalidate();
            _optMeasure[_optAccentCard] = LayoutOptionsAccent;

            // Language
            _optLangCard = NewCard(optionsTab);
            _optLangTitle = Mirror(languagesL, _optLangCard, 10.5f, Typography.Weight.Semibold, LabelTone.Primary, LayoutOptionsTab);
            _optLangHint = NewLabel(_optLangCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            Reparent(boxLang, _optLangCard);
            Reparent(picFlag, _optLangCard);
            boxLang.Font = Typography.Get(10f, Typography.Weight.Regular);
            _optMeasure[_optLangCard] = LayoutOptionsLanguage;

            // Updates
            _optUpdateCard = NewCard(optionsTab);
            _optAppName = NewLabel(_optUpdateCard, 10.5f, Typography.Weight.Semibold, LabelTone.Primary);
            _optAppName.Text = "Optimizer";
            _optVersion = NewLabel(_optUpdateCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            Reparent(btnUpdate, _optUpdateCard);
            _optMeasure[_optUpdateCard] = LayoutOptionsUpdate;

            // Troubleshooting
            _optTroubleCard = NewCard(optionsTab);
            AddOptionsAction(btnViewLog, "optDescViewLog", "Review errors Optimizer has logged on this PC.");
            AddOptionsAction(btnOpenConf, "optDescOpenConf", "Open the folder where settings and logs are stored.");
            AddOptionsAction(btnResetConfig, "optDescReset", "Reset Optimizer's settings if something misbehaves.");
            AddOptionsAction(btnReinforce, "optDescReinforce", "Re-apply the tweaks you enabled, in case Windows reverted them.");
            _optMeasure[_optTroubleCard] = LayoutOptionsTrouble;

            // About & support
            _optAboutCard = NewCard(optionsTab);
            AddOptionsChip(linkLabel7, SidebarNav.Glyph.Help, linkLabel7_LinkClicked);
            AddOptionsChip(linkLabel1, SidebarNav.Glyph.Chat, linkLabel1_LinkClicked_1);
            AddOptionsChip(linkLabel4, SidebarNav.Glyph.Bug, linkLabel4_LinkClicked_1);
            AddOptionsChip(linkLabel6, SidebarNav.Glyph.Bulb, linkLabel6_LinkClicked);
            AddOptionsChip(linkLabel2, SidebarNav.Glyph.Code, linkLabel2_LinkClicked_1);
            AddOptionsChip(linkLabel5, SidebarNav.Glyph.Document, linkLabel5_LinkClicked);
            AddOptionsChip(linkLabel3, SidebarNav.Glyph.Heart, linkLabel3_LinkClicked_1);
            AddOptionsChip(l2, SidebarNav.Glyph.User, l2_LinkClicked);
            _optMeasure[_optAboutCard] = LayoutOptionsAbout;

            _optGeneral = NewOptionsSection(general);
            _optAppearance = NewOptionsSection(themeModeToggle, _optAccentCard);
            _optLanguage = NewOptionsSection(_optLangCard);
            _optUpdates = new OptionsSection { Header = Mirror(lblUpdating, optionsTab, 10.5f, Typography.Weight.Semibold, LabelTone.Primary, LayoutOptionsTab), Blocks = new Control[] { _optUpdateCard } };
            _optTrouble = new OptionsSection { Header = Mirror(lblTroubleshoot, optionsTab, 10.5f, Typography.Weight.Semibold, LabelTone.Primary, LayoutOptionsTab), Blocks = new Control[] { _optTroubleCard } };
            _optAbout = NewOptionsSection(_optAboutCard);

            foreach (Control c in new Control[] { optionsLayout, panel9, languagesL, pictureBox3, pictureBox5, pictureBox6, pictureBox7, pictureBox12, pictureBox13, pictureBox14, pictureBox17, pictureBox85 })
                c.Visible = false;

            optionsTab.ResumeLayout(false);
            optionsTab.Layout += (s, e) => LayoutOptionsTab();
        }

        OptionsSection NewOptionsSection(params Control[] blocks)
        {
            return new OptionsSection { Header = NewLabel(optionsTab, 10.5f, Typography.Weight.Semibold, LabelTone.Primary), Blocks = blocks };
        }

        void AddOptionsAction(Button button, string descKey, string descFallback)
        {
            OptionsAction a = new OptionsAction { Button = button, DescKey = descKey, DescFallback = descFallback };
            Reparent(button, _optTroubleCard);
            a.Desc = NewLabel(_optTroubleCard, 9.5f, Typography.Weight.Regular, LabelTone.Primary);
            button.TextChanged += (s, e) => LayoutOptionsTab();
            _optActions.Add(a);
        }

        void AddOptionsChip(LinkLabel source, SidebarNav.Glyph glyph, LinkLabelLinkClickedEventHandler handler)
        {
            LinkChip chip = new LinkChip(glyph) { Text = CleanText(source.Text), AccessibleName = CleanText(source.Text) };
            source.Visible = false;
            source.TextChanged += (s, e) =>
            {
                chip.Text = CleanText(source.Text);
                chip.AccessibleName = chip.Text;
                LayoutOptionsTab();
            };
            chip.Click += (s, e) => handler(source, null);
            _optAboutCard.Controls.Add(chip);
            _optChips.Add(chip);
        }

        void RefreshOptionsStrings()
        {
            _optGeneral.Header.Text = T("optGeneral", "General");
            _optAppearance.Header.Text = T("optAppearance", "Appearance");
            _optLanguage.Header.Text = T("optLanguage", "Language");
            _optAbout.Header.Text = T("optAbout", "About & support");
            _optAccentTitle.Text = T("optAccent", "Accent color");
            _optAccentHint.Text = T("optAccentHint", "Pick a preset or fine-tune it on the color wheel.");
            _optLangHint.Text = T("optLangHint", "Changes apply instantly across the app.");
            _optVersion.Text = string.Format(T("optVersion", "Version {0}"), Program.GetCurrentVersionTostring());
            foreach (OptionsAction a in _optActions) a.Desc.Text = T(a.DescKey, a.DescFallback);
            LayoutOptionsTab();
        }

        void LayoutOptionsTab()
        {
            if (_optLayingOut || _optAbout == null) return;
            Size area = optionsTab.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;
            _optLayingOut = true;
            optionsTab.SuspendLayout();
            try
            {
                int margin = Draw.SI(16), colGap = Draw.SI(20);
                int inner = Math.Max(Draw.SI(260), area.Width - margin * 2);
                int top = margin + optionsTab.AutoScrollPosition.Y;
                int bottom;

                if (inner >= Draw.SI(820))
                {
                    int colW = (inner - colGap) / 2;
                    int left = LayoutOptionsColumn(margin, top, colW, _optGeneral, _optAppearance, _optLanguage);
                    int right = LayoutOptionsColumn(margin + colW + colGap, top, colW, _optUpdates, _optTrouble, _optAbout);
                    bottom = Math.Max(left, right);
                }
                else
                {
                    bottom = LayoutOptionsColumn(margin, top, inner, _optGeneral, _optAppearance, _optLanguage, _optUpdates, _optTrouble, _optAbout);
                }

                Size min = new Size(0, bottom - optionsTab.AutoScrollPosition.Y + margin);
                if (optionsTab.AutoScrollMinSize != min) optionsTab.AutoScrollMinSize = min;
            }
            finally
            {
                optionsTab.ResumeLayout(false);
                _optLayingOut = false;
            }
        }

        int LayoutOptionsColumn(int x, int y, int w, params OptionsSection[] sections)
        {
            for (int s = 0; s < sections.Length; s++)
            {
                if (s > 0) y += Draw.SI(22);
                OptionsSection section = sections[s];
                int hh = Math.Max(Draw.SI(24), section.Header.PreferredHeight);
                Place(section.Header, x + Draw.SI(2), y, w - Draw.SI(2), hh);
                y += hh + Draw.SI(6);

                for (int b = 0; b < section.Blocks.Length; b++)
                {
                    if (b > 0) y += Draw.SI(4);
                    Control block = section.Blocks[b];
                    Func<int, int> measure;
                    int h = _optMeasure.TryGetValue(block, out measure) ? measure(w) : Draw.SI(48);
                    Place(block, x, y, w, h);
                    y += h;
                }
            }
            return y;
        }

        int LayoutOptionsAccent(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad;
            int th = _optAccentTitle.PreferredHeight;
            Place(_optAccentTitle, pad, y, inner, th);
            y += th + Draw.SI(2);
            int hh = WrapHeight(_optAccentHint, _optAccentHint.Text, inner);
            Place(_optAccentHint, pad, y, inner, hh);
            y += hh + Draw.SI(14);

            Size wheel = new Size(Draw.SI(140), Draw.SI(100));
            int gap = Draw.SI(24);
            bool side = inner - wheel.Width - gap >= Draw.SI(200);
            if (side)
            {
                int sw = inner - wheel.Width - gap;
                int sh = _optSwatches.HeightFor(sw);
                int rowH = Math.Max(wheel.Height, sh);
                Place(colorPicker1, pad, y + (rowH - wheel.Height) / 2, wheel.Width, wheel.Height);
                Place(_optSwatches, pad + wheel.Width + gap, y + (rowH - sh) / 2, sw, sh);
                return y + rowH + pad;
            }

            int sh2 = _optSwatches.HeightFor(inner);
            Place(_optSwatches, pad, y, inner, sh2);
            y += sh2 + Draw.SI(12);
            Place(colorPicker1, pad, y, wheel.Width, wheel.Height);
            return y + wheel.Height + pad;
        }

        int LayoutOptionsLanguage(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2;
            int comboW = Draw.SI(200), flagW = Draw.SI(30), flagH = Draw.SI(20);
            int ctrlW = comboW + Draw.SI(10) + flagW;
            int ch = boxLang.Height;
            bool side = inner - ctrlW - Draw.SI(16) >= Draw.SI(180);
            int textW = side ? inner - ctrlW - Draw.SI(16) : inner;

            int y = pad;
            int th = WrapHeight(_optLangTitle, _optLangTitle.Text, textW);
            Place(_optLangTitle, pad, y, textW, th);
            y += th + Draw.SI(2);
            int hh = WrapHeight(_optLangHint, _optLangHint.Text, textW);
            Place(_optLangHint, pad, y, textW, hh);
            y += hh;

            int cy;
            if (side)
            {
                int textH = y - pad;
                int rowH = Math.Max(textH, ch);
                cy = pad + (rowH - ch) / 2;
                y = pad + rowH;
            }
            else
            {
                y += Draw.SI(12);
                cy = y;
                y += ch;
            }
            int cx = side ? w - pad - ctrlW : pad;
            Place(picFlag, cx, cy + (ch - flagH) / 2, flagW, flagH);
            Place(boxLang, cx + flagW + Draw.SI(10), cy, comboW, ch);
            return y + pad;
        }

        int LayoutOptionsUpdate(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2;
            int bw = ButtonWidth(btnUpdate, Draw.SI(150)), bh = Draw.SI(32);
            int textW = Math.Max(Draw.SI(80), inner - bw - Draw.SI(16));
            int th = _optAppName.PreferredHeight, vh = _optVersion.PreferredHeight;
            int textH = th + Draw.SI(2) + vh;
            int rowH = Math.Max(textH, bh);
            int ty = pad + (rowH - textH) / 2;
            Place(_optAppName, pad, ty, textW, th);
            Place(_optVersion, pad, ty + th + Draw.SI(2), textW, vh);
            Place(btnUpdate, w - pad - bw, pad + (rowH - bh) / 2, bw, bh);
            return pad + rowH + pad;
        }

        int LayoutOptionsTrouble(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2, bh = Draw.SI(32), y = Draw.SI(8);
            int bw = Draw.SI(140);
            foreach (OptionsAction a in _optActions) bw = Math.Max(bw, ButtonWidth(a.Button, Draw.SI(140)));
            bool side = inner - bw - Draw.SI(16) >= Draw.SI(160);

            for (int i = 0; i < _optActions.Count; i++)
            {
                OptionsAction a = _optActions[i];
                int rowTop = y + Draw.SI(8);
                if (side)
                {
                    int textW = inner - bw - Draw.SI(16);
                    int dh = WrapHeight(a.Desc, a.Desc.Text, textW);
                    int rowH = Math.Max(dh, bh);
                    Place(a.Desc, pad, rowTop + (rowH - dh) / 2, textW, dh);
                    Place(a.Button, w - pad - bw, rowTop + (rowH - bh) / 2, bw, bh);
                    y = rowTop + rowH + Draw.SI(8);
                }
                else
                {
                    int dh = WrapHeight(a.Desc, a.Desc.Text, inner);
                    Place(a.Desc, pad, rowTop, inner, dh);
                    Place(a.Button, pad, rowTop + dh + Draw.SI(8), bw, bh);
                    y = rowTop + dh + Draw.SI(8) + bh + Draw.SI(8);
                }
            }
            return y + Draw.SI(8);
        }

        int LayoutOptionsAbout(int w)
        {
            int pad = Draw.SI(12), inner = w - pad * 2, g = Draw.SI(6);
            int chipH = Draw.SI(36);
            int minChip = Draw.SI(150);
            foreach (LinkChip c in _optChips) minChip = Math.Max(minChip, c.PreferredWidth);
            int cols = Math.Max(1, Math.Min(2, (inner + g) / (minChip + g)));
            int cw = (inner - g * (cols - 1)) / cols;
            int y = pad;
            for (int i = 0; i < _optChips.Count; i++)
            {
                int col = i % cols, row = i / cols;
                Place(_optChips[i], pad + col * (cw + g), pad + row * (chipH + g), cw, chipH);
                y = pad + row * (chipH + g) + chipH;
            }
            return y + pad;
        }
    }

    /// <summary>Row of preset accent colors; the active one gets a ring.</summary>
    internal sealed class AccentSwatches : Control, IThemeable {
        static readonly Color[] Presets =
        {
            Color.FromArgb(153, 102, 204), Color.FromArgb(0, 120, 212), Color.FromArgb(0, 153, 188), Color.FromArgb(0, 178, 148),
            Color.FromArgb(16, 137, 62), Color.FromArgb(255, 185, 0), Color.FromArgb(202, 80, 16), Color.FromArgb(232, 17, 35),
            Color.FromArgb(227, 0, 140), Color.FromArgb(107, 105, 214)
        };

        readonly Func<Color> _current;
        readonly ToolTip _tips = new ToolTip();
        int _hover = -1, _focus;

        internal event Action<Color> Picked;

        internal AccentSwatches(Func<Color> current)
        {
            _current = current;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);
            TabStop = true;
            Cursor = Cursors.Hand;
            AccessibleRole = AccessibleRole.List;
        }

        static int D { get { return Draw.SI(28); } }
        static int G { get { return Draw.SI(10); } }
        static int Ring { get { return Draw.SI(3); } }

        int PerRow(int width) { return Math.Max(1, (width - Ring * 2 + G) / (D + G)); }

        internal int HeightFor(int width)
        {
            int rows = (Presets.Length + PerRow(width) - 1) / PerRow(width);
            return rows * D + (rows - 1) * G + Ring * 2;
        }

        Rectangle Cell(int i)
        {
            int per = PerRow(Width);
            return new Rectangle(Ring + (i % per) * (D + G), Ring + (i / per) * (D + G), D, D);
        }

        int HitTest(Point p)
        {
            for (int i = 0; i < Presets.Length; i++)
                if (Cell(i).Contains(p)) return i;
            return -1;
        }

        public void ApplyTheme(Palette palette) { Invalidate(); }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            int h = HitTest(e.Location);
            if (h != _hover)
            {
                _hover = h;
                _tips.SetToolTip(this, h < 0 ? null : string.Format("#{0:X2}{1:X2}{2:X2}", Presets[h].R, Presets[h].G, Presets[h].B));
                Cursor = h < 0 ? Cursors.Default : Cursors.Hand;
                Invalidate();
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _hover = -1;
            Invalidate();
            base.OnMouseLeave(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            int h = HitTest(e.Location);
            if (h >= 0) Pick(h);
            base.OnMouseClick(e);
        }

        void Pick(int i)
        {
            _focus = i;
            if (Picked != null) Picked(Presets[i]);
            Invalidate();
        }

        protected override bool IsInputKey(Keys keyData)
        {
            Keys k = keyData & Keys.KeyCode;
            return k == Keys.Left || k == Keys.Right || k == Keys.Up || k == Keys.Down || base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            int per = PerRow(Width);
            switch (e.KeyCode)
            {
                case Keys.Left: _focus = Math.Max(0, _focus - 1); break;
                case Keys.Right: _focus = Math.Min(Presets.Length - 1, _focus + 1); break;
                case Keys.Up: _focus = Math.Max(0, _focus - per); break;
                case Keys.Down: _focus = Math.Min(Presets.Length - 1, _focus + per); break;
                case Keys.Space:
                case Keys.Enter: Pick(_focus); break;
                default: base.OnKeyDown(e); return;
            }
            e.Handled = true;
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e) { Invalidate(); base.OnGotFocus(e); }
        protected override void OnLostFocus(EventArgs e) { Invalidate(); base.OnLostFocus(e); }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _tips.Dispose();
            base.Dispose(disposing);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.Layer1);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int current = _current().ToArgb();

            for (int i = 0; i < Presets.Length; i++)
            {
                RectangleF r = Cell(i);
                bool selected = Presets[i].ToArgb() == current;
                if (selected || i == _hover)
                {
                    RectangleF ring = RectangleF.Inflate(r, Ring - 0.5f, Ring - 0.5f);
                    using (Pen pen = new Pen(selected ? p.TextPrimary : p.StrokeStrong, Draw.S(selected ? 2f : 1.5f)))
                        g.DrawEllipse(pen, ring);
                }
                RectangleF dot = selected ? RectangleF.Inflate(r, -Draw.S(2), -Draw.S(2)) : r;
                using (SolidBrush b = new SolidBrush(Presets[i]))
                    g.FillEllipse(b, dot);

                if (Focused && ShowFocusCues && i == _focus)
                    ControlPaint.DrawFocusRectangle(g, Rectangle.Inflate(Cell(i), Ring + 1, Ring + 1));
            }
        }
    }

    /// <summary>Rounded clickable chip with a leading glyph, used for the About &amp; support links.</summary>
    internal sealed class LinkChip : Control, IThemeable {
        readonly SidebarNav.Glyph _glyph;
        bool _hover, _pressed;

        internal LinkChip(SidebarNav.Glyph glyph)
        {
            _glyph = glyph;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);
            TabStop = true;
            Cursor = Cursors.Hand;
            Font = Typography.Get(9.5f, Typography.Weight.Regular);
            AccessibleRole = AccessibleRole.Link;
        }

        internal int PreferredWidth
        {
            get { return Draw.SI(12) + Draw.SI(16) + Draw.SI(10) + TextRenderer.MeasureText(Text, Font, Size.Empty, TextFormatFlags.NoPrefix).Width + Draw.SI(16); }
        }

        public void ApplyTheme(Palette palette) { Invalidate(); }

        protected override void OnTextChanged(EventArgs e) { Invalidate(); base.OnTextChanged(e); }
        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { if (e.Button == MouseButtons.Left) { _pressed = true; Invalidate(); } base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { _pressed = false; Invalidate(); base.OnMouseUp(e); }
        protected override void OnGotFocus(EventArgs e) { Invalidate(); base.OnGotFocus(e); }
        protected override void OnLostFocus(EventArgs e) { Invalidate(); base.OnLostFocus(e); }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                OnClick(EventArgs.Empty);
                return;
            }
            base.OnKeyDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            Color surface = Parent != null ? Parent.BackColor : p.Layer1;
            g.Clear(surface);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color fill = _pressed ? ColorMath.Blend(surface, p.TextPrimary, p.IsDark ? 0.03 : 0.05)
                : _hover ? ColorMath.Blend(surface, p.TextPrimary, p.IsDark ? 0.08 : 0.05)
                : ColorMath.Blend(surface, p.TextPrimary, p.IsDark ? 0.045 : 0.025);
            RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(5)))
            using (SolidBrush b = new SolidBrush(fill))
            using (Pen pen = new Pen(p.IsDark ? ColorMath.Blend(surface, Color.White, 0.08) : p.Stroke))
            {
                g.FillPath(b, path);
                g.DrawPath(pen, path);
            }

            int gs = Draw.SI(16);
            Rectangle glyph = new Rectangle(Draw.SI(12), (Height - gs) / 2, gs, gs);
            SidebarNav.PaintGlyph(g, _glyph, glyph, p.AccentText);

            Rectangle text = new Rectangle(glyph.Right + Draw.SI(10), 0, Width - glyph.Right - Draw.SI(20), Height);
            TextRenderer.DrawText(g, Text, Font, text, p.TextPrimary, fill,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine);

            if (Focused && ShowFocusCues)
                ControlPaint.DrawFocusRectangle(g, Rectangle.Inflate(ClientRectangle, -Draw.SI(3), -Draw.SI(3)));
        }
    }
}
