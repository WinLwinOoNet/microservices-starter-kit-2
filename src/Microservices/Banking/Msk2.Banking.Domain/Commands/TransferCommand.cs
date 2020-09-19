using Msk2.Domain.Core.Commands;

namespace Msk2.Banking.Domain.Commands
{
    public class TransferCommand : Command
    {
        public int FromAccount { get; protected set; }
        public int ToAccount { get; protected set; }
        public decimal TransferAmount { get; protected set; }
    }
}
