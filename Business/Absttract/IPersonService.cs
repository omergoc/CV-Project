using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absttract
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAllPersons();
        Person GetPersonById(int id);
        void AddPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int id);
        // Diğer özel iş metotları
    }
}
