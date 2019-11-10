using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Entity
{
    public class WorkItem
    {
        public int Id { get; set; }
        public int WorkItemIdKickoff { get; set; }
        public Boolean IsFixedCost { get; set; }

        public int SOWId { get; set; }
        public SOW SOW { get; set; }

        public FixedCost FixedCost { get; set; }
        public ICollection<Resource> Resources { get; set; }
    }
}
