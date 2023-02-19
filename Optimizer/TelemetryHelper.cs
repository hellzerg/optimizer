using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Optimizer
{
    internal static class TelemetryHelper
    {
        const string GEO_LOOKUP_URL = "http://ip-api.com/json/";
        static TelemetryData telemetryEntry = new TelemetryData();

        internal static HttpClient TelemetryClient;

        internal const string TELEMETRY_API_URL = "https://optimizer-telemetry-handler.azurewebsites.net/telemetry.php";
        internal const string TELEMETRY_KEY = @"{OPTIMIZER-0EFC7B8A-D1FC-467F-B4B1-0117C643FE19-TELEMETRY}";

        internal static async void EnableTelemetryService()
        {
            TelemetryClient = new HttpClient();
            TelemetryClient.BaseAddress = new Uri(TELEMETRY_API_URL);
            TelemetryClient.DefaultRequestHeaders.Add("Optimizertelemetrykey", TELEMETRY_KEY);
            TelemetryClient.DefaultRequestHeaders
              .Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            await CacheTelemetryData();
        }

        internal static async Task<string> GetSessionCountry()
        {
            try
            {
                string result = await TelemetryClient.GetStringAsync(GEO_LOOKUP_URL);
                GeoLookupResult x = JsonConvert.DeserializeObject<GeoLookupResult>(result);
                if (x.status == "success")
                {
                    return x.country;
                }
                else
                {
                    return "Unknown";
                }
            }
            catch
            {
                return "Unknown";
            }
        }

        internal static async Task CacheTelemetryData()
        {
            telemetryEntry.Country = await GetSessionCountry();
            telemetryEntry.WindowsVersion = Utilities.GetWindowsDetails();
            telemetryEntry.DotNetVersion = Utilities.GetNETFramework();
            telemetryEntry.OptimizerVersion = Program.GetCurrentVersionTostring();
            telemetryEntry.UnsafeMode = Program.UNSAFE_MODE.ToString();
            telemetryEntry.ExperimentalBuild = Program.EXPERIMENTAL_BUILD.ToString();
            telemetryEntry.TelemetryID = Options.CurrentOptions.TelemetryClientID;
        }

        internal static void GenerateTelemetryData(string functionName, string errorMessage, string errorStackTrace)
        {
            telemetryEntry.Timestamp = string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", DateTime.UtcNow);
            telemetryEntry.LanguageCode = Enum.GetName(typeof(LanguageCode), Options.CurrentOptions.LanguageCode);
            telemetryEntry.SavedOptions = JsonConvert.SerializeObject(Options.CurrentOptions, Formatting.Indented);
            telemetryEntry.FunctionName = functionName;
            telemetryEntry.ErrorMessage = errorMessage;
            telemetryEntry.StackTrace = errorStackTrace;

            SendTelemetryData(telemetryEntry);
        }

        internal static void SendTelemetryData(TelemetryData entry)
        {
            try
            {
                StringContent bodyContent = new StringContent(JsonConvert.SerializeObject(telemetryEntry, Formatting.Indented), Encoding.UTF8, "application/json");
                TelemetryClient.PostAsync(TelemetryClient.BaseAddress, bodyContent);
            }
            catch { }
        }
    }
}
