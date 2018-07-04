using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekingPuraVida.Models
{
    public class ImageList
    {
        [Key]
        public int ID { get; set; }
        public string ImageLocation { get; set; }
    }
}
