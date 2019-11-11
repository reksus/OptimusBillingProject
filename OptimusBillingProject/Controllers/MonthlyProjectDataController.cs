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
    public class MonthlyProjectDataController : ControllerBase
    {
        private IMonthlyProjectDataService _monthlyProjectDataService;

        public MonthlyProjectDataController(IMonthlyProjectDataService projectService)
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
        // PUT: api/monthlyprojectdata/11/2019/1
        [HttpPut("{month}/{year}/{projectId}")]
        public ActionResult UpdateMonthlyProjectData(int month, int year, int projectId, MonthlyProjectData monthlyProjectData)
        {
            if (projectId != monthlyProjectData.ProjectId)
            {
                return BadRequest();
            }

            var _monthlyProjectData = _monthlyProjectDataService.UpdateMonthlyProjectData(month, year, projectId, monthlyProjectData);
            return Ok(_monthlyProjectData);
        }

        // This is to FREEZE the monthly project data 
        // PUT: api/MonthlyProjectData/11/2019/1/freeze
        [HttpPut("{month}/{year}/{projectId}/freeze")]
        public ActionResult FreezeMonthlyProjectData(int month, int year, int projectId, ProjectLockedUnlockedHistory projectLockedUnlockedHistory)
        {
            _monthlyProjectDataService.FreezeMonthlyProjectData(month, year, projectId, projectLockedUnlockedHistory);
            return Ok(projectLockedUnlockedHistory);

        }
        
        // This is to UNFREEZE the monthly project data 
        // PUT: api/MonthlyProjectData/11/2019/1/unfreeze
        [HttpPut("{month}/{year}/{projectId}/unfreeze")]
        public ActionResult UnfreezeMonthlyProjectData(int month, int year, int projectId, ProjectLockedUnlockedHistory projectLockedUnlockedHistory)
        {
            _monthlyProjectDataService.UnfreezeMonthlyProjectData(month, year, projectId, projectLockedUnlockedHistory);
            return Ok(projectLockedUnlockedHistory);
        }
    }
}