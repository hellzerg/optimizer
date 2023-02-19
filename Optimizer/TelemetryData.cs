using System;

namespace Optimizer
{
    [Serializable]
    public sealed class TelemetryData
    {
        // General data
        public string Timestamp { get; set; }
        public string Country { get; set; }

        // Windows environment info
        public string WindowsVersion { get; set; }
        public string DotNetVersion { get; set; }

        // Optimizer-specific details
        public string OptimizerVersion { get; set; }
        public string LanguageCode { get; set; }
        public string TelemetryID { get; set; }
        public string UnsafeMode { get; set; }
        public string ExperimentalBuild { get; set; }
        public string SavedOptions { get; set; }

        // Exception details
        public string FunctionName { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
    }

    [Serializable]
    public sealed class GeoLookupResult
    {
        public string status { get; set; }
        public string country { get; set; }
    }
}
