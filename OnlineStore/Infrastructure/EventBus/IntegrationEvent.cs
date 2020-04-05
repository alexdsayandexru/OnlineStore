using System;

namespace OnlineStore.Infrastructure.EventBus
{
    [Serializable]
    public class IntegrationEvent
    {
        public string Type { get; set; }
        public string Body { get; set; }
    }
}
