using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Entity
{
    public class MonthlyProjectData
    {
        public int Id { get; set; }
        public float MonthlyBilledAmount { get; set; }
        public float MonthlyBilledHours { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public Boolean IsLocked { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int MonthYearId { get; set; }
        public MonthYear MonthYear { get; set; }

        public ICollection<ProjectLockedUnlockedHistory> ProjectLockedUnlockedHistory { get; set; }

        public ICollection<SOW> SOWs { get; set; }
    }
}
