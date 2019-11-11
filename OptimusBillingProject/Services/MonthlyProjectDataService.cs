using OptimusBillingProject.Entity;
using OptimusBillingProject.Interfaces.IRespositories;
using OptimusBillingProject.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptimusBillingProject.Services
{
    public class MonthlyProjectDataService : IMonthlyProjectDataService
    {
        private IMonthlyProjectDataRepository _monthlyProjectDataRepository;
        private IProjectsRepository _projectsRepository;
        private IProjectLockedUnlockedHistoryRepository _projectLockedUnlockedHistoryRepository;

        public MonthlyProjectDataService(
                IMonthlyProjectDataRepository monthlyProjectDataRepository,
                IProjectsRepository projectsRepository,
                IProjectLockedUnlockedHistoryRepository projectLockedUnlockedHistoryRepository
                )
        {
            _monthlyProjectDataRepository = monthlyProjectDataRepository ?? throw new ArgumentNullException();
            _projectsRepository = projectsRepository ?? throw new ArgumentNullException();
            _projectLockedUnlockedHistoryRepository = projectLockedUnlockedHistoryRepository ?? throw new ArgumentNullException();
        }

        public void FreezeMonthlyProjectData(int month, int year, int projectId, ProjectLockedUnlockedHistory projectLockedUnlockedHistory)
        {
            // get project and monthly project data entities
            var monthlyProjectData = _monthlyProjectDataRepository.GetMonthlyProjectData(month, year, projectId).First();
            var project = _projectsRepository.GetProject(projectId);
            
            var monthlyBilledHours = monthlyProjectData.MonthlyBilledHours;
            var monthlyBilledAmount = monthlyProjectData.MonthlyBilledAmount;

            // modify project data properties
            project.TotalBilledAmount += monthlyBilledAmount;
            project.TotalBilledHours += monthlyBilledHours;
            project.LastBilledDate = DateTime.Now;

            // modify monthly project data properties
            monthlyProjectData.LastUpdatedOn = DateTime.Now;
            monthlyProjectData.IsLocked = !monthlyProjectData.IsLocked;
            // modify project locked unlocked history 
            projectLockedUnlockedHistory.UpdatedOn = DateTime.Now;

            // update project in db
            _projectsRepository.UpdateProject(projectId, project);
            // update monthyProjectData in db
            _monthlyProjectDataRepository.UpdateMonthlyProjectData(month, year, projectId, monthlyProjectData);
            // add a new entry to the project Locked Unlocked History table  in db
            _projectLockedUnlockedHistoryRepository.AddHistory(projectLockedUnlockedHistory);

        }
        
        public void UnfreezeMonthlyProjectData(int month, int year, int projectId, ProjectLockedUnlockedHistory projectLockedUnlockedHistory)
        {
            // get project and monthly project data entities
            var monthlyProjectData = _monthlyProjectDataRepository.GetMonthlyProjectData(month, year, projectId).First();
            var project = _projectsRepository.GetProject(projectId);
            
            var monthlyBilledHours = monthlyProjectData.MonthlyBilledHours;
            var monthlyBilledAmount = monthlyProjectData.MonthlyBilledAmount;

            // modify project data properties
            project.TotalBilledAmount -= monthlyBilledAmount;
            project.TotalBilledHours -= monthlyBilledHours;
            project.LastBilledDate = DateTime.Now;

            // modify monthly project data properties
            monthlyProjectData.LastUpdatedOn = DateTime.Now;
            monthlyProjectData.IsLocked = !monthlyProjectData.IsLocked;
            // modify project locked unlocked history 
            projectLockedUnlockedHistory.UpdatedOn = DateTime.Now;

            // update project in db
            _projectsRepository.UpdateProject(projectId, project);
            // update monthyProjectData in db
            _monthlyProjectDataRepository.UpdateMonthlyProjectData(month, year, projectId, monthlyProjectData);
            // add a new entry to the project Locked Unlocked History table  in db
            _projectLockedUnlockedHistoryRepository.AddHistory(projectLockedUnlockedHistory);

        }

        public IEnumerable<MonthlyProjectData> GetMonthlyProjectData(int month, int year)
        {
            return _monthlyProjectDataRepository.GetMonthlyProjectData(month, year);
        }

        public IEnumerable<MonthlyProjectData> GetMonthlyProjectData(int month, int year, int id)
        {
            return _monthlyProjectDataRepository.GetMonthlyProjectData(month, year, id);
        }

        public MonthlyProjectData UpdateMonthlyProjectData(int month, int year, int id, MonthlyProjectData monthlyProjectData)
        {
            return _monthlyProjectDataRepository.UpdateMonthlyProjectData(month, year, id, monthlyProjectData);
        }


    }
}
