using System.Collections.Generic;
using System.Threading.Tasks;
using Msk2.Transfer.Data.Context;
using Msk2.Transfer.Domain.Interfaces;
using Msk2.Transfer.Domain.Models;

namespace Msk2.Transfer.Data.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
            => _context.TransferLogs;

        public async Task AddTransferLogAsync(TransferLog transferLog)
        {
            await _context.TransferLogs.AddAsync(transferLog);
            await _context.SaveChangesAsync();
        }
    }
}
