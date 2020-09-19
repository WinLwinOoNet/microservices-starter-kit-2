using System.Collections.Generic;
using Msk2.Transfer.Domain.Models;

namespace Msk2.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
