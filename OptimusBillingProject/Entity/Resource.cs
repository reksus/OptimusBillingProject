using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Entity
{
    public class Resource
    {
        public int Id { get; set; }
        public float ResourceHours { get; set; }
        public Boolean IsSameAsRedmine { get; set; }
        public string RemarksForAdjusted { get; set; }
        public int ResourceIdKickoff { get; set; }

        public int WorkItemId { get; set; }
        public WorkItem WorkItem { get; set; }
    }
}
