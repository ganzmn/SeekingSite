using SeekingPuraVida.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeekingPuraVida.Web.Models
{
    public class BlogVM
    {
        public Blog Blog { get; set; }
        public ICollection<Category> BlogCategories { get; set; }
        public ICollection<Tag> BlogTags { get; set; }
        public ICollection<ImageList> ImageLocationList { get; set; }
        public bool IsFinished { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
        public string NewCategory { get; set; }
        public string FeatureImageLocation { get; set; }
        public HttpPostedFileBase File { get; set; }

        public List<SelectListItem> CategoryItems { get; set; }
        public List<int> SelectedCategoryIds { get; set; }

        public BlogVM()
        {
            CategoryItems = new List<SelectListItem>();
            BlogTags = new List<Tag>();
            BlogCategories = new List<Category>();
            SelectedCategoryIds = new List<int>();
            ImageLocationList = new List<ImageList>();
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