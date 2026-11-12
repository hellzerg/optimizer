using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Optimizer {
    internal enum ActivityKind { Created, Modified, Deleted, Renamed }

    internal sealed class ActivityEntry {
        internal string Path;
        internal string OldPath;
        internal ActivityKind Kind;
        internal int Count;
        internal DateTime LastSeen;
    }

    /// <summary>
    /// Watches a folder tree for file-system changes. Events are queued from the watcher threads
    /// and folded into <see cref="Entries"/> on the UI thread in batches.
    /// </summary>
    internal sealed class DiskActivityMonitor : IDisposable {
        internal const int MaxEntries = 50000;

        struct RawEvent {
            internal ActivityKind Kind;
            internal string Path, OldPath;
            internal DateTime Time;
            internal Exception Error;
        }

        readonly ConcurrentQueue<RawEvent> _queue = new ConcurrentQueue<RawEvent>();
        readonly Dictionary<string, ActivityEntry> _map = new Dictionary<string, ActivityEntry>(StringComparer.OrdinalIgnoreCase);
        readonly List<ActivityEntry> _entries = new List<ActivityEntry>();
        readonly Timer _pump = new Timer { Interval = 250 };
        FileSystemWatcher _watcher;
        volatile string[] _exclusions = new string[0];
        volatile bool _created = true, _modified = true, _deleted = true, _renamed = true;

        /// <summary>Raised on the UI thread after a batch changed <see cref="Entries"/>.</summary>
        internal event EventHandler Updated;
        /// <summary>Raised on the UI thread when events were lost because the system buffer overflowed.</summary>
        internal event EventHandler Overflowed;
        /// <summary>Raised on the UI thread when watching stopped on its own (e.g. the folder disappeared).</summary>
        internal event EventHandler Faulted;

        internal DiskActivityMonitor()
        {
            _pump.Tick += (s, e) => Drain();
        }

        internal IList<ActivityEntry> Entries { get { return _entries; } }
        internal bool Running { get { return _watcher != null; } }
        internal string WatchedPath { get; private set; }
        internal DateTime StartedAt { get; private set; }
        internal long TotalEvents { get; private set; }
        internal long Dropped { get; private set; }

        internal bool CaptureCreated { get { return _created; } set { _created = value; } }
        internal bool CaptureModified { get { return _modified; } set { _modified = value; } }
        internal bool CaptureDeleted { get { return _deleted; } set { _deleted = value; } }
        internal bool CaptureRenamed { get { return _renamed; } set { _renamed = value; } }

        /// <summary>Folder fragments to ignore (case-insensitive); null or empty disables exclusions.</summary>
        internal void SetExclusions(IEnumerable<string> filters)
        {
            List<string> list = new List<string>();
            if (filters != null)
                foreach (string f in filters)
                    if (!string.IsNullOrWhiteSpace(f)) list.Add(f.Trim());
            _exclusions = list.ToArray();
        }

        internal void Start(string path)
        {
            Stop();
            if (string.IsNullOrEmpty(path) || !Directory.Exists(path)) throw new DirectoryNotFoundException(path);

            FileSystemWatcher w = new FileSystemWatcher(path)
            {
                IncludeSubdirectories = true,
                InternalBufferSize = 64 * 1024,
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite | NotifyFilters.Size
            };
            w.Created += (s, e) => { if (_created) Enqueue(ActivityKind.Created, e.FullPath, null); };
            w.Changed += (s, e) => { if (_modified) Enqueue(ActivityKind.Modified, e.FullPath, null); };
            w.Deleted += (s, e) => { if (_deleted) Enqueue(ActivityKind.Deleted, e.FullPath, null); };
            w.Renamed += (s, e) => { if (_renamed) Enqueue(ActivityKind.Renamed, e.FullPath, e.OldFullPath); };
            w.Error += (s, e) => _queue.Enqueue(new RawEvent { Error = e.GetException() ?? new IOException() });

            WatchedPath = path;
            StartedAt = DateTime.Now;
            _watcher = w;
            w.EnableRaisingEvents = true;
            _pump.Start();
        }

        internal void Stop()
        {
            FileSystemWatcher w = _watcher;
            _watcher = null;
            if (w != null)
            {
                w.EnableRaisingEvents = false;
                w.Dispose();
            }
            _pump.Stop();
            Drain();
        }

        internal void Clear()
        {
            RawEvent ignored;
            while (_queue.TryDequeue(out ignored)) { }
            _map.Clear();
            _entries.Clear();
            TotalEvents = 0;
            Dropped = 0;
            if (Running) StartedAt = DateTime.Now;
            Updated?.Invoke(this, EventArgs.Empty);
        }

        void Enqueue(ActivityKind kind, string path, string oldPath)
        {
            if (IsExcluded(path)) return;
            _queue.Enqueue(new RawEvent { Kind = kind, Path = path, OldPath = oldPath, Time = DateTime.Now });
        }

        bool IsExcluded(string path)
        {
            string[] filters = _exclusions;
            if (filters.Length == 0 || string.IsNullOrEmpty(path)) return false;
            string dir;
            try { dir = System.IO.Path.GetDirectoryName(path) ?? path; }
            catch (ArgumentException) { dir = path; }
            catch (PathTooLongException) { dir = path; }
            foreach (string f in filters)
                if (dir.IndexOf(f, StringComparison.OrdinalIgnoreCase) >= 0) return true;
            return false;
        }

        void Drain()
        {
            bool changed = false, overflow = false, fault = false;
            RawEvent ev;
            // bound the work per tick so a burst can't freeze the UI
            for (int n = 0; n < 20000 && _queue.TryDequeue(out ev); n++)
            {
                if (ev.Error != null)
                {
                    if (ev.Error is InternalBufferOverflowException) overflow = true;
                    else fault = true;
                    continue;
                }

                TotalEvents++;
                changed = true;
                string key = ((int)ev.Kind).ToString() + "|" + ev.Path;
                ActivityEntry entry;
                if (!_map.TryGetValue(key, out entry))
                {
                    if (_entries.Count >= MaxEntries) { Dropped++; continue; }
                    entry = new ActivityEntry { Path = ev.Path, Kind = ev.Kind };
                    _map.Add(key, entry);
                    _entries.Add(entry);
                }
                entry.Count++;
                entry.LastSeen = ev.Time;
                if (ev.OldPath != null) entry.OldPath = ev.OldPath;
            }

            if (fault && Running && !Directory.Exists(WatchedPath))
            {
                Stop();
                Faulted?.Invoke(this, EventArgs.Empty);
            }
            else if (fault || overflow)
            {
                Overflowed?.Invoke(this, EventArgs.Empty);
            }
            if (changed) Updated?.Invoke(this, EventArgs.Empty);
        }

        public void Dispose()
        {
            Stop();
            _pump.Dispose();
        }
    }
}
