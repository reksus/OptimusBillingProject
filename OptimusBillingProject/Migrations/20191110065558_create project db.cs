using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OptimusBillingProject.Migrations
{
    public partial class createprojectdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastBilledDate = table.Column<DateTime>(nullable: false),
                    TotalBilledHours = table.Column<float>(nullable: false),
                    TotalBilledAmount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
