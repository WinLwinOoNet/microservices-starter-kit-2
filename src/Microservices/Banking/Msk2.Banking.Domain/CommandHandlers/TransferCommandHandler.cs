using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Msk2.Banking.Domain.Commands;
using Msk2.Banking.Domain.Events;
using Msk2.Domain.Core.Bus;

namespace Msk2.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            return Task.FromResult(true);
        }
    }
}
