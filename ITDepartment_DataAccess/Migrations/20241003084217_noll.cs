using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITDepartment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class noll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "PropertyValues",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Memo",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "AcquisitionDate",
                value: new DateTime(2022, 10, 3, 11, 42, 17, 46, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 3, 11, 42, 17, 46, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3,
                column: "AcquisitionDate",
                value: new DateTime(2021, 10, 3, 11, 42, 17, 46, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 3, 11, 42, 17, 46, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 3, 11, 42, 17, 46, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6,
                column: "AcquisitionDate",
                value: new DateTime(2022, 10, 3, 11, 42, 17, 46, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 3, 11, 42, 17, 46, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 8,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 3, 11, 42, 17, 46, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 9,
                column: "AcquisitionDate",
                value: new DateTime(2021, 10, 3, 11, 42, 17, 46, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 10,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 3, 11, 42, 17, 46, DateTimeKind.Local).AddTicks(6579));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "PropertyValues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Memo",
                table: "Devices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                column: "AcquisitionDate",
                value: new DateTime(2022, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3,
                column: "AcquisitionDate",
                value: new DateTime(2021, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6,
                column: "AcquisitionDate",
                value: new DateTime(2022, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 8,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 9,
                column: "AcquisitionDate",
                value: new DateTime(2021, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 10,
                column: "AcquisitionDate",
                value: new DateTime(2023, 10, 2, 19, 25, 19, 438, DateTimeKind.Local).AddTicks(945));
        }
    }
}
