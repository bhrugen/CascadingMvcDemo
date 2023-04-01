using CascadingMvcDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CascadingMvcDemo.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Appetizer" },
                new Category { Id = 2, CategoryName = "Main Course"},
                new Category { Id = 3, CategoryName = "Dessert" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product {
                    Id = 1,
                    Name = "Spring Roll",
                    Price = 4.99m,
                    CategoryId = 1
                }, new Product {
                    Id = 2,
                    Name = "Onion Ring",
                    Price = 6.99m,
                    CategoryId = 1
                }, new Product {
                    Id = 3,
                    Name = "Veg Burger",
                    Price = 9.99m,
                    CategoryId = 2
                }, new Product {
                    Id = 4,
                    Name = "Grilled Sandwich",
                    Price = 11.99m,
                    CategoryId = 2
                }, new Product {
                    Id = 5,
                    Name = "Chocolate Cheesecake",
                    Price = 7.99m,
                    CategoryId = 3
                }, new Product {
                    Id = 6,
                    Name = "Brownie",
                    Price = 9.99m,
                    CategoryId = 3
                }


                );
        }
    }
}