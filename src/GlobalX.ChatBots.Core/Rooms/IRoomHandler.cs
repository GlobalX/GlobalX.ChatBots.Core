using System.Threading.Tasks;

namespace GlobalX.ChatBots.Core.Rooms {
    public interface IRoomHandler {
        Task<Room> GetRoom(string id);
    }
}
