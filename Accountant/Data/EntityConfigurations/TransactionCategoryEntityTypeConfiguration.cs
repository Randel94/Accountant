using Accountant.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accountant.Data.EntityConfigurations
{
    public class TransactionCategoryEntityTypeConfiguration : IEntityTypeConfiguration<TransactionCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<TransactionCategoryEntity> builder)
        {
            builder.Property(x => x.Description)
                .IsRequired(false);
        }
    }
}
