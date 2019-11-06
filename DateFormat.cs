using Newtonsoft.Json;

namespace Tautulli.Net
{
    public class DateFormats
    {
        [JsonProperty("time_format")]
        public string TimeFormat { get; set; }

        [JsonProperty("date_format")]
        public string DateFormat { get; set; }
    }
}
