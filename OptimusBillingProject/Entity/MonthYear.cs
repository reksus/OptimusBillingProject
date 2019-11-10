using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Entity
{
    public class MonthYear
    {
        public int Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public ICollection<MonthlyProjectData> MonthlyProjectData { get; set; }
    }
}
