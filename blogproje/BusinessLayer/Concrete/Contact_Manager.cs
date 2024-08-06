using DataAccessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Contact_Manager
    {
        Repository<Contact> repo_contact = new Repository<Contact>();
        public int  buslContactAdd(Contact c)
        {
            if(c.Mail==""||c.Name==""||c.Message==""||c.Mail.IndexOf('@')==-1||c.Mail.Length<=8 )
            {
                return -1;
            }
            return repo_contact.Insert(c);
        }
    }
}
