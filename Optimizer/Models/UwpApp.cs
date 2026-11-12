using System.Collections.Generic;
using System.Drawing;

namespace Optimizer {
    /// <summary>
    /// An installed packaged (UWP / Store) app, grouped by package name across architectures.
    /// </summary>
    public sealed class UwpApp {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string InstallLocation { get; set; }
        public bool IsFramework { get; set; }
        public bool IsRemovable { get; set; }
        public List<string> FullNames { get; } = new List<string>();

        /// <summary>Preloaded, detached copy of the package logo (may be null).</summary>
        public Image Logo { get; set; }

        public string Title
        {
            get { return string.IsNullOrWhiteSpace(DisplayName) ? Name : DisplayName; }
        }
    }
}
