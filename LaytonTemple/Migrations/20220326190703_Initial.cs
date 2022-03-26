using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonTemple.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvailableTimes",
                columns: table => new
                {
                    TimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeSlot = table.Column<DateTime>(nullable: false),
                    Filled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableTimes", x => x.TimeId);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeId = table.Column<int>(nullable: false),
                    AvailableTimesTimeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Tours_AvailableTimes_AvailableTimesTimeId",
                        column: x => x.AvailableTimesTimeId,
                        principalTable: "AvailableTimes",
                        principalColumn: "TimeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 1, false, new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 61, false, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 60, false, new DateTime(2022, 3, 27, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 59, false, new DateTime(2022, 3, 27, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 58, false, new DateTime(2022, 3, 27, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 57, false, new DateTime(2022, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 56, false, new DateTime(2022, 3, 27, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 55, false, new DateTime(2022, 3, 27, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 54, false, new DateTime(2022, 3, 27, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 53, false, new DateTime(2022, 3, 27, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 52, false, new DateTime(2022, 3, 27, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 51, false, new DateTime(2022, 3, 27, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 50, false, new DateTime(2022, 3, 27, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 49, false, new DateTime(2022, 3, 27, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 48, false, new DateTime(2022, 3, 26, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 47, false, new DateTime(2022, 3, 26, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 46, false, new DateTime(2022, 3, 26, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 45, false, new DateTime(2022, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 62, false, new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 63, false, new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 64, false, new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 65, false, new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 83, false, new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 82, false, new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 81, false, new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 80, false, new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 79, false, new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 78, false, new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 77, false, new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 76, false, new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 44, false, new DateTime(2022, 3, 26, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 75, false, new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 73, false, new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 72, false, new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 71, false, new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 70, false, new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 69, false, new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 68, false, new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 67, false, new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 66, false, new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 74, false, new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 84, false, new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 43, false, new DateTime(2022, 3, 26, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 41, false, new DateTime(2022, 3, 26, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 18, false, new DateTime(2022, 3, 24, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 17, false, new DateTime(2022, 3, 24, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 16, false, new DateTime(2022, 3, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 15, false, new DateTime(2022, 3, 24, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 14, false, new DateTime(2022, 3, 24, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 13, false, new DateTime(2022, 3, 24, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 12, false, new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 11, false, new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 10, false, new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 9, false, new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 8, false, new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 7, false, new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 6, false, new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 5, false, new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 4, false, new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 3, false, new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 2, false, new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 19, false, new DateTime(2022, 3, 24, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 20, false, new DateTime(2022, 3, 24, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 21, false, new DateTime(2022, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 22, false, new DateTime(2022, 3, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 40, false, new DateTime(2022, 3, 26, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 39, false, new DateTime(2022, 3, 26, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 38, false, new DateTime(2022, 3, 26, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 37, false, new DateTime(2022, 3, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 36, false, new DateTime(2022, 3, 25, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 35, false, new DateTime(2022, 3, 25, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 34, false, new DateTime(2022, 3, 25, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 33, false, new DateTime(2022, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 42, false, new DateTime(2022, 3, 26, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 32, false, new DateTime(2022, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 30, false, new DateTime(2022, 3, 25, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 29, false, new DateTime(2022, 3, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 28, false, new DateTime(2022, 3, 25, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 27, false, new DateTime(2022, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 26, false, new DateTime(2022, 3, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 25, false, new DateTime(2022, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 24, false, new DateTime(2022, 3, 24, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 23, false, new DateTime(2022, 3, 24, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Filled", "TimeSlot" },
                values: new object[] { 31, false, new DateTime(2022, 3, 25, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "GroupId", "AvailableTimesTimeId", "Email", "GroupName", "GroupSize", "Phone", "TimeId" },
                values: new object[] { 1, null, "test@test.com", "Team 1-1", 3, "801-101-1010", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_AvailableTimesTimeId",
                table: "Tours",
                column: "AvailableTimesTimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "AvailableTimes");
        }
    }
}
