using GreenGo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.AccessControl;

namespace GreenGo.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(C => C.Customer_ID);
            builder.Property(C => C.Fname)
                   .IsRequired()
                   .HasMaxLength (10);

            builder.Property(C => C.Lname)
                   .IsRequired()
                   .HasMaxLength (10);

            builder.HasMany(C => C.CustomerContents)
                   .WithOne(CC => CC.Customer)
                   .HasForeignKey(CC => CC.CustomerId);

        }
    }
}
