using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.BotChat
{
    public class GetTokenRequest
    {
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("session_key")]
        public string SessionKey { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("session_secret")]
        public string SessionSecret { get; set; }
    }
}
