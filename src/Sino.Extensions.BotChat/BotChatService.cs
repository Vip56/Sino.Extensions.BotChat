using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Extensions.BotChat
{
    public class BotChatService : IBotChatService
    {
        private readonly BotChatOptions _boptions;
        private static HttpClient client;

        public BotChatService(BotChatOptions botChatOptions)
        {
            _boptions = botChatOptions;
        }

        /// <summary>
        /// 获取Token
        /// </summary>
        /// <returns></returns>
        public async Task<GetTokenRequest> GetTokenAsync()
        {
            client = new HttpClient();
            string host = $"https://aip.baidubce.com/oauth/2.0/token?grant_type=client_credentials&client_id={_boptions.APIKey}&client_secret={_boptions.SecretKey}";
            var content = await client.GetAsync(host);
            var json = await content.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<GetTokenRequest>(json);
        }

        /// <summary>
        /// 技能对话
        /// </summary>
        /// <param name="info"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<ChatBotResponse> UnitBotChatAsync(ChatBotRequest info, string token)
        {
            client = new HttpClient();
            string host = $"https://aip.baidubce.com/rpc/2.0/unit/bot/chat?access_token={token}";
            string str = JsonConvert.SerializeObject(info);
            var content = await client.PostAsync(host, new StringContent(str, Encoding.UTF8, "application/json"));
            var json = await content.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ChatBotResponse>(json);
        }
    }
}
