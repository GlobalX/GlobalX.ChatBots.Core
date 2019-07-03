using System.Threading.Tasks;

namespace GlobalX.ChatBots.Core.Messages {
    public interface IMessageHandler
    {
        Task<Message> ProcessMessage(string message);
        Task<Message> SendMessage(Message message);
    }
}
