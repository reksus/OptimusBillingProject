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
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly BillingDbContext _context;
        public ProjectsRepository(BillingDbContext context)
        {
            _context = context ?? throw new ArgumentNullException();
        }
        public IEnumerable<Project> GetAllProjects()
        {
            return  _context.Projects.ToList();
        }

        public Project UpdateProject(int id, Project project)
        {
            throw new NotImplementedException();
        }
    }
}
