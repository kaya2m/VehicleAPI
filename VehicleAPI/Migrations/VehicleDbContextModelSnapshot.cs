﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleAPI.ApplicationContext;

#nullable disable

namespace VehicleAPI.Migrations
{
    [DbContext(typeof(VehicleDbContext))]
    partial class VehicleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Vehicle");
                });

            modelBuilder.Entity("Entities.Boat", b =>
                {
                    b.HasBaseType("Entities.Vehicle");

                    b.Property<int>("MaxSpeed")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Boat");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            VehicleColor = "blue",
                            VehicleType = "Boat",
                            MaxSpeed = 100
                        },
                        new
                        {
                            Id = 6,
                            VehicleColor = "red",
                            VehicleType = "Boat",
                            MaxSpeed = 123
                        },
                        new
                        {
                            Id = 7,
                            VehicleColor = "black",
                            VehicleType = "Boat",
                            MaxSpeed = 142
                        },
                        new
                        {
                            Id = 8,
                            VehicleColor = "white",
                            VehicleType = "Boat",
                            MaxSpeed = 154
                        });
                });

            modelBuilder.Entity("Entities.Bus", b =>
                {
                    b.HasBaseType("Entities.Vehicle");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Bus");

                    b.HasData(
                        new
                        {
                            Id = 9,
                            VehicleColor = "red",
                            VehicleType = "Bus",
                            Capacity = 36
                        },
                        new
                        {
                            Id = 10,
                            VehicleColor = "white",
                            VehicleType = "Bus",
                            Capacity = 26
                        },
                        new
                        {
                            Id = 11,
                            VehicleColor = "black",
                            VehicleType = "Bus",
                            Capacity = 12
                        },
                        new
                        {
                            Id = 12,
                            VehicleColor = "blue",
                            VehicleType = "Bus",
                            Capacity = 19
                        });
                });

            modelBuilder.Entity("Entities.Car", b =>
                {
                    b.HasBaseType("Entities.Vehicle");

                    b.Property<bool>("HeadlightsStatus")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Car");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            VehicleColor = "blue",
                            VehicleType = "Car",
                            HeadlightsStatus = true
                        },
                        new
                        {
                            Id = 2,
                            VehicleColor = "red",
                            VehicleType = "Car",
                            HeadlightsStatus = true
                        },
                        new
                        {
                            Id = 3,
                            VehicleColor = "white",
                            VehicleType = "Car",
                            HeadlightsStatus = true
                        },
                        new
                        {
                            Id = 4,
                            VehicleColor = "black",
                            VehicleType = "Car",
                            HeadlightsStatus = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
