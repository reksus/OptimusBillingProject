using OptimusBillingProject.Entity;
using OptimusBillingProject.Interfaces.IRespositories;
using OptimusBillingProject.Interfaces.IServices;
using OptimusBillingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Services
{
    public class ProjectsService : IProjectsService
    {
        private IProjectsRepository _projectsRepository;

        public ProjectsService(IProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository ?? throw new ArgumentNullException();
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _projectsRepository.GetAllProjects();
        }

        public Project UpdateProject(int id, Project project)
        {
            
            return new Project
            {
                TotalBilledAmount = project.TotalBilledAmount,
                TotalBilledHours = project.TotalBilledHours
            };
        }
    }
}
