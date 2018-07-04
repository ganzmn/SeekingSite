using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SeekingPuraVida.Data.BlogRepos;
using SeekingPuraVida.Models;
using SeekingPuraVida.Models.Identity;
using SeekingPuraVida.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeekingPuraVida.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var repo = BlogRepoFactory.Create();
            HomepageVM model = new HomepageVM();

            List<Blog> featuredBlogs = repo.GetFeaturedBlogs();
            List<Blog> allBlogs = repo.GetAllBlogs();

            model.AllBlogs = allBlogs;
            model.FeaturedBlogs = featuredBlogs;
            model.SetCategories(repo.getAllCategories());

            //repo.getBlogCategories(model.AllBlogs);
            //repo.getBlogCategories(model.FeaturedBlogs);


            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userManager = HttpContext.GetOwinContext().GetUserManager<UserManager<AppUser>>();
            var authManager = HttpContext.GetOwinContext().Authentication;

            // attempt to load the user with this password
            var user = userManager.Find(model.UserName, model.Password);

            // user will be null if the password or user name is bad
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");

                return View(model);
            }
            else
            {
                // successful login, set up their cookies and send them on their way
                var identity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authManager.SignIn(new AuthenticationProperties { IsPersistent = true }, identity);

                    return RedirectToAction("Index","Admin");
            }
        }
    }
}