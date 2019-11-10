using OptimusBillingProject.Entity;
using OptimusBillingProject.Interfaces.IRespositories;
using OptimusBillingProject.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Services
{
    public class MonthlyProjectDataService : IMonthlyProjectDataService
    {
        private IMonthlyProjectDataRepository _monthlyProjectDataRepository;

        public MonthlyProjectDataService(IMonthlyProjectDataRepository monthlyProjectDataRepository)
        {
            _monthlyProjectDataRepository = monthlyProjectDataRepository ?? throw new ArgumentNullException();
        }
        public IEnumerable<MonthlyProjectData> GetMonthlyProjectData(int month, int year)
        {
            return _monthlyProjectDataRepository.GetMonthlyProjectData(month, year);
        }
    }
}
