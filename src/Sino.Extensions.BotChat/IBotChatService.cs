using Sino.Extensions.BotChat;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Extensions.BotChat
{
    public interface IBotChatService
    {
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <returns></returns>
        Task<GetTokenRequest> GetTokenAsync();

        /// <summary>
        /// 技能对话
        /// </summary>
        /// <param name="info"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<ChatBotResponse> UnitBotChatAsync(ChatBotRequest info,string token);
    }
}
