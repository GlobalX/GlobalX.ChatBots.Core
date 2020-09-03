using System.Threading.Tasks;

namespace GlobalX.ChatBots.Core.Messages {
    public interface IMessageHandler
    {
        /// <summary>
        /// Send a message.
        /// </summary>
        /// <param name="message">The message to be sent.
        ///   **Id:** Leave null when creating a new message to send.
        ///   **Created:** Leave null when creating a new message to send.
        ///   **Text:** Plain text representation of the message.
        ///   **MessageParts:** The full contents of the message, including formatting and user mentions.
        ///   **Sender:** Leave null when creating a message to send.
        ///   **RoomId:** The ID of the room to which the message should be sent.
        ///   **ParentId:** Set to the ID of the message to which you wish to reply, if you wish to make an inline reply.
        ///                 Leave null to create a top-level message.
        ///   **RoomType:** Direct for direct messages or Group for a public group chat room.
        /// </param>
        Task<Message> SendMessageAsync(Message message);
    }
}
