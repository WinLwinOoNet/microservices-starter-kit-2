using System.Threading.Tasks;
using Msk2.Domain.Core.Bus;
using Msk2.Transfer.Domain.Events;
using Msk2.Transfer.Domain.Interfaces;
using Msk2.Transfer.Domain.Models;

namespace Msk2.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _repository;

        public TransferEventHandler(ITransferRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(TransferCreatedEvent @event)
        {
            await _repository.AddTransferLogAsync(new TransferLog
            {
                FromAccount = @event.From,
                ToAccount =  @event.To,
                TransferAmount = @event.Amount
            });
        }
    }
}
