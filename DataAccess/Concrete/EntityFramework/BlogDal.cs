using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class BlogDal : Repository<Blog>, IBlogDal
    {
        public BlogDal(CvDbContext context) : base(context)
        {
        }

        // IBlogRepository için eklenen özel metotların gerçeklemesi
    }
}
