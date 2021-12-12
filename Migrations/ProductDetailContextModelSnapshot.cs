﻿// <auto-generated />
using InventoryControlSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryControlSystem.Migrations
{
    [DbContext(typeof(ProductDetailContext))]
    partial class ProductDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("InventoryControlSystem.Models.Product", b =>
                {
                    b.Property<int>("productID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("productCategory")
                        .HasColumnType("int");

                    b.Property<string>("productDescription")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("productName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("productPrice")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("productQuantity")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("productID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("InventoryControlSystem.Models.ProductCategory", b =>
                {
                    b.Property<int>("categoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("categoryDescription")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("categoryID");

                    b.ToTable("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
