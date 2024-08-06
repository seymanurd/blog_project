using DataAccessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class About_Manager
    {
        Repository<About> repo_about = new Repository<About>();

        public List<About> GetAll()
        {
            return repo_about.List();
        }
    }
}
