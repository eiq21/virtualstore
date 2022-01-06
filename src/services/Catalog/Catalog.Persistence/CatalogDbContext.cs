using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Catalog.Persistence
{
    public class CatalogDbContext:DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
            :base(options)
        {

        }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CatalogDbContext).Assembly);
            
            modelBuilder.HasDefaultSchema("Catalog");

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);

        }

    }
}
