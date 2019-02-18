using Sino.Extensions.BotChat;
using System;
using System.Threading.Tasks;
using Xunit;

namespace BotChatUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var service = new BotChatService(new BotChatOptions
            {
                APIKey = "gRlelqZ1wdEaF93LYDOaf3l1",
                SecretKey = "E6M4GnpP6tT0Ofc6GDGPaW76fzZhuGPw"
            });
            var token = await service.GetTokenAsync();
            var result = await service.UnitBotChatAsync(new ChatBotRequest()
            {
                BotId = "14527",
                BotSession = "",
                LogId = "7758521",
                Version = "2.0",
                Request = new RequestBody()
                {
                    BernardLevel = 1,
                    ClientSession = "{\\\"client_results\\\":\\\"\\\", \\\"candidate_options\\\":[]}",
                    Query = "天气",
                    QueryInfo = new QueryInfo()
                    {
                        AsrCandidates = new AsrCandidate[0],
                        Source = "KEYBOARD",
                        Type = "TEXT"
                    },
                    Updates = "",
                    UserId = "88888",
                    interactions = null,
                    HyperParams = null
                }
            }, token.AccessToken);

            var result2 = await service.UnitBotChatAsync(new ChatBotRequest()
            {
                BotId = "14527",
                BotSession = result.Result.BotSession,
                LogId = "7758521",
                Version = "2.0",
                Request = new RequestBody()
                {
                    BernardLevel = 1,
                    ClientSession = "{\\\"client_results\\\":\\\"\\\", \\\"candidate_options\\\":[]}",
                    Query = "今天",
                    QueryInfo = new QueryInfo()
                    {
                        AsrCandidates = new AsrCandidate[0],
                        Source = "KEYBOARD",
                        Type = "TEXT"
                    },
                    Updates = "",
                    UserId = "88888",
                    interactions = null,
                    HyperParams = null
                }
            }, token.AccessToken);

            var result3 = await service.UnitBotChatAsync(new ChatBotRequest()
            {
                BotId = "14527",
                BotSession = result2.Result.BotSession,
                LogId = "7758521",
                Version = "2.0",
                Request = new RequestBody()
                {
                    BernardLevel = 1,
                    ClientSession = "{\\\"client_results\\\":\\\"\\\", \\\"candidate_options\\\":[]}",
                    Query = "镇江",
                    QueryInfo = new QueryInfo()
                    {
                        AsrCandidates = new AsrCandidate[0],
                        Source = "KEYBOARD",
                        Type = "TEXT"
                    },
                    Updates = "",
                    UserId = "88888",
                    interactions = null,
                    HyperParams = null
                }
            }, token.AccessToken);
        }
    }
}
