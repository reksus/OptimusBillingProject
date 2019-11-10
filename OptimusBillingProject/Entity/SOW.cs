using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Entity
{
    public class SOW
    {
        public int Id { get; set; }
        public int SowIdKickoff { get; set; }
        public float BilledHours { get; set; }
        public string APContactEmail { get; set; }
        public Boolean IsCheckedByPmo { get; set; }
        public Boolean IsCheckedByDeliveryHead { get; set; }
        public float IncidentalCost { get; set; }
        public string Remarks { get; set; }

        public int MonthlyProjectDataId { get; set; }
        public MonthlyProjectData MonthlyProjectData { get; set; }

        public ICollection<WorkItem> WorkItems { get; set; }
    }
}
