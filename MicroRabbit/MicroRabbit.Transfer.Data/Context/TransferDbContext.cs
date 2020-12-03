using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public DbSet<TransferLog> TransferLog { get; set; }

        public TransferDbContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransferLog>()
                        .Property(a => a.TransferAmount)
                        .HasColumnType("decimal")
                        .HasPrecision(18, 2);
        }
    }
}
