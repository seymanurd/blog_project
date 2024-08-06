using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class Author
    {
        [Key]
        public int  Author_Id { get; set; }

        [StringLength(50)]
        public string Author_Name { get; set; }

        [StringLength(100)]
        public string Author_Image { get; set; }

        [StringLength(300)]
        public string Author_About { get; set; }

        [StringLength(25)]
        public string Author_Password { get; set; }

        [StringLength(55)]
        public string Author_Mail { get; set; }

        [StringLength(20)]
        public string Author_Phone { get; set; }

        public ICollection<Blog> Blogs { get; set; }


    }
}
