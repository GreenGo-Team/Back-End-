using GreenGo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGo.Configuration
{
    public class ProcessConfiguration : IEntityTypeConfiguration<Process>
    {
        public void Configure(EntityTypeBuilder<Process> builder)
        {
            builder.HasKey(P => P.Process_ID);
            builder.Property(P => P.Process_ID)
                   .UseIdentityColumn(1,1);

            builder.HasOne(P => P.Customer)
                   .WithMany(C => C.Processes)
                   .HasForeignKey(P => P.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(P => P.Items)
                   .WithMany(I => I.Processes)
                   .HasForeignKey(P => P.ItemsId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(P => P.Center)
                   .WithMany(Ce => Ce.Processes)
                   .HasForeignKey(P => P.CenterId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(P => P.Container)
                   .WithMany(Co => Co.Processes)
                   .HasForeignKey(P => P.ContainerId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
