using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OptimusBillingProject.Migrations
{
    public partial class seedprojectdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "LastBilledDate", "TotalBilledAmount", "TotalBilledHours" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 200f, 200f },
                    { 2, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 250f, 250f },
                    { 3, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 300f, 300f },
                    { 4, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), 400f, 400f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
