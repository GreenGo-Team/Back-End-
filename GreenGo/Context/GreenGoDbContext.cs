using GreenGo.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GreenGo.Context
{
    public class GreenGoDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = GreenGo ; Trusted_Connection =true; TrustServerCertificate = true");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<CustomerContent> CustomerContents { get; set; }

    }
}
