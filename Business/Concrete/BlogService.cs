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
    public class BlogService : IBlogService
    {
        private readonly IBlogDal _blogRepository;

        public BlogService(IBlogDal blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IEnumerable<Blog> GetAllBlogs()
        {
            return _blogRepository.GetAll();
        }

        public Blog GetBlogById(int id)
        {
            return _blogRepository.GetById(id);
        }

        public void AddBlog(Blog blog)
        {
            _blogRepository.Insert(blog);
        }

        public void UpdateBlog(Blog blog)
        {
            _blogRepository.Update(blog);
        }

        public void DeleteBlog(int id)
        {
            _blogRepository.Delete(id);
        }
    }

}
