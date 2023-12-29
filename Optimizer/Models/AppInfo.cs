namespace Optimizer {
    /// <summary>
    /// Represents an app from feed, containing:
    /// - Title
    /// - Download link for both 32 and 64 bit variant
    /// - Image
    /// - Group
    /// </summary>
    public sealed class AppInfo {
        public string Title { get; set; }
        public string Link64 { get; set; }
        public string Link { get; set; }
        public string Tag { get; set; }
        public string Image { get; set; }
        public string Group { get; set; }
    }
}
