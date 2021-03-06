using System;
using GlobalX.ChatBots.Core.People;
using GlobalX.ChatBots.Core.Rooms;

namespace GlobalX.ChatBots.Core.Messages {
    public class Message {
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public string Text { get;set; }
        public MessagePart[] MessageParts { get; set; }
        public Person Sender { get; set; }
        public string RoomId { get; set; }
        public string ParentId { get; set; }
        public RoomType RoomType { get; set; }
    }
}
