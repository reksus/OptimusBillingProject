using Microsoft.EntityFrameworkCore;
using OptimusBillingProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Extensions
{
    public static class DbContextModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    LastBilledDate = DateTime.Today,
                    TotalBilledHours = 200,
                    TotalBilledAmount = 200,
                },
                new Project
                {
                    Id = 2,
                    LastBilledDate = DateTime.Today,
                    TotalBilledHours = 250,
                    TotalBilledAmount = 250
                },
                new Project
                {
                    Id = 3,
                    LastBilledDate = DateTime.Today,
                    TotalBilledHours = 300,
                    TotalBilledAmount = 300
                },
                new Project
                {
                    Id = 4,
                    LastBilledDate = DateTime.Today,
                    TotalBilledHours = 400,
                    TotalBilledAmount = 400
                }
            );

            modelBuilder.Entity<MonthlyProjectData>().HasData(
                new MonthlyProjectData
                {
                    Id = 1,
                    ProjectId = 1,
                    MonthlyBilledAmount = 50,
                    MonthlyBilledHours = 50,
                    LastUpdatedOn = DateTime.Parse("11/5/2019"),
                    IsLocked = false,
                    MonthYearId = 2,
                },
                new MonthlyProjectData
                {
                    Id = 2,
                    ProjectId = 2,
                    MonthlyBilledAmount = 100,
                    MonthlyBilledHours = 100,
                    LastUpdatedOn = DateTime.Parse("11/1/2019"),
                    IsLocked = false,
                    MonthYearId = 2,
                },
                new MonthlyProjectData
                {
                    Id = 3,
                    ProjectId = 3,
                    MonthlyBilledAmount = 150,
                    MonthlyBilledHours = 150,
                    LastUpdatedOn = DateTime.Parse("10/20/2019"),
                    IsLocked = false,
                    MonthYearId = 1,
                },
                new MonthlyProjectData
                {
                    Id = 4,
                    ProjectId = 2,
                    MonthlyBilledAmount = 100,
                    MonthlyBilledHours = 100,
                    LastUpdatedOn = DateTime.Parse("10/5/2018"),
                    IsLocked = false,
                    MonthYearId = 4,
                },
                new MonthlyProjectData
                {
                    Id = 5,
                    ProjectId = 4,
                    MonthlyBilledAmount = 200,
                    MonthlyBilledHours = 200,
                    LastUpdatedOn = DateTime.Parse("11/5/2018"),
                    IsLocked = false,
                    MonthYearId = 5,
                }
            );
            modelBuilder.Entity<MonthYear>().HasData(
    new MonthYear
    {
        Id = 1,
        Month = 10,
        Year = 2019
    },
    new MonthYear
    {
        Id = 2,
        Month = 11,
        Year = 2019
    },
    new MonthYear
    {
        Id = 3,
        Month = 12,
        Year = 2019
    },
    new MonthYear
    {
        Id = 4,
        Month = 10,
        Year = 2018
    },
    new MonthYear
    {
        Id = 5,
        Month = 11,
        Year = 2018
    }
);


            modelBuilder.Entity<ProjectLockedUnlockedHistory>().HasData(
                new ProjectLockedUnlockedHistory
                {
                    Id = 1,
                    ActionPerformed = "freezed",
                    UpdatedBy = "Head",
                    UpdatedOn = DateTime.Now,
                    MonthlyProjectDataId = 1
                }
            );

            modelBuilder.Entity<SOW>().HasData(
                new SOW
                {
                    Id = 1,
                    MonthlyProjectDataId = 1,
                    SowIdKickoff = 1,
                    BilledHours = 100,
                    APContactEmail = "monkeymedia@gmail.com",
                    IsCheckedByDeliveryHead = false,
                    IsCheckedByPmo = false,
                },
                new SOW
                {
                    Id = 2,
                    MonthlyProjectDataId = 1,
                    SowIdKickoff = 2,
                    BilledHours = 150,
                    APContactEmail = "monkeymedia@gmail.com",
                    IsCheckedByDeliveryHead = false,
                    IsCheckedByPmo = false,
                },
                new SOW
                {
                    Id = 3,
                    MonthlyProjectDataId = 1,
                    SowIdKickoff = 3,
                    BilledHours = 200,
                    APContactEmail = "monkeymedia@gmail.com",
                    IsCheckedByDeliveryHead = false,
                    IsCheckedByPmo = false,
                },
                new SOW
                {
                    Id = 4,
                    MonthlyProjectDataId = 2,
                    SowIdKickoff = 4,
                    BilledHours = 200,
                    APContactEmail = "avigilon@gmail.com",
                    IsCheckedByDeliveryHead = false,
                    IsCheckedByPmo = false,
                }
            );

            modelBuilder.Entity<WorkItem>().HasData(
                new WorkItem
                {
                    Id = 1,
                    SOWId = 2,
                    WorkItemIdKickoff = 1,
                    IsFixedCost = true,
                },
                new WorkItem
                {
                    Id = 2,
                    SOWId = 2,
                    WorkItemIdKickoff = 2,
                    IsFixedCost = false,
                },
                new WorkItem
                {
                    Id = 3,
                    SOWId = 3,
                    WorkItemIdKickoff = 3,
                    IsFixedCost = true,
                },
                new WorkItem
                {
                    Id = 4,
                    SOWId = 3,
                    WorkItemIdKickoff = 4,
                    IsFixedCost = false,
                }
            );


            modelBuilder.Entity<Resource>().HasData(
                new Resource
                {
                    Id = 1,
                    ResourceHours = 20,
                    IsSameAsRedmine = true,
                    ResourceIdKickoff = 1,
                    WorkItemId = 4
                },
                new Resource
                {
                    Id = 2,
                    ResourceHours = 40,
                    IsSameAsRedmine = true,
                    ResourceIdKickoff = 2,
                    WorkItemId = 4
                },
                new Resource
                {
                    Id = 3,
                    ResourceHours = 50,
                    IsSameAsRedmine = true,
                    ResourceIdKickoff = 3,
                    WorkItemId = 1
                },
                new Resource
                {
                    Id = 4,
                    ResourceHours = 30,
                    IsSameAsRedmine = true,
                    ResourceIdKickoff = 4,
                    WorkItemId = 2
                }
            );

            modelBuilder.Entity<FixedCost>().HasData(
                new FixedCost
                {
                    Id = 1,
                    MonthlyChargeableFee = 100,
                    ChargeableHours = 300,
                    ChargedFee = 200,
                    RemarksForAdjustedHours = "adjusted factor",
                    WorkItemId = 2
                }
            );
        }

        public static void ConfigureEntityProperties(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FixedCost>().Property(p => p.MonthlyChargeableFee).HasColumnName("Monthly_Chargeable_Fee");
            modelBuilder.Entity<FixedCost>().Property(p => p.ChargeableHours).HasColumnName("Chargeable_Hours");
            modelBuilder.Entity<FixedCost>().Property(p => p.RemarksForAdjustedHours).HasColumnName("Remarks_For_Adjusted_Hours");
            modelBuilder.Entity<FixedCost>().Property(p => p.ChargedFee).HasColumnName("Charged_Fee");
            modelBuilder.Entity<FixedCost>().Property(p => p.WorkItemId).HasColumnName("Work_Item_Id");

            modelBuilder.Entity<MonthlyProjectData>().Property(p => p.ProjectId).HasColumnName("Project_Id");
            modelBuilder.Entity<MonthlyProjectData>().Property(p => p.MonthlyBilledAmount).HasColumnName("Monthly_Billed_Amount");
            modelBuilder.Entity<MonthlyProjectData>().Property(p => p.MonthlyBilledHours).HasColumnName("Monthly_Billed_Hours");
            modelBuilder.Entity<MonthlyProjectData>().Property(p => p.LastUpdatedOn).HasColumnName("Last_Updated_On");
            modelBuilder.Entity<MonthlyProjectData>().Property(p => p.IsLocked).HasColumnName("Is_Locked");
            modelBuilder.Entity<MonthlyProjectData>().Property(p => p.MonthYearId).HasColumnName("Month_Year_Id");

            modelBuilder.Entity<Project>().Property(p => p.LastBilledDate).HasColumnName("Last_Billed_Date");
            modelBuilder.Entity<Project>().Property(p => p.TotalBilledAmount).HasColumnName("Total_Billed_Amount");
            modelBuilder.Entity<Project>().Property(p => p.TotalBilledHours).HasColumnName("Total_Billed_Hours");

            modelBuilder.Entity<ProjectLockedUnlockedHistory>().Property(p => p.ActionPerformed).HasColumnName("Action_Performed");
            modelBuilder.Entity<ProjectLockedUnlockedHistory>().Property(p => p.UpdatedBy).HasColumnName("Updated_By");
            modelBuilder.Entity<ProjectLockedUnlockedHistory>().Property(p => p.UpdatedOn).HasColumnName("Updated_On");
            modelBuilder.Entity<ProjectLockedUnlockedHistory>().Property(p => p.MonthlyProjectDataId).HasColumnName("Monthly_Project_Data_Id");

            modelBuilder.Entity<SOW>().Property(p => p.SowIdKickoff).HasColumnName("Sow_Id_Kickoff");
            modelBuilder.Entity<SOW>().Property(p => p.BilledHours).HasColumnName("Billed_Hours");
            modelBuilder.Entity<SOW>().Property(p => p.APContactEmail).HasColumnName("AP_Contact_Email");
            modelBuilder.Entity<SOW>().Property(p => p.IsCheckedByDeliveryHead).HasColumnName("Is_Checked_By_Delivery_Head");
            modelBuilder.Entity<SOW>().Property(p => p.IsCheckedByPmo).HasColumnName("Is_Checked_By_Pmo");
            modelBuilder.Entity<SOW>().Property(p => p.IncidentalCost).HasColumnName("Incidental_Cost");
            modelBuilder.Entity<SOW>().Property(p => p.MonthlyProjectDataId).HasColumnName("Monthly_Project_Id");

            modelBuilder.Entity<WorkItem>().Property(p => p.SOWId).HasColumnName("SOW_Id_Billing");
            modelBuilder.Entity<WorkItem>().Property(p => p.WorkItemIdKickoff).HasColumnName("Work_Item_Id_Kickoff");
            modelBuilder.Entity<WorkItem>().Property(p => p.IsFixedCost).HasColumnName("Is_Fixed_Cost");

            modelBuilder.Entity<Resource>().Property(p => p.ResourceHours).HasColumnName("Resource_Hours");
            modelBuilder.Entity<Resource>().Property(p => p.IsSameAsRedmine).HasColumnName("Is_Same_As_Redmine");
            modelBuilder.Entity<Resource>().Property(p => p.RemarksForAdjusted).HasColumnName("Remarks_For_Adjusted");
            modelBuilder.Entity<Resource>().Property(p => p.WorkItemId).HasColumnName("Work_Item_Id");
        }
    }
}
