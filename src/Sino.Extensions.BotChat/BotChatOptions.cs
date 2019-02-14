using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sino.Extensions.BotChat
{
    public class BotChatOptions : IOptions<BotChatOptions>
    {
        public string APIKey { get; set; }

        public string SecretKey { get; set; }

        BotChatOptions IOptions<BotChatOptions>.Value
        {
            get { return this; }
        }
    }
}
