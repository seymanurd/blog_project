using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class About
    {
        [Key]
        public int About_Id { get; set; }

        [StringLength(500)]
        public string About_Content1 { get; set; }

        [StringLength(500)]
        public string About_Content2 { get; set; }

        [StringLength(100)]
        public string About_Image1 { get; set; }

        [StringLength(100)]
        public string About_Image2 { get; set; }

    }
}
