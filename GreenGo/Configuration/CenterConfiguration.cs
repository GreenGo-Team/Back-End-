using GreenGo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGo.Configuration
{
    public class CenterConfiguration : IEntityTypeConfiguration<Center>
    {
        public void Configure(EntityTypeBuilder<Center> builder)
        {
            builder.HasKey(Ce => Ce.Center_ID);
            builder.Property(Ce => Ce.Center_ID)
                   .UseIdentityColumn(1,1);
            builder.Property(Ce => Ce.Name)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
