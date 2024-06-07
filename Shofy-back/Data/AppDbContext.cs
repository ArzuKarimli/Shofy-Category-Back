﻿using Microsoft.EntityFrameworkCore;
using Shofy_back.Models;
using System.Reflection.Metadata;

namespace Shofy_back.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public  DbSet<ProductImage> ProductImages { get; set; }
       

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

               
                modelBuilder.Entity<Category>().ToTable("Categories");
                modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<ProductImage>().ToTable("ProductImages");
        }
        



    }
}
