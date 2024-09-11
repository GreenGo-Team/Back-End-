using GreenGo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGo.Configuration
{
    public class ContentConfiguration : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.HasKey(Co => Co.Content_ID);
            builder.Property(Co => Co.Title)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(Co => Co.Description)
                   .HasMaxLength(300);

            builder.HasMany(C => C.CustomerContents)
                   .WithOne(CC => CC.Content)
                   .HasForeignKey(CC => CC.ContentId);
        }
    }
}
