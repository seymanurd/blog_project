using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class Comment
    {
        [Key]
        public int Comment_Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(60)]
        public string Mail { get; set; }

        [StringLength(300)]
        public string Comment_Text { get; set; }

        public int Blog_ID { get; set; }
         public virtual Blog Blogs { get; set; }
        public DateTime Comment_date { get; set; }
    }
}
