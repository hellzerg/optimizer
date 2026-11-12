using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        sealed class RegistryItem {
            public MoonCheck Check;
            public RegistryTile Tile;
            public FluentLabel Desc, Badge;
            public string DescKey, DescFallback;
            public Func<bool> IsBlocked;
            public bool IsFirewall;
        }

        readonly List<RegistryItem> _regItems = new List<RegistryItem>();
        CardPanel _regItemsCard, _regApplyCard;
        FluentLabel _regIntro, _regItemsCap, _regDetected, _regRestartHint, _regCount, _regStatus;
        LinkLabel _regToggleAll, _regSelectDetected;
        bool _regLayingOut;

        void InitRegistryUi()
        {
            registryFixerTab.AutoScroll = true;
            registryFixerTab.SuspendLayout();
            panel2.Visible = false;
            checkEnableAll.Visible = false;

            _regIntro = NewLabel(registryFixerTab, 10f, Typography.Weight.Regular, LabelTone.Secondary);

            _regItemsCard = NewCard(registryFixerTab);
            _regItemsCap = NewLabel(_regItemsCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _regDetected = NewLabel(_regItemsCard, 9.5f, Typography.Weight.Regular, LabelTone.Secondary);
            _regToggleAll = NewLink(_regItemsCard);
            _regToggleAll.LinkClicked += (s, e) =>
            {
                bool select = _regItems.Any(i => !i.Check.Checked);
                foreach (RegistryItem i in _regItems) i.Check.Checked = select;
            };
            _regSelectDetected = NewLink(_regItemsCard);
            _regSelectDetected.LinkClicked += (s, e) =>
            {
                foreach (RegistryItem i in _regItems) i.Check.Checked = i.Badge.Visible;
            };

            const string explorer = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer";
            const string system = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
            AddRegistryItem(checkTaskManager, "regDescTaskManager", "Restores Task Manager if a policy has disabled it.", () => PolicySet(system, "DisableTaskMgr"));
            AddRegistryItem(checkCommandPrompt, "regDescCommandPrompt", "Lets Command Prompt and batch scripts run again.", () => PolicySet("Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD"));
            AddRegistryItem(checkControlPanel, "regDescControlPanel", "Brings back access to Control Panel and Settings.", () => PolicySet(explorer, "NoControlPanel"));
            AddRegistryItem(checkFolderOptions, "regDescFolderOptions", "Re-enables Folder Options in File Explorer.", () => PolicySet(explorer, "NoFolderOptions"));
            AddRegistryItem(checkRunDialog, "regDescRunDialog", "Restores the Run dialog (Win+R).", () => PolicySet(explorer, "NoRun"));
            AddRegistryItem(checkContextMenu, "regDescContextMenu", "Restores the right-click menu in File Explorer and on the desktop.", () => PolicySet(explorer, "NoViewContextMenu"));
            AddRegistryItem(checkRegistryEditor, "regDescRegistryEditor", "Allows Registry Editor to open again.", () => PolicySet(system, "DisableRegistryTools"));
            AddRegistryItem(checkFirewall, "regDescFirewall", "Turns Windows Firewall back on for the current network profile.", FirewallOff).IsFirewall = true;

            _regApplyCard = NewCard(registryFixerTab);
            Reparent(checkRestartExplorer, _regApplyCard);
            checkRestartExplorer.AutoSize = false;
            checkRestartExplorer.Font = Typography.Get(10.5f, Typography.Weight.Regular);
            _regRestartHint = NewLabel(_regApplyCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            _regCount = NewLabel(_regApplyCard, 9.5f, Typography.Weight.Regular, LabelTone.Secondary);
            _regStatus = NewLabel(_regApplyCard, 9.5f, Typography.Weight.Semibold, LabelTone.Success);
            _regStatus.Visible = false;
            Reparent(regFixB, _regApplyCard);
            regLbl.Visible = false;
            regLbl.TextChanged += (s, e) => UpdateRegistryRestartHint();

            regFixB.Click += (s, e) =>
            {
                int restored = _regItems.Count(i => i.Check.Checked);
                RefreshRegistryState();
                _regStatus.Text = string.Format(T("regDone", "Done. {0} item(s) restored."), restored);
                _regStatus.Visible = true;
                LayoutRegistryTab();
            };

            registryFixerTab.VisibleChanged += (s, e) => { if (registryFixerTab.Visible) RefreshRegistryState(); };
            registryFixerTab.ResumeLayout(false);
            registryFixerTab.Layout += (s, e) => LayoutRegistryTab();
            RefreshRegistryState();
        }

        RegistryItem AddRegistryItem(MoonCheck check, string descKey, string descFallback, Func<bool> isBlocked)
        {
            RegistryItem item = new RegistryItem { Check = check, DescKey = descKey, DescFallback = descFallback, IsBlocked = isBlocked };
            item.Tile = new RegistryTile(check);
            _regItemsCard.Controls.Add(item.Tile);
            Reparent(check, item.Tile);
            check.AutoSize = false;
            check.Font = Typography.Get(10.5f, Typography.Weight.Semibold);
            item.Desc = NewLabel(item.Tile, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            item.Badge = NewLabel(item.Tile, 8.5f, Typography.Weight.Semibold, LabelTone.Danger);
            item.Badge.Visible = false;
            item.Desc.Click += (s, e) => check.Checked = !check.Checked;
            item.Desc.Cursor = Cursors.Hand;
            check.CheckedChanged += (s, e) =>
            {
                item.Tile.Invalidate();
                UpdateRegistrySelection();
            };
            _regItems.Add(item);
            return item;
        }

        void RefreshRegistryStrings()
        {
            _regIntro.Text = T("regIntro", "Malware or restrictive policies can lock you out of common Windows tools. Select what to restore, then click Fix.");
            _regItemsCap.Text = T("regItemsCap", "Restore access to");
            _regSelectDetected.Text = T("regSelectDetected", "Select detected");
            foreach (RegistryItem i in _regItems)
            {
                i.Desc.Text = T(i.DescKey, i.DescFallback);
                i.Badge.Text = i.IsFirewall ? T("regFirewallOff", "Turned off") : T("regBlocked", "Blocked");
            }
            UpdateRegistryRestartHint();
            _regStatus.Visible = false;
            RefreshRegistryState();
        }

        void UpdateRegistryRestartHint()
        {
            if (_regRestartHint == null) return;
            _regRestartHint.Text = CleanText(regLbl.Text).Trim('(', ')', ' ');
            LayoutRegistryTab();
        }

        static bool PolicySet(string path, string name)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(path))
                {
                    object v = key == null ? null : key.GetValue(name);
                    return v is int && (int)v != 0;
                }
            }
            catch
            {
                return false;
            }
        }

        static bool FirewallOff()
        {
            try
            {
                foreach (string profile in new[] { "StandardProfile", "PublicProfile" })
                {
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\" + profile))
                    {
                        object v = key == null ? null : key.GetValue("EnableFirewall");
                        if (v is int && (int)v == 0) return true;
                    }
                }
            }
            catch { }
            return false;
        }

        void RefreshRegistryState()
        {
            if (_regItemsCard == null) return;
            int detected = 0;
            foreach (RegistryItem i in _regItems)
            {
                bool blocked = i.IsBlocked();
                i.Badge.Visible = blocked;
                if (blocked) detected++;
            }
            if (detected > 0)
            {
                _regDetected.Tone = LabelTone.Danger;
                _regDetected.Text = string.Format(T("regDetected", "{0} restriction(s) detected on this PC"), detected);
            }
            else
            {
                _regDetected.Tone = LabelTone.Success;
                _regDetected.Text = T("regNoneDetected", "No restrictions detected");
            }
            _regSelectDetected.Visible = detected > 0;
            UpdateRegistrySelection();
        }

        void UpdateRegistrySelection()
        {
            if (_regCount == null) return;
            int n = _regItems.Count(i => i.Check.Checked);
            _regCount.Text = string.Format(T("regSelected", "{0} of {1} selected"), n, _regItems.Count);
            _regToggleAll.Text = n == _regItems.Count ? T("regClearAll", "Clear selection") : T("regSelectAll", "Select all");
            regFixB.Enabled = n > 0;
            LayoutRegistryTab();
        }

        void LayoutRegistryTab()
        {
            if (_regLayingOut || _regApplyCard == null) return;
            Size area = registryFixerTab.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;
            _regLayingOut = true;
            registryFixerTab.SuspendLayout();
            try
            {
                int margin = Draw.SI(16), gap = Draw.SI(12);
                int innerW = Math.Max(Draw.SI(200), area.Width - margin * 2);
                int y = registryTitle.Bottom + Draw.SI(4);

                int ih = WrapHeight(_regIntro, _regIntro.Text, innerW);
                Place(_regIntro, margin, y, innerW, ih);
                y += ih + Draw.SI(14);

                int h1 = LayoutRegistryItems(innerW);
                Place(_regItemsCard, margin, y, innerW, h1);
                y += h1 + gap;

                int h2 = LayoutRegistryApply(innerW);
                Place(_regApplyCard, margin, y, innerW, h2);
                y += h2;

                Size min = new Size(0, y - registryFixerTab.AutoScrollPosition.Y + margin);
                if (registryFixerTab.AutoScrollMinSize != min) registryFixerTab.AutoScrollMinSize = min;
            }
            finally
            {
                registryFixerTab.ResumeLayout(false);
                _regLayingOut = false;
            }
        }

        int LayoutRegistryItems(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad;

            // links on the right of the caption
            int lx = w - pad;
            foreach (LinkLabel l in new[] { _regToggleAll, _regSelectDetected })
            {
                if (!l.Visible) continue;
                Size ps = l.PreferredSize;
                lx -= ps.Width;
                Place(l, lx, y + (Draw.SI(24) - ps.Height) / 2, ps.Width, ps.Height);
                lx -= Draw.SI(16);
            }
            Place(_regItemsCap, pad, y, Math.Max(0, lx - pad), Draw.SI(24));
            y += Draw.SI(26);
            Place(_regDetected, pad, y, inner, _regDetected.PreferredHeight);
            y += _regDetected.PreferredHeight + Draw.SI(12);

            int cols = inner >= Draw.SI(620) ? 2 : 1;
            int tg = Draw.SI(8);
            int tw = (inner - tg * (cols - 1)) / cols;
            for (int r = 0; r * cols < _regItems.Count; r++)
            {
                int rowH = 0;
                for (int c = 0; c < cols && r * cols + c < _regItems.Count; c++)
                    rowH = Math.Max(rowH, LayoutRegistryTile(_regItems[r * cols + c], tw));
                for (int c = 0; c < cols && r * cols + c < _regItems.Count; c++)
                    Place(_regItems[r * cols + c].Tile, pad + c * (tw + tg), y, tw, rowH);
                y += rowH + tg;
            }
            return y - tg + pad;
        }

        int LayoutRegistryTile(RegistryItem i, int w)
        {
            int pad = Draw.SI(12), inner = w - pad * 2, y = Draw.SI(10);
            int bw = 0;
            if (i.Badge.Visible)
            {
                Size bs = i.Badge.GetPreferredSize(Size.Empty);
                bw = bs.Width;
                Place(i.Badge, w - pad - bw, y + Draw.SI(3), bw, bs.Height);
                bw += Draw.SI(8);
            }
            int ch = Math.Max(Draw.SI(24), i.Check.GetPreferredSize(Size.Empty).Height);
            Place(i.Check, pad, y, Math.Max(0, inner - bw), ch);
            y += ch + Draw.SI(2);
            int indent = Draw.SI(28);
            int dh = WrapHeight(i.Desc, i.Desc.Text, inner - indent);
            Place(i.Desc, pad + indent, y, inner - indent, dh);
            return y + dh + Draw.SI(12);
        }

        int LayoutRegistryApply(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2;
            int bw = ButtonWidth(regFixB, Draw.SI(120)), bh = Draw.SI(36);
            int cw = _regCount.GetPreferredSize(Size.Empty).Width;
            bool side = inner - bw - cw - Draw.SI(32) >= Draw.SI(260);
            int textW = side ? inner - bw - cw - Draw.SI(32) : inner;

            int y = pad;
            int ch = Math.Max(Draw.SI(24), checkRestartExplorer.GetPreferredSize(Size.Empty).Height);
            Place(checkRestartExplorer, pad, y, textW, ch);
            y += ch + Draw.SI(2);
            int hh = WrapHeight(_regRestartHint, _regRestartHint.Text, textW - Draw.SI(28));
            Place(_regRestartHint, pad + Draw.SI(28), y, textW - Draw.SI(28), hh);
            y += hh;
            if (_regStatus.Visible)
            {
                y += Draw.SI(8);
                int sh = WrapHeight(_regStatus, _regStatus.Text, textW);
                Place(_regStatus, pad, y, textW, sh);
                y += sh;
            }
            int textBottom = y;

            if (side)
            {
                int by = pad + Math.Max(0, (textBottom - pad - bh) / 2);
                Place(regFixB, w - pad - bw, by, bw, bh);
                int cy = by + (bh - _regCount.PreferredHeight) / 2;
                Place(_regCount, w - pad - bw - Draw.SI(16) - cw, cy, cw, _regCount.PreferredHeight);
                return Math.Max(textBottom, by + bh) + pad;
            }

            y += Draw.SI(14);
            Place(_regCount, pad, y + (bh - _regCount.PreferredHeight) / 2, Math.Min(cw, inner - bw - Draw.SI(12)), _regCount.PreferredHeight);
            Place(regFixB, w - pad - bw, y, bw, bh);
            return y + bh + pad;
        }
    }

    /// <summary>Rounded selectable tile hosting one registry fix; clicking anywhere toggles its check.</summary>
    internal sealed class RegistryTile : Panel, IThemeable {
        readonly CheckBox _check;
        bool _hover;

        public RegistryTile(CheckBox check)
        {
            _check = check;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Cursor = Cursors.Hand;
        }

        Color Fill(Palette p)
        {
            Color baseFill = ColorMath.Blend(p.Layer1, p.TextPrimary, p.IsDark ? 0.045 : 0.025);
            return _hover ? ColorMath.Blend(baseFill, p.TextPrimary, p.IsDark ? 0.04 : 0.025) : baseFill;
        }

        public void ApplyTheme(Palette palette)
        {
            BackColor = Fill(palette);
            Invalidate();
        }

        void SetHover(bool on)
        {
            if (_hover == on) return;
            _hover = on;
            if (ThemeManager.Current == null) return;
            BackColor = Fill(ThemeManager.Current);
            foreach (Control c in Controls) c.BackColor = BackColor;
            Invalidate(true);
        }

        protected override void OnMouseEnter(EventArgs e) { SetHover(true); base.OnMouseEnter(e); }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (!ClientRectangle.Contains(PointToClient(Cursor.Position))) SetHover(false);
            base.OnMouseLeave(e);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.MouseEnter += (s, a) => SetHover(true);
            e.Control.MouseLeave += (s, a) => { if (!ClientRectangle.Contains(PointToClient(Cursor.Position))) SetHover(false); };
        }

        protected override void OnClick(EventArgs e)
        {
            _check.Checked = !_check.Checked;
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.Layer1);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            bool on = _check.Checked;
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(6)))
            using (SolidBrush b = new SolidBrush(Fill(p)))
            using (Pen pen = new Pen(on ? p.Accent : (p.IsDark ? ColorMath.Blend(p.Layer1, Color.White, 0.08) : p.Stroke), on ? Draw.S(1.5f) : 1f))
            {
                g.FillPath(b, path);
                g.DrawPath(pen, path);
            }
        }
    }
}
