using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITDepartment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedingDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Printer" },
                    { 2, "Laptop" },
                    { 3, "Desktop" },
                    { 4, "Router" },
                    { 5, "Switch" },
                    { 6, "Monitor" },
                    { 7, "Scanner" },
                    { 8, "Webcam" },
                    { 9, "Server" },
                    { 10, "Access Point" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "AcquisitionDate", "CategoryId", "Memo", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(876), 1, "Office printer", "HP Printer" },
                    { 2, new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(925), 2, "Development laptop", "Dell Laptop" },
                    { 3, new DateTime(2021, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(928), 3, "Design workstation", "iMac Desktop" },
                    { 4, new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(931), 4, "Main office router", "Cisco Router" },
                    { 5, new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(933), 5, "Network switch", "Netgear Switch" },
                    { 6, new DateTime(2022, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(935), 6, "Office monitor", "Samsung Monitor" },
                    { 7, new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(938), 7, "Office scanner", "Epson Scanner" },
                    { 8, new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(940), 8, "Video conference webcam", "Logitech Webcam" },
                    { 9, new DateTime(2021, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(942), 9, "Database server", "Dell Server" },
                    { 10, new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(945), 10, "Wi-Fi access point", "TP-Link Access Point" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "IP Address" },
                    { 2, 1, "Is Color" },
                    { 3, 2, "Processor" },
                    { 4, 2, "RAM" },
                    { 5, 2, "Display" },
                    { 6, 5, "Ports" },
                    { 7, 5, "Speed" },
                    { 8, 2, "Brand" },
                    { 9, 6, "Resolution" },
                    { 10, 7, "Scanning Resolution" }
                });

            migrationBuilder.InsertData(
                table: "PropertyValues",
                columns: new[] { "Id", "DeviceId", "PropertyId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, "192.168.1.100" },
                    { 2, 1, 2, "Yes" },
                    { 3, 2, 3, "Intel i7" },
                    { 4, 2, 4, "16 GB" },
                    { 5, 2, 8, "Dell" },
                    { 6, 3, 8, "Apple" },
                    { 7, 4, 1, "192.168.1.1" },
                    { 8, 5, 6, "24" },
                    { 9, 6, 9, "1920x1080" },
                    { 10, 7, 10, "4800 dpi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PropertyValues",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
