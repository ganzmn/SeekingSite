using SeekingPuraVida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekingPuraVida.Data.BlogRepos
{
    public interface IBlogRepo
    {
        List<Category> getAllCategories();

        List<Blog> GetNumberOfBlogs(int number, int set);
        List<Blog> GetBlogsByTitle(string title);
        List<Blog> GetBlogsByCategory(string category);
        List<Blog> GetBlogsByDate(string date);
        List<Blog> GetBlogsByTag(string tag);
        List<Blog> GetUnpublishedBlogs();
        List<Blog> GetSavedFromAuthor(string author);
        List<Blog> GetFeaturedBlogs();
        Blog GetBlogById(int BlogId);
        void AddBlog(Blog blog);
        List<Blog> GetAllBlogs();
        void DeleteBlog(int blogId);
        void EditBlog(Blog blog);
        void getBlogCategories(List<Blog> allBlogs);
    }
}
