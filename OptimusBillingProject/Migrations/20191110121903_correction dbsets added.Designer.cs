﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OptimusBillingProject.Models;

namespace OptimusBillingProject.Migrations
{
    [DbContext(typeof(BillingDbContext))]
    [Migration("20191110121903_correction dbsets added")]
    partial class correctiondbsetsadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OptimusBillingProject.Entity.FixedCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("ChargeableHours")
                        .HasColumnType("real");

                    b.Property<float>("ChargedFee")
                        .HasColumnType("real");

                    b.Property<float>("MonthlyChargeableFee")
                        .HasColumnType("real");

                    b.Property<string>("RemarksForAdjustedHours")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkItemId")
                        .IsUnique();

                    b.ToTable("FixedCosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChargeableHours = 300f,
                            ChargedFee = 200f,
                            MonthlyChargeableFee = 100f,
                            RemarksForAdjustedHours = "adjusted factor",
                            WorkItemId = 2
                        });
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.MonthYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MonthYear");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Month = 10,
                            Year = 2019
                        },
                        new
                        {
                            Id = 2,
                            Month = 11,
                            Year = 2019
                        },
                        new
                        {
                            Id = 3,
                            Month = 12,
                            Year = 2019
                        },
                        new
                        {
                            Id = 4,
                            Month = 10,
                            Year = 2018
                        },
                        new
                        {
                            Id = 5,
                            Month = 11,
                            Year = 2018
                        });
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.MonthlyProjectData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("MonthYearId")
                        .HasColumnType("int");

                    b.Property<float>("MonthlyBilledAmount")
                        .HasColumnType("real");

                    b.Property<float>("MonthlyBilledHours")
                        .HasColumnType("real");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MonthYearId");

                    b.HasIndex("ProjectId");

                    b.ToTable("MonthlyProjectData");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsLocked = false,
                            LastUpdatedOn = new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MonthYearId = 2,
                            MonthlyBilledAmount = 50f,
                            MonthlyBilledHours = 50f,
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsLocked = false,
                            LastUpdatedOn = new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MonthYearId = 2,
                            MonthlyBilledAmount = 100f,
                            MonthlyBilledHours = 100f,
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            IsLocked = false,
                            LastUpdatedOn = new DateTime(2019, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MonthYearId = 1,
                            MonthlyBilledAmount = 150f,
                            MonthlyBilledHours = 150f,
                            ProjectId = 3
                        },
                        new
                        {
                            Id = 4,
                            IsLocked = false,
                            LastUpdatedOn = new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MonthYearId = 4,
                            MonthlyBilledAmount = 100f,
                            MonthlyBilledHours = 100f,
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 5,
                            IsLocked = false,
                            LastUpdatedOn = new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MonthYearId = 5,
                            MonthlyBilledAmount = 200f,
                            MonthlyBilledHours = 200f,
                            ProjectId = 4
                        });
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LastBilledDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("TotalBilledAmount")
                        .HasColumnType("real");

                    b.Property<float>("TotalBilledHours")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastBilledDate = new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalBilledAmount = 200f,
                            TotalBilledHours = 200f
                        },
                        new
                        {
                            Id = 2,
                            LastBilledDate = new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalBilledAmount = 250f,
                            TotalBilledHours = 250f
                        },
                        new
                        {
                            Id = 3,
                            LastBilledDate = new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalBilledAmount = 300f,
                            TotalBilledHours = 300f
                        },
                        new
                        {
                            Id = 4,
                            LastBilledDate = new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            TotalBilledAmount = 400f,
                            TotalBilledHours = 400f
                        });
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.ProjectLockedUnlockedHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionPerformed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthlyProjectDataId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MonthlyProjectDataId");

                    b.ToTable("ProjectLockedUnlockedHistorys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActionPerformed = "freezed",
                            MonthlyProjectDataId = 1,
                            UpdatedBy = "Head",
                            UpdatedOn = new DateTime(2019, 11, 10, 17, 49, 2, 367, DateTimeKind.Local).AddTicks(3510)
                        });
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsSameAsRedmine")
                        .HasColumnType("bit");

                    b.Property<string>("RemarksForAdjusted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ResourceHours")
                        .HasColumnType("real");

                    b.Property<int>("ResourceIdKickoff")
                        .HasColumnType("int");

                    b.Property<int>("WorkItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkItemId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsSameAsRedmine = true,
                            ResourceHours = 20f,
                            ResourceIdKickoff = 1,
                            WorkItemId = 4
                        },
                        new
                        {
                            Id = 2,
                            IsSameAsRedmine = true,
                            ResourceHours = 40f,
                            ResourceIdKickoff = 2,
                            WorkItemId = 4
                        },
                        new
                        {
                            Id = 3,
                            IsSameAsRedmine = true,
                            ResourceHours = 50f,
                            ResourceIdKickoff = 3,
                            WorkItemId = 1
                        },
                        new
                        {
                            Id = 4,
                            IsSameAsRedmine = true,
                            ResourceHours = 30f,
                            ResourceIdKickoff = 4,
                            WorkItemId = 2
                        });
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.SOW", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("APContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("BilledHours")
                        .HasColumnType("real");

                    b.Property<float>("IncidentalCost")
                        .HasColumnType("real");

                    b.Property<bool>("IsCheckedByDeliveryHead")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCheckedByPmo")
                        .HasColumnType("bit");

                    b.Property<int>("MonthlyProjectDataId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SowIdKickoff")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MonthlyProjectDataId");

                    b.ToTable("SOWs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            APContactEmail = "monkeymedia@gmail.com",
                            BilledHours = 100f,
                            IncidentalCost = 0f,
                            IsCheckedByDeliveryHead = false,
                            IsCheckedByPmo = false,
                            MonthlyProjectDataId = 1,
                            SowIdKickoff = 1
                        },
                        new
                        {
                            Id = 2,
                            APContactEmail = "monkeymedia@gmail.com",
                            BilledHours = 150f,
                            IncidentalCost = 0f,
                            IsCheckedByDeliveryHead = false,
                            IsCheckedByPmo = false,
                            MonthlyProjectDataId = 1,
                            SowIdKickoff = 2
                        },
                        new
                        {
                            Id = 3,
                            APContactEmail = "monkeymedia@gmail.com",
                            BilledHours = 200f,
                            IncidentalCost = 0f,
                            IsCheckedByDeliveryHead = false,
                            IsCheckedByPmo = false,
                            MonthlyProjectDataId = 1,
                            SowIdKickoff = 3
                        },
                        new
                        {
                            Id = 4,
                            APContactEmail = "avigilon@gmail.com",
                            BilledHours = 200f,
                            IncidentalCost = 0f,
                            IsCheckedByDeliveryHead = false,
                            IsCheckedByPmo = false,
                            MonthlyProjectDataId = 2,
                            SowIdKickoff = 4
                        });
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.WorkItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsFixedCost")
                        .HasColumnType("bit");

                    b.Property<int>("SOWId")
                        .HasColumnType("int");

                    b.Property<int>("WorkItemIdKickoff")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SOWId");

                    b.ToTable("WorkItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsFixedCost = true,
                            SOWId = 2,
                            WorkItemIdKickoff = 1
                        },
                        new
                        {
                            Id = 2,
                            IsFixedCost = false,
                            SOWId = 2,
                            WorkItemIdKickoff = 2
                        },
                        new
                        {
                            Id = 3,
                            IsFixedCost = true,
                            SOWId = 3,
                            WorkItemIdKickoff = 3
                        },
                        new
                        {
                            Id = 4,
                            IsFixedCost = false,
                            SOWId = 3,
                            WorkItemIdKickoff = 4
                        });
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.FixedCost", b =>
                {
                    b.HasOne("OptimusBillingProject.Entity.WorkItem", "WorkItem")
                        .WithOne("FixedCost")
                        .HasForeignKey("OptimusBillingProject.Entity.FixedCost", "WorkItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.MonthlyProjectData", b =>
                {
                    b.HasOne("OptimusBillingProject.Entity.MonthYear", "MonthYear")
                        .WithMany("MonthlyProjectData")
                        .HasForeignKey("MonthYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OptimusBillingProject.Entity.Project", "Project")
                        .WithMany("MonthlyProjectData")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.ProjectLockedUnlockedHistory", b =>
                {
                    b.HasOne("OptimusBillingProject.Entity.MonthlyProjectData", "MonthlyProjectData")
                        .WithMany("ProjectLockedUnlockedHistory")
                        .HasForeignKey("MonthlyProjectDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.Resource", b =>
                {
                    b.HasOne("OptimusBillingProject.Entity.WorkItem", "WorkItem")
                        .WithMany("Resources")
                        .HasForeignKey("WorkItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.SOW", b =>
                {
                    b.HasOne("OptimusBillingProject.Entity.MonthlyProjectData", "MonthlyProjectData")
                        .WithMany("SOWs")
                        .HasForeignKey("MonthlyProjectDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OptimusBillingProject.Entity.WorkItem", b =>
                {
                    b.HasOne("OptimusBillingProject.Entity.SOW", "SOW")
                        .WithMany("WorkItems")
                        .HasForeignKey("SOWId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}