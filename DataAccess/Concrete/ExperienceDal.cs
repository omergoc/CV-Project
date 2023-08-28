using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ExperienceDal : Repository<Experience>, IExperienceDal
    {
        public ExperienceDal(CvDbContext cvDbContext) : base(cvDbContext)
        {
            
        }
    }
}
