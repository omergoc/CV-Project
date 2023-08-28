using Business.Absttract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectDal _projectRepository;

        public ProjectService(IProjectDal projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            return await _projectRepository.GetAllAsync();
        }

        public async Task<Project> GetProjectByIdAsync(int id)
        {
            return await _projectRepository.GetByIdAsync(id);
        }

        public async Task AddProjectAsync(Project project)
        {
            await _projectRepository.InsertAsync(project);
        }

        public async Task UpdateProjectAsync(Project project)
        {
            await _projectRepository.UpdateAsync(project);
        }

        public async Task DeleteProjectAsync(int id)
        {
            await _projectRepository.DeleteAsync(id);
        }
    }
}
