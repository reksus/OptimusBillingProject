using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OptimusBillingProject.Entity;
using OptimusBillingProject.Interfaces.IServices;

namespace OptimusBillingProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MontlyProjectDataController : ControllerBase
    {
        private IMonthlyProjectDataService _monthlyProjectDataService;

        public MontlyProjectDataController(IMonthlyProjectDataService projectService)
        {
            _monthlyProjectDataService = projectService ?? throw new ArgumentNullException();
        }

        // GET: api/monthlyprojectdata/11/2019
        [HttpGet("{month}/{year}")]
        public ActionResult<IEnumerable<MonthlyProjectData>> GetAllMonthlyProjectData(int month, int year)
        {
            var monthlyProjectData = _monthlyProjectDataService.GetMonthlyProjectData(month, year);
            return monthlyProjectData.ToList();
        }

    }
}