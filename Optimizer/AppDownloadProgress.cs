namespace Optimizer {
    internal static class AppDownloadProgress {
        internal static int? Percentage(long received, long total)
        {
            if (total <= 0) return null;
            if (received <= 0) return 0;
            if (received >= total) return 100;
            return (int)(100m * received / total);
        }
    }
}
