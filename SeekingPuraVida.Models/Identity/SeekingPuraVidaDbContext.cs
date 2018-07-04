using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekingPuraVida.Models.Identity
{
    public class SeekingPuraVidaDbContext : IdentityDbContext<AppUser>
    {
        public SeekingPuraVidaDbContext() : base("SeekingPuraVida")
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogSection> BlogSections { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        
    }
}
