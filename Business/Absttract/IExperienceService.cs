using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absttract
{
    public interface IExperienceService
    {
        Task<IEnumerable<Experience>> GetAllExperiencesAsync();
        Task<Experience> GetBExperienceByIdAsync(int id);
        Task AddExperienceAsync(Experience experience);
        Task UpdateExperienceAsync(Experience experience);
        Task DeleteExperienceAsync(int id);
    }
}
