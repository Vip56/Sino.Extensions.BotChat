using Sino.Extensions.BotChat;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BotChatServiceCollectionExtensions
    {
        public static IServiceCollection AddBotChat(this IServiceCollection services, BotChatOptions setupAction)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));
            if (setupAction == null)
                throw new ArgumentNullException(nameof(setupAction));

            services.AddSingleton<IBotChatService>(new BotChatService(setupAction));

            return services;
        }
    }
}
