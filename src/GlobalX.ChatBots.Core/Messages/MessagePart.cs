namespace GlobalX.ChatBots.Core.Messages {
    public class MessagePart {
        public MessageType MessageType { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public string[] ListItems { get; set; }
    }
}
