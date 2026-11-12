using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        sealed class PingLine {
            internal readonly string Text;
            internal readonly LabelTone Tone;

            internal PingLine(string text, LabelTone tone = LabelTone.Primary)
            {
                Text = text;
                Tone = tone;
            }

            public override string ToString() { return Text; }
        }

        CardPanel _pingInputCard, _pingResultsCard;
        StatTile _pingMin, _pingAvg, _pingMax, _pingLoss;
        MoonSelect _pingCount;
        FluentLabel _pingCountCap, _pingProgress;
        CancellationTokenSource _pingCts;
        string _pingIdleText;
        bool _pingLayingOut;

        void InitPingerUi()
        {
            tabPage1.SuspendLayout();
            _pingInputCard = NewCard(tabPage1);
            foreach (Control c in new Control[] { lblPinger, txtPingInput, btnPing, copyIPB, copyB, btnShodan })
                Reparent(c, _pingInputCard);
            lblPinger.AutoSize = true;
            lblPinger.Font = Typography.Get(9.5f, Typography.Weight.Semibold);
            txtPingInput.Font = Typography.Get(11f, Typography.Weight.Regular);
            txtPingInput.TextAlign = HorizontalAlignment.Left;
            ((FluentButton)btnPing).Kind = ButtonKind.Primary;
            _pingCountCap = NewLabel(_pingInputCard, 9.5f, Typography.Weight.Semibold, LabelTone.Primary);
            _pingCount = new MoonSelect { DropDownStyle = ComboBoxStyle.DropDownList };
            _pingCount.Items.AddRange(new object[] { "4", "9", "16", "32" });
            _pingCount.SelectedIndex = 1;
            _pingInputCard.Controls.Add(_pingCount);

            _pingMin = new StatTile();
            _pingAvg = new StatTile();
            _pingMax = new StatTile();
            _pingLoss = new StatTile();
            tabPage1.Controls.AddRange(new Control[] { _pingMin, _pingAvg, _pingMax, _pingLoss });

            _pingResultsCard = NewCard(tabPage1);
            foreach (Control c in new Control[] { lblResults, btnExport, listPingResults }) Reparent(c, _pingResultsCard);
            lblResults.AutoSize = true;
            lblResults.Font = Typography.Get(11f, Typography.Weight.Semibold);
            _pingProgress = NewLabel(_pingResultsCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            listPingResults.ItemColor = o =>
            {
                PingLine l = o as PingLine;
                if (l == null || l.Tone == LabelTone.Primary || ThemeManager.Current == null) return null;
                return Tones.Of(l.Tone, ThemeManager.Current);
            };
            panel7.Visible = false;
            ResetPingStats();

            tabPage1.ResumeLayout(false);
            tabPage1.Layout += (s, e) => LayoutPingerTab();
        }

        void RefreshPingerStrings()
        {
            _pingCountCap.Text = T("pingCount", "Pings");
            _pingMin.Caption = T("min", "Min");
            _pingAvg.Caption = T("avg", "Average");
            _pingMax.Caption = T("max", "Max");
            _pingLoss.Caption = T("pingLoss", "Packet loss");
            listPingResults.EmptyText = T("pingEmpty", "Enter an IP address or domain name and select Ping.");
            SetCue(txtPingInput, T("pingCue", "e.g. 1.1.1.1 or example.com"));
            if (_pingCts == null) _pingIdleText = btnPing.Text;
            _modernTips.SetToolTip(copyIPB, T("pingCopyInputTip", "Copy what you typed"));
            _modernTips.SetToolTip(copyB, T("pingCopyIpTip", "Copy the resolved IP address"));
            LayoutPingerTab();
        }

        void ResetPingStats()
        {
            foreach (StatTile t in new[] { _pingMin, _pingAvg, _pingMax, _pingLoss })
            {
                t.Value = "-";
                t.ValueTone = LabelTone.Primary;
            }
            _pingProgress.Text = string.Empty;
        }

        void UpdatePingStats(List<PingReply> ok, int sent)
        {
            if (ok.Count > 0)
            {
                _pingMin.Value = ok.Min(x => x.RoundtripTime) + " ms";
                _pingMax.Value = ok.Max(x => x.RoundtripTime) + " ms";
                _pingAvg.Value = ok.Average(x => x.RoundtripTime).ToString("F1") + " ms";
            }
            if (sent > 0)
            {
                int loss = (int)Math.Round((sent - ok.Count) * 100.0 / sent);
                _pingLoss.Value = loss + "%";
                _pingLoss.ValueTone = loss == 0 ? LabelTone.Success : loss == 100 ? LabelTone.Danger : LabelTone.Accent;
            }
        }

        void TogglePing()
        {
            if (_pingCts != null)
            {
                _pingCts.Cancel();
                return;
            }

            string host = txtPingInput.Text.Trim();
            if (string.IsNullOrEmpty(host)) return;
            int count = int.Parse(_pingCount.SelectedItem?.ToString() ?? "9");

            _pingResults = new List<PingReply>();
            listPingResults.Items.Clear();
            ResetPingStats();
            _shodanIP = string.Empty;

            CancellationTokenSource cts = new CancellationTokenSource();
            _pingCts = cts;
            _pingIdleText = btnPing.Text;
            btnPing.Text = T("pingStop", "Stop");
            btnShodan.Enabled = false;
            _pingCount.Enabled = false;
            _pingProgress.Text = OptionsHelper.TranslationList["pinging"]?.ToString();
            LayoutPingerTab();

            Task.Run(() =>
            {
                List<PingReply> ok = new List<PingReply>();
                int sent = 0;
                if (PingerHelper.PingHost(host) == null)
                {
                    UI(() => listPingResults.Items.Add(new PingLine(string.Format("{0} [{1}]", OptionsHelper.TranslationList["hostNotFound"], host), LabelTone.Danger)));
                }
                else
                {
                    UI(() =>
                    {
                        listPingResults.Items.Add(new PingLine(string.Format("{0}", OptionsHelper.TranslationList["pinging"]), LabelTone.Secondary));
                        listPingResults.Items.Add(new PingLine(string.Empty));
                    });

                    for (int i = 0; i < count && !cts.IsCancellationRequested; i++)
                    {
                        if (cts.Token.WaitHandle.WaitOne(1000)) break;
                        PingReply reply = PingerHelper.PingHost(host);
                        sent++;
                        PingLine line;
                        if (reply == null || reply.Address == null || reply.Status != IPStatus.Success)
                        {
                            line = new PingLine(reply == null ? OptionsHelper.TranslationList["timeout"].ToString() : reply.Status.ToString(), LabelTone.Danger);
                        }
                        else
                        {
                            ok.Add(reply);
                            line = new PingLine(string.Format("{0} - {1}: {2} ms - TTL: {3}", reply.Status, OptionsHelper.TranslationList["latency"], reply.RoundtripTime, reply.Options != null ? reply.Options.Ttl : 0));
                        }
                        string ip = reply?.Address?.ToString();
                        int done = sent;
                        List<PingReply> snapshot = ok.ToList();
                        UI(() =>
                        {
                            if (!string.IsNullOrEmpty(ip)) _shodanIP = ip;
                            _pingResults.Clear();
                            _pingResults.AddRange(snapshot);
                            listPingResults.Items.Add(line);
                            listPingResults.TopIndex = Math.Max(0, listPingResults.Items.Count - 1);
                            UpdatePingStats(snapshot, done);
                            _pingProgress.Text = done + " / " + count;
                            LayoutPingerTab();
                        });
                    }

                    UI(() =>
                    {
                        listPingResults.Items.Add(new PingLine(string.Empty));
                        if (ok.Count > 0)
                        {
                            listPingResults.Items.Add(new PingLine(string.Format("{0} = {1}, {2} = {3}, {4} = {5:F2}",
                                OptionsHelper.TranslationList["min"], ok.Min(x => x.RoundtripTime),
                                OptionsHelper.TranslationList["max"], ok.Max(x => x.RoundtripTime),
                                OptionsHelper.TranslationList["avg"], ok.Average(x => x.RoundtripTime)), LabelTone.Accent));
                        }
                        else
                        {
                            listPingResults.Items.Add(new PingLine(OptionsHelper.TranslationList["timeout"].ToString(), LabelTone.Danger));
                        }
                        listPingResults.TopIndex = Math.Max(0, listPingResults.Items.Count - 1);
                    });
                }

                UI(() =>
                {
                    _pingCts = null;
                    cts.Dispose();
                    btnPing.Text = _pingIdleText;
                    btnShodan.Enabled = true;
                    _pingCount.Enabled = true;
                    if (sent == 0) _pingProgress.Text = string.Empty;
                    LayoutPingerTab();
                });
            });
        }

        void LayoutPingerTab()
        {
            if (_pingLayingOut || _pingResultsCard == null) return;
            Size area = tabPage1.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;
            _pingLayingOut = true;
            tabPage1.SuspendLayout();
            try
            {
                int margin = Draw.SI(16), gap = Draw.SI(12), pad = Draw.SI(16), btnH = Draw.SI(36), g = Draw.SI(8);
                int innerW = area.Width - margin * 2;
                int y = pingerTitle.Bottom + Draw.SI(14);

                int cw = innerW - pad * 2, iy = pad;
                int countW = Draw.SI(80), pingW = ButtonWidth(btnPing, Draw.SI(110));
                pingW = Math.Max(pingW, TextRenderer.MeasureText(T("pingStop", "Stop"), btnPing.Font).Width + Draw.SI(36));
                int txtW = cw - countW - pingW - g * 2;
                Place(lblPinger, pad, iy, txtW, lblPinger.PreferredHeight);
                Place(_pingCountCap, pad + txtW + g, iy, countW, _pingCountCap.PreferredHeight);
                iy += Math.Max(lblPinger.PreferredHeight, _pingCountCap.PreferredHeight) + Draw.SI(6);
                Place(txtPingInput, pad, iy + (btnH - txtPingInput.Height) / 2, txtW, txtPingInput.Height);
                Place(_pingCount, pad + txtW + g, iy + (btnH - _pingCount.Height) / 2, countW, _pingCount.Height);
                Place(btnPing, pad + cw - pingW, iy, pingW, btnH);
                iy += btnH + g;
                int x = pad;
                foreach (Control b in new Control[] { copyIPB, copyB, btnShodan })
                {
                    int bw = ButtonWidth(b, Draw.SI(96));
                    Place(b, x, iy, bw, btnH);
                    x += bw + g;
                }
                iy += btnH + pad;
                Place(_pingInputCard, margin, y, innerW, iy);
                y += iy + gap;

                int tileH = Draw.SI(70), tileW = (innerW - gap * 3) / 4;
                StatTile[] tiles = { _pingMin, _pingAvg, _pingMax, _pingLoss };
                for (int i = 0; i < tiles.Length; i++)
                    Place(tiles[i], margin + i * (tileW + gap), y, i == 3 ? innerW - 3 * (tileW + gap) : tileW, tileH);
                y += tileH + gap;

                int rh = Math.Max(Draw.SI(160), area.Height - margin - y);
                Place(_pingResultsCard, margin, y, innerW, rh);
                int ew = ButtonWidth(btnExport, Draw.SI(96)), titleH = Draw.SI(32);
                Place(lblResults, pad, pad + (titleH - lblResults.PreferredHeight) / 2, lblResults.PreferredWidth, lblResults.PreferredHeight);
                Place(btnExport, innerW - pad - ew, pad, ew, titleH);
                int pw = _pingProgress.PreferredWidth;
                Place(_pingProgress, btnExport.Left - g - pw, pad + (titleH - _pingProgress.PreferredHeight) / 2, pw, _pingProgress.PreferredHeight);
                int ly = pad + titleH + g;
                Place(listPingResults, pad, ly, innerW - pad * 2, rh - ly - pad);
            }
            finally
            {
                tabPage1.ResumeLayout(false);
                _pingLayingOut = false;
            }
        }
    }
}
