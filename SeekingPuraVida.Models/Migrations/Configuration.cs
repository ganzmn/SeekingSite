namespace SeekingPuraVida.Models.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SeekingPuraVida.Models.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SeekingPuraVida.Models.Identity.SeekingPuraVidaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SeekingPuraVida.Models.Identity.SeekingPuraVidaDbContext context)
        {
            var userMgr = new UserManager<AppUser>(new UserStore<AppUser>(context));
            var roleMgr = new RoleManager<AppRole>(new RoleStore<AppRole>(context));

            if (!roleMgr.RoleExists("admin"))
            {
                roleMgr.Create(new AppRole() { Name = "admin" });
            }

            if (!userMgr.Users.Any(u => u.UserName == "SeekingPV"))
            {
                var user = new AppUser()
                {
                    UserName = "SeekingPV"
                };
                userMgr.Create(user, "Hockey1!");
                userMgr.AddToRole(user.Id, "admin");
            }
        }
    }
}
