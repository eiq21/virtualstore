using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Persistence
{
    public static class CatalogDbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                new Brand { BrandId = 1, Name = "Coca Cola" },
                new Brand { BrandId = 2, Name = "Gloria" },
                new Brand { BrandId = 3, Name = "Pepsi" },
                new Brand { BrandId = 4, Name = "Cristal" },
                new Brand { BrandId = 5, Name = "Bimbo" }
                );

            modelBuilder.Entity<Category>().HasData(
               new Category { CategoryId = 1, Name = "Bebidas" },
               new Category { CategoryId = 2, Name = "Frutas" },
               new Category { CategoryId = 3, Name = "Cereales" },
               new Category { CategoryId = 4, Name = "Cervezas" },
               new Category { CategoryId = 5, Name = "Piqueos" }
               );

            modelBuilder.Entity<Product>().HasData(
               new Product { ProductId = 1, BrandId = 1, CategoryId = 1, Name = "Coca Cola Botella 1.5L" }
               );
        }
    }
}
