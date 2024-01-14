﻿// <auto-generated />
using System;
using ApplicationContextLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApplicationContextLayer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240114124003_AddRating")]
    partial class AddRating
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DomainLayer.Entities.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b10514f-33ca-41d2-b6df-95fc1fd95e5a"),
                            BranchName = "Apple"
                        },
                        new
                        {
                            Id = new Guid("d0426967-668d-4e34-a139-8b86c1defb46"),
                            BranchName = "Samsung"
                        });
                });

            modelBuilder.Entity("DomainLayer.Entities.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("DomainLayer.Entities.CartProduct", b =>
                {
                    b.Property<Guid>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("DomainLayer.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("61cff61b-a84a-4002-b8dc-029cafc60408"),
                            CategoryName = "Smart Phone"
                        },
                        new
                        {
                            Id = new Guid("d1f44292-46b0-4ca3-a38a-020ce138c88b"),
                            CategoryName = "Laptop"
                        });
                });

            modelBuilder.Entity("DomainLayer.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CartId")
                        .IsUnique()
                        .HasFilter("[CartId] IS NOT NULL");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DomainLayer.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("DiscountPercentage")
                        .HasColumnType("real");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cc234dc4-9833-49de-8e17-4d2794ccf444"),
                            BranchId = new Guid("5b10514f-33ca-41d2-b6df-95fc1fd95e5a"),
                            CategoryId = new Guid("61cff61b-a84a-4002-b8dc-029cafc60408"),
                            Description = "This is a evoluntion in 2024 of smart phone ever",
                            DiscountPercentage = 5f,
                            Images = "https://cdn.dummyjson.com/product-images/2/1.jpg,https://cdn.dummyjson.com/product-images/2/2.jpg,https://cdn.dummyjson.com/product-images/2/3.jpg",
                            Price = 1500m,
                            Rating = 0f,
                            Stock = 200,
                            Thumbnail = "https://cdn.dummyjson.com/product-images/2/thumbnail.jpg",
                            Title = "Iphone X"
                        },
                        new
                        {
                            Id = new Guid("bbbcbd00-425b-47f5-83bf-1b4f83df5f37"),
                            BranchId = new Guid("d0426967-668d-4e34-a139-8b86c1defb46"),
                            CategoryId = new Guid("61cff61b-a84a-4002-b8dc-029cafc60408"),
                            Description = "This is a best smart phone for bussiness in next 100 years",
                            DiscountPercentage = 10f,
                            Images = "https://cdn.dummyjson.com/product-images/3/1.jpg,https://cdn.dummyjson.com/product-images/2/3.jpg",
                            Price = 1000m,
                            Rating = 0f,
                            Stock = 400,
                            Thumbnail = "https://cdn.dummyjson.com/product-images/3/thumbnail.jpg",
                            Title = "Samsung Universe 9"
                        },
                        new
                        {
                            Id = new Guid("687832a9-e35c-4c31-b7a0-555810f670e1"),
                            BranchId = new Guid("5b10514f-33ca-41d2-b6df-95fc1fd95e5a"),
                            CategoryId = new Guid("d1f44292-46b0-4ca3-a38a-020ce138c88b"),
                            Description = "MacBook Pro 2021 with mini-LED display may launch between September, November",
                            DiscountPercentage = 15f,
                            Images = "https://cdn.dummyjson.com/product-images/6/1.png,https://cdn.dummyjson.com/product-images/6/2.jpg",
                            Price = 2500m,
                            Rating = 0f,
                            Stock = 300,
                            Thumbnail = "https://cdn.dummyjson.com/product-images/6/thumbnail.png",
                            Title = "MacBook Pro"
                        },
                        new
                        {
                            Id = new Guid("e8639e69-430e-4275-b1d5-015e73358f1b"),
                            BranchId = new Guid("d0426967-668d-4e34-a139-8b86c1defb46"),
                            CategoryId = new Guid("d1f44292-46b0-4ca3-a38a-020ce138c88b"),
                            Description = "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched",
                            DiscountPercentage = 20f,
                            Images = "https://cdn.dummyjson.com/product-images/7/1.jpg,https://cdn.dummyjson.com/product-images/7/2.jpg",
                            Price = 1499m,
                            Rating = 0f,
                            Stock = 100,
                            Thumbnail = "https://cdn.dummyjson.com/product-images/7/thumbnail.jpg",
                            Title = "Samsung Galaxy Book"
                        });
                });

            modelBuilder.Entity("DomainLayer.Entities.CartProduct", b =>
                {
                    b.HasOne("DomainLayer.Entities.Cart", "Cart")
                        .WithMany("CartProducts")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Entities.Product", "Product")
                        .WithMany("CartProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DomainLayer.Entities.Customer", b =>
                {
                    b.HasOne("DomainLayer.Entities.Cart", "Cart")
                        .WithOne("Customer")
                        .HasForeignKey("DomainLayer.Entities.Customer", "CartId");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("DomainLayer.Entities.Product", b =>
                {
                    b.HasOne("DomainLayer.Entities.Branch", "Branch")
                        .WithMany("Products")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DomainLayer.Entities.Branch", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DomainLayer.Entities.Cart", b =>
                {
                    b.Navigation("CartProducts");

                    b.Navigation("Customer")
                        .IsRequired();
                });

            modelBuilder.Entity("DomainLayer.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DomainLayer.Entities.Product", b =>
                {
                    b.Navigation("CartProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
