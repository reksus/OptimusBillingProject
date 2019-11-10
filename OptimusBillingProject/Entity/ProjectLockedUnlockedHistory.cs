using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Entity
{
    public class ProjectLockedUnlockedHistory
    {
        public int Id { get; set; }
        public string ActionPerformed { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }

        public MonthlyProjectData MonthlyProjectData { get; set; }
        public int MonthlyProjectDataId { get; set; }
    }
}
