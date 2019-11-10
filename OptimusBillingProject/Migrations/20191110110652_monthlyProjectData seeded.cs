using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OptimusBillingProject.Migrations
{
    public partial class monthlyProjectDataseeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonthlyProjectData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyBilledAmount = table.Column<float>(nullable: false),
                    MonthlyBilledHours = table.Column<float>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    IsLocked = table.Column<bool>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyProjectData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonthlyProjectData_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MonthlyProjectData",
                columns: new[] { "Id", "IsLocked", "LastUpdatedOn", "MonthlyBilledAmount", "MonthlyBilledHours", "ProjectId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50f, 50f, 1 },
                    { 2, true, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 100f, 2 },
                    { 3, true, new DateTime(2019, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 150f, 150f, 3 },
                    { 4, true, new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 100f, 100f, 2 },
                    { 5, true, new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 200f, 200f, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyProjectData_ProjectId",
                table: "MonthlyProjectData",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyProjectData");
        }
    }
}
