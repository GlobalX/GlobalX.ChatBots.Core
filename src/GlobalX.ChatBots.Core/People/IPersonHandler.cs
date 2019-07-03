using System.Threading.Tasks;

namespace GlobalX.ChatBots.Core.People {
    public interface IPersonHandler {
        Task<Person> GetPerson(string id);
    }
}
