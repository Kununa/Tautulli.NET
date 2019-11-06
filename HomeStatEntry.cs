using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Tautulli.Net.DataTypes;

namespace Tautulli.Net
{
    public class HomeStatEntry
    {
        [JsonProperty("stat_id")]
        public string StatId { get; set; }

        [JsonProperty("rows")]
        public List<Row> Rows { get; set; }

        [JsonProperty("stat_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StatType { get; set; }

        [JsonProperty("stat_title")]
        public string StatTitle { get; set; }
    }

    public class Row
    {
        [JsonProperty("content_rating", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentRating { get; set; }

        [JsonProperty("art", NullValueHandling = NullValueHandling.Ignore)]
        public string Art { get; set; }

        [JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
        public string Thumb { get; set; }

        [JsonProperty("users_watched", NullValueHandling = NullValueHandling.Ignore)]
        public long? UsersWatched { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("row_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? RowId { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Labels { get; set; }

        [JsonProperty("total_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDuration { get; set; }

        [JsonProperty("friendly_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FriendlyName { get; set; }

        [JsonProperty("section_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? SectionId { get; set; }

        [JsonProperty("last_play", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastPlay { get; set; }

        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public Platform Platform { get; set; }

        [JsonProperty("total_plays", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalPlays { get; set; }

        [JsonProperty("media_type", NullValueHandling = NullValueHandling.Ignore)]
        public MediaType MediaType { get; set; }

        [JsonProperty("grandparent_thumb", NullValueHandling = NullValueHandling.Ignore)]
        public string GrandparentThumb { get; set; }

        [JsonProperty("rating_key", NullValueHandling = NullValueHandling.Ignore)]
        public long? RatingKey { get; set; }

        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? UserId { get; set; }

        [JsonProperty("user_thumb", NullValueHandling = NullValueHandling.Ignore)]
        public Uri UserThumb { get; set; }

        [JsonProperty("last_watch", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastWatch { get; set; }

        [JsonProperty("player", NullValueHandling = NullValueHandling.Ignore)]
        public string Player { get; set; }

        [JsonProperty("platform_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformName { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        [JsonProperty("started", NullValueHandling = NullValueHandling.Ignore)]
        public long? Started { get; set; }

        [JsonProperty("stopped", NullValueHandling = NullValueHandling.Ignore)]
        public long? Stopped { get; set; }
    }
}
