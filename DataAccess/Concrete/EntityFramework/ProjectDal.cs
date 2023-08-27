using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProjectDal: Repository<Project>, IProjectDal
    {
        public ProjectDal(CvDbContext context) : base(context)
        {
        }

        // IProjectRepository için eklenen özel metotların gerçeklemesi
    }
}
