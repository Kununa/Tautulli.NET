using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tautulli.Net
{
    public class History
    {
        [JsonProperty("draw")]
        public long Draw { get; set; }

        [JsonProperty("recordsTotal")]
        public long RecordsTotal { get; set; }

        [JsonProperty("recordsFiltered")]
        public long RecordsFiltered { get; set; }

        [JsonProperty("total_duration")]
        public string TotalDuration { get; set; }

        [JsonProperty("filter_duration")]
        public string FilterDuration { get; set; }

        [JsonProperty("data")]
        public List<HistoryMediaEntry> Media { get; set; }
    }

    public class HistoryMediaEntry
    {
        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("friendly_name")]
        public string FriendlyName { get; set; }

        [JsonProperty("full_title")]
        public string FullTitle { get; set; }

        [JsonProperty("grandparent_rating_key")]
        public long GrandparentRatingKey { get; set; }

        [JsonProperty("grandparent_title")]
        public string GrandparentTitle { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("group_count")]
        public long GroupCount { get; set; }

        [JsonProperty("group_ids")]
        public long GroupIds { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("media_index")]
        public long MediaIndex { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("parent_media_index")]
        public long ParentMediaIndex { get; set; }

        [JsonProperty("parent_rating_key")]
        public long ParentRatingKey { get; set; }

        [JsonProperty("parent_title")]
        public string ParentTitle { get; set; }

        [JsonProperty("paused_counter")]
        public long PausedCounter { get; set; }

        [JsonProperty("percent_complete")]
        public long PercentComplete { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("player")]
        public string Player { get; set; }

        [JsonProperty("rating_key")]
        public long RatingKey { get; set; }

        [JsonProperty("reference_id")]
        public long ReferenceId { get; set; }

        [JsonProperty("session_key")]
        public object SessionKey { get; set; }

        [JsonProperty("started")]
        public long Started { get; set; }

        [JsonProperty("state")]
        public object State { get; set; }

        [JsonProperty("stopped")]
        public long Stopped { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("transcode_decision")]
        public string TranscodeDecision { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("watched_status")]
        public long WatchedStatus { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }
    }
}
