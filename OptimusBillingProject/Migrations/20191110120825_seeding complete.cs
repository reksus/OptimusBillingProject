using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OptimusBillingProject.Migrations
{
    public partial class seedingcomplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonthYearId",
                table: "MonthlyProjectData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MonthYear",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthYear", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectLockedUnlockedHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionPerformed = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    MonthlyProjectDataId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectLockedUnlockedHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectLockedUnlockedHistory_MonthlyProjectData_MonthlyProjectDataId",
                        column: x => x.MonthlyProjectDataId,
                        principalTable: "MonthlyProjectData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SOW",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SowIdKickoff = table.Column<int>(nullable: false),
                    BilledHours = table.Column<float>(nullable: false),
                    APContactEmail = table.Column<string>(nullable: true),
                    IsCheckedByPmo = table.Column<bool>(nullable: false),
                    IsCheckedByDeliveryHead = table.Column<bool>(nullable: false),
                    IncidentalCost = table.Column<float>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    MonthlyProjectDataId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOW", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SOW_MonthlyProjectData_MonthlyProjectDataId",
                        column: x => x.MonthlyProjectDataId,
                        principalTable: "MonthlyProjectData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkItemIdKickoff = table.Column<int>(nullable: false),
                    IsFixedCost = table.Column<bool>(nullable: false),
                    SOWId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkItem_SOW_SOWId",
                        column: x => x.SOWId,
                        principalTable: "SOW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FixedCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyChargeableFee = table.Column<float>(nullable: false),
                    ChargeableHours = table.Column<float>(nullable: false),
                    RemarksForAdjustedHours = table.Column<string>(nullable: true),
                    ChargedFee = table.Column<float>(nullable: false),
                    WorkItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FixedCost_WorkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalTable: "WorkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceHours = table.Column<float>(nullable: false),
                    IsSameAsRedmine = table.Column<bool>(nullable: false),
                    RemarksForAdjusted = table.Column<string>(nullable: true),
                    ResourceIdKickoff = table.Column<int>(nullable: false),
                    WorkItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resource_WorkItem_WorkItemId",
                        column: x => x.WorkItemId,
                        principalTable: "WorkItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MonthYear",
                columns: new[] { "Id", "Month", "Year" },
                values: new object[,]
                {
                    { 1, 10, 2019 },
                    { 2, 11, 2019 },
                    { 3, 12, 2019 },
                    { 4, 10, 2018 },
                    { 5, 11, 2018 }
                });

            migrationBuilder.InsertData(
                table: "ProjectLockedUnlockedHistory",
                columns: new[] { "Id", "ActionPerformed", "MonthlyProjectDataId", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 1, "freezed", 1, "Head", new DateTime(2019, 11, 10, 17, 38, 24, 130, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.InsertData(
                table: "SOW",
                columns: new[] { "Id", "APContactEmail", "BilledHours", "IncidentalCost", "IsCheckedByDeliveryHead", "IsCheckedByPmo", "MonthlyProjectDataId", "Remarks", "SowIdKickoff" },
                values: new object[,]
                {
                    { 1, "monkeymedia@gmail.com", 100f, 0f, false, false, 1, null, 1 },
                    { 2, "monkeymedia@gmail.com", 150f, 0f, false, false, 1, null, 2 },
                    { 3, "monkeymedia@gmail.com", 200f, 0f, false, false, 1, null, 3 },
                    { 4, "avigilon@gmail.com", 200f, 0f, false, false, 2, null, 4 }
                });

            migrationBuilder.UpdateData(
                table: "MonthlyProjectData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsLocked", "MonthYearId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "MonthlyProjectData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsLocked", "MonthYearId" },
                values: new object[] { false, 2 });

            migrationBuilder.UpdateData(
                table: "MonthlyProjectData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsLocked", "MonthYearId" },
                values: new object[] { false, 1 });

            migrationBuilder.UpdateData(
                table: "MonthlyProjectData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsLocked", "MonthYearId" },
                values: new object[] { false, 4 });

            migrationBuilder.UpdateData(
                table: "MonthlyProjectData",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsLocked", "MonthYearId" },
                values: new object[] { false, 5 });

            migrationBuilder.InsertData(
                table: "WorkItem",
                columns: new[] { "Id", "IsFixedCost", "SOWId", "WorkItemIdKickoff" },
                values: new object[,]
                {
                    { 1, true, 2, 1 },
                    { 2, false, 2, 2 },
                    { 3, true, 3, 3 },
                    { 4, false, 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "FixedCost",
                columns: new[] { "Id", "ChargeableHours", "ChargedFee", "MonthlyChargeableFee", "RemarksForAdjustedHours", "WorkItemId" },
                values: new object[] { 1, 300f, 200f, 100f, "adjusted factor", 2 });

            migrationBuilder.InsertData(
                table: "Resource",
                columns: new[] { "Id", "IsSameAsRedmine", "RemarksForAdjusted", "ResourceHours", "ResourceIdKickoff", "WorkItemId" },
                values: new object[,]
                {
                    { 3, true, null, 50f, 3, 1 },
                    { 4, true, null, 30f, 4, 2 },
                    { 1, true, null, 20f, 1, 4 },
                    { 2, true, null, 40f, 2, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyProjectData_MonthYearId",
                table: "MonthlyProjectData",
                column: "MonthYearId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedCost_WorkItemId",
                table: "FixedCost",
                column: "WorkItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectLockedUnlockedHistory_MonthlyProjectDataId",
                table: "ProjectLockedUnlockedHistory",
                column: "MonthlyProjectDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_WorkItemId",
                table: "Resource",
                column: "WorkItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SOW_MonthlyProjectDataId",
                table: "SOW",
                column: "MonthlyProjectDataId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItem_SOWId",
                table: "WorkItem",
                column: "SOWId");

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyProjectData_MonthYear_MonthYearId",
                table: "MonthlyProjectData",
                column: "MonthYearId",
                principalTable: "MonthYear",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyProjectData_MonthYear_MonthYearId",
                table: "MonthlyProjectData");

            migrationBuilder.DropTable(
                name: "FixedCost");

            migrationBuilder.DropTable(
                name: "MonthYear");

            migrationBuilder.DropTable(
                name: "ProjectLockedUnlockedHistory");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "WorkItem");

            migrationBuilder.DropTable(
                name: "SOW");

            migrationBuilder.DropIndex(
                name: "IX_MonthlyProjectData_MonthYearId",
                table: "MonthlyProjectData");

            migrationBuilder.DropColumn(
                name: "MonthYearId",
                table: "MonthlyProjectData");

            migrationBuilder.UpdateData(
                table: "MonthlyProjectData",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsLocked",
                value: true);

            migrationBuilder.UpdateData(
                table: "MonthlyProjectData",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsLocked",
                value: true);

            migrationBuilder.UpdateData(
                table: "MonthlyProjectData",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsLocked",
                value: true);

            migrationBuilder.UpdateData(
                table: "MonthlyProjectData",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsLocked",
                value: true);

            migrationBuilder.UpdateData(
                table: "MonthlyProjectData",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsLocked",
                value: true);
        }
    }
}
