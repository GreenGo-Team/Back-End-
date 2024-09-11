using GreenGo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGo.Configuration
{
    public class ItemConfiguration : IEntityTypeConfiguration<Items>
    {
        public void Configure(EntityTypeBuilder<Items> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Type)
                   .HasMaxLength(20);

            builder.HasOne(I => I.Customer)
                   .WithMany(C => C.Items)
                   .HasForeignKey(I => I.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
