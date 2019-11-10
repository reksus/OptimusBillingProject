using Microsoft.EntityFrameworkCore;
using OptimusBillingProject.Entity;
using OptimusBillingProject.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Models
{
    public class BillingDbContext : DbContext
    {
        public BillingDbContext(DbContextOptions<BillingDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<MonthlyProjectData> MonthlyProjectData { get; set; }
        public DbSet<MonthYear> MonthYear { get; set; }
        public DbSet<SOW> SOWs { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<FixedCost> FixedCosts { get; set; }
        public DbSet<ProjectLockedUnlockedHistory> ProjectLockedUnlockedHistorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding data
            modelBuilder.Seed();
            modelBuilder.ConfigureEntityProperties();
        }
    }
}
