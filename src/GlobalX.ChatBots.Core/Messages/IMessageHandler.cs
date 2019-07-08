using System.Threading.Tasks;

namespace GlobalX.ChatBots.Core.Messages {
    public interface IMessageHandler
    {
        Task<Message> SendMessageAsync(Message message);
    }
}
