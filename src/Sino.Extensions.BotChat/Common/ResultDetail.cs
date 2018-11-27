using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.BotChat
{
    /// <summary>
    /// 返回详情
    /// </summary>
    public class ResultDetail
    {
        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// 技能编号
        /// </summary>
        [JsonProperty("bot_id")]
        public string BotId { get; set; }

        /// <summary>
        /// 日志编号
        /// </summary>
        [JsonProperty("log_id")]
        public string LogId { get; set; }

        /// <summary>
        /// 会话信息
        /// </summary>
        [JsonProperty("bot_session")]
        public string BotSession { get; set; }

        /// <summary>
        /// 为本轮请求+应答之组合，生成的编号
        /// </summary>
        [JsonProperty("interaction_id")]
        public string InteractionId { get; set; }

        /// <summary>
        /// 本轮应答体
        /// </summary>
        [JsonProperty("response")]
        public ResponseDetail Response { get; set; }
    }
}
