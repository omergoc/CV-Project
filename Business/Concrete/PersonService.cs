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
    public class PersonService : IPersonService
    {
        private readonly IPersonDal _personRepository;

        public PersonService(IPersonDal personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<IEnumerable<Person>> GetAllPersonsAsync()
        {
            return await _personRepository.GetAllAsync();
        }

        public async Task<Person> GetPersonByIdAsync(int id)
        {
            return await _personRepository.GetByIdAsync(id);
        }

        public async Task AddPersonAsync(Person person)
        {
            await _personRepository.InsertAsync(person);
        }

        public async Task UpdatePersonAsync(Person person)
        {
            await _personRepository.UpdateAsync(person);
        }

        public async Task DeletePersonAsync(int id)
        {
            await _personRepository.DeleteAsync(id);
        }
    }
}
