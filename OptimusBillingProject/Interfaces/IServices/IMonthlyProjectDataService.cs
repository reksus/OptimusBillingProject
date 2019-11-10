using OptimusBillingProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Interfaces.IServices
{
    public interface IMonthlyProjectDataService
    {
        IEnumerable<MonthlyProjectData> GetMonthlyProjectData(int month, int year);
        IEnumerable<MonthlyProjectData> GetMonthlyProjectData(int month, int year, int id);
        MonthlyProjectData UpdateMonthlyProjectData(int month, int year, int id, MonthlyProjectData monthlyProjectData);
    }
}
