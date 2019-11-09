using OptimusBillingProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Interfaces.IServices
{
    public interface IProjectsService
    {
        IEnumerable<Project> GetAllProjects();
        Project UpdateProject(int id, Project project);
    }
}
