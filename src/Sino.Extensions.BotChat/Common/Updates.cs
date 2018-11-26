using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Sino.Extensions.BotChat
{
    /// <summary>
    /// 干预信息主体
    /// </summary>
    public class Update
    {
        /// <summary>
        /// 干预方式，抛弃系统解析结果
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 具体操作集
        /// </summary>
        [JsonProperty("ops")]
        public Operator[] Ops { get; set; }
    }

    /// <summary>
    /// 操作集合
    /// </summary>
    public class Operator
    {
        /// <summary>
        /// 操作方式，定义则为DEFINE
        /// </summary>
        [JsonProperty("op")]
        public string Op { get; set; }

        /// <summary>
        /// 针对对象，可选值为意图（INTENT）、词槽（SLOT）
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; set; }

        /// <summary>
        /// 对象的值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
