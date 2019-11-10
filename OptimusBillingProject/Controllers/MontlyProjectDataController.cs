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

        // Fetches all projects for the given month and year
        // GET: api/monthlyprojectdata/11/2019
        [HttpGet("{month}/{year}")]
        public ActionResult<IEnumerable<MonthlyProjectData>> GetMonthlyProjectDataAllProjects(int month, int year)
        {
            var monthlyProjectData = _monthlyProjectDataService.GetMonthlyProjectData(month, year);
            return monthlyProjectData.ToList();
        }

        // Fetches one projects for the given month and year based on the project id
        // GET: api/monthlyprojectdata/11/2019/1
        [HttpGet("{month}/{year}/{projectId}")]
        public ActionResult<IEnumerable<MonthlyProjectData>> GetMonthlyProjectDataOneProject(int month, int year, int projectId)
        {
            var monthlyProjectData = _monthlyProjectDataService.GetMonthlyProjectData(month, year, projectId);
            return monthlyProjectData.ToList();
        }

        // Updates the hour's data for a given monthly project
        // GET: api/monthlyprojectdata/11/2019/1
        [HttpPut("{month}/{year}/{projectId}")]
        public ActionResult UpdateMonthlyProjectData(int month, int year, int projectId, MonthlyProjectData monthlyProjectData)
        {
            if (projectId != monthlyProjectData.Id)
            {
                return BadRequest();
            }

            var _monthlyProjectData = _monthlyProjectDataService.UpdateMonthlyProjectData(month, year, projectId, monthlyProjectData);
            return Ok(_monthlyProjectData);
        }
    }
}