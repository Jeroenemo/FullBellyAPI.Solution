// <auto-generated />
using System;
using FullBellyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FullBellyAPI.Migrations
{
    [DbContext(typeof(FullBellyAPIContext))]
    [Migration("20210519182558_inital")]
    partial class inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("FullBellyAPI.Models.Donation", b =>
                {
                    b.Property<int>("DonationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DonationName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Donor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EndTime")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Lat")
                        .HasColumnType("double");

                    b.Property<double>("Lng")
                        .HasColumnType("double");

                    b.Property<string>("StartTime")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Zip")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DonationId");

                    b.ToTable("Donations");

                    b.HasData(
                        new
                        {
                            DonationId = 1,
                            Address = "8445 55th Ave S",
                            City = "Seattle",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonationName = "cheese",
                            Donor = "Jeroen",
                            Lat = 47.527229800000001,
                            Lng = -122.2640512,
                            State = "WA",
                            Zip = "98118"
                        },
                        new
                        {
                            DonationId = 2,
                            Address = "8445 55th Ave S",
                            City = "Seattle",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonationName = "waterloo",
                            Donor = "Hannah",
                            Lat = 47.527229800000001,
                            Lng = -122.2640523,
                            State = "WA",
                            Zip = "98118"
                        },
                        new
                        {
                            DonationId = 3,
                            Address = "8445 55th Ave S",
                            City = "Seattle",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonationName = "kibble",
                            Donor = "Attila",
                            Lat = 47.527229800000001,
                            Lng = -122.26405870000001,
                            State = "WA",
                            Zip = "98118"
                        },
                        new
                        {
                            DonationId = 4,
                            Address = "8445 55th Ave S",
                            City = "Seattle",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonationName = "eggs",
                            Donor = "Koji",
                            Lat = 47.527229800000001,
                            Lng = -122.2640512,
                            State = "WA",
                            Zip = "98118"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
