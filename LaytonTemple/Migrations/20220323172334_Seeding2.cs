using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonTemple.Migrations
{
    public partial class Seeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 6,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 7,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 8,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 9,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 10,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 11,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 12,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 6,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 1, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 7,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 2, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 8,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 3, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 9,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 4, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 10,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 5, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 11,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 6, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 12,
                column: "TimeSlot",
                value: new DateTime(2022, 3, 23, 7, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
