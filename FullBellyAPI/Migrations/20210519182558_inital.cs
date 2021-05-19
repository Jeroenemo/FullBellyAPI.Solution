using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FullBellyAPI.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    DonationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Donor = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DonationName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    State = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Zip = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StartTime = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EndTime = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lat = table.Column<double>(type: "double", nullable: false),
                    Lng = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.DonationId);
                });

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "DonationId", "Address", "City", "Date", "DonationName", "Donor", "EndTime", "Lat", "Lng", "StartTime", "State", "Zip" },
                values: new object[,]
                {
                    { 1, "8445 55th Ave S", "Seattle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cheese", "Jeroen", null, 47.527229800000001, -122.2640512, null, "WA", "98118" },
                    { 2, "8445 55th Ave S", "Seattle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "waterloo", "Hannah", null, 47.527229800000001, -122.2640523, null, "WA", "98118" },
                    { 3, "8445 55th Ave S", "Seattle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kibble", "Attila", null, 47.527229800000001, -122.26405870000001, null, "WA", "98118" },
                    { 4, "8445 55th Ave S", "Seattle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "eggs", "Koji", null, 47.527229800000001, -122.2640512, null, "WA", "98118" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donations");
        }
    }
}
