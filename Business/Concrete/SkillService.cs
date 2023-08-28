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
    public class SkillService : ISkillService
    {
        public readonly ISkillDal _skillRepository;
        public SkillService(ISkillDal skillDal) 
        {
            _skillRepository = skillDal;
        }
        public async Task AddSkillAsync(Skill skill)
        {
            await _skillRepository.InsertAsync(skill);
        }

        public async Task DeleteSkillAsync(int id)
        {
            await _skillRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Skill>> GetAllSkillsAsync()
        {
           return await _skillRepository.GetAllAsync();
        }

        public async Task<Skill> GetSkillByIdAsync(int id)
        {
            return await _skillRepository.GetByIdAsync(id);
        }

        public async Task UpdateSkillAsync(Skill skill)
        {
            await _skillRepository.UpdateAsync(skill);
        }
    }
}
