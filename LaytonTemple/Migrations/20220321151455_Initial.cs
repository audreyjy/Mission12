using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonTemple.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AvailableTimes",
            //    columns: table => new
            //    {
            //        TimeId = table.Column<int>(nullable: false)
            //            .Annotation("Sqlite:Autoincrement", true),
            //        Time = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AvailableTimes", x => x.TimeId);
            //    });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(nullable: false),
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
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 1, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 2, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 3, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 4, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 5, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 6, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 7, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 8, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 9, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 10, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 11, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 12, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "AvailableTimes",
                columns: new[] { "TimeId", "Time" },
                values: new object[] { 13, "9:00 PM" });

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
