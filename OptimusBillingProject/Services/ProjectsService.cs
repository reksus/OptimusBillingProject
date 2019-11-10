using OptimusBillingProject.Entity;
using OptimusBillingProject.Interfaces.IRespositories;
using OptimusBillingProject.Interfaces.IServices;
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

        //public IEnumerable<Project> GetAllProjects()
        //{
        //    var projects = new List<Project>()
        //    {
        //        new Project
        //        {
        //            Id = 1,
        //            LastBilledDate = DateTime.Today,
        //            TotalBilledHours = 200,
        //            TotalBilledAmount = 200,
        //        },
        //        new Project
        //        {
        //            Id = 2,
        //            LastBilledDate = DateTime.Today,
        //            TotalBilledHours = 250,
        //            TotalBilledAmount = 250
        //        }
        //    };
        //    return projects;
        //}
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
