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
                    TimeSlot = table.Column<DateTime>(nullable: false)
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
                columns: new[] { "TimeId", "TimeSlot" },
                values: new object[] { 1, new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified) });

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
