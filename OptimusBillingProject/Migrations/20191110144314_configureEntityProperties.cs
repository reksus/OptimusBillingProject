using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OptimusBillingProject.Migrations
{
    public partial class configureEntityProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FixedCosts_WorkItems_WorkItemId",
                table: "FixedCosts");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyProjectData_MonthYear_MonthYearId",
                table: "MonthlyProjectData");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyProjectData_Projects_ProjectId",
                table: "MonthlyProjectData");

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

            migrationBuilder.RenameColumn(
                name: "WorkItemIdKickoff",
                table: "WorkItems",
                newName: "Work_Item_Id_Kickoff");

            migrationBuilder.RenameColumn(
                name: "SOWId",
                table: "WorkItems",
                newName: "SOW_Id_Billing");

            migrationBuilder.RenameColumn(
                name: "IsFixedCost",
                table: "WorkItems",
                newName: "Is_Fixed_Cost");

            migrationBuilder.RenameIndex(
                name: "IX_WorkItems_SOWId",
                table: "WorkItems",
                newName: "IX_WorkItems_SOW_Id_Billing");

            migrationBuilder.RenameColumn(
                name: "SowIdKickoff",
                table: "SOWs",
                newName: "Sow_Id_Kickoff");

            migrationBuilder.RenameColumn(
                name: "MonthlyProjectDataId",
                table: "SOWs",
                newName: "Monthly_Project_Id");

            migrationBuilder.RenameColumn(
                name: "IsCheckedByPmo",
                table: "SOWs",
                newName: "Is_Checked_By_Pmo");

            migrationBuilder.RenameColumn(
                name: "IsCheckedByDeliveryHead",
                table: "SOWs",
                newName: "Is_Checked_By_Delivery_Head");

            migrationBuilder.RenameColumn(
                name: "IncidentalCost",
                table: "SOWs",
                newName: "Incidental_Cost");

            migrationBuilder.RenameColumn(
                name: "BilledHours",
                table: "SOWs",
                newName: "Billed_Hours");

            migrationBuilder.RenameColumn(
                name: "APContactEmail",
                table: "SOWs",
                newName: "AP_Contact_Email");

            migrationBuilder.RenameIndex(
                name: "IX_SOWs_MonthlyProjectDataId",
                table: "SOWs",
                newName: "IX_SOWs_Monthly_Project_Id");

            migrationBuilder.RenameColumn(
                name: "WorkItemId",
                table: "Resources",
                newName: "Work_Item_Id");

            migrationBuilder.RenameColumn(
                name: "ResourceHours",
                table: "Resources",
                newName: "Resource_Hours");

            migrationBuilder.RenameColumn(
                name: "RemarksForAdjusted",
                table: "Resources",
                newName: "Remarks_For_Adjusted");

            migrationBuilder.RenameColumn(
                name: "IsSameAsRedmine",
                table: "Resources",
                newName: "Is_Same_As_Redmine");

            migrationBuilder.RenameIndex(
                name: "IX_Resources_WorkItemId",
                table: "Resources",
                newName: "IX_Resources_Work_Item_Id");

            migrationBuilder.RenameColumn(
                name: "TotalBilledHours",
                table: "Projects",
                newName: "Total_Billed_Hours");

            migrationBuilder.RenameColumn(
                name: "TotalBilledAmount",
                table: "Projects",
                newName: "Total_Billed_Amount");

            migrationBuilder.RenameColumn(
                name: "LastBilledDate",
                table: "Projects",
                newName: "Last_Billed_Date");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "ProjectLockedUnlockedHistorys",
                newName: "Updated_On");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "ProjectLockedUnlockedHistorys",
                newName: "Updated_By");

            migrationBuilder.RenameColumn(
                name: "MonthlyProjectDataId",
                table: "ProjectLockedUnlockedHistorys",
                newName: "Monthly_Project_Data_Id");

            migrationBuilder.RenameColumn(
                name: "ActionPerformed",
                table: "ProjectLockedUnlockedHistorys",
                newName: "Action_Performed");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectLockedUnlockedHistorys_MonthlyProjectDataId",
                table: "ProjectLockedUnlockedHistorys",
                newName: "IX_ProjectLockedUnlockedHistorys_Monthly_Project_Data_Id");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "MonthlyProjectData",
                newName: "Project_Id");

            migrationBuilder.RenameColumn(
                name: "MonthlyBilledHours",
                table: "MonthlyProjectData",
                newName: "Monthly_Billed_Hours");

            migrationBuilder.RenameColumn(
                name: "MonthlyBilledAmount",
                table: "MonthlyProjectData",
                newName: "Monthly_Billed_Amount");

            migrationBuilder.RenameColumn(
                name: "MonthYearId",
                table: "MonthlyProjectData",
                newName: "Month_Year_Id");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedOn",
                table: "MonthlyProjectData",
                newName: "Last_Updated_On");

            migrationBuilder.RenameColumn(
                name: "IsLocked",
                table: "MonthlyProjectData",
                newName: "Is_Locked");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyProjectData_ProjectId",
                table: "MonthlyProjectData",
                newName: "IX_MonthlyProjectData_Project_Id");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyProjectData_MonthYearId",
                table: "MonthlyProjectData",
                newName: "IX_MonthlyProjectData_Month_Year_Id");

            migrationBuilder.RenameColumn(
                name: "WorkItemId",
                table: "FixedCosts",
                newName: "Work_Item_Id");

            migrationBuilder.RenameColumn(
                name: "RemarksForAdjustedHours",
                table: "FixedCosts",
                newName: "Remarks_For_Adjusted_Hours");

            migrationBuilder.RenameColumn(
                name: "MonthlyChargeableFee",
                table: "FixedCosts",
                newName: "Monthly_Chargeable_Fee");

            migrationBuilder.RenameColumn(
                name: "ChargedFee",
                table: "FixedCosts",
                newName: "Charged_Fee");

            migrationBuilder.RenameColumn(
                name: "ChargeableHours",
                table: "FixedCosts",
                newName: "Chargeable_Hours");

            migrationBuilder.RenameIndex(
                name: "IX_FixedCosts_WorkItemId",
                table: "FixedCosts",
                newName: "IX_FixedCosts_Work_Item_Id");

            migrationBuilder.UpdateData(
                table: "ProjectLockedUnlockedHistorys",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated_On",
                value: new DateTime(2019, 11, 10, 20, 13, 13, 643, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.AddForeignKey(
                name: "FK_FixedCosts_WorkItems_Work_Item_Id",
                table: "FixedCosts",
                column: "Work_Item_Id",
                principalTable: "WorkItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyProjectData_MonthYear_Month_Year_Id",
                table: "MonthlyProjectData",
                column: "Month_Year_Id",
                principalTable: "MonthYear",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyProjectData_Projects_Project_Id",
                table: "MonthlyProjectData",
                column: "Project_Id",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectLockedUnlockedHistorys_MonthlyProjectData_Monthly_Project_Data_Id",
                table: "ProjectLockedUnlockedHistorys",
                column: "Monthly_Project_Data_Id",
                principalTable: "MonthlyProjectData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_WorkItems_Work_Item_Id",
                table: "Resources",
                column: "Work_Item_Id",
                principalTable: "WorkItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SOWs_MonthlyProjectData_Monthly_Project_Id",
                table: "SOWs",
                column: "Monthly_Project_Id",
                principalTable: "MonthlyProjectData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_SOWs_SOW_Id_Billing",
                table: "WorkItems",
                column: "SOW_Id_Billing",
                principalTable: "SOWs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FixedCosts_WorkItems_Work_Item_Id",
                table: "FixedCosts");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyProjectData_MonthYear_Month_Year_Id",
                table: "MonthlyProjectData");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyProjectData_Projects_Project_Id",
                table: "MonthlyProjectData");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectLockedUnlockedHistorys_MonthlyProjectData_Monthly_Project_Data_Id",
                table: "ProjectLockedUnlockedHistorys");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_WorkItems_Work_Item_Id",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_SOWs_MonthlyProjectData_Monthly_Project_Id",
                table: "SOWs");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_SOWs_SOW_Id_Billing",
                table: "WorkItems");

            migrationBuilder.RenameColumn(
                name: "Work_Item_Id_Kickoff",
                table: "WorkItems",
                newName: "WorkItemIdKickoff");

            migrationBuilder.RenameColumn(
                name: "SOW_Id_Billing",
                table: "WorkItems",
                newName: "SOWId");

            migrationBuilder.RenameColumn(
                name: "Is_Fixed_Cost",
                table: "WorkItems",
                newName: "IsFixedCost");

            migrationBuilder.RenameIndex(
                name: "IX_WorkItems_SOW_Id_Billing",
                table: "WorkItems",
                newName: "IX_WorkItems_SOWId");

            migrationBuilder.RenameColumn(
                name: "Sow_Id_Kickoff",
                table: "SOWs",
                newName: "SowIdKickoff");

            migrationBuilder.RenameColumn(
                name: "Monthly_Project_Id",
                table: "SOWs",
                newName: "MonthlyProjectDataId");

            migrationBuilder.RenameColumn(
                name: "Is_Checked_By_Pmo",
                table: "SOWs",
                newName: "IsCheckedByPmo");

            migrationBuilder.RenameColumn(
                name: "Is_Checked_By_Delivery_Head",
                table: "SOWs",
                newName: "IsCheckedByDeliveryHead");

            migrationBuilder.RenameColumn(
                name: "Incidental_Cost",
                table: "SOWs",
                newName: "IncidentalCost");

            migrationBuilder.RenameColumn(
                name: "Billed_Hours",
                table: "SOWs",
                newName: "BilledHours");

            migrationBuilder.RenameColumn(
                name: "AP_Contact_Email",
                table: "SOWs",
                newName: "APContactEmail");

            migrationBuilder.RenameIndex(
                name: "IX_SOWs_Monthly_Project_Id",
                table: "SOWs",
                newName: "IX_SOWs_MonthlyProjectDataId");

            migrationBuilder.RenameColumn(
                name: "Work_Item_Id",
                table: "Resources",
                newName: "WorkItemId");

            migrationBuilder.RenameColumn(
                name: "Resource_Hours",
                table: "Resources",
                newName: "ResourceHours");

            migrationBuilder.RenameColumn(
                name: "Remarks_For_Adjusted",
                table: "Resources",
                newName: "RemarksForAdjusted");

            migrationBuilder.RenameColumn(
                name: "Is_Same_As_Redmine",
                table: "Resources",
                newName: "IsSameAsRedmine");

            migrationBuilder.RenameIndex(
                name: "IX_Resources_Work_Item_Id",
                table: "Resources",
                newName: "IX_Resources_WorkItemId");

            migrationBuilder.RenameColumn(
                name: "Total_Billed_Hours",
                table: "Projects",
                newName: "TotalBilledHours");

            migrationBuilder.RenameColumn(
                name: "Total_Billed_Amount",
                table: "Projects",
                newName: "TotalBilledAmount");

            migrationBuilder.RenameColumn(
                name: "Last_Billed_Date",
                table: "Projects",
                newName: "LastBilledDate");

            migrationBuilder.RenameColumn(
                name: "Updated_On",
                table: "ProjectLockedUnlockedHistorys",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "Updated_By",
                table: "ProjectLockedUnlockedHistorys",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Monthly_Project_Data_Id",
                table: "ProjectLockedUnlockedHistorys",
                newName: "MonthlyProjectDataId");

            migrationBuilder.RenameColumn(
                name: "Action_Performed",
                table: "ProjectLockedUnlockedHistorys",
                newName: "ActionPerformed");

            migrationBuilder.RenameIndex(
                name: "IX_ProjectLockedUnlockedHistorys_Monthly_Project_Data_Id",
                table: "ProjectLockedUnlockedHistorys",
                newName: "IX_ProjectLockedUnlockedHistorys_MonthlyProjectDataId");

            migrationBuilder.RenameColumn(
                name: "Project_Id",
                table: "MonthlyProjectData",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "Monthly_Billed_Hours",
                table: "MonthlyProjectData",
                newName: "MonthlyBilledHours");

            migrationBuilder.RenameColumn(
                name: "Monthly_Billed_Amount",
                table: "MonthlyProjectData",
                newName: "MonthlyBilledAmount");

            migrationBuilder.RenameColumn(
                name: "Month_Year_Id",
                table: "MonthlyProjectData",
                newName: "MonthYearId");

            migrationBuilder.RenameColumn(
                name: "Last_Updated_On",
                table: "MonthlyProjectData",
                newName: "LastUpdatedOn");

            migrationBuilder.RenameColumn(
                name: "Is_Locked",
                table: "MonthlyProjectData",
                newName: "IsLocked");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyProjectData_Project_Id",
                table: "MonthlyProjectData",
                newName: "IX_MonthlyProjectData_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyProjectData_Month_Year_Id",
                table: "MonthlyProjectData",
                newName: "IX_MonthlyProjectData_MonthYearId");

            migrationBuilder.RenameColumn(
                name: "Work_Item_Id",
                table: "FixedCosts",
                newName: "WorkItemId");

            migrationBuilder.RenameColumn(
                name: "Remarks_For_Adjusted_Hours",
                table: "FixedCosts",
                newName: "RemarksForAdjustedHours");

            migrationBuilder.RenameColumn(
                name: "Monthly_Chargeable_Fee",
                table: "FixedCosts",
                newName: "MonthlyChargeableFee");

            migrationBuilder.RenameColumn(
                name: "Charged_Fee",
                table: "FixedCosts",
                newName: "ChargedFee");

            migrationBuilder.RenameColumn(
                name: "Chargeable_Hours",
                table: "FixedCosts",
                newName: "ChargeableHours");

            migrationBuilder.RenameIndex(
                name: "IX_FixedCosts_Work_Item_Id",
                table: "FixedCosts",
                newName: "IX_FixedCosts_WorkItemId");

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
                name: "FK_MonthlyProjectData_MonthYear_MonthYearId",
                table: "MonthlyProjectData",
                column: "MonthYearId",
                principalTable: "MonthYear",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyProjectData_Projects_ProjectId",
                table: "MonthlyProjectData",
                column: "ProjectId",
                principalTable: "Projects",
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
    }
}
