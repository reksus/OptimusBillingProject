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
using OptimusBillingProject.Interfaces.IServices;

namespace OptimusBillingProject.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private IProjectsService _projectsService;

        public ProjectsController(IProjectsService projectService)
        {
            _projectsService = projectService ?? throw new ArgumentNullException();
        }

        // GET: api/projects
        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetAllProjects()
        {
            var projects = _projectsService.GetAllProjects();
            return projects.ToList();
        }

        // PUT: api/projects/1
        [HttpPut("{id}")]
        public ActionResult<Project> UpdateProject(int id, Project project)
        {
            if (project.Id != id)
            {
                return BadRequest("Project to be updated doesn't match the given Id");
            }
            var _project = _projectsService.UpdateProject(id, project);
            return _project;
            
        }
    }
}