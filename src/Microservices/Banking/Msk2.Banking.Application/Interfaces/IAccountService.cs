using System.Collections.Generic;
using Msk2.Banking.Application.Models;
using Msk2.Banking.Domain.Models;

namespace Msk2.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void Transfer(AccountTransfer accountTransfer);
    }
}
