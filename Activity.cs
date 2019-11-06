using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Tautulli.Net
{
    public class Activity
    {
            [JsonProperty("sessions")]
            public List<ActivitySession> Sessions { get; set; }

            [JsonProperty("stream_count")]
            public long StreamCount { get; set; }

            [JsonProperty("total_bandwidth")]
            public long TotalBandwidth { get; set; }

            [JsonProperty("stream_count_transcode")]
            public long StreamCountTranscode { get; set; }

            [JsonProperty("wan_bandwidth")]
            public long WanBandwidth { get; set; }

            [JsonProperty("stream_count_direct_play")]
            public long StreamCountDirectPlay { get; set; }

            [JsonProperty("lan_bandwidth")]
            public long LanBandwidth { get; set; }

            [JsonProperty("stream_count_direct_stream")]
            public long StreamCountDirectStream { get; set; }
    }
}
