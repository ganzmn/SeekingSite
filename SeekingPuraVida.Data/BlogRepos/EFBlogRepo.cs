using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeekingPuraVida.Models;
using SeekingPuraVida.Models.Identity;

namespace SeekingPuraVida.Data.BlogRepos
{
    public class EFBlogRepo : IBlogRepo
    {
        public List<Category> getAllCategories()
        {
            using (SeekingPuraVidaDbContext context = new SeekingPuraVidaDbContext())
            {
                return context.Categories.ToList();
            }
        }

        public void AddBlog(Blog blog)
        {
            using (SeekingPuraVidaDbContext context = new SeekingPuraVidaDbContext())
            {
                List<Category> cats = new List<Category>();
                foreach(var cat in blog.BlogCategories)
                {
                    cats.Add(context.Categories.FirstOrDefault(c => c.CategoryName == cat.CategoryName));
                }

                blog.BlogCategories = cats;

                context.Blogs.Add(blog);
                context.SaveChanges();
            }
        }

        public void DeleteBlog(int blogId)
        {
            throw new NotImplementedException();
        }

        public void EditBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogs()
        {
            using (SeekingPuraVidaDbContext context = new SeekingPuraVidaDbContext())
            {
                return context.Blogs.ToList();

            }
        }

        public Blog GetBlogById(int BlogId)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogsByDate(string date)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogsByTag(string tag)
        {
            throw new NotImplementedException();
        }

        public Category AddNewCategory(string newCategory)
        {
            Category toAdd = new Category();

            using (SeekingPuraVidaDbContext context = new SeekingPuraVidaDbContext())
            {
                toAdd.CategoryName = newCategory;
                context.Categories.Add(toAdd);
                context.SaveChanges();
            }

            Category toReturn = new Category();
            toReturn = GetCategoryByName(newCategory);

            return toReturn;
        }

        private Category GetCategoryByName(string newCategory)
        {
            using (SeekingPuraVidaDbContext context = new SeekingPuraVidaDbContext())
            {
                return context.Categories.FirstOrDefault(c => c.CategoryName == newCategory);

            }
        }

        public List<Blog> GetBlogsByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetFeaturedBlogs()
        {
            using (SeekingPuraVidaDbContext context = new SeekingPuraVidaDbContext())
            {
                return context.Blogs.Where(b => b.IsFeatured == true).ToList();

            }
        }

        public List<Blog> GetNumberOfBlogs(int number, int set)
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            using (SeekingPuraVidaDbContext context = new SeekingPuraVidaDbContext())
            {
                return context.Categories.FirstOrDefault(c => c.CategoryId == id);

            }

        }

        public List<Blog> GetSavedFromAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetUnpublishedBlogs()
        {
            throw new NotImplementedException();
        }

        public void getBlogCategories(List<Blog> allBlogs)
        {
            //using (SeekingPuraVidaDbContext context = new SeekingPuraVidaDbContext())
            //{
            //    foreach(var blog in allBlogs)
            //    {
            //        var categories = context.Categories.Where(c => c)
            //    }
            //}
            throw new NotImplementedException();
        }
    }
}
