using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class PersonDal : Repository<Person>, IPersonDal
    {
        public PersonDal(CvDbContext context) : base(context)
        {
        }

        // IPersonRepository için eklenen özel metotların gerçeklemesi
    }
}
