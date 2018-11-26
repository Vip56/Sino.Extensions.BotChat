using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Sino.Extensions.BotChat
{
    /// <summary>
    /// 查询附加信息
    /// </summary>
    public class QueryInfo
    {
        /// <summary>
        /// 请求信息类型，默认为TEXT，如果为EVENT则可以支持直接触发指定意图
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = "TEXT";

        /// <summary>
        /// 请求信息来源，可选择为ASR与KEYBOARD，ASR为语音输入，KEYBOARD为键盘文本输入
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 请求信息若为ASR，改字段为ASR候选信息
        /// </summary>
        [JsonProperty("asr_candidates")]
        public AsrCandidate[] AsrCandidates { get; set; }
    }

    /// <summary>
    /// ASR候选信息
    /// </summary>
    public class AsrCandidate
    {
        /// <summary>
        /// 语音输入候选文本
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 语音输入候选置信度
        /// </summary>
        [JsonProperty("confidence")]
        public string Confidence { get; set; }
    }
}
