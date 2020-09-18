using System.Collections.Generic;
using Msk2.Banking.Data.Context;
using Msk2.Banking.Domain.Interfaces;
using Msk2.Banking.Domain.Models;

namespace Msk2.Banking.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _context;

        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Account> GetAccounts()
            => _context.Accounts;
    }
}
