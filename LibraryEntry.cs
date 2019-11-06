using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Tautulli.Net
{
    public class LibraryEntry
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("art")]
        public string Art { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("section_type")]
        public string SectionType { get; set; }

        [JsonProperty("section_id")]
        public long SectionId { get; set; }

        [JsonProperty("agent")]
        public string Agent { get; set; }

        [JsonProperty("section_name")]
        public string SectionName { get; set; }

        [JsonProperty("parent_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentCount { get; set; }

        [JsonProperty("child_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ChildCount { get; set; }
    }
}
