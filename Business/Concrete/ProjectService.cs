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

        public IEnumerable<Project> GetAllProjects()
        {
            return _projectRepository.GetAll();
        }

        public Project GetProjectById(int id)
        {
            return _projectRepository.GetById(id);
        }

        public void AddProject(Project project)
        {
            _projectRepository.Insert(project);
        }

        public void UpdateProject(Project project)
        {
            _projectRepository.Update(project);
        }

        public void DeleteProject(int id)
        {
            _projectRepository.Delete(id);
        }
    }
}
