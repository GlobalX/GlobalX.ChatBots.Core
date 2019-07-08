using GlobalX.ChatBots.Core.Messages;
using GlobalX.ChatBots.Core.People;
using GlobalX.ChatBots.Core.Rooms;

namespace GlobalX.ChatBots.Core
{
    public interface IChatHelper
    {
        IMessageHandler Messages { get; set; }
        IPersonHandler People { get; set; }
        IRoomHandler Rooms { get; set; }
    }
}
