using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }

        [StringLength(30)]
        public string Category_Name { get; set; }
        [StringLength(550)]
        public string Category_Description { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
