using Business.Absttract;
using DataAccess.Abstract;
using Entities;


namespace Business.Concrete
{
    public class ExperienceService : IExperienceService
    {
        public readonly IExperienceDal _experienceRepository;
        public ExperienceService(IExperienceDal experienceDal)
        {
            _experienceRepository = experienceDal;
        }
        public async Task AddExperienceAsync(Experience experience)
        {
            await _experienceRepository.InsertAsync(experience);
        }

        public async Task DeleteExperienceAsync(int id)
        {
            await _experienceRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Experience>> GetAllExperiencesAsync()
        {
            return await _experienceRepository.GetAllAsync();
        }

        public async Task<Experience> GetBExperienceByIdAsync(int id)
        {
            return await _experienceRepository.GetByIdAsync(id);
        }

        public async Task UpdateExperienceAsync(Experience experience)
        {
            await _experienceRepository.UpdateAsync(experience);
        }
    }
}
