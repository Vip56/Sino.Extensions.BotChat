using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.BotChat
{
    /// <summary>
    /// 回应请求
    /// </summary>
    public class ChatBotResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 具体数据对象
        /// </summary>
        [JsonProperty("result")]
        public ResultDetail Result { get; set; }
    }
}
