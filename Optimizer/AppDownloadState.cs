using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Optimizer {
    internal sealed class AppDownloadState {
        internal sealed class Batch {
            internal IReadOnlyList<AppInfo> Apps { get; private set; }
            internal string Folder { get; private set; }
            internal bool Prefer64 { get; private set; }
            internal bool AutoInstall { get; private set; }

            internal Batch(AppInfo[] apps, string folder, bool prefer64, bool autoInstall)
            {
                Apps = Array.AsReadOnly(apps);
                Folder = Path.GetFullPath(folder);
                Prefer64 = prefer64;
                AutoInstall = autoInstall;
            }
        }

        Batch _batch;
        internal bool IsLoadingFeed { get; private set; }
        internal bool IsDownloading { get { return _batch != null; } }
        internal bool IsBusy { get { return IsLoadingFeed || IsDownloading; } }

        internal bool TryBeginFeedLoad()
        {
            if (IsBusy) return false;
            IsLoadingFeed = true;
            return true;
        }

        internal void EndFeedLoad()
        {
            IsLoadingFeed = false;
        }

        internal Batch TryBeginDownload(IEnumerable<AppInfo> apps, string folder, bool prefer64, bool autoInstall)
        {
            if (IsBusy) return null;
            if (apps == null) throw new ArgumentNullException(nameof(apps));

            AppInfo[] selected = apps.Select(app => new AppInfo
            {
                Title = app.Title,
                Tag = app.Tag,
                Link = app.Link,
                Link64 = app.Link64
            }).ToArray();
            if (selected.Length == 0) return null;

            _batch = new Batch(selected, folder, prefer64, autoInstall);
            return _batch;
        }

        internal void EndDownload(Batch batch)
        {
            if (ReferenceEquals(_batch, batch)) _batch = null;
        }
    }
}
