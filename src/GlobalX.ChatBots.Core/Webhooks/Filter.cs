using GlobalX.ChatBots.Core.Rooms;

namespace GlobalX.ChatBots.Core.Webhooks {
    public class Filter {
        public FilterType Type { get; set; }
        public bool? Me { get; set; }
        public RoomType? RoomType { get; set; }
        public string PersonId { get; set; }
        public string[] MentionedPeople { get; set; }
    }
}
