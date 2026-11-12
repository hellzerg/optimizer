using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        TabPage fileHandlesTab;
        CardPanel _fhPickCard, _fhListCard;
        FluentLabel _fhPickCap, _fhHint, _fhListCap, _fhCount, _fhStatus;
        TextBox _fhPath;
        FluentButton _fhBrowse, _fhFind, _fhKill;
        MoonCheck _fhSelectAll;
        LockerList _fhList;
        bool _fhLayingOut, _fhBusy, _fhSyncAll;
        string _fhLastPath;

        void InitFileHandlesUi()
        {
            fileHandlesTab = new TabPage
            {
                Name = "fileHandlesTab",
                BackColor = cleanerTab.BackColor,
                ForeColor = cleanerTab.ForeColor,
                Padding = cleanerTab.Padding,
                UseVisualStyleBackColor = false,
                AutoScroll = true,
                AllowDrop = true,
                Text = T("trayUnlocker", "File Handles")
            };
            fileHandlesTab.SuspendLayout();

            _fhPickCard = NewCard(fileHandlesTab);
            _fhPickCap = NewLabel(_fhPickCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _fhHint = NewLabel(_fhPickCard, 9.5f, Typography.Weight.Regular, LabelTone.Secondary);
            _fhPath = new TextBox { Font = Typography.Get(10.5f, Typography.Weight.Regular) };
            _fhPickCard.Controls.Add(_fhPath);
            _fhBrowse = new FluentButton { Kind = ButtonKind.Standard, Font = Typography.Get(10f, Typography.Weight.Regular) };
            _fhPickCard.Controls.Add(_fhBrowse);
            _fhFind = new FluentButton { Kind = ButtonKind.Primary, Font = Typography.Get(10f, Typography.Weight.Regular) };
            _fhPickCard.Controls.Add(_fhFind);

            _fhListCard = NewCard(fileHandlesTab);
            _fhListCap = NewLabel(_fhListCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _fhCount = NewLabel(_fhListCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            _fhCount.TextAlign = ContentAlignment.MiddleRight;
            _fhSelectAll = new MoonCheck { AutoSize = true, Font = Typography.Get(10f, Typography.Weight.Regular) };
            _fhListCard.Controls.Add(_fhSelectAll);
            _fhList = new LockerList();
            _fhListCard.Controls.Add(_fhList);
            _fhStatus = NewLabel(_fhListCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            _fhStatus.AutoEllipsis = true;
            _fhStatus.TextAlign = ContentAlignment.MiddleLeft;
            _fhKill = new FluentButton { Kind = ButtonKind.Primary, Font = Typography.Get(10f, Typography.Weight.Regular), Enabled = false };
            _fhListCard.Controls.Add(_fhKill);

            _fhBrowse.Click += (s, e) => BrowseLockedFile();
            _fhFind.Click += (s, e) => FindFileLockers(_fhPath.Text);
            _fhKill.Click += (s, e) => KillFileLockers();
            _fhPath.KeyDown += (s, e) =>
            {
                if (e.KeyCode != Keys.Enter) return;
                e.Handled = e.SuppressKeyPress = true;
                FindFileLockers(_fhPath.Text);
            };
            _fhPath.TextChanged += (s, e) => UpdateFileHandlesState();
            _fhSelectAll.CheckedChanged += (s, e) => { if (!_fhSyncAll) _fhList.SetAll(_fhSelectAll.Checked); };
            _fhList.CheckedChanged += (s, e) => UpdateFileHandlesState();
            _fhList.RowActivated += (s, row) => RevealInExplorer(row.Path);

            // drop anywhere on the page, including over the cards and the text box
            foreach (Control c in new Control[] { fileHandlesTab, _fhPickCard, _fhListCard, _fhPath, _fhList })
            {
                c.AllowDrop = true;
                c.DragEnter += FileHandles_DragEnter;
                c.DragDrop += FileHandles_DragDrop;
            }

            // TabPages.Insert is broken before the handle exists, so re-append the pages that follow Cleaner
            int at = tabCollection.TabPages.IndexOf(cleanerTab);
            List<TabPage> tail = new List<TabPage>();
            if (at >= 0)
                for (int i = tabCollection.TabPages.Count - 1; i > at; i--)
                {
                    tail.Insert(0, tabCollection.TabPages[i]);
                    tabCollection.TabPages.RemoveAt(i);
                }
            tabCollection.TabPages.Add(fileHandlesTab);
            foreach (TabPage page in tail) tabCollection.TabPages.Add(page);

            fileHandlesTab.ResumeLayout(false);
            fileHandlesTab.Layout += (s, e) => LayoutFileHandlesTab();
        }

        void RefreshFileHandlesStrings()
        {
            fileHandlesTab.Text = T("trayUnlocker", "File Handles");
            _fhPickCap.Text = T("fhPickCaption", "Find what's locking a file");
            _fhHint.Text = T("fhHint", "Choose a file or drop it here to see which processes keep it open. End them to release the file.");
            SetCue(_fhPath, T("fhPathCue", "Path to a file"));
            _fhBrowse.Text = T("fhBrowse", "Browse…");
            _fhFind.Text = T("fhFind", "Find");
            _fhListCap.Text = T("fhListCaption", "Processes using the file");
            _fhSelectAll.Text = T("chkSelectAllModernApps", "Select all");
            _fhKill.Text = T("btnKill", "Kill");
            _fhList.SetColumns(T("fhColProcess", "Process"), T("fhColPid", "PID"), T("fhColPath", "Path"));
            UpdateFileHandlesState();
            LayoutFileHandlesTab();
        }

        void FileHandles_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetDataPresent(DataFormats.FileDrop) ? e.Data.GetData(DataFormats.FileDrop) as string[] : null;
            e.Effect = files != null && files.Length > 0 && File.Exists(files[0]) ? DragDropEffects.Link : DragDropEffects.None;
        }

        void FileHandles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files == null || files.Length == 0) return;
            _fhPath.Text = files[0];
            FindFileLockers(files[0]);
        }

        void BrowseLockedFile()
        {
            using (OpenFileDialog dlg = new OpenFileDialog { CheckFileExists = true, Multiselect = false })
            {
                try
                {
                    string dir = Path.GetDirectoryName(_fhPath.Text.Trim().Trim('"'));
                    if (!string.IsNullOrEmpty(dir) && Directory.Exists(dir)) dlg.InitialDirectory = dir;
                }
                catch (ArgumentException) { }
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                _fhPath.Text = dlg.FileName;
                FindFileLockers(dlg.FileName);
            }
        }

        void FindFileLockers(string path)
        {
            if (_fhBusy) return;
            path = (path ?? string.Empty).Trim().Trim('"');
            if (path.Length == 0) return;

            if (!File.Exists(path))
            {
                _fhLastPath = null;
                _fhList.SetRows(null);
                SetFileHandlesStatus(T("fhNotFound", "The file doesn't exist."), LabelTone.Danger);
                return;
            }

            _fhBusy = true;
            _fhLastPath = path;
            SetFileHandlesStatus(string.Empty, LabelTone.Secondary);
            UpdateFileHandlesState();

            Task.Factory.StartNew(() => ReadFileLockers(path)).ContinueWith(t =>
            {
                List<LockerRow> rows = t.IsFaulted ? null : t.Result;
                UI(() =>
                {
                    _fhBusy = false;
                    if (rows == null)
                    {
                        _fhList.SetRows(null);
                        SetFileHandlesStatus(T("fhError", "The file couldn't be inspected."), LabelTone.Danger);
                    }
                    else
                    {
                        _fhList.SetRows(rows);
                    }
                    UpdateFileHandlesState();
                });
            });
        }

        static List<LockerRow> ReadFileLockers(string path)
        {
            List<Process> lockers = FileHandleHelper.GetProcessesLockingFile(path);
            if (lockers == null) return null;

            List<LockerRow> rows = new List<LockerRow>(lockers.Count);
            foreach (Process pr in lockers)
            {
                using (pr)
                {
                    LockerRow row = new LockerRow { Pid = pr.Id };
                    try { row.Name = pr.ProcessName; } catch (InvalidOperationException) { continue; }
                    row.Path = ProcessImagePath(pr.Id);
                    if (!string.IsNullOrEmpty(row.Path))
                    {
                        try
                        {
                            using (Icon icon = Icon.ExtractAssociatedIcon(row.Path)) row.Icon = icon == null ? null : icon.ToBitmap();
                        }
                        catch (Exception ex) when (ex is ArgumentException || ex is IOException || ex is UnauthorizedAccessException) { }
                    }
                    rows.Add(row);
                }
            }
            rows.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));
            return rows;
        }

        void KillFileLockers()
        {
            List<LockerRow> targets = new List<LockerRow>();
            foreach (LockerRow r in _fhList.Rows) if (r.Checked) targets.Add(r);
            if (targets.Count == 0) return;

            int failed = 0;
            foreach (LockerRow r in targets)
            {
                try
                {
                    using (Process pr = Process.GetProcessById(r.Pid))
                    {
                        // the PID could have been reused since the scan
                        if (!string.Equals(pr.ProcessName, r.Name, StringComparison.OrdinalIgnoreCase)) continue;
                        pr.Kill();
                        pr.WaitForExit(3000);
                    }
                }
                catch (ArgumentException) { }
                catch (Exception ex) when (ex is Win32Exception || ex is InvalidOperationException || ex is NotSupportedException) { failed++; }
            }

            string again = _fhLastPath;
            if (!string.IsNullOrEmpty(again)) FindFileLockers(again);
            if (failed > 0) SetFileHandlesStatus(string.Format(T("fhKillFailed", "{0} process(es) couldn't be ended."), failed), LabelTone.Danger);
        }

        static void RevealInExplorer(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path)) return;
            try { Process.Start("explorer.exe", "/select,\"" + path + "\""); }
            catch (Win32Exception) { }
        }

        void SetFileHandlesStatus(string text, LabelTone tone)
        {
            _fhStatus.Tone = tone;
            _fhStatus.Text = text;
            // a fixed-size Label snaps back to its requested size on Text changes
            if (_fhListCard != null && !_fhLayingOut) LayoutFileHandlesList(_fhListCard.Width, _fhListCard.Height);
        }

        void UpdateFileHandlesState()
        {
            if (_fhList == null) return;
            int total = _fhList.Rows.Count, picked = _fhList.CheckedCount;

            _fhFind.Enabled = !_fhBusy && _fhPath.Text.Trim().Length > 0;
            _fhKill.Enabled = !_fhBusy && picked > 0;
            _fhSelectAll.Enabled = !_fhBusy && total > 0;

            _fhSyncAll = true;
            _fhSelectAll.Checked = total > 0 && picked == total;
            _fhSyncAll = false;

            if (_fhBusy) _fhCount.Text = T("fhSearching", "Searching…");
            else if (_fhLastPath == null) _fhCount.Text = string.Empty;
            else _fhCount.Text = string.Format(T("fhCount", "{0} found · {1} selected"), total, picked);

            _fhList.EmptyText = _fhBusy ? string.Empty
                : _fhLastPath == null ? T("fhIdle", "Choose a file above to list the processes that are using it.")
                : T("fhNone", "No process is using this file. It's free to move, rename or delete.");

            if (_fhListCard != null && !_fhLayingOut) LayoutFileHandlesList(_fhListCard.Width, _fhListCard.Height);
        }

        void LayoutFileHandlesTab()
        {
            if (_fhLayingOut || _fhListCard == null) return;
            Size area = fileHandlesTab.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;
            _fhLayingOut = true;
            fileHandlesTab.SuspendLayout();
            try
            {
                int margin = Draw.SI(16), gap = Draw.SI(12), minList = Draw.SI(240);
                int innerW = area.Width - margin * 2;
                int y = margin;

                int pickH = LayoutFileHandlesPick(innerW);
                Place(_fhPickCard, margin, y + AutoScrollOffsetY(), innerW, pickH);
                y += pickH + gap;

                int listH = Math.Max(minList, area.Height - y - margin);
                Place(_fhListCard, margin, y + AutoScrollOffsetY(), innerW, listH);
                LayoutFileHandlesList(innerW, listH);
                fileHandlesTab.AutoScrollMinSize = new Size(0, y + minList + margin);
            }
            finally
            {
                fileHandlesTab.ResumeLayout(false);
                _fhLayingOut = false;
            }
        }

        int AutoScrollOffsetY()
        {
            return fileHandlesTab.AutoScrollPosition.Y;
        }

        int LayoutFileHandlesPick(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad, btnH = Draw.SI(32);
            Place(_fhPickCap, pad, y, inner, Draw.SI(24));
            y += Draw.SI(26);
            int hintH = WrapHeight(_fhHint, _fhHint.Text, inner);
            Place(_fhHint, pad, y, inner, hintH);
            y += hintH + Draw.SI(12);

            int findW = ButtonWidth(_fhFind, Draw.SI(96)), browseW = ButtonWidth(_fhBrowse, Draw.SI(96));
            int boxW = inner - findW - browseW - Draw.SI(16);
            if (boxW >= Draw.SI(200))
            {
                Place(_fhPath, pad, y + (btnH - _fhPath.Height) / 2, boxW, _fhPath.Height);
                Place(_fhBrowse, pad + boxW + Draw.SI(8), y, browseW, btnH);
                Place(_fhFind, pad + inner - findW, y, findW, btnH);
                y += btnH;
            }
            else
            {
                Place(_fhPath, pad, y, inner, _fhPath.Height);
                y += _fhPath.Height + Draw.SI(10);
                Place(_fhFind, pad + inner - findW, y, findW, btnH);
                Place(_fhBrowse, pad + inner - findW - Draw.SI(8) - browseW, y, browseW, btnH);
                y += btnH;
            }
            return y + pad;
        }

        void LayoutFileHandlesList(int w, int h)
        {
            if (w <= 0 || h <= 0) return;
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad, btnH = Draw.SI(32);

            int cw = Math.Min(TextWidth(_fhCount) + Draw.SI(4), inner / 2);
            Place(_fhListCap, pad, y, inner - cw - Draw.SI(8), Draw.SI(24));
            Place(_fhCount, pad + inner - cw, y, cw, Draw.SI(24));
            y += Draw.SI(30);

            Size sa = _fhSelectAll.GetPreferredSize(Size.Empty);
            Place(_fhSelectAll, pad, y, sa.Width, sa.Height);
            y += sa.Height + Draw.SI(6);

            int bottom = h - pad - btnH;
            Place(_fhList, pad - Draw.SI(4), y, inner + Draw.SI(8), Math.Max(0, bottom - Draw.SI(12) - y));

            int killW = ButtonWidth(_fhKill, Draw.SI(96));
            Place(_fhKill, pad + inner - killW, bottom, killW, btnH);
            Place(_fhStatus, pad, bottom, Math.Max(0, inner - killW - Draw.SI(12)), btnH);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(uint access, bool inherit, int pid);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern bool QueryFullProcessImageName(IntPtr process, int flags, StringBuilder name, ref int size);

        [DllImport("kernel32.dll")]
        static extern bool CloseHandle(IntPtr handle);

        // works across bitness and for most elevated processes, unlike Process.MainModule
        static string ProcessImagePath(int pid)
        {
            const uint PROCESS_QUERY_LIMITED_INFORMATION = 0x1000;
            IntPtr h = OpenProcess(PROCESS_QUERY_LIMITED_INFORMATION, false, pid);
            if (h == IntPtr.Zero) return null;
            try
            {
                StringBuilder sb = new StringBuilder(1024);
                int size = sb.Capacity;
                return QueryFullProcessImageName(h, 0, sb, ref size) ? sb.ToString(0, size) : null;
            }
            finally
            {
                CloseHandle(h);
            }
        }
    }
}
