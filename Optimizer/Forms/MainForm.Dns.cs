using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        CardPanel _dnsAdapterCard, _dnsProviderCard, _dnsCurrentCard;
        FluentLabel _dnsAdapterCap, _dnsProviderCap, _dnsProviderHint, _dnsCurrentCap, _dnsCopyHint;
        Timer _dnsCopiedTimer;
        bool _dnsLayingOut;

        void InitDnsUi()
        {
            tabPage2.AutoScroll = true;
            tabPage2.SuspendLayout();

            _dnsAdapterCard = NewCard(tabPage2);
            _dnsAdapterCap = NewLabel(_dnsAdapterCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            Reparent(boxAdapter, _dnsAdapterCard);
            Reparent(chkAllNics, _dnsAdapterCard);

            _dnsProviderCard = NewCard(tabPage2);
            _dnsProviderCap = NewLabel(_dnsProviderCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _dnsProviderHint = NewLabel(_dnsProviderCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            _dnsProviderHint.AutoSize = false;
            foreach (Control c in new Control[] { boxDNS, chkCustomDns, label10, txtDns4A, txtDns4B, label12, txtDns6A, txtDns6B, btnSetDns })
                Reparent(c, _dnsProviderCard);
            ((FluentButton)btnSetDns).Kind = ButtonKind.Primary;

            _dnsCurrentCard = NewCard(tabPage2);
            _dnsCurrentCap = NewLabel(_dnsCurrentCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _dnsCopyHint = NewLabel(_dnsCurrentCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            foreach (Control c in new Control[] { label1, linkDNSv4, linkDNSv4A, label3, linkDNSv6, linkDNSv6A, flushCacheB, btnOpenNetwork })
                Reparent(c, _dnsCurrentCard);

            foreach (Label l in new Label[] { label10, label12, label1, label3 })
            {
                l.AutoSize = true;
                l.Font = Typography.Get(9.5f, Typography.Weight.Semibold);
            }
            foreach (LinkLabel l in new[] { linkDNSv4, linkDNSv4A, linkDNSv6, linkDNSv6A })
            {
                l.AutoSize = true;
                l.Font = Typography.Get(10.5f, Typography.Weight.Regular);
            }

            _dnsCopiedTimer = new Timer { Interval = 2000 };
            _dnsCopiedTimer.Tick += (s, e) =>
            {
                _dnsCopiedTimer.Stop();
                _dnsCopyHint.Tone = LabelTone.Secondary;
                _dnsCopyHint.Text = T("dnsCopyHint", "Select an address to copy it");
            };

            boxDNS.SelectedIndexChanged += (s, e) => UpdateDnsHint();
            boxDNS.TextChanged += (s, e) => UpdateDnsHint();
            chkCustomDns.CheckedChanged += (s, e) => LayoutDnsTab();

            tabPage2.ResumeLayout(false);
            tabPage2.Layout += (s, e) => LayoutDnsTab();
        }

        void RefreshDnsStrings()
        {
            _dnsAdapterCap.Text = T("dnsAdapter", "Network adapter");
            _dnsProviderCap.Text = T("dnsProvider", "DNS provider");
            _dnsCurrentCap.Text = T("dnsCurrent", "Current DNS servers");
            _dnsCopyHint.Tone = LabelTone.Secondary;
            _dnsCopyHint.Text = T("dnsCopyHint", "Select an address to copy it");
            SetCue(txtDns4A, T("dnsPreferred", "Preferred"));
            SetCue(txtDns4B, T("dnsAlternate", "Alternate"));
            SetCue(txtDns6A, T("dnsPreferred", "Preferred"));
            SetCue(txtDns6B, T("dnsAlternate", "Alternate"));
            UpdateDnsHint();
        }

        void FlashDnsCopied()
        {
            if (_dnsCopyHint == null) return;
            _dnsCopiedTimer.Stop();
            _dnsCopyHint.Tone = LabelTone.Success;
            _dnsCopyHint.Text = T("dnsCopied", "Copied to clipboard");
            _dnsCopiedTimer.Start();
            LayoutDnsTab();
        }

        void UpdateDnsHint()
        {
            if (_dnsProviderHint == null) return;
            string[] v4 = null, v6 = null;
            string p = boxDNS.Text;
            if (p == Constants.CloudflareDNS) { v4 = PingerHelper.CloudflareDNSv4; v6 = PingerHelper.CloudflareDNSv6; }
            else if (p == Constants.OpenDNS) { v4 = PingerHelper.OpenDNSv4; v6 = PingerHelper.OpenDNSv6; }
            else if (p == Constants.Quad9DNS) { v4 = PingerHelper.Quad9DNSv4; v6 = PingerHelper.Quad9DNSv6; }
            else if (p == Constants.GoogleDNS) { v4 = PingerHelper.GoogleDNSv4; v6 = PingerHelper.GoogleDNSv6; }
            else if (p == Constants.AlternateDNS) { v4 = PingerHelper.AlternateDNSv4; v6 = PingerHelper.AlternateDNSv6; }
            else if (p == Constants.AdguardDNS) { v4 = PingerHelper.AdguardDNSv4; v6 = PingerHelper.AdguardDNSv6; }
            else if (p == Constants.CleanBrowsingDNS) { v4 = PingerHelper.CleanBrowsingDNSv4; v6 = PingerHelper.CleanBrowsingDNSv6; }
            else if (p == Constants.CleanBrowsingAdultFilterDNS) { v4 = PingerHelper.CleanBrowsingAdultDNSv4; v6 = PingerHelper.CleanBrowsingAdultDNSv6; }

            if (p == Constants.AutomaticDNS)
                _dnsProviderHint.Text = T("dnsAutoHint", "Use the DNS servers provided by your network (DHCP).");
            else if (v4 != null)
                _dnsProviderHint.Text = "IPv4: " + string.Join(", ", v4.Where(x => !string.IsNullOrEmpty(x)))
                    + Environment.NewLine + "IPv6: " + string.Join(", ", (v6 ?? new string[0]).Where(x => !string.IsNullOrEmpty(x)));
            else
                _dnsProviderHint.Text = string.Empty;
            LayoutDnsTab();
        }

        void LayoutDnsTab()
        {
            if (_dnsLayingOut || _dnsCurrentCard == null) return;
            Size area = tabPage2.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;
            _dnsLayingOut = true;
            tabPage2.SuspendLayout();
            try
            {
                int margin = Draw.SI(16), gap = Draw.SI(12);
                int innerW = area.Width - margin * 2;
                int top = dnsTitle.Bottom + Draw.SI(14);
                int bottom;
                if (innerW >= Draw.SI(760))
                {
                    int lw = (innerW - gap) / 2, rw = innerW - gap - lw;
                    int h1 = LayoutDnsAdapter(lw);
                    Place(_dnsAdapterCard, margin, top, lw, h1);
                    int h2 = LayoutDnsProvider(lw);
                    Place(_dnsProviderCard, margin, top + h1 + gap, lw, h2);
                    int h3 = LayoutDnsCurrent(rw);
                    Place(_dnsCurrentCard, margin + lw + gap, top, rw, h3);
                    bottom = Math.Max(top + h1 + gap + h2, top + h3);
                }
                else
                {
                    int y = top;
                    int h1 = LayoutDnsAdapter(innerW);
                    Place(_dnsAdapterCard, margin, y, innerW, h1);
                    y += h1 + gap;
                    int h2 = LayoutDnsProvider(innerW);
                    Place(_dnsProviderCard, margin, y, innerW, h2);
                    y += h2 + gap;
                    int h3 = LayoutDnsCurrent(innerW);
                    Place(_dnsCurrentCard, margin, y, innerW, h3);
                    bottom = y + h3;
                }
                Size min = new Size(0, bottom - tabPage2.AutoScrollPosition.Y + margin);
                if (tabPage2.AutoScrollMinSize != min) tabPage2.AutoScrollMinSize = min;
            }
            finally
            {
                tabPage2.ResumeLayout(false);
                _dnsLayingOut = false;
            }
        }

        int LayoutDnsAdapter(int w)
        {
            int pad = Draw.SI(16), y = pad;
            Place(_dnsAdapterCap, pad, y, w - pad * 2, Draw.SI(24));
            y += Draw.SI(30);
            Place(boxAdapter, pad, y, w - pad * 2, boxAdapter.Height);
            y += boxAdapter.Height + Draw.SI(10);
            int ch = chkAllNics.GetPreferredSize(Size.Empty).Height;
            Place(chkAllNics, pad, y, w - pad * 2, ch);
            return y + ch + pad;
        }

        int LayoutDnsProvider(int w)
        {
            int pad = Draw.SI(16), y = pad, inner = w - pad * 2;
            Place(_dnsProviderCap, pad, y, inner, Draw.SI(24));
            y += Draw.SI(30);
            int ch = chkCustomDns.GetPreferredSize(Size.Empty).Height;
            Place(chkCustomDns, pad, y, inner, ch);
            y += ch + Draw.SI(10);

            bool custom = chkCustomDns.Checked;
            boxDNS.Visible = !custom;
            _dnsProviderHint.Visible = !custom && _dnsProviderHint.Text.Length > 0;
            foreach (Control c in new Control[] { label10, txtDns4A, txtDns4B, label12, txtDns6A, txtDns6B }) c.Visible = custom;

            if (!custom)
            {
                Place(boxDNS, pad, y, inner, boxDNS.Height);
                y += boxDNS.Height + Draw.SI(8);
                if (_dnsProviderHint.Visible)
                {
                    int hh = TextRenderer.MeasureText(_dnsProviderHint.Text, _dnsProviderHint.Font, new Size(inner, 0), TextFormatFlags.WordBreak).Height;
                    Place(_dnsProviderHint, pad, y, inner, hh);
                    y += hh + Draw.SI(8);
                }
            }
            else
            {
                int half = (inner - Draw.SI(8)) / 2;
                foreach (Control[] row in new[] { new Control[] { label10, txtDns4A, txtDns4B }, new Control[] { label12, txtDns6A, txtDns6B } })
                {
                    Place(row[0], pad, y, inner, row[0].GetPreferredSize(Size.Empty).Height);
                    y += row[0].GetPreferredSize(Size.Empty).Height + Draw.SI(4);
                    Place(row[1], pad, y, half, row[1].Height);
                    Place(row[2], pad + half + Draw.SI(8), y, inner - half - Draw.SI(8), row[2].Height);
                    y += row[1].Height + Draw.SI(10);
                }
            }

            int bw = ButtonWidth(btnSetDns, Draw.SI(120)), bh = Draw.SI(36);
            y += Draw.SI(4);
            Place(btnSetDns, w - pad - bw, y, bw, bh);
            return y + bh + pad;
        }

        int LayoutDnsCurrent(int w)
        {
            int pad = Draw.SI(16), y = pad, inner = w - pad * 2;
            Place(_dnsCurrentCap, pad, y, inner, Draw.SI(24));
            y += Draw.SI(26);
            Place(_dnsCopyHint, pad, y, inner, _dnsCopyHint.PreferredHeight);
            y += _dnsCopyHint.PreferredHeight + Draw.SI(12);

            int lw = Math.Max(label1.PreferredWidth, label3.PreferredWidth) + Draw.SI(12);
            int rowH = Draw.SI(26);
            foreach (Control[] grp in new[] { new Control[] { label1, linkDNSv4, linkDNSv4A }, new Control[] { label3, linkDNSv6, linkDNSv6A } })
            {
                Place(grp[0], pad, y + (rowH - grp[0].GetPreferredSize(Size.Empty).Height) / 2, lw, grp[0].GetPreferredSize(Size.Empty).Height);
                for (int i = 1; i < grp.Length; i++)
                {
                    Size ps = grp[i].PreferredSize;
                    Place(grp[i], pad + lw, y + (rowH - ps.Height) / 2, Math.Min(ps.Width, inner - lw), ps.Height);
                    y += rowH;
                }
                y += Draw.SI(8);
            }

            int bh = Draw.SI(36), gap = Draw.SI(8);
            int w1 = ButtonWidth(flushCacheB, Draw.SI(120)), w2 = ButtonWidth(btnOpenNetwork, Draw.SI(120));
            y += Draw.SI(4);
            if (w1 + gap + w2 <= inner)
            {
                Place(flushCacheB, pad, y, w1, bh);
                Place(btnOpenNetwork, pad + w1 + gap, y, w2, bh);
                y += bh;
            }
            else
            {
                Place(flushCacheB, pad, y, Math.Min(w1, inner), bh);
                y += bh + gap;
                Place(btnOpenNetwork, pad, y, Math.Min(w2, inner), bh);
                y += bh;
            }
            return y + pad;
        }
    }
}
