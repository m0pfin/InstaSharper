﻿using System;
using InstagramAPI.ResponseWrappers.BaseResponse;
using Newtonsoft.Json;

namespace InstagramApi.ResponseWrappers
{
    public class InstaCaptionResponse : BaseStatusResponse
    {
        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("created_at_utc")]
        public string CreatedAtUTCUnixLike { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAtUnixLike { get; set; }

        [JsonProperty("user")]
        public InstaUserResponse User { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("pk")]
        public string PK { get; set; }
    }
}