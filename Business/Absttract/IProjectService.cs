using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absttract
{
    public interface IProjectService
    {
        IEnumerable<Project> GetAllProjects();
        Project GetProjectById(int id);
        void AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(int id);
        // Diğer özel iş metotları
    }
}
