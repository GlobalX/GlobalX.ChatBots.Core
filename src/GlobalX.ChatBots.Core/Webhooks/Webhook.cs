namespace GlobalX.ChatBots.Core.Webhooks {
    public class Webhook {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TargetUrl { get; set; }
        public WebhookType Type { get; set; }
        public WebhookEvent Event { get; set; }
        public Filter[] Filters { get; set; }
    }
}
