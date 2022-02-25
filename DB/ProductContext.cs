using System.Reflection.Emit;
using System.Reflection;
//using System.Runtime.Intrinsics.Arm.Arm64;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using EFCoreDay11.Entities;
namespace EFCoreDay11.DB
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                        .HasOne<Category>(p => p.Category)
                        .WithMany(c => c.Products)
                        .HasForeignKey(s => s.CategoryID);
            modelBuilder.Entity<Category>().HasData(
        new Category
        {
            CategoryID = 1,
            CategoryName = "book"

        }
    );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, CategoryID = "1", ProductName = Omo, Manufacture = "Machine" },
                new Product { ProductID = 2, CategoryID = "2", ProductName = Steev, Manufacture = "King Lear" },
                new Product { ProductID = 3, CategoryID = "3", ProductName = High, Manufacture = "Othello" }
            );
        }

    }
}