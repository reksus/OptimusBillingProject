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
        private IAuthenticationService _authenticationService;

        public ProjectsController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService ?? throw new ArgumentNullException("Authentication Service");
        }

        // POST : api/projects/authenticate
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var token = _authenticationService.Authenticate(model.Username, model.Password);

            if (token == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(token);
        }

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
    }
}