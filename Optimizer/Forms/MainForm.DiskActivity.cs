using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm {
        TabPage diskActivityTab;
        ToolStripMenuItem trayDiskActivity;
        DiskActivityMonitor _daMonitor;
        Timer _daClock;
        CardPanel _daWatchCard, _daExclCard, _daListCard;
        FluentLabel _daWatchCap, _daHint, _daStatus, _daExclCap, _daListCap, _daCount;
        TextBox _daPath, _daExclInput, _daFilter;
        FluentButton _daBrowse, _daDrive, _daStart, _daExclAdd, _daExclRemove, _daExclClear, _daClear, _daExport;
        MoonCheck _daCreated, _daModified, _daDeleted, _daRenamed, _daExclEnabled;
        MoonList _daExclList;
        ActivityList _daList;
        ContextMenuStrip _daRowMenu, _daDriveMenu;
        ToolStripMenuItem _daMenuReveal, _daMenuCopy, _daMenuExclude;
        string _daNotice;
        LabelTone _daNoticeTone;
        bool _daLayingOut, _daLoading;

        void InitDiskActivityUi()
        {
            diskActivityTab = new TabPage
            {
                Name = "diskActivityTab",
                BackColor = cleanerTab.BackColor,
                ForeColor = cleanerTab.ForeColor,
                Padding = cleanerTab.Padding,
                UseVisualStyleBackColor = false,
                AutoScroll = true,
                Text = T("daTitle", "Disk Activity")
            };
            diskActivityTab.SuspendLayout();

            Font btnFont = Typography.Get(10f, Typography.Weight.Regular);
            Font chkFont = Typography.Get(10f, Typography.Weight.Regular);

            _daWatchCard = NewCard(diskActivityTab);
            _daWatchCap = NewLabel(_daWatchCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _daHint = NewLabel(_daWatchCard, 9.5f, Typography.Weight.Regular, LabelTone.Secondary);
            _daPath = new TextBox { Font = Typography.Get(10.5f, Typography.Weight.Regular) };
            _daBrowse = new FluentButton { Kind = ButtonKind.Standard, Font = btnFont };
            _daDrive = new FluentButton { Kind = ButtonKind.Standard, Font = btnFont };
            _daStart = new FluentButton { Kind = ButtonKind.Primary, Font = btnFont };
            _daCreated = new MoonCheck { AutoSize = true, Font = chkFont };
            _daModified = new MoonCheck { AutoSize = true, Font = chkFont };
            _daDeleted = new MoonCheck { AutoSize = true, Font = chkFont };
            _daRenamed = new MoonCheck { AutoSize = true, Font = chkFont };
            _daWatchCard.Controls.AddRange(new Control[] { _daPath, _daBrowse, _daDrive, _daStart, _daCreated, _daModified, _daDeleted, _daRenamed });
            _daStatus = NewLabel(_daWatchCard, 9.5f, Typography.Weight.Regular, LabelTone.Secondary);
            _daStatus.AutoEllipsis = true;
            _daStatus.TextAlign = ContentAlignment.MiddleLeft;

            _daExclCard = NewCard(diskActivityTab);
            _daExclCap = NewLabel(_daExclCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _daExclEnabled = new MoonCheck { AutoSize = true, Font = chkFont };
            _daExclInput = new TextBox { Font = Typography.Get(10.5f, Typography.Weight.Regular) };
            _daExclAdd = new FluentButton { Kind = ButtonKind.Standard, Font = btnFont };
            _daExclList = new MoonList { IntegralHeight = false, Font = Typography.Get(10f, Typography.Weight.Regular) };
            _daExclRemove = new FluentButton { Kind = ButtonKind.Standard, Font = btnFont };
            _daExclClear = new FluentButton { Kind = ButtonKind.Standard, Font = btnFont };
            _daExclCard.Controls.AddRange(new Control[] { _daExclEnabled, _daExclInput, _daExclAdd, _daExclList, _daExclRemove, _daExclClear });

            _daListCard = NewCard(diskActivityTab);
            _daListCap = NewLabel(_daListCard, 11f, Typography.Weight.Semibold, LabelTone.Primary);
            _daCount = NewLabel(_daListCard, 9f, Typography.Weight.Regular, LabelTone.Secondary);
            _daCount.TextAlign = ContentAlignment.MiddleRight;
            _daFilter = new TextBox { Font = Typography.Get(10.5f, Typography.Weight.Regular) };
            _daClear = new FluentButton { Kind = ButtonKind.Standard, Font = btnFont };
            _daExport = new FluentButton { Kind = ButtonKind.Standard, Font = btnFont };
            _daList = new ActivityList();
            _daListCard.Controls.AddRange(new Control[] { _daFilter, _daClear, _daExport, _daList });

            _daMonitor = new DiskActivityMonitor();
            _daList.SetSource(_daMonitor.Entries);
            _daClock = new Timer { Interval = 1000 };
            _daClock.Tick += (s, e) => UpdateDiskActivityStatus();

            _daRowMenu = new ContextMenuStrip();
            _daMenuReveal = new ToolStripMenuItem { Tag = SidebarNav.Glyph.Search };
            _daMenuCopy = new ToolStripMenuItem { Tag = SidebarNav.Glyph.Document };
            _daMenuExclude = new ToolStripMenuItem { Tag = SidebarNav.Glyph.Eye };
            _daRowMenu.Items.AddRange(new ToolStripItem[] { _daMenuReveal, _daMenuCopy, new ToolStripSeparator(), _daMenuExclude });
            _daMenuReveal.Click += (s, e) => { if (_daList.Selected != null) RevealActivity(_daList.Selected); };
            _daMenuCopy.Click += (s, e) => { if (_daList.Selected != null) CopyActivityPath(_daList.Selected); };
            _daMenuExclude.Click += (s, e) => { if (_daList.Selected != null) ExcludeActivityFolder(_daList.Selected); };
            _daDriveMenu = new ContextMenuStrip();

            LoadDiskActivitySettings();

            _daBrowse.Click += (s, e) => BrowseWatchFolder();
            _daDrive.Click += (s, e) => ShowDriveMenu();
            _daStart.Click += (s, e) => ToggleDiskActivity();
            _daPath.TextChanged += (s, e) => { if (!_daLoading) OptionsHelper.CurrentOptions.ObserverPath = _daPath.Text.Trim(); UpdateDiskActivityState(); };
            _daPath.KeyDown += (s, e) =>
            {
                if (e.KeyCode != Keys.Enter) return;
                e.Handled = e.SuppressKeyPress = true;
                if (!_daMonitor.Running) ToggleDiskActivity();
            };
            foreach (MoonCheck c in new[] { _daCreated, _daModified, _daDeleted, _daRenamed, _daExclEnabled })
                c.CheckedChanged += (s, e) => ApplyDiskActivityFilters();

            _daExclInput.TextChanged += (s, e) => UpdateDiskActivityState();
            _daExclInput.KeyDown += (s, e) =>
            {
                if (e.KeyCode != Keys.Enter) return;
                e.Handled = e.SuppressKeyPress = true;
                AddExclusion(_daExclInput.Text);
            };
            _daExclAdd.Click += (s, e) => AddExclusion(_daExclInput.Text);
            _daExclList.SelectedIndexChanged += (s, e) => UpdateDiskActivityState();
            _daExclList.KeyDown += (s, e) => { if (e.KeyCode == Keys.Delete) RemoveExclusion(); };
            _daExclRemove.Click += (s, e) => RemoveExclusion();
            _daExclClear.Click += (s, e) =>
            {
                _daExclList.Items.Clear();
                SyncExclusions();
            };

            _daFilter.TextChanged += (s, e) => { _daList.Filter = _daFilter.Text; UpdateDiskActivityCount(); };
            _daClear.Click += (s, e) => _daMonitor.Clear();
            _daExport.Click += (s, e) => ExportDiskActivity();
            _daList.RowActivated += (s, row) => RevealActivity(row);
            _daList.RowMenuRequested += (s, row) => ShowActivityMenu();
            _daList.SelectionChanged += (s, e) => UpdateDiskActivityState();

            _daMonitor.Updated += (s, e) =>
            {
                if (IsDisposed) return;
                _daList.Rebuild();
                UpdateDiskActivityCount();
            };
            _daMonitor.Overflowed += (s, e) => SetDiskActivityNotice(T("daOverflow", "Some events were missed because of heavy activity. Add exclusions to reduce the noise."), LabelTone.Danger);
            _daMonitor.Faulted += (s, e) =>
            {
                SetDiskActivityNotice(T("daLost", "Watching stopped because the folder is no longer available."), LabelTone.Danger);
                OnDiskActivityStopped();
            };

            foreach (Control c in new Control[] { diskActivityTab, _daWatchCard, _daPath })
            {
                c.AllowDrop = true;
                c.DragEnter += DiskActivity_DragEnter;
                c.DragDrop += DiskActivity_DragDrop;
            }

            // TabPages.Insert is broken before the handle exists, so re-append the pages that follow File Handles
            int at = tabCollection.TabPages.IndexOf(fileHandlesTab);
            List<TabPage> tail = new List<TabPage>();
            if (at >= 0)
                for (int i = tabCollection.TabPages.Count - 1; i > at; i--)
                {
                    tail.Insert(0, tabCollection.TabPages[i]);
                    tabCollection.TabPages.RemoveAt(i);
                }
            tabCollection.TabPages.Add(diskActivityTab);
            foreach (TabPage page in tail) tabCollection.TabPages.Add(page);

            trayDiskActivity = new ToolStripMenuItem
            {
                Name = "trayDiskActivity",
                Font = trayUnlocker.Font,
                ForeColor = trayUnlocker.ForeColor,
                Size = trayUnlocker.Size,
                Tag = SidebarNav.Glyph.Drive,
                ShowShortcutKeys = true
            };
            trayDiskActivity.Click += (s, e) =>
            {
                tabCollection.SelectedTab = diskActivityTab;
                RestoreWindow();
            };
            launcherMenu.Items.Insert(launcherMenu.Items.IndexOf(trayUnlocker) + 1, trayDiskActivity);

            FormClosed += (s, e) =>
            {
                _daClock.Dispose();
                _daMonitor.Dispose();
            };

            diskActivityTab.ResumeLayout(false);
            diskActivityTab.Layout += (s, e) => LayoutDiskActivityTab();
        }

        void LoadDiskActivitySettings()
        {
            Options o = OptionsHelper.CurrentOptions;
            _daLoading = true;
            _daPath.Text = o.ObserverPath ?? string.Empty;
            _daCreated.Checked = o.ObserverCreated ?? true;
            _daModified.Checked = o.ObserverModified ?? true;
            _daDeleted.Checked = o.ObserverDeleted ?? true;
            _daRenamed.Checked = o.ObserverRenamed ?? true;
            _daExclEnabled.Checked = o.ObserverExclusionsEnabled ?? true;
            _daExclList.Items.Clear();
            if (o.ObserverExclusions != null)
                foreach (string x in o.ObserverExclusions)
                    if (!string.IsNullOrWhiteSpace(x)) _daExclList.Items.Add(x);
            _daLoading = false;
            ApplyDiskActivityFilters();
        }

        void RefreshDiskActivityStrings()
        {
            diskActivityTab.Text = T("daTitle", "Disk Activity");
            trayDiskActivity.Text = T("daTitle", "Disk Activity");
            _daWatchCap.Text = T("daWatchCaption", "Watch a folder");
            _daHint.Text = T("daHint", "See which files and folders are created, modified, deleted or renamed inside a folder and all of its subfolders.");
            SetCue(_daPath, T("daPathCue", "Folder to watch"));
            _daBrowse.Text = T("fhBrowse", "Browse…");
            _daDrive.Text = T("daDrive", "Whole drive");
            _daCreated.Text = T("daCreated", "Created");
            _daModified.Text = T("daModified", "Modified");
            _daDeleted.Text = T("daDeleted", "Deleted");
            _daRenamed.Text = T("daRenamed", "Renamed");
            _daExclCap.Text = T("daExclCaption", "Exclusions");
            _daExclEnabled.Text = T("daExclEnable", "Ignore folders whose path contains");
            SetCue(_daExclInput, T("daExclCue", "Folder or part of a path"));
            _daExclAdd.Text = T("daAdd", "Add");
            _daExclRemove.Text = T("daRemove", "Remove");
            _daExclClear.Text = T("daClearAll", "Clear all");
            _daExclList.EmptyText = T("daExclEmpty", "Nothing is excluded.");
            _daListCap.Text = T("daListCaption", "Activity");
            SetCue(_daFilter, T("daFilterCue", "Filter by path or type"));
            _daClear.Text = T("daClear", "Clear");
            _daExport.Text = T("daExport", "Export…");
            _daMenuReveal.Text = T("daReveal", "Show in Explorer");
            _daMenuCopy.Text = T("daCopyPath", "Copy path");
            _daMenuExclude.Text = T("daExcludeFolder", "Exclude this folder");
            _daList.SetColumns(T("daColPath", "File or folder"), T("daColType", "Type"), T("daColCount", "Count"), T("daColLast", "Last seen"));
            _daList.SetKindNames(_daCreated.Text, _daModified.Text, _daDeleted.Text, _daRenamed.Text);
            UpdateDiskActivityState();
            LayoutDiskActivityTab();
        }

        void ApplyDiskActivityFilters()
        {
            if (_daLoading || _daMonitor == null) return;
            _daMonitor.CaptureCreated = _daCreated.Checked;
            _daMonitor.CaptureModified = _daModified.Checked;
            _daMonitor.CaptureDeleted = _daDeleted.Checked;
            _daMonitor.CaptureRenamed = _daRenamed.Checked;
            SyncExclusions();

            Options o = OptionsHelper.CurrentOptions;
            o.ObserverCreated = _daCreated.Checked;
            o.ObserverModified = _daModified.Checked;
            o.ObserverDeleted = _daDeleted.Checked;
            o.ObserverRenamed = _daRenamed.Checked;
            o.ObserverExclusionsEnabled = _daExclEnabled.Checked;
        }

        void SyncExclusions()
        {
            List<string> list = new List<string>();
            foreach (object x in _daExclList.Items) list.Add((string)x);
            OptionsHelper.CurrentOptions.ObserverExclusions = list;
            _daMonitor.SetExclusions(_daExclEnabled.Checked ? list : null);
            UpdateDiskActivityState();
        }

        void AddExclusion(string text)
        {
            text = (text ?? string.Empty).Trim().Trim('"');
            if (text.Length == 0) return;
            foreach (object x in _daExclList.Items)
                if (string.Equals((string)x, text, StringComparison.OrdinalIgnoreCase)) { _daExclInput.Clear(); return; }
            _daExclList.Items.Add(text);
            _daExclInput.Clear();
            SyncExclusions();
        }

        void RemoveExclusion()
        {
            int i = _daExclList.SelectedIndex;
            if (i < 0) return;
            _daExclList.Items.RemoveAt(i);
            if (_daExclList.Items.Count > 0) _daExclList.SelectedIndex = Math.Min(i, _daExclList.Items.Count - 1);
            SyncExclusions();
        }

        void DiskActivity_DragEnter(object sender, DragEventArgs e)
        {
            string[] items = e.Data.GetDataPresent(DataFormats.FileDrop) ? e.Data.GetData(DataFormats.FileDrop) as string[] : null;
            bool ok = !_daMonitor.Running && items != null && items.Length > 0 && (Directory.Exists(items[0]) || File.Exists(items[0]));
            e.Effect = ok ? DragDropEffects.Link : DragDropEffects.None;
        }

        void DiskActivity_DragDrop(object sender, DragEventArgs e)
        {
            string[] items = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (items == null || items.Length == 0 || _daMonitor.Running) return;
            string path = items[0];
            if (File.Exists(path)) path = Path.GetDirectoryName(path);
            _daPath.Text = path;
        }

        void BrowseWatchFolder()
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog { ShowNewFolderButton = false })
            {
                string cur = _daPath.Text.Trim().Trim('"');
                if (cur.Length > 0 && Directory.Exists(cur)) dlg.SelectedPath = cur;
                if (dlg.ShowDialog(this) == DialogResult.OK) _daPath.Text = dlg.SelectedPath;
            }
        }

        void ShowDriveMenu()
        {
            foreach (ToolStripItem old in _daDriveMenu.Items) old.Dispose();
            _daDriveMenu.Items.Clear();
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                string label;
                try
                {
                    if (!d.IsReady || (d.DriveType != DriveType.Fixed && d.DriveType != DriveType.Removable)) continue;
                    label = string.IsNullOrEmpty(d.VolumeLabel) ? d.Name : d.Name + "  " + d.VolumeLabel;
                }
                catch (IOException) { continue; }
                catch (UnauthorizedAccessException) { continue; }
                string root = d.Name;
                ToolStripMenuItem item = new ToolStripMenuItem(label) { Tag = SidebarNav.Glyph.Drive };
                item.Click += (s, e) => _daPath.Text = root;
                _daDriveMenu.Items.Add(item);
            }
            if (_daDriveMenu.Items.Count == 0) return;
            ThemeManager.ApplyMenu(_daDriveMenu);
            _daDriveMenu.Show(_daDrive, new Point(0, _daDrive.Height + Draw.SI(2)));
        }

        void ShowActivityMenu()
        {
            ActivityEntry row = _daList.Selected;
            if (row == null) return;
            _daMenuExclude.Enabled = !string.IsNullOrEmpty(ParentFolder(row.Path));
            ThemeManager.ApplyMenu(_daRowMenu);
            Rectangle r = _daList.SelectedBounds();
            Point at = _daList.PointToClient(MousePosition);
            if (!_daList.ClientRectangle.Contains(at) || !r.Contains(at)) at = new Point(r.X + Draw.SI(24), r.Bottom);
            _daRowMenu.Show(_daList, at);
        }

        void ToggleDiskActivity()
        {
            if (_daMonitor.Running)
            {
                _daMonitor.Stop();
                OnDiskActivityStopped();
                return;
            }

            string path = _daPath.Text.Trim().Trim('"');
            if (path.Length == 0) return;
            if (!Directory.Exists(path))
            {
                SetDiskActivityNotice(T("daNoFolder", "The folder doesn't exist."), LabelTone.Danger);
                return;
            }
            try { path = Path.GetFullPath(path); }
            catch (Exception ex) when (ex is ArgumentException || ex is NotSupportedException || ex is PathTooLongException || ex is System.Security.SecurityException) { }

            ApplyDiskActivityFilters();
            _daMonitor.Clear();
            try
            {
                _daMonitor.Start(path);
            }
            catch (Exception ex) when (ex is IOException || ex is ArgumentException || ex is UnauthorizedAccessException || ex is PlatformNotSupportedException)
            {
                SetDiskActivityNotice(T("daStartFailed", "This folder can't be watched."), LabelTone.Danger);
                return;
            }
            OptionsHelper.CurrentOptions.ObserverPath = path;
            _daNotice = null;
            _daClock.Start();
            UpdateDiskActivityState();
        }

        void OnDiskActivityStopped()
        {
            _daClock.Stop();
            UpdateDiskActivityState();
        }

        void SetDiskActivityNotice(string text, LabelTone tone)
        {
            _daNotice = text;
            _daNoticeTone = tone;
            UpdateDiskActivityStatus();
        }

        void UpdateDiskActivityStatus()
        {
            if (_daStatus == null) return;
            string text;
            LabelTone tone;
            if (_daNotice != null)
            {
                text = _daNotice;
                tone = _daNoticeTone;
            }
            else if (_daMonitor.Running)
            {
                TimeSpan t = DateTime.Now - _daMonitor.StartedAt;
                text = string.Format(T("daWatching", "Watching {0} · {1} · {2} events"), _daMonitor.WatchedPath,
                    t.ToString(t.TotalHours >= 1 ? @"h\:mm\:ss" : @"m\:ss", CultureInfo.InvariantCulture), _daMonitor.TotalEvents.ToString("N0"));
                tone = LabelTone.Success;
            }
            else
            {
                text = T("daIdle", "Not watching.");
                tone = LabelTone.Secondary;
            }
            if (_daStatus.Text == text && _daStatus.Tone == tone) return;
            _daStatus.Tone = tone;
            _daStatus.Text = text;
            // a fixed-size Label snaps back to its requested size on Text changes
            if (!_daLayingOut) LayoutDiskActivityTab();
        }

        void UpdateDiskActivityCount()
        {
            if (_daCount == null) return;
            int items = _daMonitor.Entries.Count, shown = _daList.VisibleCount;
            string text = string.Format(T("daCount", "{0} items · {1} events"), (_daFilter.Text.Trim().Length > 0 ? shown : items).ToString("N0"), _daMonitor.TotalEvents.ToString("N0"));
            if (_daMonitor.Dropped > 0) text += " · " + T("daCapped", "list is full");
            bool resize = _daCount.Text.Length != text.Length;
            _daCount.Text = text;

            _daList.EmptyText = items > 0 ? T("daNoMatch", "Nothing matches the filter.")
                : _daMonitor.Running ? T("daWaiting", "Waiting for activity…")
                : T("daEmpty", "Start watching a folder to see its activity here.");
            _daExport.Enabled = shown > 0;
            _daClear.Enabled = items > 0;
            if (resize && !_daLayingOut && _daListCard != null) LayoutDiskActivityList(_daListCard.Width, _daListCard.Height);
        }

        void UpdateDiskActivityState()
        {
            if (_daMonitor == null || _daStart == null) return;
            bool running = _daMonitor.Running;
            _daStart.Text = running ? T("daStop", "Stop") : T("daStart", "Start");
            _daStart.Enabled = running || _daPath.Text.Trim().Length > 0;
            _daPath.ReadOnly = running;
            _daBrowse.Enabled = !running;
            _daDrive.Enabled = !running;
            _daExclAdd.Enabled = _daExclInput.Text.Trim().Length > 0;
            _daExclRemove.Enabled = _daExclList.SelectedIndex >= 0;
            _daExclClear.Enabled = _daExclList.Items.Count > 0;
            _daExclList.Enabled = true;

            if (trayDiskActivity != null)
                trayDiskActivity.ShortcutKeyDisplayString = running ? "● " + T("daTrayWatching", "Watching") : null;

            UpdateDiskActivityStatus();
            UpdateDiskActivityCount();
            if (!_daLayingOut && _daWatchCard != null) LayoutDiskActivityTab();
        }

        static string ParentFolder(string path)
        {
            try { return Path.GetDirectoryName(path); }
            catch (ArgumentException) { return null; }
            catch (PathTooLongException) { return null; }
        }

        void RevealActivity(ActivityEntry row)
        {
            string path = row.Path;
            try
            {
                if (File.Exists(path)) Process.Start("explorer.exe", "/select,\"" + path + "\"");
                else if (Directory.Exists(path)) Process.Start("explorer.exe", "\"" + path + "\"");
                else
                {
                    string dir = ParentFolder(path);
                    if (!string.IsNullOrEmpty(dir) && Directory.Exists(dir)) Process.Start("explorer.exe", "\"" + dir + "\"");
                }
            }
            catch (Win32Exception) { }
        }

        static void CopyActivityPath(ActivityEntry row)
        {
            try { Clipboard.SetText(row.Path); }
            catch (ExternalException) { }
        }

        void ExcludeActivityFolder(ActivityEntry row)
        {
            string dir = ParentFolder(row.Path);
            if (string.IsNullOrEmpty(dir)) return;
            if (!_daExclEnabled.Checked) _daExclEnabled.Checked = true;
            AddExclusion(dir);
        }

        void ExportDiskActivity()
        {
            IList<ActivityEntry> rows = _daList.View;
            if (rows.Count == 0) return;
            using (SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = T("daLogFile", "Log file") + " (*.log)|*.log|" + T("daCsvFile", "CSV file") + " (*.csv)|*.csv",
                FileName = "DiskActivity_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss", CultureInfo.InvariantCulture),
                AddExtension = true,
                OverwritePrompt = true
            })
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                StringBuilder sb = new StringBuilder();
                if (dlg.FilterIndex == 2 || dlg.FileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                {
                    sb.AppendLine("Path,Old path,Type,Count,Last seen");
                    foreach (ActivityEntry r in rows)
                        sb.Append(Csv(r.Path)).Append(',').Append(Csv(r.OldPath)).Append(',').Append(r.Kind)
                          .Append(',').Append(r.Count.ToString(CultureInfo.InvariantCulture))
                          .Append(',').AppendLine(r.LastSeen.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));
                }
                else
                {
                    DateTime now = DateTime.Now;
                    sb.AppendLine(string.Format("Observer log - {0}, {1}", now.ToLongDateString(), now.ToLongTimeString()));
                    sb.AppendLine();
                    foreach (ActivityEntry r in rows)
                    {
                        sb.AppendLine("Object: " + (r.OldPath != null ? r.OldPath + " -> " + r.Path : r.Path));
                        sb.AppendLine("Last accessed: " + r.LastSeen.ToLongTimeString());
                        sb.AppendLine("Access count: " + r.Count.ToString(CultureInfo.InvariantCulture));
                        sb.AppendLine("Access type: " + r.Kind);
                        sb.AppendLine();
                    }
                }
                try
                {
                    File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
                }
                catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
                {
                    SetDiskActivityNotice(T("daExportFailed", "The file couldn't be saved."), LabelTone.Danger);
                }
            }
        }

        static string Csv(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            return s.IndexOfAny(new[] { ',', '"', '\n', '\r' }) < 0 ? s : "\"" + s.Replace("\"", "\"\"") + "\"";
        }

        void LayoutDiskActivityTab()
        {
            if (_daLayingOut || _daListCard == null) return;
            Size area = diskActivityTab.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;
            _daLayingOut = true;
            diskActivityTab.SuspendLayout();
            try
            {
                int margin = Draw.SI(16), gap = Draw.SI(12), minList = Draw.SI(260);
                int innerW = area.Width - margin * 2;
                int y = margin, scroll = diskActivityTab.AutoScrollPosition.Y;

                if (innerW >= Draw.SI(900))
                {
                    int exclW = Math.Max(Draw.SI(300), innerW * 36 / 100);
                    int watchW = innerW - exclW - gap;
                    int h = Math.Max(LayoutWatchCard(watchW), Draw.SI(196));
                    Place(_daWatchCard, margin, y + scroll, watchW, h);
                    Place(_daExclCard, margin + watchW + gap, y + scroll, exclW, h);
                    LayoutExclusionsCard(exclW, h);
                    y += h + gap;
                }
                else
                {
                    int h = LayoutWatchCard(innerW);
                    Place(_daWatchCard, margin, y + scroll, innerW, h);
                    y += h + gap;
                    int eh = Draw.SI(196);
                    Place(_daExclCard, margin, y + scroll, innerW, eh);
                    LayoutExclusionsCard(innerW, eh);
                    y += eh + gap;
                }

                int listH = Math.Max(minList, area.Height - y - margin);
                Place(_daListCard, margin, y + scroll, innerW, listH);
                LayoutDiskActivityList(innerW, listH);
                diskActivityTab.AutoScrollMinSize = new Size(0, y + minList + margin);
            }
            finally
            {
                diskActivityTab.ResumeLayout(false);
                _daLayingOut = false;
            }
        }

        int LayoutWatchCard(int w)
        {
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad, btnH = Draw.SI(32), sp = Draw.SI(8);
            Place(_daWatchCap, pad, y, inner, Draw.SI(24));
            y += Draw.SI(26);
            int hintH = WrapHeight(_daHint, _daHint.Text, inner);
            Place(_daHint, pad, y, inner, hintH);
            y += hintH + Draw.SI(12);

            int startW = ButtonWidth(_daStart, Draw.SI(96)), browseW = ButtonWidth(_daBrowse, Draw.SI(88)), driveW = ButtonWidth(_daDrive, Draw.SI(88));
            int boxW = inner - startW - browseW - driveW - sp * 3;
            if (boxW >= Draw.SI(180))
            {
                Place(_daPath, pad, y + (btnH - _daPath.Height) / 2, boxW, _daPath.Height);
                int x = pad + boxW + sp;
                Place(_daBrowse, x, y, browseW, btnH); x += browseW + sp;
                Place(_daDrive, x, y, driveW, btnH);
                Place(_daStart, pad + inner - startW, y, startW, btnH);
                y += btnH;
            }
            else
            {
                Place(_daPath, pad, y, inner, _daPath.Height);
                y += _daPath.Height + Draw.SI(10);
                Place(_daStart, pad + inner - startW, y, startW, btnH);
                Place(_daDrive, pad + inner - startW - sp - driveW, y, driveW, btnH);
                Place(_daBrowse, pad + inner - startW - driveW - sp * 2 - browseW, y, browseW, btnH);
                y += btnH;
            }
            y += Draw.SI(12);

            int cx = pad, rowH = 0;
            foreach (MoonCheck c in new[] { _daCreated, _daModified, _daDeleted, _daRenamed })
            {
                Size s = c.GetPreferredSize(Size.Empty);
                if (cx > pad && cx + s.Width > pad + inner) { cx = pad; y += rowH + Draw.SI(6); rowH = 0; }
                Place(c, cx, y, s.Width, s.Height);
                cx += s.Width + Draw.SI(20);
                rowH = Math.Max(rowH, s.Height);
            }
            y += rowH + Draw.SI(10);

            Place(_daStatus, pad, y, inner, Draw.SI(22));
            y += Draw.SI(22);
            return y + pad;
        }

        void LayoutExclusionsCard(int w, int h)
        {
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad, btnH = Draw.SI(30), sp = Draw.SI(8);
            Place(_daExclCap, pad, y, inner, Draw.SI(24));
            y += Draw.SI(28);
            Size es = _daExclEnabled.GetPreferredSize(Size.Empty);
            Place(_daExclEnabled, pad, y, Math.Min(inner, es.Width), es.Height);
            y += es.Height + Draw.SI(8);

            int addW = ButtonWidth(_daExclAdd, Draw.SI(72));
            Place(_daExclInput, pad, y + (btnH - _daExclInput.Height) / 2, inner - addW - sp, _daExclInput.Height);
            Place(_daExclAdd, pad + inner - addW, y, addW, btnH);
            y += btnH + Draw.SI(8);

            int removeW = ButtonWidth(_daExclRemove, Draw.SI(72)), clearW = ButtonWidth(_daExclClear, Draw.SI(72));
            int bottom = h - pad - btnH;
            Place(_daExclList, pad, y, inner - removeW - sp, Math.Max(Draw.SI(30), h - pad - y));
            Place(_daExclRemove, pad + inner - removeW, y, removeW, btnH);
            Place(_daExclClear, pad + inner - removeW, Math.Max(y + btnH + Draw.SI(6), bottom), removeW, btnH);
            if (clearW > removeW) Place(_daExclClear, pad + inner - clearW, _daExclClear.Top, clearW, btnH);
        }

        void LayoutDiskActivityList(int w, int h)
        {
            if (w <= 0 || h <= 0) return;
            int pad = Draw.SI(16), inner = w - pad * 2, y = pad, btnH = Draw.SI(32), sp = Draw.SI(8);

            int cw = Math.Min(TextWidth(_daCount) + Draw.SI(4), inner / 2);
            Place(_daListCap, pad, y, inner - cw - sp, Draw.SI(24));
            Place(_daCount, pad + inner - cw, y, cw, Draw.SI(24));
            y += Draw.SI(32);

            int exportW = ButtonWidth(_daExport, Draw.SI(88)), clearW = ButtonWidth(_daClear, Draw.SI(80));
            int filterW = Math.Min(Draw.SI(360), inner - exportW - clearW - sp * 2);
            Place(_daFilter, pad, y + (btnH - _daFilter.Height) / 2, Math.Max(Draw.SI(120), filterW), _daFilter.Height);
            Place(_daExport, pad + inner - exportW, y, exportW, btnH);
            Place(_daClear, pad + inner - exportW - sp - clearW, y, clearW, btnH);
            y += btnH + Draw.SI(10);

            Place(_daList, pad - Draw.SI(4), y, inner + Draw.SI(8), Math.Max(0, h - pad - y));
        }
    }
}
