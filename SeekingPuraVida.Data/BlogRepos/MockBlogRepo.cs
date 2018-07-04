using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeekingPuraVida.Models;

namespace SeekingPuraVida.Data.BlogRepos
{
    //public class MockBlogRepo : IBlogRepo
    //{
    //    //private static List<Category> _categories = new List<Category>
    //    //{
    //    //    new Category
    //    //    {
    //    //        CategoryId = 1,
    //    //        CategoryName = "Costa Rica"
    //    //    }
    //    //};

    //    //        private static List<Blog> _blogs = new List<Blog>
    //    //        {
    //    //            new Blog
    //    //            {
    //    //                BlogId = 1,
    //    //                //BlogCategory = _categories[1],
    //    //                Author = "Ashley",
    //    //                Country = "Costa Rica",
    //    //                BlogTags = new List<Tag>
    //    //                {
    //    //                    new Tag
    //    //                    {
    //    //                        TagId = 1,
    //    //                        TagName = "#costaRica"
    //    //                    }
    //    //                },
    //    //                Date = DateTime.Parse("2/2/2018"),
    //    //                Title = "Costa Rica Blog",
    //    //                Summary = "This is the summary for the costa rica blog",
    //    //                IsFeatured = true,
    //    //                SubTitle = "True Love in Costa Rica",
    //    //                IsFinished = true,
    //    //                IsDeleted = false,
    //    //                FeatureImageLocation = @"img/portfolio/LizardoThumbnail.jpg",
    //    //                BlogSections = new List<BlogSection>
    //    //                {
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"img/portfolio/04-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph one of blog one"
    //    //                    },
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"img/portfolio/03-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph two of blog one"
    //    //                    },
    //    //                }
    //    //            },
    //    //            new Blog
    //    //            {
    //    //                BlogId = 2,
    //    //                //BlogCategory = _categories[1],
    //    //                Author = "Ashley",
    //    //                BlogTags = new List<Tag>
    //    //                {
    //    //                    new Tag
    //    //                    {
    //    //                        TagId = 1,
    //    //                        TagName = "#costaRica"
    //    //                    }
    //    //                },
    //    //                Date = DateTime.Parse("2/2/2018"),
    //    //                Title = "Costa Rica Blog",
    //    //                Summary = "This is the summary for the costa rica blog",
    //    //                IsFeatured = true,
    //    //                SubTitle = "True Love in Costa Rica",
    //    //                IsFinished = true,
    //    //                IsDeleted = false,
    //    //                FeatureImageLocation = @"img/portfolio/LizardoThumbnail.jpg",
    //    //                BlogSections = new List<BlogSection>
    //    //                {
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\04-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph one of blog one"
    //    //                    },
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\03-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph two of blog one"
    //    //                    },
    //    //                }
    //    //            },
    //    //            new Blog
    //    //            {
    //    //                BlogId = 3,
    //    //                //BlogCategory = _categories[1],
    //    //                Author = "Ashley",
    //    //                BlogTags = new List<Tag>
    //    //                {
    //    //                    new Tag
    //    //                    {
    //    //                        TagId = 1,
    //    //                        TagName = "#costaRica"
    //    //                    }
    //    //                },
    //    //                Date = DateTime.Parse("2/2/2018"),
    //    //                Title = "Costa Rica Blog",
    //    //                Summary = "This is the summary for the costa rica blog",
    //    //                IsFeatured = true,
    //    //                SubTitle = "True Love in Costa Rica",
    //    //                IsFinished = true,
    //    //                IsDeleted = false,
    //    //                FeatureImageLocation = @"img/portfolio/LizardoThumbnail.jpg",
    //    //                BlogSections = new List<BlogSection>
    //    //                {
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\04-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph one of blog one"
    //    //                    },
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\03-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph two of blog one"
    //    //                    },
    //    //                }
    //    //            },
    //    //            new Blog
    //    //            {
    //    //                BlogId = 4,
    //    //                //BlogCategory = _categories[1],
    //    //                Author = "Ashley",
    //    //                BlogTags = new List<Tag>
    //    //                {
    //    //                    new Tag
    //    //                    {
    //    //                        TagId = 1,
    //    //                        TagName = "#costaRica"
    //    //                    }
    //    //                },
    //    //                Date = DateTime.Parse("2/2/2018"),
    //    //                Title = "Costa Rica Blog",
    //    //                Summary = "This is the summary for the costa rica blog",
    //    //                IsFeatured = true,
    //    //                SubTitle = "True Love in Costa Rica",
    //    //                IsFinished = true,
    //    //                IsDeleted = false,
    //    //                FeatureImageLocation = @"img/portfolio/LizardoThumbnail.jpg",
    //    //                BlogSections = new List<BlogSection>
    //    //                {
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\04-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph one of blog one"
    //    //                    },
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\03-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph two of blog one"
    //    //                    },
    //    //                }
    //    //            },
    //    //            new Blog
    //    //            {
    //    //                BlogId = 5,
    //    //                //BlogCategory = _categories[1],
    //    //                Author = "Ashley",
    //    //                BlogTags = new List<Tag>
    //    //                {
    //    //                    new Tag
    //    //                    {
    //    //                        TagId = 1,
    //    //                        TagName = "#costaRica"
    //    //                    }
    //    //                },
    //    //                Date = DateTime.Parse("2/2/2018"),
    //    //                Title = "Costa Rica Blog",
    //    //                Summary = "This is the summary for the costa rica blog",
    //    //                IsFeatured = true,
    //    //                SubTitle = "True Love in Costa Rica",
    //    //                IsFinished = true,
    //    //                IsDeleted = false,
    //    //                FeatureImageLocation = @"img/portfolio/LizardoThumbnail.jpg",
    //    //                BlogSections = new List<BlogSection>
    //    //                {
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\04-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph one of blog one"
    //    //                    },
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\03-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph two of blog one"
    //    //                    },
    //    //                }
    //    //            },
    //    //            new Blog
    //    //            {
    //    //                BlogId = 1,
    //    //                //BlogCategory = _categories[1],
    //    //                Author = "Ashley",
    //    //                BlogTags = new List<Tag>
    //    //                {
    //    //                    new Tag
    //    //                    {
    //    //                        TagId = 1,
    //    //                        TagName = "#costaRica"
    //    //                    }
    //    //                },
    //    //                Date = DateTime.Parse("2/2/2018"),
    //    //                Title = "Costa Rica Blog",
    //    //                Summary = "This is the summary for the costa rica blog",
    //    //                IsFeatured = true,
    //    //                SubTitle = "True Love in Costa Rica",
    //    //                IsFinished = true,
    //    //                IsDeleted = false,
    //    //                FeatureImageLocation = @"img/portfolio/LizardoThumbnail.jpg",
    //    //                BlogSections = new List<BlogSection>
    //    //                {
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\04-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph one of blog one"
    //    //                    },
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\03-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph two of blog one"
    //    //                    },
    //    //                }
    //    //            },
    //    //            new Blog
    //    //            {
    //    //                BlogId = 1,
    //    //                //BlogCategory = _categories[1],
    //    //                Author = "Ashley",
    //    //                BlogTags = new List<Tag>
    //    //                {
    //    //                    new Tag
    //    //                    {
    //    //                        TagId = 1,
    //    //                        TagName = "#costaRica"
    //    //                    }
    //    //                },
    //    //                Date = DateTime.Parse("2/2/2018"),
    //    //                Title = "Costa Rica Blog",
    //    //                Summary = "This is the summary for the costa rica blog",
    //    //                IsFeatured = true,
    //    //                SubTitle = "True Love in Costa Rica",
    //    //                IsFinished = true,
    //    //                IsDeleted = false,
    //    //                FeatureImageLocation = @"img/portfolio/LizardoThumbnail.jpg",
    //    //                BlogSections = new List<BlogSection>
    //    //                {
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\04-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph one of blog one"
    //    //                    },
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\03-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph two of blog one"
    //    //                    },
    //    //                }
    //    //            },
    //    //            new Blog
    //    //            {
    //    //                BlogId = 1,
    //    //                //BlogCategory = _categories[1],
    //    //                Author = "Ashley",
    //    //                BlogTags = new List<Tag>
    //    //                {
    //    //                    new Tag
    //    //                    {
    //    //                        TagId = 1,
    //    //                        TagName = "#costaRica"
    //    //                    }
    //    //                },
    //    //                Date = DateTime.Parse("2/2/2018"),
    //    //                Title = "Costa Rica Blog",
    //    //                Summary = "This is the summary for the costa rica blog",
    //    //                IsFeatured = true,
    //    //                SubTitle = "True Love in Costa Rica",
    //    //                IsFinished = true,
    //    //                IsDeleted = false,
    //    //                FeatureImageLocation = @"img/portfolio/LizardoThumbnail.jpg",
    //    //                BlogSections = new List<BlogSection>
    //    //                {
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\04-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph one of blog one"
    //    //                    },
    //    //                    new BlogSection
    //    //                    {
    //    //                        ImageLocation = @"C:\SeekingPuraVidaSite\SeekingPuraVida.Web\img\portfolio\03-thumbnail.jpg",
    //    //                        Paragraph = "This is paragraph two of blog one"
    //    //                    },
    //    //                }
    //    //            }
    //    //        };

