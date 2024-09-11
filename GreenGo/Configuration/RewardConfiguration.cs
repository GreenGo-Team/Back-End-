using GreenGo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GreenGo.Configuration
{
    public class RewardConfiguration : IEntityTypeConfiguration<Reward>
    {
        public void Configure(EntityTypeBuilder<Reward> builder)
        {
            builder.HasKey(R => R.Reward_ID);
            builder.Property(R => R.Description)
                   .IsRequired()
                   .HasMaxLength(300);

            builder.HasOne(R => R.Customer)
                   .WithMany(C => C.Rewards)
                   .HasForeignKey(R => R.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
