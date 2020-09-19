using Microsoft.EntityFrameworkCore;
using Msk2.Transfer.Domain.Models;

namespace Msk2.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
