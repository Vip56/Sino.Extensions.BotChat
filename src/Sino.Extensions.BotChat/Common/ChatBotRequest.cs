using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.BotChat
{
    /// <summary>
    /// 请求主体
    /// </summary>
    public class ChatBotRequest
    {
        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; } = "2.0";

        /// <summary>
        /// 技能ID
        /// </summary>
        [JsonProperty("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 请求编号，由于客户生成并在返回中携带。
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }

        /// <summary>
        /// 请求体
        /// </summary>
        [JsonProperty("request")]
        public RequestBody Request { get; set; }

        /// <summary>
        /// BOT的会话信息，由client根据上次请求的返回取出并传递
        /// </summary>
        [JsonProperty("bot_session")]
        public string BotSession { get; set; }
    }
}
