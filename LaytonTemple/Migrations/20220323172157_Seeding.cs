using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonTemple.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 2, new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 3, new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 4, new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 5, new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 6, new DateTime(2022, 3, 23, 1, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 7, new DateTime(2022, 3, 23, 2, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 8, new DateTime(2022, 3, 23, 3, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 9, new DateTime(2022, 3, 23, 4, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 10, new DateTime(2022, 3, 23, 5, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 11, new DateTime(2022, 3, 23, 6, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 12, new DateTime(2022, 3, 23, 7, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AvailableTimes",
                keyColumn: "TimeId",
                keyValue: 12);
        }
    }
}
