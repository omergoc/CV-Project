using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absttract
{
    public interface IBlogService
    {
        IEnumerable<Blog> GetAllBlogs();
        Blog GetBlogById(int id);
        void AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void DeleteBlog(int id);
        // Diğer özel iş metotları
    }
}
