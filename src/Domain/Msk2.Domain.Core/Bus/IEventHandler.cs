using System.Threading.Tasks;
using Msk2.Domain.Core.Events;

namespace Msk2.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHander
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHander {}
}
