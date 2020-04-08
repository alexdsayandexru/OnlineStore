using OnlineStore.Infrastructure.EventBus;

namespace OnlineStore.Infrastructure
{
    public abstract class DataEventInputController
    {
        private IEventBus _eventBus;

        protected DataEventInputController (IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
    }
}
