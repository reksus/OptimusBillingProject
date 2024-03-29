﻿using OptimusBillingProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Interfaces.IRespositories
{
    public interface IProjectsRepository
    {
        IEnumerable<Project> GetAllProjects();
        Project GetProject(int projectId);
        Project UpdateProject(int id, Project project);
    }
}