    //    //        public List<Blog> GetFeaturedBlogs ()
    //    //        {
    //    //            return _blogs.Where(b => b.IsFeatured == true).ToList();
    //    //        }

    //    //        public void AddBlog(Blog blog)
    //    //        {
    //    //            _blogs.Add(blog);
    //    //        }

    //    //        public void DeleteBlog(int blogId)
    //    //        {
    //    //            _blogs.RemoveAll(b => b.BlogId == blogId);
    //    //        }

    //    //        public void EditBlog(Blog blog)
    //    //        {
    //    //            var b = new Blog();
    //    //            foreach (var blo in _blogs)
    //    //            {
    //    //                if (blo.BlogId == blog.BlogId)
    //    //                {
    //    //                    blo.Title = blog.Title;
    //    //                    blo.Summary = blog.Summary;
    //    //                    blo.IsFeatured = blog.IsFeatured;
    //    //                    blo.FeatureImageLocation = blog.FeatureImageLocation;
    //    //                    blo.BlogSections = blog.BlogSections;
    //    //                    blo.BlogCategory = blog.BlogCategory;
    //    //                    blo.Date = blog.Date;
    //    //                    blo.IsDeleted = blog.IsDeleted;
    //    //                    blo.IsFinished = blog.IsFinished;
    //    //                    blo.BlogTags = blog.BlogTags;
    //    //                }
    //    //            }
    //    //            b = blog;
    //    //        }

