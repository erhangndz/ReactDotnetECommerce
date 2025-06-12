using ECommerce.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Data
{
    public class AppDbContext(DbContextOptions options): DbContext(options)
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(
                new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        Name = "IPhone 15 ",
                        Description = "Apple Telefon",
                        Price = 50000m,
                        IsActive = true,
                        Stock = 100,
                        ImageUrl = "1.jpg"
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "IPhone 14 ",
                        Description = "Apple Telefon",
                        Price = 40000m,
                        IsActive = true,
                        Stock = 100,
                        ImageUrl = "2.jpg"
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "IPhone 13 ",
                        Description = "Apple Telefon",
                        Price = 30000m,
                        IsActive = true,
                        Stock = 100,
                        ImageUrl = "3.jpg"
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "IPhone 12 ",
                        Description = "Apple Telefon",
                        Price = 20000m,
                        IsActive = true,
                        Stock = 100,
                        ImageUrl = "4.jpg"
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "IPhone 11 ",
                        Description = "Apple Telefon",
                        Price = 10000m,
                        IsActive = true,
                        Stock = 100,
                        ImageUrl = "5.jpg"
                    }
                });
        }
    }
}
