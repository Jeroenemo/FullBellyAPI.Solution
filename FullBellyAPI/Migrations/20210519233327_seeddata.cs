using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FullBellyAPI.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 1,
                columns: new[] { "Date", "Description", "DonationName", "Donor", "EndTime", "Quantity", "StartTime" },
                values: new object[] { new DateTime(2021, 5, 19, 23, 33, 26, 823, DateTimeKind.Utc).AddTicks(3950), "We have left over csa boxes for anyone who wants them.", "Veggies", "Seattle Tilth Alliance", "16:00", "10", "12:00" });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Description", "DonationName", "Donor", "EndTime", "Lat", "Lng", "Quantity", "StartTime", "Zip" },
                values: new object[] { "500 Wall St", new DateTime(2021, 5, 19, 23, 33, 26, 823, DateTimeKind.Utc).AddTicks(7000), "This is our mobile soup kitchen van. We will operate until the cops crash the party", "Biscuits and Gravy", "Sacred Heart Seattle", "20:00", 47.617812200000003, -122.3450959, "200", "9:00", "98121" });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 3,
                columns: new[] { "Address", "Date", "Description", "DonationName", "Donor", "EndTime", "Lat", "Lng", "Quantity", "StartTime", "Zip" },
                values: new object[] { "2201 E Madison St", new DateTime(2021, 5, 19, 23, 33, 26, 823, DateTimeKind.Utc).AddTicks(7000), "We are offering a sit down meal to anyone who cannot afford one. First come first serve. Continuation is based on your kind cooperation", "Chicken dinner", "A Real Restaurant", "22:00", 47.6178326, -122.30336459999999, "20", "20:00", "98112" });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Description", "DonationName", "Donor", "EndTime", "Lat", "Lng", "Quantity", "StartTime", "Zip" },
                values: new object[] { "2025 14th Ave S", new DateTime(2021, 5, 19, 23, 33, 26, 823, DateTimeKind.Utc).AddTicks(7000), "Our students are organizing a free sandwich day.", "Sandwiches", "Beacon Hill Elementary", "16:00", 47.585071399999997, -122.31538860000001, "100", "14:00", "98144" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 1,
                columns: new[] { "Date", "Description", "DonationName", "Donor", "EndTime", "Quantity", "StartTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "cheese", "Jeroen", null, null, null });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 2,
                columns: new[] { "Address", "Date", "Description", "DonationName", "Donor", "EndTime", "Lat", "Lng", "Quantity", "StartTime", "Zip" },
                values: new object[] { "8445 55th Ave S", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "waterloo", "Hannah", null, 47.527229800000001, -122.2640523, null, null, "98118" });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 3,
                columns: new[] { "Address", "Date", "Description", "DonationName", "Donor", "EndTime", "Lat", "Lng", "Quantity", "StartTime", "Zip" },
                values: new object[] { "8445 55th Ave S", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "kibble", "Attila", null, 47.527229800000001, -122.26405870000001, null, null, "98118" });

            migrationBuilder.UpdateData(
                table: "Donations",
                keyColumn: "DonationId",
                keyValue: 4,
                columns: new[] { "Address", "Date", "Description", "DonationName", "Donor", "EndTime", "Lat", "Lng", "Quantity", "StartTime", "Zip" },
                values: new object[] { "8445 55th Ave S", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "eggs", "Koji", null, 47.527229800000001, -122.2640512, null, null, "98118" });
        }
    }
}