    //    //        public Blog GetBlogById(int BlogId)
    //    //        {
    //    //            foreach (var blog in _blogs)
    //    //            {
    //    //                if (blog.BlogId == BlogId)
    //    //                {
    //    //                    return blog;
    //    //                }
    //    //            }
    //    //            return new Blog();
    //    //        }

    //    //        public List<Blog> GetBlogsByCategory(string category)
    //    //        {
    //    //            return _blogs.Where(b => b.BlogCategory.CategoryName == category).ToList();
    //    //        }

    //    //        public List<Blog> GetBlogsByDate(string date)
    //    //        {
    //    //            var day = DateTime.Parse(date);
    //    //            return _blogs.Where(b => b.Date == day).ToList();
    //    //        }

    //    //        public List<Blog> GetBlogsByTag(string tag)
    //    //        {
    //    //            var toReturn = new List<Blog>();
    //    //            foreach (var blog in _blogs)
    //    //            {
    //    //                foreach (var tags in blog.BlogTags)
    //    //                {
    //    //                    if (tag.ToLower() == tags.TagName.ToLower())
    //    //                    {
    //    //                        toReturn.Add(blog);
    //    //                    }
    //    //                }
    //    //            }
    //    //            return toReturn;
    //    //        }

    //    //        public List<Blog> GetBlogsByTitle(string title)
    //    //        {
    //    //            List<Blog> toReturn = new List<Blog>();
    //    //            foreach (var blo in _blogs)
    //    //            {
    //    //                if (blo.Title.Contains(title))
    //    //                {
    //    //                    toReturn.Add(blo);
    //    //                }
    //    //            }
    //    //            return toReturn;
    //    //        }

    //    //        public List<Blog> GetNumberOfBlogs(int number, int set)
    //    //        {
    //    //            return _blogs.Skip(number * set).Take(number).ToList();
    //    //        }

    //    //        public List<Blog> GetSavedFromAuthor(string author)
    //    //        {
    //    //            return _blogs.Where(b => b.Author == author).Where(b => b.IsFinished == false).ToList();
    //    //        }

    //    //        public List<Blog> GetUnpublishedBlogs()
    //    //        {
    //    //            return _blogs.Where(b => b.IsFinished == false).ToList();
    //    //        }

    //    //        public List<Blog> GetAllBlogs()
    //    //        {
    //    //            List<Blog> toReturn = _blogs.OrderBy(b => b.Date).ToList();
    //    //            return toReturn;
    //    //        }
    //}
}
