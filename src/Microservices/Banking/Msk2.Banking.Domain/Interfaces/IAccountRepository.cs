using System.Collections.Generic;
using Msk2.Banking.Domain.Models;

namespace Msk2.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
