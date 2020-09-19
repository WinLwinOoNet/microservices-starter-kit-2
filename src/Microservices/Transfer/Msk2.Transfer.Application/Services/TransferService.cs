using System.Collections.Generic;
using Msk2.Domain.Core.Bus;
using Msk2.Transfer.Application.Interfaces;
using Msk2.Transfer.Domain.Interfaces;
using Msk2.Transfer.Domain.Models;

namespace Msk2.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _repository;
        private readonly IEventBus _bus;

        public TransferService(
            ITransferRepository repository,
            IEventBus bus)
        {
            _repository = repository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
            => _repository.GetTransferLogs();
    }
}
