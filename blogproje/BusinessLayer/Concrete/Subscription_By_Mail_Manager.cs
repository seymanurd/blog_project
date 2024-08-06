using DataAccessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Subscription_By_Mail_Manager
    {
        Repository<subscription_by_mail> reposubscription_by_mail = new Repository<subscription_by_mail>();
        public int bl_add(subscription_by_mail p)
        {
            
            if(p.eMail_Adress.Length<=9 || p.eMail_Adress.Length>=60 || p.eMail_Adress.IndexOf('@') == -1 )
            {
                return -1;
            }
            return reposubscription_by_mail.Insert(p);
        }
    }
}
