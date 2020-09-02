using System.Threading.Tasks;

namespace GlobalX.ChatBots.Core.Messages {
    public interface IMessageHandler
    {
        Task<Message> SendMessageAsync(Message message);

        /// <summary>
        /// Send a message in reply to another message,
        /// in a system with support for threaded messaging.
        ///
        /// Fall back to a standard message reply in systems lacking threaded messaging.
        /// </summary>
        /// <param name="message">The message to be sent.</param>
        /// <param name="parentId">The id of the message to be replied to.
        /// Systems with only single-level threading should allow any id within a thread to be used.</param>
        Task<Message> SendReplyAsync(Message message, string parentId);
    }
}
