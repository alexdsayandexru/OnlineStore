namespace OnlineStore.Infrastructure.EventBus
{
    public class EventBus : IEventBus
    {
        public void Publish(IntegrationEvent @event)
        {

        }

        public void Subscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {

        }

        public void Unsubscribe<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {

        }
    }
}
