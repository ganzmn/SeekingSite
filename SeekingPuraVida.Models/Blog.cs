using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekingPuraVida.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Author { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Category> BlogCategories { get; set; }
        public virtual ICollection<Tag> BlogTags { get; set; }
        public string BlogBody{ get; set; }
        public bool IsFinished { get; set; }
        public bool IsFeatured { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
        public string FeatureImageLocation { get; set; }
        public virtual ICollection<ImageList> ImageLocationList { get; set; }

        public Blog()
        {
            BlogTags = new HashSet<Tag>();
            ImageLocationList = new HashSet<ImageList>();
            BlogCategories = new HashSet<Category>();
        }
    }
}
