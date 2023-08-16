using Accountant.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accountant.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<TransactionEntity> Transactions { get; set; }
        public DbSet<TransactionCategoryEntity> TransactionCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
