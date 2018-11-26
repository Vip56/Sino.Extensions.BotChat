using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Sino.Extensions.BotChat
{
    /// <summary>
    /// 请求体
    /// </summary>
    public class RequestBody
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户查询语句
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        /// 请求附加信息
        /// </summary>
        [JsonProperty("query_info")]
        public QueryInfo QueryInfo { get; set; }

        /// <summary>
        /// 希望传递给BOT的本地信息，以K-V的JSON形式
        /// </summary>
        [JsonProperty("client_session")]
        public string ClientSession { get; set; }

        /// <summary>
        /// 干预信息
        /// </summary>
        [JsonProperty("updates")]
        public Update Updates { get; set; }

        /// <summary>
        /// 系统自动发现不置信意图/词槽，默认为1
        /// </summary>
        [JsonProperty("bernard_level")]
        public int BernardLevel { get; set; } = 1;

        /// <summary>
        /// 影响UNIT内部行为的超参数，支持K-V形式的JSON对象
        /// </summary>
        [JsonProperty("hyper_params")]
        public object HyperParams { get; set; }

        /// <summary>
        /// SLU阈值，默认为0.5
        /// </summary>
        [JsonProperty("slu_threshold")]
        public float SluThreshold { get; set; } = 0.5f;

        /// <summary>
        /// 会话编号
        /// </summary>
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// BOT视图数据
        /// </summary>
        [JsonProperty("bot_views")]
        public object BotViews { get; set; }

        /// <summary>
        /// 对话状态数据
        /// </summary>
        [JsonProperty("dialog_state")]
        public object DialogState { get; set; }

        /// <summary>
        /// 历史交互序列
        /// </summary>
        [JsonProperty("interactions")]
        public Interaction[] interactions { get; set; }
    }

    /// <summary>
    /// 交互序列
    /// </summary>
    public class Interaction
    {
        /// <summary>
        /// 标识符
        /// </summary>
        [JsonProperty("interaction_id")]
        public string Id { get; set; }

        /// <summary>
        /// 请求体
        /// </summary>
        [JsonProperty("request")]
        public object Request { get; set; }

        /// <summary>
        /// 回应体
        /// </summary>
        [JsonProperty("response")]
        public object Response { get; set; }
    }
}
