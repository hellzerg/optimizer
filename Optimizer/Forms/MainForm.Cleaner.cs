using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        sealed class CleanCategory {
            internal CardPanel Card;
            internal PictureBox Icon;
            internal Label Title;
            internal FluentLabel Count;
            internal MoonCheck Header;
            internal ChevronGlyph Chevron;
            internal CheckBox[] Boxes;
            internal bool Collapsed;
        }

        readonly List<CleanCategory> _cleanCats = new List<CleanCategory>();
        ScrollHost _cleanCatHost, _cleanBreakHost;
        CardPanel _cleanSummary, _cleanBreakCard;
        FluentLabel _cleanStatus, _cleanBreakTitle, _cleanDetailsTitle, _cleanSelected;
        BusyBar _cleanBusyBar;
        CleanBreakdown _cleanBreakdown;
        bool _cleanLayingOut, _cleanCatSync;

        CheckBox[] CleanerBoxes()
        {
            return _cleanCats.SelectMany(c => c.Boxes).ToArray();
        }

        void InitCleanerUi()
        {
            cleanerTab.AutoScroll = false;
            cleanerTab.SuspendLayout();

            _cleanCatHost = new ScrollHost();
            cleanerTab.Controls.Add(_cleanCatHost);

            AddCleanCategory(label8, pictureBox2, checkTemp, checkMiniDumps, checkErrorReports, checkBin);
            AddCleanCategory(label4, pictureBox9, chromeCache, chromeCookies, chromeHistory, chromeSession, chromePws);
            AddCleanCategory(label5, pictureBox8, firefoxCache, firefoxCookies, firefoxHistory);
            AddCleanCategory(label7, pictureBox11, edgeCache, edgeCookies, edgeHistory, edgeSession);
            AddCleanCategory(label9, pictureBox4, braveCache, braveCookies, braveHistory, braveSession, bravePasswords);
            AddCleanCategory(label6, pictureBox10, IECache);

            _cleanSummary = NewCard(cleanerTab);
            foreach (Control c in new Control[] { lblPretext, lblFootprint, btnWinClean, analyzeDriveB, cleanDriveB }) Reparent(c, _cleanSummary);
            lblPretext.AutoSize = false;
            lblPretext.AutoEllipsis = true;
            lblPretext.Font = Typography.Get(10f, Typography.Weight.Regular);
            lblFootprint.AutoSize = false;
            lblFootprint.AutoEllipsis = true;
            lblFootprint.Font = Typography.Get(22f, Typography.Weight.Display);
            _cleanStatus = NewLabel(_cleanSummary, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            _cleanStatus.AutoSize = false;
            _cleanStatus.AutoEllipsis = true;
            _cleanBusyBar = new BusyBar();
            _cleanSummary.Controls.Add(_cleanBusyBar);
            ((FluentButton)analyzeDriveB).Kind = ButtonKind.Standard;
            ((FluentButton)cleanDriveB).Kind = ButtonKind.Primary;

            _cleanBreakCard = NewCard(cleanerTab);
            _cleanBreakTitle = NewLabel(_cleanBreakCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _cleanBreakHost = new ScrollHost();
            _cleanBreakCard.Controls.Add(_cleanBreakHost);
            _cleanBreakdown = new CleanBreakdown();
            _cleanBreakHost.Controls.Add(_cleanBreakdown);
            _cleanBreakdown.RowToggled += CleanBreakdown_RowToggled;
            _cleanBreakCard.Visible = false;

            panel14.Dock = DockStyle.None;
            panel14.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            _cleanDetailsTitle = NewLabel(panel14, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _cleanSelected = NewLabel(panel14, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            _cleanSelected.AutoSize = false;
            _cleanSelected.AutoEllipsis = true;
            Reparent(checkSelectAll, panel14);
            checkSelectAll.AutoSize = true;
            listCleanPreview.Dock = DockStyle.None;
            listCleanPreview.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            listCleanPreview.ItemCheck += listCleanPreview_ItemCheckModern;
            _cleanCheckTimer = new Timer { Interval = 120 };
            _cleanCheckTimer.Tick += (s, e) => { _cleanCheckTimer.Stop(); UpdateCleanSelection(); };

            panel1.Visible = false;
            panel13.Visible = false;

            cleanerTab.ResumeLayout(false);
            cleanerTab.Layout += (s, e) => LayoutCleanerTab();
            _cleanCatHost.Resize += (s, e) => LayoutCleanCategories();
        }

        void AddCleanCategory(Label title, PictureBox icon, params CheckBox[] boxes)
        {
            CleanCategory cat = new CleanCategory { Boxes = boxes };
            cat.Card = NewCard(_cleanCatHost);
            cat.Card.Cursor = Cursors.Default;

            Reparent(icon, cat.Card);
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.Cursor = Cursors.Hand;
            cat.Icon = icon;

            Reparent(title, cat.Card);
            title.AutoSize = false;
            title.AutoEllipsis = true;
            title.TextAlign = ContentAlignment.MiddleLeft;
            title.Font = Typography.Get(10.5f, Typography.Weight.Semibold);
            title.Cursor = Cursors.Hand;
            cat.Title = title;

            cat.Count = NewLabel(cat.Card, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            cat.Header = new MoonCheck { AutoCheck = false, Text = string.Empty, AutoSize = false, ThreeState = true };
            cat.Card.Controls.Add(cat.Header);
            cat.Chevron = new ChevronGlyph();
            cat.Card.Controls.Add(cat.Chevron);

            foreach (CheckBox b in boxes)
            {
                Reparent(b, cat.Card);
                b.AutoSize = false;
                b.CheckedChanged += (s, e) => SyncCleanCategory(cat);
            }

            cat.Header.Click += (s, e) =>
            {
                bool on = cat.Header.CheckState != CheckState.Checked;
                _cleanCatSync = true;
                foreach (CheckBox b in cat.Boxes) b.Checked = on;
                _cleanCatSync = false;
                SyncCleanCategory(cat);
            };

            EventHandler toggle = (s, e) =>
            {
                cat.Collapsed = !cat.Collapsed;
                cat.Chevron.Expanded = !cat.Collapsed;
                LayoutCleanCategories();
            };
            cat.Chevron.Click += toggle;
            title.Click += toggle;
            icon.Click += toggle;

            _cleanCats.Add(cat);
            SyncCleanCategory(cat);
        }

        void SyncCleanCategory(CleanCategory cat)
        {
            if (_cleanCatSync) return;
            int on = cat.Boxes.Count(b => b.Checked);
            cat.Count.Text = on + "/" + cat.Boxes.Length;
            cat.Header.CheckState = on == 0 ? CheckState.Unchecked : on == cat.Boxes.Length ? CheckState.Checked : CheckState.Indeterminate;
            cat.Header.Invalidate();
        }

        void RefreshCleanerStrings()
        {
            _cleanBreakTitle.Text = T("cleanerBreakdown", "Breakdown");
            _cleanDetailsTitle.Text = T("cleanerDetails", "Files to clean");
            _cleanBreakdown.ItemsFormat = T("cleanerItems", "{0} items");
            listCleanPreview.EmptyText = T("cleanerEmpty", "Pick categories on the left, then select Analyze to preview what will be removed.");
            foreach (CleanCategory cat in _cleanCats)
            {
                _modernTips.SetToolTip(cat.Header, T("cleanerToggleCategory", "Select or clear everything in this category"));
                _modernTips.SetToolTip(cat.Chevron, T("cleanerCollapse", "Expand or collapse"));
            }
            UpdateCleanSelection();
            LayoutCleanerTab();
        }

        void LayoutCleanerTab()
        {
            if (_cleanLayingOut || _cleanSummary == null) return;
            Size area = cleanerTab.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;
            _cleanLayingOut = true;
            try
            {
                int margin = Draw.SI(16), gap = Draw.SI(12);
                int innerW = area.Width - margin * 2, innerH = area.Height - margin * 2;
                int leftW = Math.Max(Draw.SI(310), Math.Min(Draw.SI(440), innerW * 38 / 100));
                Place(_cleanCatHost, margin, margin, leftW, innerH);

                int rx = margin + leftW + gap, rw = area.Width - margin - rx, y = margin;
                int sumH = LayoutCleanSummary(rw);
                Place(_cleanSummary, rx, y, rw, sumH);
                y += sumH + gap;

                if (_cleanBreakdown.Rows.Count > 0)
                {
                    int pad = Draw.SI(16), titleH = Draw.SI(24);
                    int rowsH = _cleanBreakdown.RowHeight * Math.Min(4, _cleanBreakdown.Rows.Count);
                    int cardH = pad + titleH + Draw.SI(4) + rowsH + Draw.SI(10);
                    _cleanBreakCard.Visible = true;
                    Place(_cleanBreakCard, rx, y, rw, cardH);
                    Place(_cleanBreakTitle, pad, pad, rw - pad * 2, titleH);
                    Place(_cleanBreakHost, Draw.SI(8), pad + titleH + Draw.SI(4), rw - Draw.SI(16), rowsH);
                    bool scroll = _cleanBreakdown.Rows.Count > 4;
                    int bw = _cleanBreakHost.Width - (scroll ? SystemInformation.VerticalScrollBarWidth : 0);
                    Place(_cleanBreakdown, 0, _cleanBreakHost.AutoScrollPosition.Y, bw, _cleanBreakdown.RowHeight * _cleanBreakdown.Rows.Count);
                    y += cardH + gap;
                }
                else _cleanBreakCard.Visible = false;

                int detailsH = Math.Max(Draw.SI(140), area.Height - margin - y);
                Place(panel14, rx, y, rw, detailsH);
                LayoutCleanDetails(rw, detailsH);
            }
            finally
            {
                _cleanLayingOut = false;
            }
            LayoutCleanCategories();
        }

        int LayoutCleanSummary(int w)
        {
            int pad = Draw.SI(16), gap = Draw.SI(8), btnH = Draw.SI(36);
            int y = pad;
            Place(lblPretext, pad, y, w - pad * 2, Draw.SI(20));
            y += Draw.SI(20);
            int footH = TextRenderer.MeasureText("0", lblFootprint.Font).Height + Draw.SI(4);
            Place(lblFootprint, pad, y, w - pad * 2, footH);
            y += footH;
            Place(_cleanStatus, pad, y, w - pad * 2, Draw.SI(20));
            y += Draw.SI(20) + Draw.SI(6);
            Place(_cleanBusyBar, pad, y, w - pad * 2, Draw.SI(3));
            y += Draw.SI(3) + Draw.SI(12);

            int wWin = ButtonWidth(btnWinClean, Draw.SI(110));
            int wAn = ButtonWidth(analyzeDriveB, Draw.SI(110));
            int wCl = ButtonWidth(cleanDriveB, Draw.SI(110));
            int avail = w - pad * 2;
            if (wWin + wAn + wCl + gap * 3 <= avail)
            {
                Place(btnWinClean, pad, y, wWin, btnH);
                Place(cleanDriveB, w - pad - wCl, y, wCl, btnH);
                Place(analyzeDriveB, w - pad - wCl - gap - wAn, y, wAn, btnH);
                y += btnH;
            }
            else
            {
                Place(cleanDriveB, w - pad - wCl, y, wCl, btnH);
                Place(analyzeDriveB, w - pad - wCl - gap - wAn, y, wAn, btnH);
                y += btnH + gap;
                Place(btnWinClean, w - pad - wWin, y, wWin, btnH);
                y += btnH;
            }
            return y + pad;
        }

        void LayoutCleanDetails(int w, int h)
        {
            int pad = Draw.SI(16), titleH = Draw.SI(24);
            int linkW = TextWidth(checkSelectAll) + Draw.SI(4);
            int titleW = Math.Min(TextWidth(_cleanDetailsTitle) + Draw.SI(8), w - pad * 2 - linkW);
            Place(_cleanDetailsTitle, pad, pad, titleW, titleH);
            Place(checkSelectAll, w - pad - linkW, pad + (titleH - checkSelectAll.Height) / 2, linkW, checkSelectAll.Height);
            int selX = pad + titleW + Draw.SI(8);
            Place(_cleanSelected, selX, pad + Draw.SI(2), Math.Max(0, w - pad - linkW - Draw.SI(8) - selX), titleH - Draw.SI(2));
            int listY = pad + titleH + Draw.SI(8);
            Place(listCleanPreview, pad, listY, w - pad * 2, h - listY - pad);
        }

        void LayoutCleanCategories()
        {
            if (_cleanCatHost == null || _cleanCatHost.Width <= 0) return;
            int gap = Draw.SI(10);
            int total = 0;
            foreach (CleanCategory cat in _cleanCats) total += CleanCategoryHeight(cat, _cleanCatHost.Width) + gap;
            int w = _cleanCatHost.Width;
            if (total - gap > _cleanCatHost.Height) w -= SystemInformation.VerticalScrollBarWidth + Draw.SI(4);

            _cleanCatHost.SuspendLayout();
            int y = _cleanCatHost.AutoScrollPosition.Y;
            foreach (CleanCategory cat in _cleanCats)
            {
                int h = LayoutCleanCategory(cat, w);
                Place(cat.Card, 0, y, w, h);
                y += h + gap;
            }
            _cleanCatHost.ResumeLayout(true);
        }

        int CleanCategoryHeight(CleanCategory cat, int w)
        {
            int headerH = Draw.SI(44);
            if (cat.Collapsed) return headerH;
            int rows = CleanColumns(cat, w) == 2 ? (cat.Boxes.Length + 1) / 2 : cat.Boxes.Length;
            return headerH + rows * Draw.SI(28) + Draw.SI(10);
        }

        int CleanColumns(CleanCategory cat, int w)
        {
            int colW = (w - Draw.SI(32) - Draw.SI(8)) / 2;
            foreach (CheckBox b in cat.Boxes)
                if (b.GetPreferredSize(Size.Empty).Width > colW) return 1;
            return 2;
        }

        int LayoutCleanCategory(CleanCategory cat, int w)
        {
            int pad = Draw.SI(16), headerH = Draw.SI(44), icon = Draw.SI(20);
            Place(cat.Icon, pad, (headerH - icon) / 2, icon, icon);
            int chev = Draw.SI(24);
            Place(cat.Chevron, w - Draw.SI(10) - chev, (headerH - chev) / 2, chev, chev);
            Size hs = cat.Header.GetPreferredSize(Size.Empty);
            int hx = cat.Chevron.Left - Draw.SI(6) - hs.Width;
            Place(cat.Header, hx, (headerH - hs.Height) / 2, hs.Width, hs.Height);
            int countW = TextWidth(cat.Count) + Draw.SI(4);
            Place(cat.Count, hx - Draw.SI(6) - countW, (headerH - cat.Count.PreferredHeight) / 2, countW, cat.Count.PreferredHeight);
            int tx = pad + icon + Draw.SI(10);
            Place(cat.Title, tx, Draw.SI(4), Math.Max(0, cat.Count.Left - Draw.SI(8) - tx), headerH - Draw.SI(8));

            foreach (CheckBox b in cat.Boxes) b.Visible = !cat.Collapsed;
            if (cat.Collapsed) return headerH;

            int cols = CleanColumns(cat, w);
            int colW = (w - pad * 2 - Draw.SI(8)) / cols, rowH = Draw.SI(28);
            for (int i = 0; i < cat.Boxes.Length; i++)
            {
                int col = cols == 2 ? i % 2 : 0, row = cols == 2 ? i / 2 : i;
                CheckBox b = cat.Boxes[i];
                int bh = b.GetPreferredSize(Size.Empty).Height;
                Place(b, pad + col * (colW + Draw.SI(8)), headerH + row * rowH + (rowH - bh) / 2, colW, bh);
            }
            return CleanCategoryHeight(cat, w);
        }
    }
}
