using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPersonDal : IRepository<Person>
    {
        // Özel Person işlemleri için ek metotlar (örneğin belirli bir kriterle kişi arama)
    }
}
