﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _0106HotelApp.Data;

namespace _0106HotelApp.Migrations
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

            modelBuilder.Entity("_0106HotelApp.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Vilnius"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kaunas"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Klaipėda"
                        });
                });

            modelBuilder.Entity("_0106HotelApp.Models.Cleaner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Cleaners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Audronė",
                            Surname = "Audronytė"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            Name = "Jonius",
                            Surname = "Joniauskas"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Name = "Žilas",
                            Surname = "Žilauskas"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 3,
                            Name = "Valė",
                            Surname = "Valėtoja"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 1,
                            Name = "Ramunė",
                            Surname = "Ramunytė"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            Name = "Gintaras",
                            Surname = "Už puse kainos"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 1,
                            Name = "Valerija",
                            Surname = "Valerijytė"
                        });
                });

            modelBuilder.Entity("_0106HotelApp.Models.CleanerRoom", b =>
                {
                    b.Property<int>("CleanerId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<bool>("Cleaned")
                        .HasColumnType("bit");

                    b.HasKey("CleanerId", "RoomId");

                    b.HasIndex("RoomId");

                    b.ToTable("CleanerRooms");
                });

            modelBuilder.Entity("_0106HotelApp.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Centro 10",
                            CityId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Senamiesčio 10",
                            CityId = 3
                        },
                        new
                        {
                            Id = 3,
                            Address = "Valančiaus 1",
                            CityId = 2
                        },
                        new
                        {
                            Id = 4,
                            Address = "Naujininkų 15",
                            CityId = 1
                        },
                        new
                        {
                            Id = 5,
                            Address = "Aušros 1515",
                            CityId = 2
                        },
                        new
                        {
                            Id = 6,
                            Address = "Šnipiškių 3000",
                            CityId = 1
                        },
                        new
                        {
                            Id = 7,
                            Address = "Jūros vidurys",
                            CityId = 3
                        },
                        new
                        {
                            Id = 8,
                            Address = "Donelaičio 110",
                            CityId = 2
                        },
                        new
                        {
                            Id = 9,
                            Address = "Naujamiesčio 18 ",
                            CityId = 1
                        });
                });

            modelBuilder.Entity("_0106HotelApp.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Booked")
                        .HasColumnType("bit");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("_0106HotelApp.Models.Cleaner", b =>
                {
                    b.HasOne("_0106HotelApp.Models.City", null)
                        .WithMany("Cleaners")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_0106HotelApp.Models.CleanerRoom", b =>
                {
                    b.HasOne("_0106HotelApp.Models.Cleaner", "Cleaner")
                        .WithMany("CleanerRooms")
                        .HasForeignKey("CleanerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_0106HotelApp.Models.Room", "Room")
                        .WithMany("CleanerRooms")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cleaner");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("_0106HotelApp.Models.Hotel", b =>
                {
                    b.HasOne("_0106HotelApp.Models.City", null)
                        .WithMany("Hotels")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_0106HotelApp.Models.Room", b =>
                {
                    b.HasOne("_0106HotelApp.Models.Hotel", null)
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_0106HotelApp.Models.City", b =>
                {
                    b.Navigation("Cleaners");

                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("_0106HotelApp.Models.Cleaner", b =>
                {
                    b.Navigation("CleanerRooms");
                });

            modelBuilder.Entity("_0106HotelApp.Models.Hotel", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("_0106HotelApp.Models.Room", b =>
                {
                    b.Navigation("CleanerRooms");
                });
#pragma warning restore 612, 618
        }
    }
}
