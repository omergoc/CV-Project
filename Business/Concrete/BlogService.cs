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

        public async Task<IEnumerable<Blog>> GetAllBlogsAsync()
        {
            return await _blogRepository.GetAllAsync();
        }

        public async Task<Blog> GetBlogByIdAsync(int id)
        {
            return await _blogRepository.GetByIdAsync(id);
        }

        public async Task AddBlogAsync(Blog blog)
        {
            await _blogRepository.InsertAsync(blog);
        }

        public async Task UpdateBlogAsync(Blog blog)
        {
            await _blogRepository.UpdateAsync(blog);
        }

        public async Task DeleteBlogAsync(int id)
        {
            await _blogRepository.DeleteAsync(id);
        }
    }

}
