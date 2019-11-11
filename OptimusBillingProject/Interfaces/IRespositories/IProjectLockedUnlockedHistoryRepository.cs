using OptimusBillingProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Interfaces.IRespositories
{
    public interface IProjectLockedUnlockedHistoryRepository
    {
        ProjectLockedUnlockedHistory AddHistory(ProjectLockedUnlockedHistory projectLockedUnlockedHistory);
    }
}
