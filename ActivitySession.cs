using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Tautulli.Net
{
    public class ActivitySession
    {
        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("transcode_width")]
        public string TranscodeWidth { get; set; }

        [JsonProperty("labels")]
        public List<object> Labels { get; set; }

        [JsonProperty("stream_bitrate")]
        public long StreamBitrate { get; set; }

        [JsonProperty("bandwidth")]
        public long Bandwidth { get; set; }

        [JsonProperty("optimized_version")]
        public long OptimizedVersion { get; set; }

        [JsonProperty("video_language")]
        public string VideoLanguage { get; set; }

        [JsonProperty("parent_rating_key")]
        public long ParentRatingKey { get; set; }

        [JsonProperty("rating_key")]
        public long RatingKey { get; set; }

        [JsonProperty("video_decision")]
        public string VideoDecision { get; set; }

        [JsonProperty("transcode_hw_decoding")]
        public long TranscodeHwDecoding { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("video_codec_level")]
        public long VideoCodecLevel { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("last_viewed_at")]
        public long LastViewedAt { get; set; }

        [JsonProperty("synced_version")]
        public long SyncedVersion { get; set; }

        [JsonProperty("audio_sample_rate")]
        public long AudioSampleRate { get; set; }

        [JsonProperty("user_rating")]
        public string UserRating { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("collections")]
        public List<object> Collections { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("transcode_container")]
        public string TranscodeContainer { get; set; }

        [JsonProperty("audio_channel_layout")]
        public string AudioChannelLayout { get; set; }

        [JsonProperty("stream_duration")]
        public long StreamDuration { get; set; }

        [JsonProperty("local")]
        public long Local { get; set; }

        [JsonProperty("stream_video_ref_frames")]
        public string StreamVideoRefFrames { get; set; }

        [JsonProperty("transcode_hw_encode_title")]
        public string TranscodeHwEncodeTitle { get; set; }

        [JsonProperty("stream_container_decision")]
        public string StreamContainerDecision { get; set; }

        [JsonProperty("audience_rating")]
        public string AudienceRating { get; set; }

        [JsonProperty("full_title")]
        public string FullTitle { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("transcode_speed")]
        public string TranscodeSpeed { get; set; }

        [JsonProperty("stream_subtitle_language")]
        public string StreamSubtitleLanguage { get; set; }

        [JsonProperty("channel_stream")]
        public long ChannelStream { get; set; }

        [JsonProperty("video_bitrate")]
        public long VideoBitrate { get; set; }

        [JsonProperty("is_allow_sync")]
        public long IsAllowSync { get; set; }

        [JsonProperty("stream_video_bitrate")]
        public long StreamVideoBitrate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("stream_audio_decision")]
        public string StreamAudioDecision { get; set; }

        [JsonProperty("aspect_ratio")]
        public string AspectRatio { get; set; }

        [JsonProperty("audio_bitrate_mode")]
        public string AudioBitrateMode { get; set; }

        [JsonProperty("transcode_hw_decode_title")]
        public string TranscodeHwDecodeTitle { get; set; }

        [JsonProperty("machine_id")]
        public string MachineId { get; set; }

        [JsonProperty("deleted_user")]
        public long DeletedUser { get; set; }

        [JsonProperty("library_name")]
        public string LibraryName { get; set; }

        [JsonProperty("art")]
        public string Art { get; set; }

        [JsonProperty("stream_video_resolution")]
        public long StreamVideoResolution { get; set; }

        [JsonProperty("video_profile")]
        public string VideoProfile { get; set; }

        [JsonProperty("sort_title")]
        public string SortTitle { get; set; }

        [JsonProperty("stream_video_codec_level")]
        public string StreamVideoCodecLevel { get; set; }

        [JsonProperty("stream_video_height")]
        public long StreamVideoHeight { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("video_scan_type")]
        public string VideoScanType { get; set; }

        [JsonProperty("progress_percent")]
        public long ProgressPercent { get; set; }

        [JsonProperty("video_language_code")]
        public string VideoLanguageCode { get; set; }

        [JsonProperty("transcode_key")]
        public string TranscodeKey { get; set; }

        [JsonProperty("transcode_throttled")]
        public long TranscodeThrottled { get; set; }

        [JsonProperty("container")]
        public string Container { get; set; }

        [JsonProperty("stream_audio_bitrate")]
        public long StreamAudioBitrate { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("selected")]
        public long Selected { get; set; }

        [JsonProperty("product_version")]
        public string ProductVersion { get; set; }

        [JsonProperty("subtitle_location")]
        public string SubtitleLocation { get; set; }

        [JsonProperty("transcode_hw_requested")]
        public long TranscodeHwRequested { get; set; }

        [JsonProperty("video_height")]
        public long VideoHeight { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("is_restricted")]
        public long IsRestricted { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("stream_container")]
        public string StreamContainer { get; set; }

        [JsonProperty("video_bit_depth")]
        public long VideoBitDepth { get; set; }

        [JsonProperty("stream_audio_sample_rate")]
        public string StreamAudioSampleRate { get; set; }

        [JsonProperty("grandparent_title")]
        public string GrandparentTitle { get; set; }

        [JsonProperty("studio")]
        public string Studio { get; set; }

        [JsonProperty("transcode_decision")]
        public string TranscodeDecision { get; set; }

        [JsonProperty("video_width")]
        public long VideoWidth { get; set; }

        [JsonProperty("bitrate")]
        public long Bitrate { get; set; }

        [JsonProperty("stream_audio_channel_layout")]
        public string StreamAudioChannelLayout { get; set; }

        [JsonProperty("originally_available_at")]
        public DateTimeOffset OriginallyAvailableAt { get; set; }

        [JsonProperty("video_frame_rate")]
        public string VideoFrameRate { get; set; }

        [JsonProperty("synced_version_profile")]
        public string SyncedVersionProfile { get; set; }

        [JsonProperty("friendly_name")]
        public string FriendlyName { get; set; }

        [JsonProperty("audio_profile")]
        public string AudioProfile { get; set; }

        [JsonProperty("optimized_version_title")]
        public string OptimizedVersionTitle { get; set; }

        [JsonProperty("platform_name")]
        public string PlatformName { get; set; }

        [JsonProperty("stream_video_language")]
        public string StreamVideoLanguage { get; set; }

        [JsonProperty("keep_history")]
        public long KeepHistory { get; set; }

        [JsonProperty("stream_audio_codec")]
        public string StreamAudioCodec { get; set; }

        [JsonProperty("stream_video_full_resolution")]
        public string StreamVideoFullResolution { get; set; }

        [JsonProperty("video_codec")]
        public string VideoCodec { get; set; }

        [JsonProperty("grandparent_thumb")]
        public string GrandparentThumb { get; set; }

        [JsonProperty("audio_bitrate")]
        public long AudioBitrate { get; set; }

        [JsonProperty("transcode_hw_decode")]
        public string TranscodeHwDecode { get; set; }

        [JsonProperty("secure")]
        public long Secure { get; set; }

        [JsonProperty("user_thumb")]
        public Uri UserThumb { get; set; }

        [JsonProperty("stream_video_width")]
        public long StreamVideoWidth { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("stream_subtitle_decision")]
        public string StreamSubtitleDecision { get; set; }

        [JsonProperty("audio_codec")]
        public string AudioCodec { get; set; }

        [JsonProperty("parent_title")]
        public string ParentTitle { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("stream_video_scan_type")]
        public string StreamVideoScanType { get; set; }

        [JsonProperty("audio_language_code")]
        public string AudioLanguageCode { get; set; }

        [JsonProperty("transcode_video_codec")]
        public string TranscodeVideoCodec { get; set; }

        [JsonProperty("transcode_audio_codec")]
        public string TranscodeAudioCodec { get; set; }

        [JsonProperty("stream_video_decision")]
        public string StreamVideoDecision { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("transcode_height")]
        public string TranscodeHeight { get; set; }

        [JsonProperty("transcode_hw_full_pipeline")]
        public long TranscodeHwFullPipeline { get; set; }

        [JsonProperty("throttled")]
        public long Throttled { get; set; }

        [JsonProperty("grandparent_guid")]
        public string GrandparentGuid { get; set; }

        [JsonProperty("live")]
        public long Live { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("quality_profile")]
        public string QualityProfile { get; set; }

        [JsonProperty("stream_subtitle_forced")]
        public long StreamSubtitleForced { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("video_resolution")]
        public long VideoResolution { get; set; }

        [JsonProperty("stream_subtitle_location")]
        public string StreamSubtitleLocation { get; set; }

        [JsonProperty("do_notify")]
        public long DoNotify { get; set; }

        [JsonProperty("video_ref_frames")]
        public long VideoRefFrames { get; set; }

        [JsonProperty("stream_subtitle_language_code")]
        public string StreamSubtitleLanguageCode { get; set; }

        [JsonProperty("audio_channels")]
        public long AudioChannels { get; set; }

        [JsonProperty("stream_audio_language_code")]
        public string StreamAudioLanguageCode { get; set; }

        [JsonProperty("optimized_version_profile")]
        public string OptimizedVersionProfile { get; set; }

        [JsonProperty("rating_image")]
        public string RatingImage { get; set; }

        [JsonProperty("is_home_user")]
        public long IsHomeUser { get; set; }

        [JsonProperty("is_admin")]
        public long IsAdmin { get; set; }

        [JsonProperty("ip_address_public")]
        public string IpAddressPublic { get; set; }

        [JsonProperty("allow_guest")]
        public long AllowGuest { get; set; }

        [JsonProperty("transcode_audio_channels")]
        public long TranscodeAudioChannels { get; set; }

        [JsonProperty("stream_audio_channel_layout_")]
        public string SessionStreamAudioChannelLayout { get; set; }

        [JsonProperty("media_index")]
        public long MediaIndex { get; set; }

        [JsonProperty("stream_video_framerate")]
        public string StreamVideoFramerate { get; set; }

        [JsonProperty("transcode_hw_encode")]
        public string TranscodeHwEncode { get; set; }

        [JsonProperty("grandparent_rating_key")]
        public long GrandparentRatingKey { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("added_at")]
        public long AddedAt { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }

        [JsonProperty("bif_thumb")]
        public string BifThumb { get; set; }

        [JsonProperty("parent_media_index")]
        public long ParentMediaIndex { get; set; }

        [JsonProperty("live_uuid")]
        public string LiveUuid { get; set; }

        [JsonProperty("audio_language")]
        public string AudioLanguage { get; set; }

        [JsonProperty("stream_audio_bitrate_mode")]
        public string StreamAudioBitrateMode { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("subtitle_decision")]
        public string SubtitleDecision { get; set; }

        [JsonProperty("parent_guid")]
        public string ParentGuid { get; set; }

        [JsonProperty("children_count")]
        public string ChildrenCount { get; set; }

        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; }

        [JsonProperty("video_full_resolution")]
        public string VideoFullResolution { get; set; }

        [JsonProperty("player")]
        public string Player { get; set; }

        [JsonProperty("subtitle_format")]
        public string SubtitleFormat { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("file_size")]
        public long FileSize { get; set; }

        [JsonProperty("session_key")]
        public long SessionKey { get; set; }

        [JsonProperty("subtitles")]
        public long Subtitles { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subtitle_container")]
        public string SubtitleContainer { get; set; }

        [JsonProperty("genres")]
        public List<string> Genres { get; set; }

        [JsonProperty("stream_audio_channels")]
        public long StreamAudioChannels { get; set; }

        [JsonProperty("stream_video_language_code")]
        public string StreamVideoLanguageCode { get; set; }

        [JsonProperty("relayed")]
        public long Relayed { get; set; }

        [JsonProperty("indexes")]
        public long Indexes { get; set; }

        [JsonProperty("platform_version")]
        public string PlatformVersion { get; set; }

        [JsonProperty("stream_audio_language")]
        public string StreamAudioLanguage { get; set; }

        [JsonProperty("writers")]
        public List<string> Writers { get; set; }

        [JsonProperty("actors")]
        public List<string> Actors { get; set; }

        [JsonProperty("stream_subtitle_format")]
        public string StreamSubtitleFormat { get; set; }

        [JsonProperty("audio_decision")]
        public string AudioDecision { get; set; }

        [JsonProperty("subtitle_forced")]
        public long SubtitleForced { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("view_offset")]
        public long ViewOffset { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("audience_rating_image")]
        public string AudienceRatingImage { get; set; }

        [JsonProperty("section_id")]
        public long SectionId { get; set; }

        [JsonProperty("stream_subtitle_codec")]
        public string StreamSubtitleCodec { get; set; }

        [JsonProperty("subtitle_codec")]
        public string SubtitleCodec { get; set; }

        [JsonProperty("stream_video_codec")]
        public string StreamVideoCodec { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("stream_video_bit_depth")]
        public string StreamVideoBitDepth { get; set; }

        [JsonProperty("video_framerate")]
        public string VideoFramerate { get; set; }

        [JsonProperty("transcode_hw_encoding")]
        public long TranscodeHwEncoding { get; set; }

        [JsonProperty("transcode_protocol")]
        public string TranscodeProtocol { get; set; }

        [JsonProperty("shared_libraries")]
        public List<long> SharedLibraries { get; set; }

        [JsonProperty("stream_aspect_ratio")]
        public string StreamAspectRatio { get; set; }

        [JsonProperty("content_rating")]
        public string ContentRating { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("directors")]
        public List<string> Directors { get; set; }

        [JsonProperty("parent_thumb")]
        public string ParentThumb { get; set; }

        [JsonProperty("subtitle_language_code")]
        public string SubtitleLanguageCode { get; set; }

        [JsonProperty("transcode_progress")]
        public long TranscodeProgress { get; set; }

        [JsonProperty("subtitle_language")]
        public string SubtitleLanguage { get; set; }

        [JsonProperty("stream_subtitle_container")]
        public string StreamSubtitleContainer { get; set; }
    }
}
