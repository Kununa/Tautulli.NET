using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tautulli.Net
{
    public class LibraryTable
    {
        [JsonProperty("recordsFiltered")]
        public long RecordsFiltered { get; set; }

        [JsonProperty("recordsTotal")]
        public long RecordsTotal { get; set; }

        [JsonProperty("draw")]
        public long Draw { get; set; }

        [JsonProperty("data")]
        public List<LibraryTableEntry> Libraries { get; set; }
    }

    public class LibraryTableEntry
    {
        [JsonProperty("labels")]
        public List<object> Labels { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("rating_key")]
        public long RatingKey { get; set; }

        [JsonProperty("plays")]
        public long Plays { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("parent_count")]
        public long? ParentCount { get; set; }

        [JsonProperty("section_type")]
        public string SectionType { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("child_count")]
        public long? ChildCount { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("do_notify")]
        public string DoNotify { get; set; }

        [JsonProperty("parent_title")]
        public string ParentTitle { get; set; }

        [JsonProperty("library_art")]
        public string LibraryArt { get; set; }

        [JsonProperty("last_played")]
        public string LastPlayed { get; set; }

        [JsonProperty("last_accessed")]
        public long LastAccessed { get; set; }

        [JsonProperty("section_id")]
        public long SectionId { get; set; }

        [JsonProperty("section_name")]
        public string SectionName { get; set; }

        [JsonProperty("library_thumb")]
        public string LibraryThumb { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("media_index")]
        public long? MediaIndex { get; set; }

        [JsonProperty("content_rating")]
        public string ContentRating { get; set; }

        [JsonProperty("do_notify_created")]
        public string DoNotifyCreated { get; set; }

        [JsonProperty("keep_history")]
        public string KeepHistory { get; set; }

        [JsonProperty("parent_media_index")]
        public long? ParentMediaIndex { get; set; }
    }
}
