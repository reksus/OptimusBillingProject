using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OptimusBillingProject.Entity;
using OptimusBillingProject.Models;
using OptimusBillingProject.Services;

namespace OptimusBillingProject.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        // GET: api/projects
        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetAllProjects()
        {
            var projects = new List<Project>()
            {
                new Project
                {
                    Id = 1,
                    LastBilledDate = DateTime.Today,
                    TotalBilledHours = 200,
                    TotalBilledAmount = 200,
                },
                new Project
                {
                    Id = 2,
                    LastBilledDate = DateTime.Today,
                    TotalBilledHours = 250,
                    TotalBilledAmount = 250
                }
            };
            return projects;
        }

        // PUT: api/projects/1
        [HttpPut("{id}")]
        public ActionResult<Project> UpdateProject(int id, Project project)
        {
            if (project.Id != id)
            {
                return BadRequest("Project to be updated doesn't match the given Id");
            }
            return new Project
            {
                TotalBilledAmount = project.TotalBilledAmount,
                TotalBilledHours = project.TotalBilledHours
            };
        }
    }
}