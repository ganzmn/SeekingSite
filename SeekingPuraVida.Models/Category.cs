using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekingPuraVida.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Blog> Blog { get; set; }

        public Category()
        {
            Blog = new HashSet<Blog>();
        }
    }
}
