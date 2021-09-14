﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication;

namespace WebApplication.Migrations
{
    [DbContext(typeof(MvcDbContext))]
    [Migration("20210914175900_AddProductsToOnModelCreating")]
    partial class AddProductsToOnModelCreating
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication.Models.Enteties.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Category = "Verktøy",
                            Name = "Hammer",
                            Price = 121.50m
                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Verktøy",
                            Name = "Vinkelsliper",
                            Price = 1520.00m
                        },
                        new
                        {
                            ProductId = 3,
                            Category = " Kjøretøy",
                            Name = "Volvo XC90",
                            Price = 990000m
                        },
                        new
                        {
                            ProductId = 4,
                            Category = "Kjøretøy",
                            Name = "Volvo XC60",
                            Price = 620000m
                        },
                        new
                        {
                            ProductId = 5,
                            Category = "Dagligvarer",
                            Name = "Brød",
                            Price = 25.50m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
