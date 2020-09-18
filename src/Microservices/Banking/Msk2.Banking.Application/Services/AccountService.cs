using System.Collections.Generic;
using Msk2.Banking.Application.Interfaces;
using Msk2.Banking.Application.Models;
using Msk2.Banking.Domain.Commands;
using Msk2.Banking.Domain.Interfaces;
using Msk2.Banking.Domain.Models;
using Msk2.Domain.Core.Bus;

namespace Msk2.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;
        private readonly IEventBus _bus;

        public AccountService(
            IAccountRepository repository,
            IEventBus bus)
        {
            _repository = repository;
            _bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
            => _repository.GetAccounts();

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.TransferAmount);

            _bus.SendCommand(createTransferCommand);
        }
    }
}
