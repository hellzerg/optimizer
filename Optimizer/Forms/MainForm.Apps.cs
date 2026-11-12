using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        ScrollHost _appsHost;
        CardPanel _appsBar;
        CardPanel[] _appsCats;
        Panel[] _appsGroups;
        FluentLabel[] _appsCatCaps, _appsCatCounts;
        LinkLabel[] _appsCatToggles;
        TextBox _appsSearch;
        FluentLabel _appsSelected, _appsNoMatch, _appsError;
        LinkLabel _appsClear;
        int _appsTileW;
        bool _appsLayingOut, _appsBulk;

        void InitAppsUi()
        {
            appsTab.SuspendLayout();
            appsTab.AutoScroll = true;

            _appsHost = new ScrollHost();
            appsTab.Controls.Add(_appsHost);

            _appsCats = new[] { cardSystemTools, cardInternet, cardCoding, cardSoundVideo };
            _appsGroups = new[] { groupSystemTools, groupInternet, groupCoding, groupSoundVideo };
            Label[] sources = { lblSystemTools, lblInternet, lblCoding, lblVideoSound };
            _appsCatCaps = new FluentLabel[4];
            _appsCatCounts = new FluentLabel[4];
            _appsCatToggles = new LinkLabel[4];

            for (int i = 0; i < 4; i++)
            {
                int index = i;
                CardPanel card = _appsCats[i];
                Reparent(card, _appsHost);
                card.Padding = Padding.Empty;
                card.Margin = Padding.Empty;

                Panel group = _appsGroups[i];
                group.AutoScroll = false;
                group.Dock = DockStyle.None;
                group.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                _appsCatCaps[i] = Mirror(sources[i], card, 11f, Typography.Weight.Semibold, LabelTone.Primary, LayoutAppsTab);
                _appsCatCounts[i] = NewLabel(card, 9f, Typography.Weight.Regular, LabelTone.Secondary);
                _appsCatToggles[i] = NewLink(card);
                _appsCatToggles[i].LinkClicked += (s, e) => ToggleAppsCategory(index);
                sources[i].Visible = false;
            }

            Reparent(appsTitle, appsTab);
            Reparent(btnGetFeed, appsTab);

            _appsSearch = new TextBox { Font = Typography.Get(10f, Typography.Weight.Regular) };
            appsTab.Controls.Add(_appsSearch);
            _appsSelected = NewLabel(appsTab, 9.5f, Typography.Weight.Semibold, LabelTone.Secondary);
            _appsClear = NewLink(appsTab);
            _appsClear.LinkClicked += (s, e) => SetAppsChecked(AllAppTiles(), false);

            _appsNoMatch = NewLabel(_appsHost, 10f, Typography.Weight.Regular, LabelTone.Secondary);
            _appsNoMatch.TextAlign = ContentAlignment.MiddleCenter;
            _appsNoMatch.Visible = false;

            // the designer label stays hidden in a collapsed panel; this card-styled copy is shown instead
            _appsError = Mirror(txtFeedError, _appsHost, 11f, Typography.Weight.Semibold, LabelTone.Secondary, LayoutAppsTab);
            _appsError.TextAlign = ContentAlignment.MiddleCenter;
            _appsError.Visible = false;
            Reparent(txtFeedError, panel10);

            _appsBar = NewCard(appsTab);
            foreach (Control c in panelCommonApps.Controls.Cast<Control>().ToArray()) Reparent(c, _appsBar);
            btnDownloadApps.Kind = ButtonKind.Primary;
            foreach (Label l in new[] { setDownDirLbl, bitPref })
            {
                l.AutoSize = true;
                l.Font = Typography.Get(9.5f, Typography.Weight.Semibold);
            }
            txtDownloadStatus.AutoSize = false;
            txtDownloadStatus.AutoEllipsis = true;
            txtDownloadStatus.Font = Typography.Get(9.5f, Typography.Weight.Regular);
            linkWarnings.AutoSize = true;
            linkWarnings.Font = Typography.Get(9.5f, Typography.Weight.Regular);
            txtDownloadFolder.Font = Typography.Get(10f, Typography.Weight.Regular);

            tableApps.Visible = false;
            panel10.Visible = false;
            panelCommonApps.Visible = false;

            _appsSearch.TextChanged += (s, e) => ApplyAppsFilter();
            _appsSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape) { _appsSearch.Clear(); e.SuppressKeyPress = true; }
            };
            linkWarnings.VisibleChanged += (s, e) => LayoutAppsTab();

            appsTab.ResumeLayout(false);
            appsTab.Layout += (s, e) => LayoutAppsTab();
            _appsHost.Resize += (s, e) => LayoutAppsCards();
        }

        void RefreshAppsStrings()
        {
            if (_appsHost == null) return;
            SetCue(_appsSearch, T("appsSearch", "Search apps"));
            _appsClear.Text = T("appsClearSelection", "Clear selection");
            _appsNoMatch.Text = T("appsNoMatch", "No apps match your search.");
            if (_modernTips != null)
            {
                _modernTips.SetToolTip(changeDownDirB, T("appsBrowseFolder", "Choose the download folder"));
                _modernTips.SetToolTip(btnGetFeed, T("appsRefreshTip", "Download the latest app list"));
            }
            UpdateAppsSelection();
        }

        IEnumerable<AppCard> AppTiles(int category)
        {
            return _appsGroups[category].Controls.OfType<AppCard>();
        }

        IEnumerable<AppCard> AllAppTiles()
        {
            return Enumerable.Range(0, 4).SelectMany(AppTiles);
        }

        bool AppMatches(AppCard card)
        {
            string q = _appsSearch == null ? string.Empty : _appsSearch.Text.Trim();
            return q.Length == 0 || card.appTitle.Text.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        void OnAppsFeedPopulated()
        {
            if (_appsHost == null) return;

            int widest = 0;
            foreach (AppCard card in AllAppTiles())
            {
                card.StretchToHost = false;
                card.AutoSize = false;
                card.appTitle.AutoSize = false;
                card.Cursor = Cursors.Hand;
                card.appTitle.CheckedChanged += (s, e) => { if (!_appsBulk) UpdateAppsSelection(); };
                widest = Math.Max(widest, card.appTitle.GetPreferredSize(Size.Empty).Width);
            }
            // icon + gaps + the check glyph's own preferred width
            _appsTileW = Math.Max(Draw.SI(170), Math.Min(Draw.SI(300), widest + Draw.SI(56)));

            ApplyAppsFilter();
        }

        void ApplyAppsFilter()
        {
            if (_appsHost == null) return;
            foreach (AppCard card in AllAppTiles()) card.Visible = AppMatches(card);
            UpdateAppsSelection();
        }

        void SetAppsChecked(IEnumerable<AppCard> cards, bool value)
        {
            _appsBulk = true;
            try
            {
                foreach (AppCard card in cards.ToArray()) card.appTitle.Checked = value;
            }
            finally
            {
                _appsBulk = false;
            }
            UpdateAppsSelection();
        }

        void ToggleAppsCategory(int category)
        {
            AppCard[] shown = AppTiles(category).Where(AppMatches).ToArray();
            SetAppsChecked(shown, !shown.All(c => c.appTitle.Checked));
        }

        void UpdateAppsSelection()
        {
            if (_appsHost == null) return;

            int selected = AllAppTiles().Count(c => c.appTitle.Checked);
            _appsSelected.Tone = selected > 0 ? LabelTone.Accent : LabelTone.Secondary;
            _appsSelected.Text = selected > 0
                ? string.Format(T("appsSelectedCount", "{0} selected"), selected)
                : T("appsNoneSelected", "No apps selected");
            _appsClear.Visible = selected > 0;

            for (int i = 0; i < 4; i++)
            {
                AppCard[] all = AppTiles(i).ToArray();
                int on = all.Count(c => c.appTitle.Checked);
                _appsCatCounts[i].Text = on > 0
                    ? string.Format(T("appsCatSelected", "{0} of {1} selected"), on, all.Length)
                    : string.Format(T("appsCatTotal", "{0} apps"), all.Length);

                AppCard[] shown = all.Where(AppMatches).ToArray();
                _appsCatToggles[i].Text = shown.Length > 0 && shown.All(c => c.appTitle.Checked)
                    ? T("appsClearCategory", "Clear")
                    : T("appsSelectAll", "Select all");
            }
            LayoutAppsTab();
        }

        void LayoutAppsTab()
        {
            if (_appsLayingOut || _appsBar == null) return;
            Size area = appsTab.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;
            _appsLayingOut = true;
            appsTab.SuspendLayout();
            try
            {
                int margin = Draw.SI(16), gap = Draw.SI(12), bh = Draw.SI(32);
                int innerW = area.Width - margin * 2;
                int y = margin;

                int rb = ButtonWidth(btnGetFeed, Draw.SI(110));
                Size ts = appsTitle.GetPreferredSize(Size.Empty);
                Place(appsTitle, margin - Draw.SI(4), y + (bh - ts.Height) / 2, Math.Min(ts.Width, innerW - rb - gap), ts.Height);
                Place(btnGetFeed, area.Width - margin - rb, y, rb, bh);
                y += bh + Draw.SI(10);

                int sh = _appsSearch.PreferredHeight;
                int sw = Math.Max(Draw.SI(160), Math.Min(Draw.SI(320), innerW / 2));
                Place(_appsSearch, margin, y + (bh - sh) / 2, sw, sh);
                int right = area.Width - margin;
                if (_appsClear.Visible)
                {
                    Size cs = _appsClear.GetPreferredSize(Size.Empty);
                    Place(_appsClear, right - cs.Width, y + (bh - cs.Height) / 2, cs.Width, cs.Height);
                    right -= cs.Width + Draw.SI(14);
                }
                int lw = Math.Max(0, Math.Min(TextWidth(_appsSelected) + Draw.SI(4), right - margin - sw - gap));
                Place(_appsSelected, right - lw, y + (bh - Draw.SI(20)) / 2, lw, Draw.SI(20));
                y += bh + Draw.SI(10);

                int barH = LayoutAppsBar(innerW);
                int minHost = Draw.SI(160);
                int barY = Math.Max(y + minHost + gap, area.Height - margin - barH);
                Place(_appsBar, margin, barY, innerW, barH);
                Place(_appsHost, margin, y, innerW, barY - gap - y);
                appsTab.AutoScrollMinSize = new Size(0, y + minHost + gap + barH + margin);
            }
            finally
            {
                appsTab.ResumeLayout(false);
                _appsLayingOut = false;
            }
            LayoutAppsCards();
        }

        int AppsCategoryHeight(int category, int w)
        {
            int pad = Draw.SI(16), tg = Draw.SI(8), tileH = Draw.SI(44);
            int inner = w - pad * 2;
            int n = AppTiles(category).Count(AppMatches);
            int cols = Math.Max(1, (inner + tg) / (Math.Max(1, _appsTileW) + tg));
            int rows = (n + cols - 1) / cols;
            return pad + Draw.SI(34) + Math.Max(0, rows * (tileH + tg) - tg) + pad;
        }

        void LayoutAppsCards()
        {
            if (_appsHost == null || _appsLayingOut) return;
            int hostW = _appsHost.Width, hostH = _appsHost.Height;
            if (hostW <= 0 || hostH <= 0) return;
            _appsLayingOut = true;
            _appsHost.SuspendLayout();
            try
            {
                int gap = Draw.SI(12);
                bool any = AllAppTiles().Any();
                bool[] show = new bool[4];
                int total = 0;
                for (int i = 0; i < 4; i++)
                {
                    show[i] = AppTiles(i).Any(AppMatches);
                    if (show[i]) total += AppsCategoryHeight(i, hostW) + gap;
                }

                int w = hostW;
                if (total - gap > hostH)
                {
                    w = hostW - SystemInformation.VerticalScrollBarWidth - Draw.SI(4);
                    total = 0;
                    for (int i = 0; i < 4; i++) if (show[i]) total += AppsCategoryHeight(i, w) + gap;
                }

                int y = _appsHost.AutoScrollPosition.Y;
                for (int i = 0; i < 4; i++)
                {
                    _appsCats[i].Visible = show[i];
                    if (!show[i]) continue;
                    int h = AppsCategoryHeight(i, w);
                    Place(_appsCats[i], 0, y, w, h);
                    LayoutAppsCategory(i, w);
                    y += h + gap;
                }

                bool loadingShown = LayoutAppsLoading(any, hostW, hostH);
                _appsError.Visible = !any && !loadingShown;
                _appsNoMatch.Visible = any && !show.Any(s => s);
                if (_appsError.Visible) Place(_appsError, 0, 0, hostW, Math.Min(hostH, Draw.SI(120)));
                if (_appsNoMatch.Visible) Place(_appsNoMatch, 0, 0, hostW, Draw.SI(80));

                _appsHost.AutoScrollMinSize = new Size(0, Math.Max(0, total - gap));
            }
            finally
            {
                _appsHost.ResumeLayout(false);
                _appsLayingOut = false;
            }
        }

        void LayoutAppsCategory(int category, int w)
        {
            int pad = Draw.SI(16), tg = Draw.SI(8), tileH = Draw.SI(44);
            int inner = w - pad * 2;

            LinkLabel toggle = _appsCatToggles[category];
            Size ls = toggle.GetPreferredSize(Size.Empty);
            Place(toggle, w - pad - ls.Width, pad + (Draw.SI(24) - ls.Height) / 2, ls.Width, ls.Height);

            FluentLabel cap = _appsCatCaps[category], count = _appsCatCounts[category];
            int capW = Math.Min(TextWidth(cap) + Draw.SI(4), inner - ls.Width - Draw.SI(12));
            Place(cap, pad, pad, capW, Draw.SI(24));
            int cx = pad + capW + Draw.SI(10);
            Place(count, cx, pad + Draw.SI(4), Math.Max(0, w - pad - ls.Width - Draw.SI(12) - cx), Draw.SI(20));

            int cols = Math.Max(1, (inner + tg) / (Math.Max(1, _appsTileW) + tg));
            int tileW = (inner - (cols - 1) * tg) / cols;
            AppCard[] shown = AppTiles(category).Where(AppMatches).ToArray();
            int rows = (shown.Length + cols - 1) / cols;

            Panel group = _appsGroups[category];
            Place(group, pad, pad + Draw.SI(34), inner, Math.Max(0, rows * (tileH + tg) - tg));
            group.SuspendLayout();
            for (int i = 0; i < shown.Length; i++)
            {
                Rectangle r = new Rectangle((i % cols) * (tileW + tg), (i / cols) * (tileH + tg), tileW, tileH);
                if (shown[i].Bounds != r) shown[i].Bounds = r;
            }
            group.ResumeLayout(false);
        }

        int LayoutAppsBar(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad;
            int bh = Draw.SI(32), colGap = Draw.SI(28);

            int capH = setDownDirLbl.GetPreferredSize(Size.Empty).Height;
            int th = txtDownloadFolder.PreferredHeight;
            Size r64 = c64.GetPreferredSize(Size.Empty), r32 = c32.GetPreferredSize(Size.Empty);
            Size ai = cAutoInstall.GetPreferredSize(Size.Empty);
            int bitW = Math.Max(bitPref.GetPreferredSize(Size.Empty).Width, r64.Width + Draw.SI(16) + r32.Width);
            int browseW = Draw.SI(40);
            int folderMin = Draw.SI(260);
            bool oneRow = inner - bitW - ai.Width - colGap * 2 >= folderMin;

            int folderW = oneRow ? inner - bitW - ai.Width - colGap * 2 : inner;
            Size fs = setDownDirLbl.GetPreferredSize(Size.Empty);
            Place(setDownDirLbl, pad, y, Math.Min(fs.Width, folderW), capH);
            int iy = y + capH + Draw.SI(6);
            Place(txtDownloadFolder, pad, iy + (bh - th) / 2, folderW - browseW - Draw.SI(6), th);
            Place(changeDownDirB, pad + folderW - browseW, iy, browseW, bh);

            int bx, by;
            if (oneRow)
            {
                bx = pad + folderW + colGap;
                by = y;
            }
            else
            {
                bx = pad;
                by = iy + bh + Draw.SI(12);
            }
            Size bs = bitPref.GetPreferredSize(Size.Empty);
            Place(bitPref, bx, by, Math.Min(bs.Width, inner), capH);
            int ry = by + capH + Draw.SI(6);
            Place(c64, bx, ry + (bh - r64.Height) / 2, r64.Width, r64.Height);
            Place(c32, bx + r64.Width + Draw.SI(16), ry + (bh - r32.Height) / 2, r32.Width, r32.Height);

            int ax = oneRow ? bx + bitW + colGap : bx + bitW + colGap;
            if (!oneRow && ax + ai.Width > pad + inner) ax = pad + inner - ai.Width;
            Place(cAutoInstall, ax, ry + (bh - ai.Height) / 2, ai.Width, ai.Height);

            y = ry + bh + Draw.SI(14);

            int b1 = ButtonWidth(btnDownloadApps, Draw.SI(120)), b2 = ButtonWidth(goToDownloadsB, Draw.SI(120));
            int buttonsW = b1 + b2 + Draw.SI(8);
            bool stack = inner - buttonsW - Draw.SI(16) < Draw.SI(200);
            int statusW = stack ? inner : inner - buttonsW - Draw.SI(16);

            int wl = linkWarnings.Visible ? linkWarnings.GetPreferredSize(Size.Empty).Width : 0;
            int lh = Draw.SI(20);
            Place(txtDownloadStatus, pad, y, Math.Max(0, statusW - (wl > 0 ? wl + Draw.SI(12) : 0)), lh);
            if (wl > 0)
            {
                Size ws = linkWarnings.GetPreferredSize(Size.Empty);
                Place(linkWarnings, pad + statusW - ws.Width, y + (lh - ws.Height) / 2, ws.Width, ws.Height);
            }
            Place(progressDownloader, pad, y + lh + Draw.SI(4), statusW, Draw.SI(6));

            int buttonsY = stack ? y + lh + Draw.SI(20) : y + (lh + Draw.SI(10) - bh) / 2;
            if (!stack) buttonsY = Math.Max(y - Draw.SI(2), buttonsY);
            Place(btnDownloadApps, pad + inner - b1, buttonsY, b1, bh);
            Place(goToDownloadsB, pad + inner - b1 - Draw.SI(8) - b2, buttonsY, b2, bh);

            int bottom = Math.Max(y + lh + Draw.SI(10), buttonsY + bh);
            return bottom + pad;
        }
    }
}
