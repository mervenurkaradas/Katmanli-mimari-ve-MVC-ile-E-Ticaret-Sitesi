using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public class ShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ShopDB;Trusted_Connection=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                        .HasKey(c => new { c.CategoryId, c.ProductId });

            modelBuilder.Entity<ProductCategory>()
                        .HasOne(c => c.Product)
                        .WithMany(c => c.ProductCategories)
                        .HasForeignKey(c => c.ProductId);

            modelBuilder.Entity<ProductCategory>()
                        .HasOne(c => c.Category)
                        .WithMany(c => c.ProductCategories)
                        .HasForeignKey(c => c.CategoryId);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
