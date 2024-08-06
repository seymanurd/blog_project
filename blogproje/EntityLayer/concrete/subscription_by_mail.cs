using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class subscription_by_mail
    {
        [Key]
        public int Mail_ID { get; set; }
        [StringLength(65)]
        public string eMail_Adress { get; set; }


    }
}
