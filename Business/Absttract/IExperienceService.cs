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
        IEnumerable<Experience> GetAllExperiences();
        Experience GetBExperienceById(int id);
        void AddExperience(Experience experience);
        void UpdateExperience(Experience experience);
        void DeleteExperience(int id);
        // Diğer özel iş metotları
    }
}
