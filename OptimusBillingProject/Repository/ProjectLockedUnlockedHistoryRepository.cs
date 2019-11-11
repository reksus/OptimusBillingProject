using OptimusBillingProject.Entity;
using OptimusBillingProject.Interfaces.IRespositories;
using OptimusBillingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Repository
{
    public class ProjectLockedUnlockedHistoryRepository : IProjectLockedUnlockedHistoryRepository
    {
        private readonly BillingDbContext _context;
        public ProjectLockedUnlockedHistoryRepository(BillingDbContext context)
        {
            _context = context ?? throw new ArgumentNullException();
        }
        public ProjectLockedUnlockedHistory AddHistory(ProjectLockedUnlockedHistory projectLockedUnlockedHistory)
        {
            _context.ProjectLockedUnlockedHistorys.Add(projectLockedUnlockedHistory);
            _context.SaveChanges();
            return projectLockedUnlockedHistory;
        }
    }
}
