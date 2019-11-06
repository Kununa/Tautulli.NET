using Newtonsoft.Json;

namespace Tautulli.Net
{
    public class Library
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("deleted_section")]
        public long DeletedSection { get; set; }

        [JsonProperty("section_id")]
        public long SectionId { get; set; }

        [JsonProperty("section_name")]
        public string SectionName { get; set; }

        [JsonProperty("library_art")]
        public string LibraryArt { get; set; }

        [JsonProperty("parent_count")]
        public object ParentCount { get; set; }

        [JsonProperty("section_type")]
        public string SectionType { get; set; }

        [JsonProperty("do_notify_created")]
        public long DoNotifyCreated { get; set; }

        [JsonProperty("keep_history")]
        public long KeepHistory { get; set; }

        [JsonProperty("child_count")]
        public object ChildCount { get; set; }

        [JsonProperty("library_thumb")]
        public string LibraryThumb { get; set; }

        [JsonProperty("do_notify")]
        public long DoNotify { get; set; }
    }
}
