using System;
using GlobalX.ChatBots.Core.Messages;
using GlobalX.ChatBots.Core.People;
using GlobalX.ChatBots.Core.Rooms;
using GlobalX.ChatBots.Core.Webhooks;

namespace GlobalX.ChatBots.Core
{
    public interface IChatHelper
    {
        IMessageHandler Messages { get; set; }
        IPersonHandler People { get; set; }
        IRoomHandler Rooms { get; set; }
        IWebhookHandler Webhooks { get; set; }
    }
}
