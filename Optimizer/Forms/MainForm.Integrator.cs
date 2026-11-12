using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        PivotStrip _intPivot;
        bool _intLayingOut;

        // Info
        CardPanel _intHero, _intNotes;
        FluentLabel _intHeroTitle, _intHeroText, _intNotesTitle, _intNotesText;
        FluentButton _intStartAdd, _intStartRun;
        CardPanel[] _intChips;
        FluentLabel[] _intChipText;

        // Add / modify
        CardPanel _intItemCard, _intOptionsCard;
        FluentLabel _intItemTitle, _intOptionsTitle, _intTypeCap, _intTargetCap, _intNameCap, _intIconCap, _intPosCap, _intSecCap;
        ScrollHost _intTypeBox, _intPosBox;

        // Delete
        CardPanel _intItemsCard;
        FluentLabel _intItemsCount, _intItemsEmpty;

        // Ready menus
        FluentLabel _intMenusCap, _intCmdsCap;
        int _intToggleH;

        // Run dialog
        CardPanel _intCcCard, _intCcListCard;
        FluentLabel _intCcFileCap, _intCcKeyCap, _intCcHint, _intCcListCap, _intCcCount, _intCcEmpty;

        // System variables
        CardPanel _intVarAddCard, _intVarListCard;
        FluentLabel _intVarCap, _intVarListCap, _intVarCount;
        FluentButton _intVarBrowse;

        // Fonts
        CardPanel _intFontCurCard, _intFontListCard;
        FluentLabel _intFontCurCap, _intFontsCap, _intPreviewCap, _intPreview;
        Font _intPreviewFont;

        void InitIntegratorUi()
        {
            integratorTab.SuspendLayout();

            synapse.HideHeaders = true;
            synapse.Dock = DockStyle.None;
            synapse.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            _intPivot = new PivotStrip { Tabs = synapse };
            integratorTab.Controls.Add(_intPivot);
            foreach (TabPage page in synapse.TabPages)
            {
                page.TextChanged += (s, e) => { _intPivot.Relayout(); LayoutIntegratorTab(); };
            }
            integratorTab.Layout += (s, e) => LayoutIntegratorTab();

            InitIntegratorInfo();
            InitIntegratorAdd();
            InitIntegratorDelete();
            InitIntegratorMenus();
            InitIntegratorRun();
            InitIntegratorVariables();
            InitIntegratorFonts();

            integratorTab.ResumeLayout(false);
        }

        void RefreshIntegratorStrings()
        {
            if (_intPivot == null) return;
            _intHeroTitle.Text = T("integratorHeroTitle", "Extend the desktop right-click menu");
            _intStartAdd.Text = T("integratorStartAdd", "Add an item");
            _intStartRun.Text = T("integratorStartRun", "Create a Run command");
            _intNotesTitle.Text = T("integratorNotes", "Good to know");
            _intItemTitle.Text = T("integratorItemCard", "Item");
            _intOptionsTitle.Text = T("integratorOptionsCard", "Options");
            _intMenusCap.Text = T("readyMenusDesktop", "Desktop menus");
            _intCmdsCap.Text = T("readyMenusCommands", "Context menu commands");
            _intCcHint.Text = T("ccHint", "Press Win+R and type the keyword to launch the file.");
            _intItemsEmpty.Text = T("integratorNoItems", "No custom desktop items yet");
            _intCcEmpty.Text = T("integratorNoCommands", "No custom commands yet");
            _intPreviewCap.Text = T("fontsPreviewTitle", "Preview");
            _intPreview.Text = T("fontsPreview", "The quick brown fox jumps over the lazy dog 0123456789");
            SetCue(txtSearchFonts, T("fontsSearch", "Search fonts"));
            if (_modernTips != null) _modernTips.SetToolTip(_intVarBrowse, T("sysVarBrowse", "Browse for a folder"));
            _intPivot.Relayout();
            UpdateIntegratorCounts();
        }

        // ---------- shared helpers ----------

        static void HookPage(TabPage page, Func<int, int, int> layout)
        {
            bool busy = false;
            page.AutoScroll = true;
            page.Layout += (s, e) =>
            {
                if (busy) return;
                Size area = page.ClientSize;
                if (area.Width <= 0 || area.Height <= 0) return;
                busy = true;
                page.SuspendLayout();
                try
                {
                    int top = page.AutoScrollPosition.Y;
                    int bottom = layout(top, area.Width);
                    page.AutoScrollMinSize = new Size(0, bottom - top);
                }
                finally
                {
                    page.ResumeLayout(false);
                    busy = false;
                }
            };
        }

        static int PageTitle(Label title, int y)
        {
            Size s = title.GetPreferredSize(Size.Empty);
            Place(title, Draw.SI(16), y, s.Width, s.Height);
            return y + s.Height + Draw.SI(12);
        }

        static void AsTitle(Label title)
        {
            title.AutoSize = true;
            title.Font = Typography.Get(14f, Typography.Weight.Semibold);
        }

        static FluentLabel Caption(Control parent)
        {
            return NewLabel(parent, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
        }

        static FluentLabel CardTitle(Control parent)
        {
            return NewLabel(parent, 11f, Typography.Weight.Semibold, LabelTone.Primary);
        }

        static int PlaceLine(Control c, int x, int y, int w)
        {
            int h = Math.Max(Draw.SI(18), WrapHeight(c, c.Text, w));
            Place(c, x, y, w, h);
            return y + h;
        }

        /// <summary>Text box with an optional trailing button; returns the row bottom.</summary>
        static int InputRow(TextBox box, Control button, int x, int y, int w)
        {
            int bh = Draw.SI(32), bw = button == null ? 0 : Math.Max(Draw.SI(40), ButtonWidthStatic(button));
            int th = box.PreferredHeight;
            Place(box, x, y + (bh - th) / 2, w - (bw > 0 ? bw + Draw.SI(6) : 0), th);
            if (button != null) Place(button, x + w - bw, y, bw, bh);
            return y + bh;
        }

        static int ButtonWidthStatic(Control b)
        {
            return b.Text == "..." ? Draw.SI(40) : TextRenderer.MeasureText(b.Text, b.Font).Width + Draw.SI(32);
        }

        /// <summary>Lays choices left to right inside a transparent host, wrapping when needed.</summary>
        static int FlowChoices(Control host, Control[] items, int x, int y, int w)
        {
            int cx = 0, cy = 0, rowH = Draw.SI(30), gap = Draw.SI(22);
            foreach (Control c in items)
            {
                Size s = c.GetPreferredSize(Size.Empty);
                if (cx > 0 && cx + s.Width > w)
                {
                    cx = 0;
                    cy += rowH;
                }
                Place(c, cx, cy + (rowH - s.Height) / 2, s.Width, s.Height);
                cx += s.Width + gap;
            }
            Place(host, x, y, w, cy + rowH);
            return y + cy + rowH;
        }

        static void HostChoices(ScrollHost host, params Control[] items)
        {
            host.AutoScroll = false;
            foreach (Control c in items) Reparent(c, host);
        }

        static void HookEnter(TextBox box, Button target)
        {
            box.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter && target.Enabled) { target.PerformClick(); e.SuppressKeyPress = true; }
            };
        }

        static void HookDelete(ListBox list, Button target)
        {
            list.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Delete && list.SelectedIndex >= 0 && target.Enabled) { target.PerformClick(); e.Handled = true; }
            };
        }

        static void ListInCard(ListBox list, Panel legacyHost, CardPanel card)
        {
            Reparent(list, card);
            legacyHost.Visible = false;
            list.IntegralHeight = false;
        }

        void LayoutIntegratorTab()
        {
            if (_intLayingOut || _intPivot == null) return;
            Size area = integratorTab.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;
            _intLayingOut = true;
            integratorTab.SuspendLayout();
            try
            {
                int margin = Draw.SI(14);
                int ph = _intPivot.Measure(area.Width - margin * 2);
                Place(_intPivot, margin, Draw.SI(4), area.Width - margin * 2, ph);
                int y = Draw.SI(4) + ph + Draw.SI(4);
                Place(synapse, 0, y, area.Width, Math.Max(0, area.Height - y));
            }
            finally
            {
                integratorTab.ResumeLayout(false);
                _intLayingOut = false;
            }
            _intPivot.Invalidate();
        }

        void UpdateIntegratorCounts()
        {
            if (_intPivot == null) return;

            int items = listDesktopItems.Items.Count;
            _intItemsCount.Text = string.Format(T("integratorItemsCount", "{0} items"), items);
            _intItemsEmpty.Visible = items == 0;
            removeDIB.Enabled = items > 0;
            removeAllIIB.Enabled = items > 0;

            int cmds = listCustomCommands.Items.Count;
            _intCcCount.Text = string.Format(T("integratorCommandsCount", "{0} commands"), cmds);
            _intCcEmpty.Visible = cmds == 0;
            removeCCB.Enabled = cmds > 0;

            _intVarCount.Text = string.Format(T("integratorPathCount", "{0} entries"), listSystemVariables.Items.Count);

            string fonts = CleanText(lblFontsCount.Text).TrimEnd(':') + ": " + lblFontsNumber.Text;
            if (!string.IsNullOrEmpty(txtSearchFonts.Text))
                fonts += "  ·  " + string.Format(T("fontsShown", "{0} shown"), listFonts.Items.Count);
            _intFontsCap.Text = fonts;

            if (_intItemsEmpty.Visible) _intItemsEmpty.BringToFront();
            if (_intCcEmpty.Visible) _intCcEmpty.BringToFront();
        }

        // ---------- Info ----------

        void InitIntegratorInfo()
        {
            TabPage page = integratorInfoTab;

            _intHero = NewCard(page);
            _intHeroTitle = NewLabel(_intHero, 13f, Typography.Weight.Semibold, LabelTone.Primary);
            _intHeroText = Mirror(integrator1, _intHero, 10f, Typography.Weight.Regular, LabelTone.Secondary);
            _intStartAdd = new FluentButton { Kind = ButtonKind.Primary };
            _intStartRun = new FluentButton();
            _intHero.Controls.Add(_intStartAdd);
            _intHero.Controls.Add(_intStartRun);
            _intStartAdd.Click += (s, e) => synapse.SelectedTab = tabPage8;
            _intStartRun.Click += (s, e) => synapse.SelectedTab = tabPage11;

            Label[] features = { integrator2, integrator3, integrator4, integrator5, integrator6 };
            _intChips = new CardPanel[features.Length];
            _intChipText = new FluentLabel[features.Length];
            for (int i = 0; i < features.Length; i++)
            {
                _intChips[i] = NewCard(page);
                _intChipText[i] = Mirror(features[i], _intChips[i], 10f, Typography.Weight.Semibold, LabelTone.Primary);
                _intChipText[i].TextAlign = ContentAlignment.MiddleLeft;
                features[i].Visible = false;
            }

            _intNotes = NewCard(page);
            _intNotesTitle = CardTitle(_intNotes);
            _intNotesText = Mirror(integrator7, _intNotes, 10f, Typography.Weight.Regular, LabelTone.Secondary);
            integrator1.Visible = false;
            integrator7.Visible = false;

            HookPage(page, (top, width) =>
            {
                int margin = Draw.SI(16), pad = Draw.SI(18), gap = Draw.SI(12), bh = Draw.SI(32);
                int w = width - margin * 2, inner = w - pad * 2;
                int y = top + margin;

                int hy = pad;
                hy = PlaceLine(_intHeroTitle, pad, hy, inner) + Draw.SI(6);
                hy = PlaceLine(_intHeroText, pad, hy, inner) + Draw.SI(16);
                int b1 = ButtonWidthStatic(_intStartAdd), b2 = ButtonWidthStatic(_intStartRun);
                Place(_intStartAdd, pad, hy, b1, bh);
                if (pad + b1 + Draw.SI(8) + b2 <= pad + inner) Place(_intStartRun, pad + b1 + Draw.SI(8), hy, b2, bh);
                else { hy += bh + Draw.SI(8); Place(_intStartRun, pad, hy, b2, bh); }
                hy += bh + pad;
                Place(_intHero, margin, y, w, hy);
                y += hy + gap;

                int cols = Math.Max(1, Math.Min(_intChips.Length, (w + gap) / (Draw.SI(190) + gap)));
                int cw = (w - (cols - 1) * gap) / cols, ch = Draw.SI(52);
                for (int i = 0; i < _intChips.Length; i++)
                {
                    Place(_intChips[i], margin + (i % cols) * (cw + gap), y + (i / cols) * (ch + gap), cw, ch);
                    Place(_intChipText[i], Draw.SI(16), 0, cw - Draw.SI(24), ch);
                }
                y += ((_intChips.Length + cols - 1) / cols) * (ch + gap);

                int ny = pad;
                ny = PlaceLine(_intNotesTitle, pad, ny, inner) + Draw.SI(6);
                ny = PlaceLine(_intNotesText, pad, ny, inner) + pad;
                Place(_intNotes, margin, y, w, ny);
                return y + ny + margin;
            });
        }

        // ---------- Add / Modify ----------

        void InitIntegratorAdd()
        {
            TabPage page = tabPage8;
            AsTitle(addItemL);

            _intItemCard = NewCard(page);
            _intItemTitle = CardTitle(_intItemCard);
            _intTypeCap = Mirror(itemtype, _intItemCard, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            _intTypeBox = new ScrollHost();
            _intItemCard.Controls.Add(_intTypeBox);
            HostChoices(_intTypeBox, radioProgram, radioFolder, radioLink, radioFile, radioCommand);
            _intTargetCap = Mirror(itemtoaddgroup, _intItemCard, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            Reparent(txtItem, _intItemCard);
            Reparent(btnBrowseItem, _intItemCard);
            _intNameCap = Mirror(itemnamegroup, _intItemCard, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            Reparent(txtItemName, _intItemCard);
            _intIconCap = Mirror(icontoaddgroup, _intItemCard, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            Reparent(txtIcon, _intItemCard);
            Reparent(btnBrowseIcon, _intItemCard);
            Reparent(checkDefaultIcon, _intItemCard);

            _intOptionsCard = NewCard(page);
            _intOptionsTitle = CardTitle(_intOptionsCard);
            _intPosCap = Mirror(itemposition, _intOptionsCard, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            _intPosBox = new ScrollHost();
            _intOptionsCard.Controls.Add(_intPosBox);
            HostChoices(_intPosBox, radioTop, radioMiddle, radioBottom);
            _intSecCap = Mirror(security, _intOptionsCard, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            Reparent(checkShift, _intOptionsCard);
            Reparent(btnAddItem, _intOptionsCard);
            btnAddItem.Kind = ButtonKind.Primary;

            foreach (Control g in new Control[] { itemtype, itemtoaddgroup, itemnamegroup, icontoaddgroup, itemposition, security }) g.Visible = false;
            foreach (Control c in new Control[] { radioProgram, radioFolder, radioLink, radioFile, radioCommand, radioTop, radioMiddle, radioBottom, checkDefaultIcon, checkShift })
                c.Font = Typography.Get(10f, Typography.Weight.Regular);
            foreach (TextBox t in new[] { txtItem, txtItemName, txtIcon }) t.Font = Typography.Get(10f, Typography.Weight.Regular);
            HookEnter(txtItemName, btnAddItem);

            HookPage(page, (top, width) =>
            {
                int margin = Draw.SI(16), pad = Draw.SI(18), gap = Draw.SI(12), bh = Draw.SI(32);
                int w = width - margin * 2;
                int y = PageTitle(addItemL, top + margin);

                bool wide = w >= Draw.SI(820);
                int itemW = wide ? (w - gap) * 3 / 5 : w;
                int optW = wide ? w - itemW - gap : w;

                int inner = itemW - pad * 2, iy = pad;
                iy = PlaceLine(_intItemTitle, pad, iy, inner) + Draw.SI(12);
                iy = PlaceLine(_intTypeCap, pad, iy, inner) + Draw.SI(4);
                iy = FlowChoices(_intTypeBox, new Control[] { radioProgram, radioFolder, radioLink, radioFile, radioCommand }, pad, iy, inner) + Draw.SI(12);
                iy = PlaceLine(_intTargetCap, pad, iy, inner) + Draw.SI(6);
                iy = InputRow(txtItem, btnBrowseItem, pad, iy, inner) + Draw.SI(14);
                iy = PlaceLine(_intNameCap, pad, iy, inner) + Draw.SI(6);
                iy = InputRow(txtItemName, null, pad, iy, inner) + Draw.SI(14);
                iy = PlaceLine(_intIconCap, pad, iy, inner) + Draw.SI(6);
                iy = InputRow(txtIcon, btnBrowseIcon, pad, iy, inner) + Draw.SI(8);
                Size dc = checkDefaultIcon.GetPreferredSize(Size.Empty);
                Place(checkDefaultIcon, pad, iy, Math.Min(dc.Width, inner), dc.Height);
                iy += dc.Height + pad;

                int oinner = optW - pad * 2, oy = pad;
                oy = PlaceLine(_intOptionsTitle, pad, oy, oinner) + Draw.SI(12);
                oy = PlaceLine(_intPosCap, pad, oy, oinner) + Draw.SI(4);
                oy = FlowChoices(_intPosBox, new Control[] { radioTop, radioMiddle, radioBottom }, pad, oy, oinner) + Draw.SI(14);
                oy = PlaceLine(_intSecCap, pad, oy, oinner) + Draw.SI(6);
                Size sc = checkShift.GetPreferredSize(new Size(oinner, 0));
                int shH = Math.Max(sc.Height, sc.Width > oinner ? sc.Height * 2 : sc.Height);
                Place(checkShift, pad, oy, oinner, shH);
                oy += shH + Draw.SI(20);
                int ab = ButtonWidthStatic(btnAddItem);

                int itemH = iy, optH;
                if (wide)
                {
                    optH = Math.Max(itemH, oy + bh + pad);
                    itemH = optH;
                    Place(btnAddItem, optW - pad - ab, optH - pad - bh, ab, bh);
                }
                else
                {
                    Place(btnAddItem, optW - pad - ab, oy, ab, bh);
                    optH = oy + bh + pad;
                }

                Place(_intItemCard, margin, y, itemW, itemH);
                if (wide)
                {
                    Place(_intOptionsCard, margin + itemW + gap, y, optW, optH);
                    return y + itemH + margin;
                }
                Place(_intOptionsCard, margin, y + itemH + gap, optW, optH);
                return y + itemH + gap + optH + margin;
            });
        }

        // ---------- Delete ----------

        void InitIntegratorDelete()
        {
            TabPage page = tabPage9;
            AsTitle(removeIntegratorItemsL);

            _intItemsCard = NewCard(page);
            _intItemsCount = CardTitle(_intItemsCard);
            ListInCard(listDesktopItems, panel5, _intItemsCard);
            _intItemsEmpty = NewLabel(_intItemsCard, 10f, Typography.Weight.Regular, LabelTone.Secondary);
            _intItemsEmpty.TextAlign = ContentAlignment.MiddleCenter;
            foreach (Control b in new Control[] { refreshIIB, removeDIB, removeAllIIB }) Reparent(b, _intItemsCard);
            HookDelete(listDesktopItems, removeDIB);

            HookPage(page, (top, width) => LayoutListPage(page, removeIntegratorItemsL, null, _intItemsCard, _intItemsCount,
                listDesktopItems, _intItemsEmpty, new Control[] { refreshIIB }, new Control[] { removeAllIIB, removeDIB }, top, width, 0));
        }

        /// <summary>Title, optional top card, then a list card filling the rest of the page.</summary>
        int LayoutListPage(TabPage page, Label title, Func<int, int, int> topCard, CardPanel card, Control caption, ListBox list, Control empty,
            Control[] headerButtons, Control[] footerButtons, int top, int width, int extra)
        {
            int margin = Draw.SI(16), pad = Draw.SI(18), gap = Draw.SI(12), bh = Draw.SI(32);
            int w = width - margin * 2, inner = w - pad * 2;
            int y = PageTitle(title, top + margin);
            if (topCard != null) y = topCard(y, w) + gap;

            int cy = pad, right = pad + inner;
            foreach (Control b in headerButtons)
            {
                int bw = ButtonWidthStatic(b);
                Place(b, right - bw, cy, bw, bh);
                right -= bw + Draw.SI(8);
            }
            Place(caption, pad, cy + (bh - Draw.SI(24)) / 2, Math.Max(0, right - pad - Draw.SI(8)), Draw.SI(24));
            cy += bh + Draw.SI(12);

            int footer = footerButtons.Length > 0 ? bh + Draw.SI(14) : 0;
            int minList = Draw.SI(200);
            int available = page.ClientSize.Height - margin - (y - top) - cy - footer - pad;
            int listH = Math.Max(minList, available);
            Place(list, pad, cy, inner, listH);
            Place(empty, pad, cy, inner, Math.Min(listH, Draw.SI(120)));
            cy += listH;

            if (footerButtons.Length > 0)
            {
                cy += Draw.SI(14);
                int x = pad + inner;
                foreach (Control b in footerButtons)
                {
                    int bw = ButtonWidthStatic(b);
                    Place(b, x - bw, cy, bw, bh);
                    x -= bw + Draw.SI(8);
                }
                cy += bh;
            }
            cy += pad;
            Place(card, margin, y, w, cy);
            return y + cy + margin;
        }

        // ---------- Ready menus ----------

        void InitIntegratorMenus()
        {
            TabPage page = tabPage10;
            AsTitle(readyMenusL);
            _intMenusCap = CardTitle(page);
            _intCmdsCap = CardTitle(page);
            _intToggleH = Math.Max(Draw.SI(48), PMB.Height);
            ToggleCard[] menus = { PMB, STB, WAB, SSB, DSB };
            ToggleCard[] cmds = { AddOwnerB, AddCMDB };
            foreach (ToggleCard t in menus.Concat(cmds)) t.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            HookPage(page, (top, width) =>
            {
                int margin = Draw.SI(16), gap = Draw.SI(10);
                int w = width - margin * 2;
                int y = PageTitle(readyMenusL, top + margin);
                int cols = w >= Draw.SI(760) ? 2 : 1;
                int cw = (w - (cols - 1) * gap) / cols;

                Func<FluentLabel, ToggleCard[], int, int> section = (cap, cards, sy) =>
                {
                    sy = PlaceLine(cap, margin, sy, w) + Draw.SI(8);
                    for (int i = 0; i < cards.Length; i++)
                        Place(cards[i], margin + (i % cols) * (cw + gap), sy + (i / cols) * (_intToggleH + gap), cw, _intToggleH);
                    return sy + ((cards.Length + cols - 1) / cols) * (_intToggleH + gap);
                };
                y = section(_intMenusCap, menus, y) + Draw.SI(14);
                y = section(_intCmdsCap, cmds, y);
                return y + margin;
            });
        }

        // ---------- Run dialog ----------

        void InitIntegratorRun()
        {
            TabPage page = tabPage11;
            AsTitle(ccL);

            _intCcCard = NewCard(page);
            _intCcFileCap = Mirror(ccFileL, _intCcCard, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            Reparent(txtRunFile, _intCcCard);
            Reparent(button48, _intCcCard);
            _intCcKeyCap = Mirror(ccKeywordL, _intCcCard, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            Reparent(txtRunKeyword, _intCcCard);
            _intCcHint = NewLabel(_intCcCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            Reparent(btnCreateCustomCommand, _intCcCard);
            btnCreateCustomCommand.Kind = ButtonKind.Primary;
            ccFileL.Visible = false;
            ccKeywordL.Visible = false;
            foreach (TextBox t in new[] { txtRunFile, txtRunKeyword }) t.Font = Typography.Get(10f, Typography.Weight.Regular);
            HookEnter(txtRunKeyword, btnCreateCustomCommand);

            _intCcListCard = NewCard(page);
            _intCcListCap = Mirror(removeCCL, _intCcListCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _intCcCount = NewLabel(_intCcListCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            ListInCard(listCustomCommands, panel6, _intCcListCard);
            _intCcEmpty = NewLabel(_intCcListCard, 10f, Typography.Weight.Regular, LabelTone.Secondary);
            _intCcEmpty.TextAlign = ContentAlignment.MiddleCenter;
            Reparent(refreshCCB, _intCcListCard);
            Reparent(removeCCB, _intCcListCard);
            removeCCL.Visible = false;
            HookDelete(listCustomCommands, removeCCB);

            HookPage(page, (top, width) =>
            {
                int bottom = LayoutListPage(page, ccL, (y, w) =>
                {
                    int pad = Draw.SI(18), inner = w - pad * 2, bh = Draw.SI(32), cy = pad;
                    bool wide = inner >= Draw.SI(700);
                    int kw = wide ? Math.Max(Draw.SI(200), inner / 3) : inner;
                    int fw = wide ? inner - kw - Draw.SI(16) : inner;
                    PlaceLine(_intCcFileCap, pad, cy, fw);
                    int ry = cy + Draw.SI(24);
                    InputRow(txtRunFile, button48, pad, ry, fw);
                    if (wide)
                    {
                        PlaceLine(_intCcKeyCap, pad + fw + Draw.SI(16), cy, kw);
                        InputRow(txtRunKeyword, null, pad + fw + Draw.SI(16), ry, kw);
                        cy = ry + bh + Draw.SI(14);
                    }
                    else
                    {
                        cy = ry + bh + Draw.SI(14);
                        PlaceLine(_intCcKeyCap, pad, cy, inner);
                        cy = InputRow(txtRunKeyword, null, pad, cy + Draw.SI(24), inner) + Draw.SI(14);
                    }
                    int cb = ButtonWidthStatic(btnCreateCustomCommand);
                    Place(btnCreateCustomCommand, pad + inner - cb, cy, cb, bh);
                    int hh = Math.Max(Draw.SI(18), WrapHeight(_intCcHint, _intCcHint.Text, inner - cb - Draw.SI(16)));
                    Place(_intCcHint, pad, cy + (bh - hh) / 2, inner - cb - Draw.SI(16), hh);
                    cy += Math.Max(bh, hh) + pad;
                    Place(_intCcCard, Draw.SI(16), y, w, cy);
                    return y + cy;
                }, _intCcListCard, _intCcListCap, listCustomCommands, _intCcEmpty, new Control[] { removeCCB, refreshCCB }, new Control[0], top, width, 0);
                PlaceCountBeside(_intCcListCap, _intCcCount);
                return bottom;
            });
        }

        static void PlaceCountBeside(FluentLabel caption, FluentLabel count)
        {
            int cw = Math.Min(caption.Width, TextWidth(caption) + Draw.SI(4));
            Rectangle r = caption.Bounds;
            Place(caption, r.X, r.Y, cw, r.Height);
            int x = r.X + cw + Draw.SI(10);
            Place(count, x, r.Y + Draw.SI(3), Math.Max(0, r.Right - x), Draw.SI(20));
        }

        // ---------- System variables ----------

        void InitIntegratorVariables()
        {
            TabPage page = tabPage4;
            AsTitle(label24);

            _intVarAddCard = NewCard(page);
            _intVarCap = Mirror(label23, _intVarAddCard, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            Reparent(txtSysVar, _intVarAddCard);
            txtSysVar.Font = Typography.Get(10f, Typography.Weight.Regular);
            _intVarBrowse = new FluentButton { Text = "..." };
            _intVarAddCard.Controls.Add(_intVarBrowse);
            _intVarBrowse.Click += (s, e) =>
            {
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK) txtSysVar.Text = dialog.SelectedPath;
                }
            };
            Reparent(button3, _intVarAddCard);
            button3.Kind = ButtonKind.Primary;
            label23.Visible = false;
            HookEnter(txtSysVar, button3);

            _intVarListCard = NewCard(page);
            _intVarListCap = Mirror(label21, _intVarListCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _intVarCount = NewLabel(_intVarListCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            ListInCard(listSystemVariables, panel15, _intVarListCard);
            Reparent(button2, _intVarListCard);
            Reparent(button1, _intVarListCard);
            label21.Visible = false;
            HookDelete(listSystemVariables, button1);
            FluentLabel none = NewLabel(_intVarListCard, 1f, Typography.Weight.Regular, LabelTone.Secondary);
            none.Visible = false;

            HookPage(page, (top, width) =>
            {
                int bottom = LayoutListPage(page, label24, (y, w) =>
                {
                    int pad = Draw.SI(18), inner = w - pad * 2, bh = Draw.SI(32), cy = pad;
                    cy = PlaceLine(_intVarCap, pad, cy, inner) + Draw.SI(6);
                    int ab = ButtonWidthStatic(button3);
                    InputRow(txtSysVar, _intVarBrowse, pad, cy, inner - ab - Draw.SI(8));
                    Place(button3, pad + inner - ab, cy, ab, bh);
                    cy += bh + pad;
                    Place(_intVarAddCard, Draw.SI(16), y, w, cy);
                    return y + cy;
                }, _intVarListCard, _intVarListCap, listSystemVariables, none, new Control[] { button1, button2 }, new Control[0], top, width, 0);
                PlaceCountBeside(_intVarListCap, _intVarCount);
                return bottom;
            });
        }

        // ---------- Fonts ----------

        void InitIntegratorFonts()
        {
            TabPage page = tabPage3;
            AsTitle(fontSetTitle);

            _intFontCurCard = NewCard(page);
            _intFontCurCap = Mirror(label11, _intFontCurCard, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            Reparent(lblCurrentFont, _intFontCurCard);
            lblCurrentFont.AutoSize = false;
            lblCurrentFont.AutoEllipsis = true;
            lblCurrentFont.Font = Typography.Get(14f, Typography.Weight.Semibold);
            Reparent(btnRestoreFont, _intFontCurCard);
            label11.Visible = false;

            _intFontListCard = NewCard(page);
            _intFontsCap = CardTitle(_intFontListCard);
            Reparent(txtSearchFonts, _intFontListCard);
            txtSearchFonts.Font = Typography.Get(10f, Typography.Weight.Regular);
            Reparent(btnRefreshFonts, _intFontListCard);
            ListInCard(listFonts, panel8, _intFontListCard);
            _intPreviewCap = Caption(_intFontListCard);
            _intPreview = NewLabel(_intFontListCard, 16f, Typography.Weight.Regular, LabelTone.Primary);
            Reparent(btnSetGlobalFont, _intFontListCard);
            btnSetGlobalFont.Kind = ButtonKind.Primary;
            lblFontsCount.Visible = false;
            lblFontsNumber.Visible = false;
            lblFontsCount.TextChanged += (s, e) => UpdateIntegratorCounts();
            txtSearchFonts.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape) { txtSearchFonts.Clear(); e.SuppressKeyPress = true; }
            };
            listFonts.SelectedIndexChanged += (s, e) => UpdateFontPreview();

            HookPage(page, (top, width) =>
            {
                int margin = Draw.SI(16), pad = Draw.SI(18), gap = Draw.SI(12), bh = Draw.SI(32);
                int w = width - margin * 2, inner = w - pad * 2;
                int y = PageTitle(fontSetTitle, top + margin);

                int rb = ButtonWidthStatic(btnRestoreFont);
                int cy = pad;
                cy = PlaceLine(_intFontCurCap, pad, cy, inner - rb - Draw.SI(12)) + Draw.SI(4);
                int fh = lblCurrentFont.GetPreferredSize(Size.Empty).Height;
                Place(lblCurrentFont, pad, cy, inner - rb - Draw.SI(12), fh);
                Place(btnRestoreFont, pad + inner - rb, pad + (cy + fh - pad - bh) / 2, rb, bh);
                cy += fh + pad;
                Place(_intFontCurCard, margin, y, w, cy);
                y += cy + gap;

                int ly = pad, fb = ButtonWidthStatic(btnRefreshFonts);
                Place(btnRefreshFonts, pad + inner - fb, ly, fb, bh);
                int sw = Math.Max(Draw.SI(160), Math.Min(Draw.SI(280), inner / 3));
                int sh = txtSearchFonts.PreferredHeight;
                Place(txtSearchFonts, pad + inner - fb - Draw.SI(8) - sw, ly + (bh - sh) / 2, sw, sh);
                Place(_intFontsCap, pad, ly + (bh - Draw.SI(24)) / 2, Math.Max(0, inner - fb - sw - Draw.SI(24)), Draw.SI(24));
                ly += bh + Draw.SI(12);

                bool side = inner >= Draw.SI(640);
                int listW = side ? Math.Max(Draw.SI(240), inner * 2 / 5) : inner;
                int footer = bh + Draw.SI(14);
                int available = page.ClientSize.Height - margin - (y - top) - ly - footer - pad;
                int listH = Math.Max(Draw.SI(220), available);
                int pw = side ? inner - listW - Draw.SI(20) : inner;
                int px = side ? pad + listW + Draw.SI(20) : pad;

                if (side)
                {
                    Place(listFonts, pad, ly, listW, listH);
                    PlaceLine(_intPreviewCap, px, ly, pw);
                    Place(_intPreview, px, ly + Draw.SI(28), pw, Math.Max(0, listH - Draw.SI(28)));
                    ly += listH;
                }
                else
                {
                    int lh = Math.Max(Draw.SI(180), listH - Draw.SI(140));
                    Place(listFonts, pad, ly, inner, lh);
                    ly += lh + Draw.SI(12);
                    PlaceLine(_intPreviewCap, pad, ly, inner);
                    Place(_intPreview, pad, ly + Draw.SI(28), inner, Draw.SI(100));
                    ly += Draw.SI(128);
                }
                ly += Draw.SI(14);
                int gb = ButtonWidthStatic(btnSetGlobalFont);
                Place(btnSetGlobalFont, pad + inner - gb, ly, gb, bh);
                ly += bh + pad;
                Place(_intFontListCard, margin, y, w, ly);
                return y + ly + margin;
            });
        }

        void UpdateFontPreview()
        {
            Font next = null;
            if (listFonts.SelectedItem != null)
            {
                try
                {
                    next = new Font(listFonts.SelectedItem.ToString(), 16f);
                }
                catch (ArgumentException)
                {
                    next = null;
                }
            }
            Font previous = _intPreviewFont;
            _intPreviewFont = next;
            _intPreview.PinnedFont = next ?? Typography.Get(16f, Typography.Weight.Regular);
            btnSetGlobalFont.Enabled = next != null;
            if (previous != null) previous.Dispose();
        }
    }
}
