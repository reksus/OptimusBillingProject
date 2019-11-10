using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OptimusBillingProject.Migrations
{
    public partial class correctiondbsetsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FixedCost_WorkItem_WorkItemId",
                table: "FixedCost");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectLockedUnlockedHistory_MonthlyProjectData_MonthlyProjectDataId",
                table: "ProjectLockedUnlockedHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_WorkItem_WorkItemId",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_SOW_MonthlyProjectData_MonthlyProjectDataId",
                table: "SOW");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItem_SOW_SOWId",
                table: "WorkItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkItem",
                table: "WorkItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SOW",
                table: "SOW");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resource",
                table: "Resource");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectLockedUnlockedHistory",
                table: "ProjectLockedUnlockedHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FixedCost",
                table: "FixedCost");

            migrationBuilder.RenameTable(
                name: "WorkItem",
                newName: "WorkItems");

            migrationBuilder.RenameTable(
                name: "SOW",
                newName: "SOWs");

            migrationBuilder.RenameTable(
                name: "Resource",
                newName: "Resources");

            migrationBuilder.RenameTable(
                name: "ProjectLockedUnlockedHistory",
                newName: "ProjectLockedUnlockedHistorys");

            migrationBuilder.RenameTable(
                name: "FixedCost",
                newName: "FixedCosts");

            migrationBuilder.RenameIndex(
                name: "IX_WorkItem_SOWId",
                table: "WorkItems",
                newName: "IX_WorkItems_SOWId");

            migrationBuilder.RenameIndex(
                name: "IX_SOW_MonthlyProjectDataId",
                table: "SOWs",
                newName: "IX_SOWs_MonthlyProjectDataId");

            migrationBuilder.RenameIndex(
                name: "IX_Resource_WorkItemId",
                table: "Resources",
                newName: "IX_Resources_WorkItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectLockedUnlockedHistory_MonthlyProjectDataId",
                table: "ProjectLockedUnlockedHistorys",
                newName: "IX_ProjectLockedUnlockedHistorys_MonthlyProjectDataId");

            migrationBuilder.RenameIndex(
                name: "IX_FixedCost_WorkItemId",
                table: "FixedCosts",
                newName: "IX_FixedCosts_WorkItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkItems",
                table: "WorkItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SOWs",
                table: "SOWs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resources",
                table: "Resources",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectLockedUnlockedHistorys",
                table: "ProjectLockedUnlockedHistorys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FixedCosts",
                table: "FixedCosts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ProjectLockedUnlockedHistorys",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedOn",
                value: new DateTime(2019, 11, 10, 17, 49, 2, 367, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.AddForeignKey(
                name: "FK_FixedCosts_WorkItems_WorkItemId",
                table: "FixedCosts",
                column: "WorkItemId",
                principalTable: "WorkItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectLockedUnlockedHistorys_MonthlyProjectData_MonthlyProjectDataId",
                table: "ProjectLockedUnlockedHistorys",
                column: "MonthlyProjectDataId",
                principalTable: "MonthlyProjectData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_WorkItems_WorkItemId",
                table: "Resources",
                column: "WorkItemId",
                principalTable: "WorkItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SOWs_MonthlyProjectData_MonthlyProjectDataId",
                table: "SOWs",
                column: "MonthlyProjectDataId",
                principalTable: "MonthlyProjectData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_SOWs_SOWId",
                table: "WorkItems",
                column: "SOWId",
                principalTable: "SOWs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FixedCosts_WorkItems_WorkItemId",
                table: "FixedCosts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectLockedUnlockedHistorys_MonthlyProjectData_MonthlyProjectDataId",
                table: "ProjectLockedUnlockedHistorys");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_WorkItems_WorkItemId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_SOWs_MonthlyProjectData_MonthlyProjectDataId",
                table: "SOWs");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_SOWs_SOWId",
                table: "WorkItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkItems",
                table: "WorkItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SOWs",
                table: "SOWs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resources",
                table: "Resources");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectLockedUnlockedHistorys",
                table: "ProjectLockedUnlockedHistorys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FixedCosts",
                table: "FixedCosts");

            migrationBuilder.RenameTable(
                name: "WorkItems",
                newName: "WorkItem");

            migrationBuilder.RenameTable(
                name: "SOWs",
                newName: "SOW");

            migrationBuilder.RenameTable(
                name: "Resources",
                newName: "Resource");

            migrationBuilder.RenameTable(
                name: "ProjectLockedUnlockedHistorys",
                newName: "ProjectLockedUnlockedHistory");

            migrationBuilder.RenameTable(
                name: "FixedCosts",
                newName: "FixedCost");

            migrationBuilder.RenameIndex(
                name: "IX_WorkItems_SOWId",
                table: "WorkItem",
                newName: "IX_WorkItem_SOWId");

            migrationBuilder.RenameIndex(
                name: "IX_SOWs_MonthlyProjectDataId",
                table: "SOW",
                newName: "IX_SOW_MonthlyProjectDataId");

            migrationBuilder.RenameIndex(
                name: "IX_Resources_WorkItemId",
                table: "Resource",
                newName: "IX_Resource_WorkItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectLockedUnlockedHistorys_MonthlyProjectDataId",
                table: "ProjectLockedUnlockedHistory",
                newName: "IX_ProjectLockedUnlockedHistory_MonthlyProjectDataId");

            migrationBuilder.RenameIndex(
                name: "IX_FixedCosts_WorkItemId",
                table: "FixedCost",
                newName: "IX_FixedCost_WorkItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkItem",
                table: "WorkItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SOW",
                table: "SOW",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resource",
                table: "Resource",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectLockedUnlockedHistory",
                table: "ProjectLockedUnlockedHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FixedCost",
                table: "FixedCost",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ProjectLockedUnlockedHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedOn",
                value: new DateTime(2019, 11, 10, 17, 38, 24, 130, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.AddForeignKey(
                name: "FK_FixedCost_WorkItem_WorkItemId",
                table: "FixedCost",
                column: "WorkItemId",
                principalTable: "WorkItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectLockedUnlockedHistory_MonthlyProjectData_MonthlyProjectDataId",
                table: "ProjectLockedUnlockedHistory",
                column: "MonthlyProjectDataId",
                principalTable: "MonthlyProjectData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_WorkItem_WorkItemId",
                table: "Resource",
                column: "WorkItemId",
                principalTable: "WorkItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SOW_MonthlyProjectData_MonthlyProjectDataId",
                table: "SOW",
                column: "MonthlyProjectDataId",
                principalTable: "MonthlyProjectData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItem_SOW_SOWId",
                table: "WorkItem",
                column: "SOWId",
                principalTable: "SOW",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
