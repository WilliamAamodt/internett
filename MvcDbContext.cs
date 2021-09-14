using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApplication.Models.Enteties;

#nullable disable

namespace WebApplication
{
    public class MvcDbContext : DbContext
    {
        
        public MvcDbContext(DbContextOptions<MvcDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Manufacturer>().ToTable("Manufacturer");

            modelBuilder.Entity<Manufacturer>()
                .HasData(
                    new Manufacturer
                    {
                        ManufacturerId = 1, Description = "Svensk bilmerke", Name = "Volvo", Address = "Svergie"
                    },
                    new Manufacturer
                    {
                        ManufacturerId = 2, Description = "Tysk verktøy", Name = "Bosch", Address = "Tyskland"
                    },
                    new Manufacturer
                    {
                        ManufacturerId = 3, Description = "Daglivare butikk", Name = "Coop", Address = "Nordland"
                    });

            modelBuilder.Entity<Category>().ToTable("Category");

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        CategoryId = 1,Description = "Diverse verktøy", Name = "Verktøy"
                    },
                    new Category
                    {
                        CategoryId = 2,Description = "Forskjellige bilfabrikanter", Name = "Bilmekre"
                    },
                    new Category
                    {
                        CategoryId = 3,Description = "Diverse matvarer", Name = "Matvarer"
                    }
                );
            
            modelBuilder.Entity<Product>().ToTable("Product");
            // Seeding
            modelBuilder.Entity<Product>()
                .HasData(new Product { ProductId = 1, Name = "Hammer", Price = 1300.00m, ManufacturerId = 2, CategoryId = 1});
            modelBuilder.Entity<Product>().HasData(new Product
                { ProductId = 2, Name = "Vinkelsliper", Price = 1520.00m, ManufacturerId = 2, CategoryId = 1});
            modelBuilder.Entity<Product>().HasData(new Product
                { ProductId = 3, Name = "Volvo XC90", Price = 990000m, ManufacturerId = 1, CategoryId = 2});
            modelBuilder.Entity<Product>().HasData(new Product
                { ProductId = 4, Name = "Volvo XC60", Price = 620000m, ManufacturerId = 2, CategoryId = 1});
            modelBuilder.Entity<Product>()
                .HasData(new Product { ProductId = 5, Name = "Brød", Price = 25.50m, ManufacturerId = 3, CategoryId = 3});

        }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}