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

        public IEnumerable<Person> GetAllPersons()
        {
            return _personRepository.GetAll();
        }

        public Person GetPersonById(int id)
        {
            return _personRepository.GetById(id);
        }

        public void AddPerson(Person person)
        {
            _personRepository.Insert(person);
        }

        public void UpdatePerson(Person person)
        {
            _personRepository.Update(person);
        }

        public void DeletePerson(int id)
        {
            _personRepository.Delete(id);
        }
    }

    // Aynı şekilde BlogService ve ProjectService için de gerçeklemeler yapılabilir.

}
