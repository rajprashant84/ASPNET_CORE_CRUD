using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace ASPNET_CORE_CRUD.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
