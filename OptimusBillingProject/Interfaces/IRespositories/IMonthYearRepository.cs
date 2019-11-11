using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Interfaces.IRespositories
{
    public interface IMonthYearRepository
    {
        int GetId(int month, int year);
    }
}
