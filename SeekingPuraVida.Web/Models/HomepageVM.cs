using SeekingPuraVida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeekingPuraVida.Web.Models
{
    public class HomepageVM
    {
        public List<Blog> AllBlogs { get; set; }
        public List<Blog> FeaturedBlogs { get; set; }
        public ICollection<Category> BlogCategories { get; set; }
        public List<SelectListItem> CategoryItems { get; set; }
        public List<int> SelectedCategoryIds { get; set; }

        public HomepageVM()
        {
            CategoryItems = new List<SelectListItem>();
            BlogCategories = new List<Category>();
            SelectedCategoryIds = new List<int>();
        }

        public void SetCategories(List<Category> category)
        {
            category = category.OrderBy(c => c.CategoryName).ToList();
            foreach (var c in category)
            {
                CategoryItems.Add(new SelectListItem()
                {
                    Value = c.CategoryId.ToString(),
                    Text = c.CategoryName
                });
            }
        }
    }
}