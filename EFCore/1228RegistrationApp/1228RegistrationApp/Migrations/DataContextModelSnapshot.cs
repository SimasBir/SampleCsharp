﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1228RegistrationApp.Data;

namespace _1228RegistrationApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1228RegistrationApp.Models.Prompt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ValueGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("ValueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ValueId");

                    b.ToTable("Prompts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Reikia atlikti rangos darbus",
                            ValueGroupId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Rangos Darbus atliks",
                            ValueGroupId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Verslo klientas",
                            ValueGroupId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Skaičiavimo metodas",
                            ValueGroupId = 3
                        },
                        new
                        {
                            Id = 5,
                            Description = "Svarbus klientas",
                            ValueGroupId = 1
                        });
                });

            modelBuilder.Entity("_1228RegistrationApp.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ValueGroup")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Taip",
                            ValueGroup = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ne",
                            ValueGroup = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Metinis rangovas",
                            ValueGroup = 2
                        },
                        new
                        {
                            Id = 4,
                            Description = "Operatorius",
                            ValueGroup = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "Automatinis",
                            ValueGroup = 3
                        },
                        new
                        {
                            Id = 6,
                            Description = "Manualus",
                            ValueGroup = 3
                        });
                });

            modelBuilder.Entity("_1228RegistrationApp.Models.Prompt", b =>
                {
                    b.HasOne("_1228RegistrationApp.Models.Value", "Values")
                        .WithMany()
                        .HasForeignKey("ValueId");

                    b.Navigation("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
