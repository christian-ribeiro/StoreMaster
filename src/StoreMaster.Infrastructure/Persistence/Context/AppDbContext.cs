using Microsoft.EntityFrameworkCore;
using StoreMaster.Infrastructure.Persistence.Entry;
using StoreMaster.Infrastructure.Persistence.Mapping;

namespace StoreMaster.Infrastructure.Persistence.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<StockConfiguration> StockConfiguration { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<StockMovement> StockMovement { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductMap).Assembly);
        }
    }
}