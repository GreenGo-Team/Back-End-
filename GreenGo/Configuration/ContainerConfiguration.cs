using GreenGo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGo.Configuration
{
    public class ContainerConfiguration : IEntityTypeConfiguration<Container>
    {
        public void Configure(EntityTypeBuilder<Container> builder)
        {
            builder.HasKey(Co => Co.Container_ID);
            builder.Property(Co => Co.Container_ID)
                   .UseIdentityColumn(1,1);

            builder.Property(Co => Co.Type)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
