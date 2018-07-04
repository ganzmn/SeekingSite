using SeekingPuraVida.Data.BlogRepos;
using SeekingPuraVida.Models;
using SeekingPuraVida.Models.Identity;
using SeekingPuraVida.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeekingPuraVida.Web.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        IBlogRepo repo = BlogRepoFactory.Create();
        SeekingPuraVidaDbContext context = new SeekingPuraVidaDbContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddBlog()
        {
            BlogVM model = new BlogVM()
            {
                BlogCategories = new List<Category>(),
                Blog = new Blog()
            };
            model.Blog.Author = User.Identity.Name;
            model.Blog.BlogTags = new List<Tag>();
            model.Blog.Date = DateTime.Today;

            model.SetCategories(context.Categories.ToList());

            return View(model);
        }

        [HttpPost]
        public ActionResult AddBlog(BlogVM model)
        {
            EFBlogRepo repo = new EFBlogRepo();
            model.Blog.Author = User.Identity.Name;
            model.Blog.Date = DateTime.Now;

            if (model.File != null)
            {
                //create new folder for blog images
                string title = model.Blog.Title.Replace(" ", "_");
                string pathString = Server.MapPath("~//img//blogimages");
                pathString += "//" + title;
                System.IO.Directory.CreateDirectory(pathString);

                string pic = Path.GetFileName(model.File.FileName);
                string path = Path.Combine(
                                       Server.MapPath("~//img//blogimages//"+title), pic);

                model.Blog.FeatureImageLocation = path;
                // file is uploaded
                model.File.SaveAs(path);
            }

            model.Blog.BlogCategories = new List<Category>();

            foreach (var id in model.SelectedCategoryIds)
                model.Blog.BlogCategories.Add(repo.GetCategory(id));

            repo.AddBlog(model.Blog);

                return RedirectToAction("Index");
        }

        public ActionResult AddCategory()
        {
            Category model = new Category();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddCategory(string command, Category model)
        {
            if(command == "Cancel")
            {
                return RedirectToAction("Index");
            }
            if(command == "Submit")
            {
                EFBlogRepo repo = new EFBlogRepo();
                repo.AddNewCategory(model.CategoryName);

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


    }
}