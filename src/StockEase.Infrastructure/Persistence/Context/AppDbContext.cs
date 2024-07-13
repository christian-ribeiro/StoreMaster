using Microsoft.EntityFrameworkCore;
using StockEase.Infrastructure.Persistence.Entry;
using StockEase.Infrastructure.Persistence.Mapping;

namespace StockEase.Infrastructure.Persistence.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<StockConfiguration> StockConfiguration { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<StockMovement> StockMovement { get; set; }
        public DbSet<StockMovementType> StockMovementType { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserStatus> UserStatus { get; set; }
        public DbSet<Menu> Menu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductMap).Assembly);
        }
    }
}