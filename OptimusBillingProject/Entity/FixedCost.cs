using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Entity
{
    public class FixedCost
    {
        public int Id { get; set; }
        public float MonthlyChargeableFee { get; set; }
        public float ChargeableHours { get; set; }
        public string RemarksForAdjustedHours { get; set; }
        public float ChargedFee { get; set; }


        public WorkItem WorkItem { get; set; }
        public int WorkItemId { get; set; }
    }
}
