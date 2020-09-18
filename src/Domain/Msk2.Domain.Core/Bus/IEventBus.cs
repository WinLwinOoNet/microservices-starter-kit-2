using System.Threading.Tasks;
using Msk2.Domain.Core.Commands;
using Msk2.Domain.Core.Events;

namespace Msk2.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
