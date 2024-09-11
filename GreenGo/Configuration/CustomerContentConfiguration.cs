using GreenGo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGo.Configuration
{
    public class CustomerContentConfiguration : IEntityTypeConfiguration<CustomerContent>
    {
        public void Configure(EntityTypeBuilder<CustomerContent> builder)
        {
            builder.HasKey(CC => new { CC.CustomerId, CC.ContentId });

            builder.HasOne(cc => cc.Customer)
            .WithMany(C => C.CustomerContents)
            .HasForeignKey(CC => CC.CustomerId);

            builder.HasOne(CC => CC.Content)
                .WithMany(C => C.CustomerContents)
                .HasForeignKey(CC => CC.ContentId);
        }
    }
}
