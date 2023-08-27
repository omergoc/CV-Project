using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDal : IRepository<Blog>
    {
        // Özel Blog işlemleri için ek metotlar (örneğin belirli bir tarihten sonraki blog gönderilerini alma)
    }

}
