using System;

namespace GlobalX.ChatBots.Core.Rooms {
    public class Room {
        public DateTime Created { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public RoomType Type { get; set; }
    }
}
