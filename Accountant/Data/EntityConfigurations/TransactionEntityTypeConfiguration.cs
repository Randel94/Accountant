using Accountant.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accountant.Data.EntityConfigurations
{
    public class TransactionEntityTypeConfiguration : IEntityTypeConfiguration<TransactionEntity>
    {
        public void Configure(EntityTypeBuilder<TransactionEntity> builder)
        {
            builder.HasOne(x => x.Category)
                .WithMany(x => x.Transactions);

            builder.Property(x => x.Comment)
                .IsRequired(false);
        }
    }
}
