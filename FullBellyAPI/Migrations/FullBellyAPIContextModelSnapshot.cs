// <auto-generated />
using System;
using FullBellyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FullBellyAPI.Migrations
{
    [DbContext(typeof(FullBellyAPIContext))]
    partial class FullBellyAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

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

                    b.Property<string>("Quantity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

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
                            Date = new DateTime(2021, 5, 19, 23, 33, 26, 823, DateTimeKind.Utc).AddTicks(3950),
                            Description = "We have left over csa boxes for anyone who wants them.",
                            DonationName = "Veggies",
                            Donor = "Seattle Tilth Alliance",
                            EndTime = "16:00",
                            Lat = 47.527229800000001,
                            Lng = -122.2640512,
                            Quantity = "10",
                            StartTime = "12:00",
                            State = "WA",
                            Zip = "98118"
                        },
                        new
                        {
                            DonationId = 2,
                            Address = "500 Wall St",
                            City = "Seattle",
                            Date = new DateTime(2021, 5, 19, 23, 33, 26, 823, DateTimeKind.Utc).AddTicks(7000),
                            Description = "This is our mobile soup kitchen van. We will operate until the cops crash the party",
                            DonationName = "Biscuits and Gravy",
                            Donor = "Sacred Heart Seattle",
                            EndTime = "20:00",
                            Lat = 47.617812200000003,
                            Lng = -122.3450959,
                            Quantity = "200",
                            StartTime = "9:00",
                            State = "WA",
                            Zip = "98121"
                        },
                        new
                        {
                            DonationId = 3,
                            Address = "2201 E Madison St",
                            City = "Seattle",
                            Date = new DateTime(2021, 5, 19, 23, 33, 26, 823, DateTimeKind.Utc).AddTicks(7000),
                            Description = "We are offering a sit down meal to anyone who cannot afford one. First come first serve. Continuation is based on your kind cooperation",
                            DonationName = "Chicken dinner",
                            Donor = "A Real Restaurant",
                            EndTime = "22:00",
                            Lat = 47.6178326,
                            Lng = -122.30336459999999,
                            Quantity = "20",
                            StartTime = "20:00",
                            State = "WA",
                            Zip = "98112"
                        },
                        new
                        {
                            DonationId = 4,
                            Address = "2025 14th Ave S",
                            City = "Seattle",
                            Date = new DateTime(2021, 5, 19, 23, 33, 26, 823, DateTimeKind.Utc).AddTicks(7000),
                            Description = "Our students are organizing a free sandwich day.",
                            DonationName = "Sandwiches",
                            Donor = "Beacon Hill Elementary",
                            EndTime = "16:00",
                            Lat = 47.585071399999997,
                            Lng = -122.31538860000001,
                            Quantity = "100",
                            StartTime = "14:00",
                            State = "WA",
                            Zip = "98144"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
