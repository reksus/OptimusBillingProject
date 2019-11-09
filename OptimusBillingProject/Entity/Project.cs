using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Entity
{
    public class Project
    {
        public int Id { get; set; }
        public DateTime LastBilledDate { get; set; }
        public float TotalBilledHours { get; set; }
        public float TotalBilledAmount { get; set; }
        //public ICollection<MonthlyProjectData> MonthlyProjectData { get; set; }
    }
}
