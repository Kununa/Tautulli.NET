using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Tautulli.Net.DataTypes;

namespace Tautulli.Net
{
    public class Tautulli
    {
        private readonly string url;
        private readonly string apiKey;
        private readonly HttpClient httpClient = new HttpClient();

        public Tautulli(string url, string apiKey)
        {
            if (!url.EndsWith("/"))
                url += "/";
            this.url = url;
            this.apiKey = apiKey;
        }

        /*public Tautulli(string url, string username, string password)
        {
            if (!url.EndsWith("/"))
                url += "/";
            this.url = url;
            this.apiKey = get_apikey(username, password).Result;
        }*/

        public async Task<Library> get_library(long sectionId)
        {
            return await SendRequest<Library>("get_library", new[] { ("section_id", (object)sectionId) });
        }

        public async Task<LibraryTable> get_libraries_table(bool grouping = false, LibraryOrderColumn orderColumn = null, OrderDir orderDir = null, int start = 0, int length = 25, string search = null)
        {
            var parameters = new List<(string, object)> {("grouping", grouping ? 1 : 0)};
            if (orderColumn != null)
                parameters.Add(("order_column", orderColumn));
            if (orderDir != null)
                parameters.Add(("order_dir", orderDir));
            if (start >= 0)
                parameters.Add(("start", start));
            if (length >= 0)
                parameters.Add(("length", length));
            if (!string.IsNullOrEmpty(search))
                parameters.Add(("search", search));

            return await SendRequest<LibraryTable>("get_libraries_table", parameters.ToArray());
        }

        public async Task<List<LibraryEntry>> get_libraries()
        {
            return await SendRequest<List<LibraryEntry>>("get_libraries");
        }

        public async Task<List<HomeStatEntry>> get_home_stats(bool grouping = false, string timeRange = "30", StatsType statsType = null, string statsCount = "5")
        {
            if (statsType == null)
                statsType = StatsType.Plays;
            var parameters = new List<(string, object)> {("grouping", grouping ? 1 : 0)};
            if (!string.IsNullOrEmpty(timeRange))
                parameters.Add(("time_range", timeRange));
            parameters.Add(("stats_type", statsType));
            if (!string.IsNullOrEmpty(statsCount))
                parameters.Add(("stats_count", statsCount));

            return await SendRequest<List<HomeStatEntry>>("get_home_stats", parameters.ToArray());
        }

        public async Task<History> get_history(bool grouping = false, string user = null, int userId = -1, int ratingKey = -1, int parentRatingKey = -1, int grandparentRatingKey = -1, string startDate = "YYYY-MM-DD", int sectionId = -1,
        MediaType mediaType = null, TranscodeDecision transcodeDecision = null, HistoryOrderColumn orderColumn = null, OrderDir orderDir = null, int start = 0, int length = 25, string search = null)
        {
            var parameters = new List<(string, object)> {("grouping", grouping ? 1 : 0), ("start", start), ("length", length)};
            if (!string.IsNullOrEmpty(user))
                parameters.Add(("user", user));
            if (userId >= 0)
                parameters.Add(("user_id", userId));
            if (ratingKey >= 0)
                parameters.Add(("rating_key", ratingKey));
            if (parentRatingKey >= 0)
                parameters.Add(("parent_rating_key", parentRatingKey));
            if (grandparentRatingKey >= 0)
                parameters.Add(("grandparent_rating_key", grandparentRatingKey));
            if (sectionId >= 0)
                parameters.Add(("section_id", sectionId));
            if (!string.IsNullOrEmpty(startDate))
                parameters.Add(("start_date", startDate));
            if (mediaType != null)
                parameters.Add(("media_type", mediaType));
            if (transcodeDecision != null)
                parameters.Add(("transcode_decision", transcodeDecision));
            if (orderColumn != null)
                parameters.Add(("order_column", orderColumn));
            if (orderDir != null)
                parameters.Add(("order_dir", orderColumn));
            if (!string.IsNullOrEmpty(search))
                parameters.Add(("search", search));

            return await SendRequest<History>("get_history", parameters.ToArray());
        }

        public async Task<IpInformation> get_geoip_lookup(string ip)
        {
            if (string.IsNullOrEmpty(ip))
                throw new ArgumentNullException(nameof(ip));
            return await SendRequest<IpInformation>("get_geoip_lookup", new[] { ("ip_address", (object)ip) });
        }

        public async Task<DateFormats> get_date_formats()
        {
            return await SendRequest<DateFormats>("get_date_formats");
        }

        public async Task<string> get_apikey(string username = null, string password = null)
        {
            var parameters = new List<(string, object)>();
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                parameters.Add(("username", username));
                parameters.Add(("password", password));
            }
            return await SendRequest<string>("get_apikey", parameters.ToArray());
        }

        public async Task<Activity> get_activity()
        {
            return await SendRequest<Activity>("get_activity");
        }

        private async Task<T> SendRequest<T>(string cmd, (string, object)[] additionalParameters = null)
        {
            var u = url + @"api/v2";
            if (!string.IsNullOrEmpty(apiKey))
            {
                u += "?apikey=" + apiKey;
                u += "&cmd=" + cmd;
            }
            else
                u += "?cmd=" + cmd;

            if (additionalParameters != null && additionalParameters.Length > 0)
            {
                foreach (var additionalParameter in additionalParameters)
                {
                    u += "&" + additionalParameter.Item1 + "=" + additionalParameter.Item2;
                }
            }

            HttpResponseMessage response = await httpClient.GetAsync(u);
            //response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic dyn = JsonConvert.DeserializeObject(responseBody);
            if (HasProperty(dyn.response.data, "error") && dyn.response.data.error != null)
                throw new Exception((string)dyn.response.data.error);

            return dyn.response.data.ToObject<T>();
        }



        public static bool HasProperty(dynamic obj, string name)
        {
            Type objType = obj.GetType();

            if (objType == typeof(ExpandoObject))
            {
                return ((IDictionary<string, object>)obj).ContainsKey(name);
            }

            return objType.GetProperty(name) != null;
        }


    }

}
