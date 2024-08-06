using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class Blog
    {
        [Key]
        public int Blog_ID { get; set; }

        [StringLength(100)]
        public string Blog_Title { get; set; }

        [StringLength(100)]
        public string Blog_Image { get; set; }

        public DateTime Blog_Date { get; set; }

        public string Blog_Content { get; set; }

        public int Category_ID { get; set; }
        public virtual Category Category { get; set; }
        //category sınıfını bloklarla ilişkili hale getirecek

        public int Author_Id { get; set; }
        public virtual Author Author  { get; set; }

        public ICollection<Comment> Comments{ get; set; }



    }
}
