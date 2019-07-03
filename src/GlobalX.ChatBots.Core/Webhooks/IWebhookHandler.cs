using System.Threading.Tasks;

namespace GlobalX.ChatBots.Core.Webhooks {
    public interface IWebhookHandler
    {
        Task<Webhook[]> GetWebhooks();
        Task<Webhook> CreateWebhook(Webhook webhook);
        Task<bool> DeleteWebhook(string id);
    }
}
