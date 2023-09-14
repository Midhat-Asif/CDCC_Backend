using CDCC_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace CDCC_Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sale>()
                .Property(s => s.unitcost)
                .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed

            modelBuilder.Entity<Sale>()
                .Property(s => s.total)
                .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed

            
        }
    }
}