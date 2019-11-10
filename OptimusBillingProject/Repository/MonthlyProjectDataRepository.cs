using Microsoft.EntityFrameworkCore;
using OptimusBillingProject.Entity;
using OptimusBillingProject.Interfaces.IRespositories;
using OptimusBillingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Repository
{
    public class MonthlyProjectDataRepository : IMonthlyProjectDataRepository
    {
        private readonly BillingDbContext _context;
        public MonthlyProjectDataRepository(BillingDbContext context)
        {
            _context = context ?? throw new ArgumentNullException();
        }
        public IEnumerable<MonthlyProjectData> GetMonthlyProjectData(int month, int year)
        {
            //get the monthyear id from the Month_year table based on route parameters
            int monthYearId = _context.MonthYear.FirstOrDefault(my => my.Year == year && my.Month == month).Id;
            
            var monthlyProjectData = _context.MonthlyProjectData
                                             .Where(monthlyData => 
                                                    monthlyData.MonthYearId == monthYearId)
                                                 .Include(monthlyData => monthlyData.SOWs)
                                                     .ThenInclude(sow => sow.WorkItems)
                                                         .ThenInclude(workItem => workItem.Resources)
                                                 .Include(monthlyData => monthlyData.SOWs)
                                                     .ThenInclude(sow => sow.WorkItems)
                                                         .ThenInclude(workItem => workItem.FixedCost)
                                             .ToList();

            return monthlyProjectData;

        }

        public IEnumerable<MonthlyProjectData> GetMonthlyProjectData(int month, int year, int id)
        {
            //get the monthyear id from the Month_year table based on route parameters
            int monthYearId = _context.MonthYear.FirstOrDefault(my => my.Year == year && my.Month == month).Id;
            
            var monthlyProjectData = _context.MonthlyProjectData
                                             .Where(monthlyData => 
                                                    monthlyData.MonthYearId == monthYearId && 
                                                    monthlyData.ProjectId == id)
                                                 .Include(monthlyData => monthlyData.SOWs)
                                                     .ThenInclude(sow => sow.WorkItems)
                                                         .ThenInclude(workItem => workItem.Resources)
                                                 .Include(monthlyData => monthlyData.SOWs)
                                                     .ThenInclude(sow => sow.WorkItems)
                                                         .ThenInclude(workItem => workItem.FixedCost)
                                             .ToList();

            return monthlyProjectData;  
        }

        public MonthlyProjectData UpdateMonthlyProjectData(int month, int year, int id, MonthlyProjectData monthlyProjectData)
        {

            _context.Entry(monthlyProjectData).State = EntityState.Modified;

            foreach (var sow in monthlyProjectData.SOWs)
            {
                _context.Entry(sow).State = EntityState.Modified;
                foreach (var workItem in sow.WorkItems)
                {
                    _context.Entry(workItem).State = EntityState.Modified;
                    foreach (var resource in workItem.Resources)
                    {
                        _context.Entry(resource).State = EntityState.Modified;
                    }
                    if (workItem.FixedCost != null)
                        _context.Entry(workItem.FixedCost).State = EntityState.Modified;
                }
            }

            _context.SaveChanges();

            return monthlyProjectData;
        }
    }
}
