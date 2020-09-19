using System.Collections.Generic;
using System.Threading.Tasks;
using Msk2.Transfer.Domain.Models;

namespace Msk2.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();

        Task AddTransferLogAsync(TransferLog transferLog);
    }
}
