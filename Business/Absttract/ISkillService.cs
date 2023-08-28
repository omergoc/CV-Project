using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absttract
{
    public interface ISkillService
    {
        IEnumerable<Skill> GetAllSkills();
        Skill GetSkillById(int id);
        void AddSkill(Skill skill);
        void UpdateSkill(Skill skill);
        void DeleteSkill(int id);
        // Diğer özel iş metotları
    }
}
