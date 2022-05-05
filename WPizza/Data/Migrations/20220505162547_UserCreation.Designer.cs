﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WPizza.Data;

#nullable disable

namespace WPizza.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220505162547_UserCreation")]
    partial class UserCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WPizza.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vegetarian"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Beverage"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Desserts"
                        });
                });

            modelBuilder.Entity("WPizza.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("TotalValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WPizza.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Creamy white garlic sauce, mozzarella, and Freshslice cheddar.",
                            ImageUrl = "",
                            Name = "Cheese Pizza",
                            Price = 3m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Description = "",
                            ImageUrl = "",
                            Name = "Water (500 ml)",
                            Price = 1.5m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            Description = "Delicious, rich and sweet filo pastry dessert with nuts.",
                            ImageUrl = "",
                            Name = "Baklava",
                            Price = 3.49m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "",
                            ImageUrl = "",
                            Name = "Coke",
                            Price = 2m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Field greens, quinoa, feta cheese, dried cranberries, beet slaw, strawberries, carrots, balsamic vinaigrette.",
                            ImageUrl = "",
                            Name = "Market Salad",
                            Price = 12.7m
                        });
                });

            modelBuilder.Entity("WPizza.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "12345 Mains St.",
                            Name = "Wallace Torres",
                            Phone = "+1 222-333-4444"
                        },
                        new
                        {
                            Id = 2,
                            Address = "12345 Mains St.",
                            Name = "Andreza Carvalho",
                            Phone = "+1 222-333-5555"
                        });
                });

            modelBuilder.Entity("WPizza.Domain.Entities.Product", b =>
                {
                    b.HasOne("WPizza.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}