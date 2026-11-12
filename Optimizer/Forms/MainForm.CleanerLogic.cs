using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        static readonly Color[] CleanTints =
        {
            Color.FromArgb(0, 120, 212), Color.FromArgb(232, 17, 35), Color.FromArgb(255, 140, 0),
            Color.FromArgb(0, 153, 188), Color.FromArgb(16, 124, 16), Color.FromArgb(251, 84, 43),
            Color.FromArgb(136, 23, 152), Color.FromArgb(0, 99, 177), Color.FromArgb(122, 117, 116)
        };

        System.Windows.Forms.Timer _cleanCheckTimer;
        int[] _cleanItemCat = new int[0];
        long[] _cleanItemSize = new long[0];
        string[] _cleanCatNames = new string[0];
        bool _cleanBusy, _cleanBulk;

        string[] CleanCategoryNames()
        {
            return new[] { checkTemp.Text, checkMiniDumps.Text, checkErrorReports.Text, label4.Text, label5.Text, label7.Text, label9.Text, label6.Text, T("cleanerOther", "Other") };
        }

        static int ClassifyCleanPath(string path)
        {
            string p = path.Replace('/', '\\');
            if (p.IndexOf("\\Google\\Chrome\\", StringComparison.OrdinalIgnoreCase) >= 0) return 3;
            if (p.IndexOf("\\Mozilla\\Firefox\\", StringComparison.OrdinalIgnoreCase) >= 0) return 4;
            if (p.IndexOf("\\Microsoft\\Edge\\", StringComparison.OrdinalIgnoreCase) >= 0) return 5;
            if (p.IndexOf("\\BraveSoftware\\", StringComparison.OrdinalIgnoreCase) >= 0) return 6;
            if (p.IndexOf("\\INetCache\\", StringComparison.OrdinalIgnoreCase) >= 0 || p.IndexOf("\\WebCache", StringComparison.OrdinalIgnoreCase) >= 0) return 7;
            if (p.IndexOf("\\WER\\", StringComparison.OrdinalIgnoreCase) >= 0) return 2;
            if (p.IndexOf("\\Minidump", StringComparison.OrdinalIgnoreCase) >= 0) return 1;
            if (p.StartsWith(CleanHelper.TempFolder, StringComparison.OrdinalIgnoreCase)) return 0;
            return 8;
        }

        void SetCleanBusy(bool busy, string status)
        {
            _cleanBusy = busy;
            _cleanBusyBar.Running = busy;
            foreach (Control c in new Control[] { _cleanCatHost, analyzeDriveB, cleanDriveB, btnWinClean, checkSelectAll, listCleanPreview, _cleanBreakdown })
                c.Enabled = !busy;
            if (status != null)
            {
                _cleanStatus.Tone = LabelTone.Secondary;
                _cleanStatus.Text = status;
            }
        }

        void ResetCleanPreview()
        {
            CleanHelper.PreviewSizeToBeFreed = new ByteSize(0);
            CleanHelper.PreviewCleanList.Clear();
            listCleanPreview.Items.Clear();
            _cleanItemCat = new int[0];
            _cleanItemSize = new long[0];
            _cleanBreakdown.SetRows(null);
        }

        void AnalyzeCleanerAsync(Action then = null)
        {
            if (_cleanBusy) return;
            ResetCleanPreview();
            SetCleanBusy(true, T("cleanerAnalyzing", "Analyzing selected locations…"));
            UpdateCleanSelection();
            LayoutCleanerTab();

            bool temp = checkTemp.Checked, dumps = checkMiniDumps.Checked, wer = checkErrorReports.Checked, ie = IECache.Checked;
            bool[] chrome = { chromeCache.Checked, chromeCookies.Checked, chromeHistory.Checked, chromeSession.Checked, chromePws.Checked };
            bool[] fox = { firefoxCache.Checked, firefoxCookies.Checked, firefoxHistory.Checked };
            bool[] edge = { edgeCache.Checked, edgeCookies.Checked, edgeHistory.Checked, edgeSession.Checked };
            bool[] brave = { braveCache.Checked, braveCookies.Checked, braveHistory.Checked, braveSession.Checked, bravePasswords.Checked };
            _cleanCatNames = CleanCategoryNames();

            Task.Run(() =>
            {
                try
                {
                    if (temp) CleanHelper.PreviewTemp();
                    if (dumps) CleanHelper.PreviewMinidumps();
                    if (wer) CleanHelper.PreviewErrorReports();
                    CleanHelper.PreviewChromeClean(chrome[0], chrome[1], chrome[2], chrome[3], chrome[4]);
                    CleanHelper.PreviewFireFoxClean(fox[0], fox[1], fox[2]);
                    CleanHelper.PreviewEdgeClean(edge[0], edge[1], edge[2], edge[3]);
                    CleanHelper.PreviewBraveClean(brave[0], brave[1], brave[2], brave[3], brave[4]);
                    if (ie) CleanHelper.PreviewInternetExplorerCache();
                }
                catch (Exception ex)
                {
                    Logger.LogError("MainForm.AnalyzeCleaner", ex.Message, ex.StackTrace);
                }

                string[] items = CleanHelper.PreviewCleanList.Distinct(StringComparer.OrdinalIgnoreCase).OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ToArray();
                int[] cats = new int[items.Length];
                long[] sizes = new long[items.Length];
                for (int i = 0; i < items.Length; i++)
                {
                    cats[i] = ClassifyCleanPath(items[i]);
                    try { if (File.Exists(items[i])) sizes[i] = new FileInfo(items[i]).Length; } catch { }
                }

                UI(() =>
                {
                    _cleanItemCat = cats;
                    _cleanItemSize = sizes;
                    _cleanBulk = true;
                    listCleanPreview.BeginUpdate();
                    listCleanPreview.Items.AddRange(items);
                    for (int i = 0; i < items.Length; i++) listCleanPreview.SetItemChecked(i, true);
                    listCleanPreview.EndUpdate();
                    _cleanBulk = false;

                    _cleanBreakdown.SetRows(Enumerable.Range(0, _cleanCatNames.Length)
                        .Where(c => cats.Contains(c))
                        .Select(c => new BreakdownRow
                        {
                            Name = _cleanCatNames[c],
                            Items = cats.Count(x => x == c),
                            Bytes = Enumerable.Range(0, items.Length).Where(i => cats[i] == c).Sum(i => sizes[i]),
                            State = CheckState.Checked,
                            Tint = CleanTints[c]
                        }));

                    SetCleanBusy(false, items.Length == 0
                        ? T("cleanerNothing", "Nothing to clean in the selected locations.")
                        : string.Format(T("cleanerFound", "{0} items found in {1} categories"), items.Length, _cleanBreakdown.Rows.Count));
                    UpdateCleanSelection();
                    LayoutCleanerTab();
                    then?.Invoke();
                });
            });
        }

        void CleanSelectedAsync()
        {
            if (_cleanBusy) return;
            if (listCleanPreview.Items.Count == 0 && !checkBin.Checked)
            {
                AnalyzeCleanerAsync(() => { if (listCleanPreview.Items.Count > 0) CleanSelectedAsync(); });
                return;
            }

            List<int> idx = listCleanPreview.CheckedIndices.Cast<int>().ToList();
            if (idx.Count > 0)
            {
                long total = idx.Sum(i => i < _cleanItemSize.Length ? _cleanItemSize[i] : 0);
                string msg = string.Format(T("cleanerConfirm", "Permanently delete {0} selected items ({1})?"), idx.Count, ByteSize.FromBytes(total));
                if (MessageBox.Show(this, msg, cleanDriveB.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            }

            string[] targets = idx.Select(i => listCleanPreview.Items[i].ToString())
                .OrderBy(x => Directory.Exists(x) ? 1 : 0)
                .ThenByDescending(x => x.Count(ch => ch == '\\'))
                .ToArray();
            long[] sizes = idx.Select(i => i < _cleanItemSize.Length ? _cleanItemSize[i] : 0).ToArray();
            Dictionary<string, long> sizeOf = new Dictionary<string, long>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < idx.Count; i++) sizeOf[listCleanPreview.Items[idx[i]].ToString()] = sizes[i];
            bool bin = checkBin.Checked;

            SetCleanBusy(true, T("cleanerCleaning", "Cleaning…"));
            Thread worker = new Thread(() =>
            {
                long freed = 0;
                try
                {
                    if (bin) CleanHelper.EmptyRecycleBin();
                    CleanHelper.PreviewCleanList.Clear();
                    CleanHelper.PreviewCleanList.AddRange(targets);
                    CleanHelper.Clean();
                    foreach (string t in targets)
                        if (!File.Exists(t) && !Directory.Exists(t)) freed += sizeOf[t];
                }
                catch (Exception ex)
                {
                    Logger.LogError("MainForm.CleanSelected", ex.Message, ex.StackTrace);
                }

                UI(() =>
                {
                    ResetCleanPreview();
                    SetCleanBusy(false, null);
                    _cleanStatus.Tone = LabelTone.Success;
                    _cleanStatus.Text = string.Format(T("cleanerFreed", "Done. Freed {0}"), ByteSize.FromBytes(freed));
                    UpdateCleanSelection();
                    LayoutCleanerTab();
                });
            });
            worker.IsBackground = true;
            worker.SetApartmentState(ApartmentState.STA);
            worker.Start();
        }

        void listCleanPreview_ItemCheckModern(object sender, ItemCheckEventArgs e)
        {
            if (_cleanBulk) return;
            _cleanCheckTimer.Stop();
            _cleanCheckTimer.Start();
        }

        void UpdateCleanSelection()
        {
            if (_cleanSelected == null) return;
            int total = listCleanPreview.Items.Count;
            long bytes = 0;
            int sel = 0;
            int[] on = new int[CleanTints.Length], all = new int[CleanTints.Length];
            for (int i = 0; i < _cleanItemCat.Length && i < total; i++) all[_cleanItemCat[i]]++;
            foreach (int i in listCleanPreview.CheckedIndices)
            {
                sel++;
                if (i < _cleanItemSize.Length) bytes += _cleanItemSize[i];
                if (i < _cleanItemCat.Length) on[_cleanItemCat[i]]++;
            }

            lblFootprint.Text = bytes > 0 ? ByteSize.FromBytes(bytes).ToString() : "-";
            _cleanSelected.Text = total == 0 ? string.Empty
                : string.Format(T("cleanerSelected", "{0} of {1} selected · {2}"), sel, total, ByteSize.FromBytes(bytes));

            foreach (BreakdownRow row in _cleanBreakdown.Rows)
            {
                int c = Array.IndexOf(_cleanCatNames, row.Name);
                if (c < 0) continue;
                row.State = on[c] == 0 ? CheckState.Unchecked : on[c] == all[c] ? CheckState.Checked : CheckState.Indeterminate;
            }
            _cleanBreakdown.Invalidate();
        }

        void CleanBreakdown_RowToggled(object sender, int row)
        {
            if (row < 0 || row >= _cleanBreakdown.Rows.Count) return;
            int c = Array.IndexOf(_cleanCatNames, _cleanBreakdown.Rows[row].Name);
            if (c < 0) return;
            bool on = _cleanBreakdown.Rows[row].State == CheckState.Checked;
            _cleanBulk = true;
            listCleanPreview.BeginUpdate();
            for (int i = 0; i < _cleanItemCat.Length && i < listCleanPreview.Items.Count; i++)
                if (_cleanItemCat[i] == c) listCleanPreview.SetItemChecked(i, on);
            listCleanPreview.EndUpdate();
            _cleanBulk = false;
            UpdateCleanSelection();
        }
    }
}
