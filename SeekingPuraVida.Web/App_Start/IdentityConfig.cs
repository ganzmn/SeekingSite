using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Owin;
using SeekingPuraVida.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeekingPuraVida.Web.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions()
            { 
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/auth/login")
            });

            app.CreatePerOwinContext(() => new SeekingPuraVidaDbContext());
            app.CreatePerOwinContext<UserManager<AppUser>>((options, context) => new UserManager<AppUser>(new UserStore<AppUser>(context.Get<SeekingPuraVidaDbContext>())));
            app.CreatePerOwinContext<RoleManager<AppRole>>((options, context) => new RoleManager<AppRole>(new RoleStore<AppRole>(context.Get<SeekingPuraVidaDbContext>())));

        }
    }
}