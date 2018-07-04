﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekingPuraVida.Data.BlogRepos
{
    public static class BlogRepoFactory
    {
        public static IBlogRepo Create()
        {
            string mode = ConfigurationManager.AppSettings["Blog"].ToString();

            switch (mode)
            {
                case "EF":
                    return new EFBlogRepo();
                //case "Mock":
                //    return new MockBlogRepo();
                default:
                    throw new Exception("Mode value in app config is not valid.");
            }
        }
    }
}
