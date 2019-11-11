using OptimusBillingProject.Interfaces.IRespositories;
using OptimusBillingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Repository
{
    public class MonthYearRepository : IMonthYearRepository
    {
        private readonly BillingDbContext _context;
        public MonthYearRepository(BillingDbContext context)
        {
            _context = context ?? throw new ArgumentNullException();
        }

        public int GetId(int month, int year)
        {
            return _context.MonthYear.FirstOrDefault(my => my.Year == year && my.Month == month).Id;
        }
    }
}
