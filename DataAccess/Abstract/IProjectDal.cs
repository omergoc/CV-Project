using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProjectDal : IRepository<Project>
    {
        // Özel Project işlemleri için ek metotlar
    }
}
