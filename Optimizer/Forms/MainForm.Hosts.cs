using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        CardPanel _hostsListCard, _hostsAddCard, _hostsLockCard;
        FluentLabel _hostsListCap, _hostsCount, _hostsAddCap, _hostsError, _hostsLockCap, _hostsLockState;
        TextBox _hostsSearch;
        bool _hostsLayingOut;

        static readonly Regex HostsDomainPattern = new Regex(@"^[A-Za-z0-9_\-\*]+(\.[A-Za-z0-9_\-\*]+)*\.?$", RegexOptions.Compiled);

        void InitHostsUi()
        {
            hostsEditorTab.SuspendLayout();
            hostsEditorTab.AutoScroll = true;

            _hostsListCard = NewCard(hostsEditorTab);
            _hostsListCap = NewLabel(_hostsListCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _hostsCount = NewLabel(_hostsListCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            _hostsSearch = new TextBox { Font = Typography.Get(10f, Typography.Weight.Regular) };
            _hostsListCard.Controls.Add(_hostsSearch);
            foreach (Control c in new Control[] { refreshHostsB, listHostEntries, removeHostB, removeAllHostsB })
                Reparent(c, _hostsListCard);

            _hostsAddCard = NewCard(hostsEditorTab);
            _hostsAddCap = NewLabel(_hostsAddCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _hostsError = NewLabel(_hostsAddCard, 9f, Typography.Weight.Regular, LabelTone.Danger);
            _hostsError.AutoSize = false;
            foreach (Control c in new Control[] { lblIP, txtIP, lblDomain, txtDomain, chkBlock, chkIncludeWww, addHostB })
                Reparent(c, _hostsAddCard);
            addHostB.Kind = ButtonKind.Primary;

            _hostsLockCard = NewCard(hostsEditorTab);
            _hostsLockCap = NewLabel(_hostsLockCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _hostsLockState = NewLabel(_hostsLockCard, 9f, Typography.Weight.Semibold, LabelTone.Secondary);
            _hostsLockState.AutoSize = false;
            Reparent(lblLock, _hostsLockCard);
            Reparent(chkReadOnly, _hostsLockCard);

            foreach (Control c in new Control[] { linkLocate, linkAdvancedEdit, linkRestoreDefault })
            {
                Reparent(c, hostsEditorTab);
                ((LinkLabel)c).AutoSize = true;
                c.Font = Typography.Get(9.5f, Typography.Weight.Regular);
            }

            foreach (Label l in new Label[] { lblIP, lblDomain })
            {
                l.AutoSize = true;
                l.Font = Typography.Get(9.5f, Typography.Weight.Semibold);
            }
            lblLock.AutoSize = false;
            lblLock.Font = Typography.Get(9.5f, Typography.Weight.Regular);
            txtIP.Font = Typography.Get(10.5f, Typography.Weight.Regular);
            txtIP.TextAlign = HorizontalAlignment.Left;
            txtDomain.TextAlign = HorizontalAlignment.Left;
            txtDomain.Font = Typography.Get(10.5f, Typography.Weight.Regular);

            removeAllHostsB.Visible = true;
            panel4.Visible = false;
            panelList.Visible = false;

            listHostEntries.SelectionMode = SelectionMode.MultiExtended;
            listHostEntries.ColumnSeparator = " : ";
            listHostEntries.FirstColumnWidth = 130;
            listHostEntries.ItemBadge = o => HostsBadge(o.ToString(), out _);
            listHostEntries.ItemBadgeColor = o =>
            {
                bool danger;
                HostsBadge(o.ToString(), out danger);
                return danger ? ThemeManager.Current.Danger : ThemeManager.Current.TextSecondary;
            };
            listHostEntries.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Delete && removeHostB.Enabled) { removeHostB.PerformClick(); e.Handled = true; }
                else if (e.KeyCode == Keys.A && e.Control) { SelectAllHosts(); e.Handled = true; }
            };

            _hostsSearch.TextChanged += (s, e) => ApplyHostsFilter();
            _hostsSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape) { _hostsSearch.Clear(); e.SuppressKeyPress = true; }
            };

            KeyEventHandler addOnEnter = (s, e) =>
            {
                if (e.KeyCode != Keys.Enter) return;
                e.SuppressKeyPress = true;
                if (addHostB.Enabled) addHostB.PerformClick();
            };
            txtIP.KeyDown += addOnEnter;
            txtDomain.KeyDown += addOnEnter;
            txtIP.TextChanged += (s, e) => ClearHostsError();
            txtDomain.TextChanged += (s, e) => ClearHostsError();
            chkReadOnly.CheckedChanged += (s, e) => UpdateHostsLockState();

            hostsEditorTab.ResumeLayout(false);
            hostsEditorTab.Layout += (s, e) => LayoutHostsTab();
        }

        void RefreshHostsStrings()
        {
            _hostsListCap.Text = T("hostsEntries", "Entries");
            _hostsAddCap.Text = T("hostsAddEntry", "Add entry");
            _hostsLockCap.Text = T("hostsProtection", "Protection");
            listHostEntries.EmptyText = T("hostsEmpty", "No custom entries in your hosts file.");
            SetCue(_hostsSearch, T("hostsSearch", "Search entries"));
            SetCue(txtIP, "0.0.0.0");
            SetCue(txtDomain, "example.com");
            if (_modernTips != null)
            {
                _modernTips.SetToolTip(chkBlock, T("hostsBlockTip", "Redirects the domain to 0.0.0.0 so it can't be reached"));
                _modernTips.SetToolTip(removeHostB, T("hostsDeleteTip", "Delete the selected entries (Del)"));
            }
            UpdateHostsCount();
            UpdateHostsLockState();
            LayoutHostsTab();
        }

        static string HostsBadge(string entry, out bool danger)
        {
            danger = false;
            int split = entry.IndexOf(" : ", StringComparison.Ordinal);
            if (split < 0) return null;
            string ip = entry.Substring(0, split).Trim();
            string domain = entry.Substring(split + 3).Trim();

            if (ip == "0.0.0.0" || ip == "::" || ip == "::0")
            {
                danger = true;
                return T("hostsBlocked", "Blocked");
            }
            if (ip == "127.0.0.1" || ip == "::1")
            {
                if (domain.Equals("localhost", StringComparison.OrdinalIgnoreCase)) return T("hostsLoopback", "Loopback");
                danger = true;
                return T("hostsBlocked", "Blocked");
            }
            return null;
        }

        void ApplyHostsFilter()
        {
            string q = _hostsSearch == null ? string.Empty : _hostsSearch.Text.Trim();
            string[] items = q.Length == 0
                ? _hostsEntries.ToArray()
                : _hostsEntries.Where(x => x.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0).ToArray();

            listHostEntries.BeginUpdate();
            listHostEntries.Items.Clear();
            listHostEntries.Items.AddRange(items);
            listHostEntries.EndUpdate();
            UpdateHostsCount();
        }

        void SelectAllHosts()
        {
            listHostEntries.BeginUpdate();
            for (int i = 0; i < listHostEntries.Items.Count; i++) listHostEntries.SetSelected(i, true);
            listHostEntries.EndUpdate();
        }

        void UpdateHostsCount()
        {
            if (_hostsCount == null) return;
            int total = _hostsEntries.Count, shown = listHostEntries.Items.Count;
            _hostsCount.Text = shown == total
                ? string.Format(T("hostsCount", "{0} entries"), total)
                : string.Format(T("hostsCountFiltered", "{0} of {1} entries"), shown, total);
            LayoutHostsTab();
        }

        void UpdateHostsLockState()
        {
            if (_hostsLockState == null) return;
            bool locked = chkReadOnly.Checked;
            _hostsLockState.Tone = locked ? LabelTone.Success : LabelTone.Secondary;
            _hostsLockState.Text = locked
                ? T("hostsLocked", "Locked — changes are blocked")
                : T("hostsUnlocked", "Unlocked — the hosts file can be modified");
            _hostsSearch.Enabled = true;
            LayoutHostsTab();
        }

        void ClearHostsError()
        {
            if (_hostsError == null || _hostsError.Text.Length == 0) return;
            _hostsError.Text = string.Empty;
            LayoutHostsTab();
        }

        bool ValidateHostsInput(string ip, string domain)
        {
            string error = null;
            IPAddress parsed;
            if (!IPAddress.TryParse(ip, out parsed))
                error = T("hostsInvalidIp", "Enter a valid IPv4 or IPv6 address.");
            else if (domain.Length > 253 || !HostsDomainPattern.IsMatch(domain))
                error = T("hostsInvalidDomain", "Enter a valid domain name, e.g. example.com.");

            if (_hostsError != null)
            {
                _hostsError.Text = error ?? string.Empty;
                LayoutHostsTab();
            }
            if (error != null)
            {
                if (_hostsError == null) MessageBox.Show(this, error, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                (parsed == null ? txtIP : txtDomain).Focus();
                return false;
            }
            return true;
        }

        void LayoutHostsTab()
        {
            if (_hostsLayingOut || _hostsLockCard == null) return;
            Size area = hostsEditorTab.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;
            _hostsLayingOut = true;
            hostsEditorTab.SuspendLayout();
            try
            {
                int margin = Draw.SI(16), gap = Draw.SI(12);
                int innerW = area.Width - margin * 2;

                int x = hostsTitle.Left + Draw.SI(2), ly = hostsTitle.Bottom + Draw.SI(2);
                foreach (LinkLabel l in new[] { linkLocate, linkAdvancedEdit, linkRestoreDefault })
                {
                    Size ps = l.GetPreferredSize(Size.Empty);
                    Place(l, x, ly, ps.Width, ps.Height);
                    x += ps.Width + Draw.SI(18);
                }
                int top = linkLocate.Bottom + Draw.SI(12);
                int minList = Draw.SI(260);

                if (innerW >= Draw.SI(560))
                {
                    int rw = Draw.SI(290), lw = innerW - gap - rw;
                    int h1 = LayoutHostsAdd(rw);
                    int h2 = LayoutHostsLock(rw);
                    int listH = Math.Max(minList, Math.Max(area.Height - top - margin, h1 + gap + h2));
                    Place(_hostsListCard, margin, top, lw, listH);
                    LayoutHostsList(lw, listH);
                    Place(_hostsAddCard, margin + lw + gap, top, rw, h1);
                    Place(_hostsLockCard, margin + lw + gap, top + h1 + gap, rw, h2);
                    hostsEditorTab.AutoScrollMinSize = new Size(0, top + Math.Max(minList, h1 + gap + h2) + margin);
                }
                else
                {
                    int y = top;
                    int h1 = LayoutHostsAdd(innerW);
                    Place(_hostsAddCard, margin, y, innerW, h1);
                    y += h1 + gap;
                    int h2 = LayoutHostsLock(innerW);
                    Place(_hostsLockCard, margin, y, innerW, h2);
                    y += h2 + gap;
                    int listH = Math.Max(minList, area.Height - y - margin);
                    Place(_hostsListCard, margin, y, innerW, listH);
                    LayoutHostsList(innerW, listH);
                    hostsEditorTab.AutoScrollMinSize = new Size(0, y + minList + margin);
                }
            }
            finally
            {
                hostsEditorTab.ResumeLayout(false);
                _hostsLayingOut = false;
            }
        }

        void LayoutHostsList(int w, int h)
        {
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad;
            int cw = Math.Min(TextWidth(_hostsCount) + Draw.SI(4), inner / 2);
            Place(_hostsListCap, pad, y, inner - cw - Draw.SI(8), Draw.SI(24));
            Place(_hostsCount, w - pad - cw, y + Draw.SI(4), cw, Draw.SI(20));
            y += Draw.SI(32);

            int bh = Draw.SI(32);
            int rb = ButtonWidth(refreshHostsB, Draw.SI(96));
            int sh = _hostsSearch.PreferredHeight;
            Place(_hostsSearch, pad, y + (bh - sh) / 2, inner - rb - Draw.SI(8), sh);
            Place(refreshHostsB, w - pad - rb, y, rb, bh);
            y += bh + Draw.SI(10);

            int footY = h - pad - bh;
            Place(listHostEntries, pad, y, inner, Math.Max(Draw.SI(80), footY - Draw.SI(10) - y));

            int b1 = ButtonWidth(removeHostB, Draw.SI(96)), b2 = ButtonWidth(removeAllHostsB, Draw.SI(96));
            Place(removeAllHostsB, w - pad - b2, footY, b2, bh);
            Place(removeHostB, w - pad - b2 - Draw.SI(8) - b1, footY, b1, bh);
        }

        int LayoutHostsAdd(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad;
            Place(_hostsAddCap, pad, y, inner, Draw.SI(24));
            y += Draw.SI(34);

            foreach (Control[] pair in new[] { new Control[] { lblIP, txtIP }, new Control[] { lblDomain, txtDomain } })
            {
                Size ls = pair[0].GetPreferredSize(Size.Empty);
                Place(pair[0], pad, y, inner, ls.Height);
                y += ls.Height + Draw.SI(4);
                Place(pair[1], pad, y, inner, pair[1].Height);
                y += pair[1].Height + Draw.SI(12);
            }

            Size c1 = chkBlock.GetPreferredSize(Size.Empty), c2 = chkIncludeWww.GetPreferredSize(Size.Empty);
            int ch = Math.Max(c1.Height, c2.Height);
            if (c1.Width + Draw.SI(16) + c2.Width <= inner)
            {
                Place(chkBlock, pad, y, c1.Width, ch);
                Place(chkIncludeWww, pad + c1.Width + Draw.SI(16), y, c2.Width, ch);
                y += ch + Draw.SI(8);
            }
            else
            {
                Place(chkBlock, pad, y, inner, ch);
                y += ch + Draw.SI(6);
                Place(chkIncludeWww, pad, y, inner, ch);
                y += ch + Draw.SI(8);
            }

            if (_hostsError.Text.Length > 0)
            {
                int eh = TextRenderer.MeasureText(_hostsError.Text, _hostsError.Font, new Size(inner, 0), TextFormatFlags.WordBreak).Height;
                _hostsError.Visible = true;
                Place(_hostsError, pad, y, inner, eh);
                y += eh + Draw.SI(8);
            }
            else
            {
                _hostsError.Visible = false;
            }

            int bh = Draw.SI(32), bw = ButtonWidth(addHostB, Draw.SI(110));
            y += Draw.SI(4);
            Place(addHostB, w - pad - bw, y, bw, bh);
            return y + bh + pad;
        }

        int LayoutHostsLock(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad;
            Place(_hostsLockCap, pad, y, inner, Draw.SI(24));
            y += Draw.SI(30);

            int lh = TextRenderer.MeasureText(lblLock.Text, lblLock.Font, new Size(inner, 0), TextFormatFlags.WordBreak).Height;
            Place(lblLock, pad, y, inner, lh);
            y += lh + Draw.SI(10);

            Size cs = chkReadOnly.GetPreferredSize(Size.Empty);
            Place(chkReadOnly, pad, y, Math.Min(cs.Width, inner), cs.Height);
            y += cs.Height + Draw.SI(6);

            int sh = TextRenderer.MeasureText(_hostsLockState.Text, _hostsLockState.Font, new Size(inner, 0), TextFormatFlags.WordBreak).Height;
            Place(_hostsLockState, pad, y, inner, sh);
            return y + sh + pad;
        }
    }
}
