using System.Threading.Tasks;

namespace GlobalX.ChatBots.Core.Rooms {
    public interface IRoomHandler {
        Task<Room> GetRoomAsync(string id);
    }
}
