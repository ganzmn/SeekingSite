using System;
using SeekingPuraVida.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SeekingPuraVida.Data.BlogRepos;
using SeekingPuraVida.Models;

namespace SeekingPuraVida.Web.Controllers
{
    public class BlogController : ApiController
    {
        IBlogRepo repo = BlogRepoFactory.Create();

        [Route("blogs")]
        [AcceptVerbs("GET")]
        public IHttpActionResult All()
        {
            return Ok(repo.GetAllBlogs());
        }

        
        [Route("blogs/featured")]
        public List<Blog> GetFeatured()
        {
            List<Blog> toReturn = repo.GetFeaturedBlogs();
            return toReturn;
        }
    }
}
