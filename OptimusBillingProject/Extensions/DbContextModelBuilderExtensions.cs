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
        }
    }
}
