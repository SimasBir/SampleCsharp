﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1215EFCoreShopApp.Data;

namespace _1215EFCoreShopApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211216162050_data-seed")]
    partial class dataseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1215EFCoreShopApp.Models.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Groceries"
                        });
                });

            modelBuilder.Entity("_1215EFCoreShopApp.Models.ShopItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ShopItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpiryDate = new DateTime(2021, 12, 16, 16, 20, 49, 930, DateTimeKind.Utc).AddTicks(4886),
                            Name = "Phone",
                            ShopId = 1
                        },
                        new
                        {
                            Id = 2,
                            ExpiryDate = new DateTime(2021, 12, 16, 16, 20, 49, 930, DateTimeKind.Utc).AddTicks(5276),
                            Name = "Bread",
                            ShopId = 2
                        },
                        new
                        {
                            Id = 3,
                            ExpiryDate = new DateTime(2021, 12, 16, 16, 20, 49, 930, DateTimeKind.Utc).AddTicks(5280),
                            Name = "TV",
                            ShopId = 1
                        },
                        new
                        {
                            Id = 4,
                            ExpiryDate = new DateTime(2021, 12, 16, 16, 20, 49, 930, DateTimeKind.Utc).AddTicks(5281),
                            Name = "Milk",
                            ShopId = 2
                        },
                        new
                        {
                            Id = 5,
                            ExpiryDate = new DateTime(2021, 12, 16, 16, 20, 49, 930, DateTimeKind.Utc).AddTicks(5283),
                            Name = "Beef",
                            ShopId = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
