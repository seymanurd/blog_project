using DataAccessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        Repository<Blog> repoblog = new Repository<Blog>();

        public List<Blog> GetAll()
        {
            return repoblog.List();
        }

        public List<Blog> Get_Blog_With_ID(int ID)
        {
            return repoblog.List(x => x.Blog_ID == ID);
        }
        public List<Blog> Get_Blog_With_Category(int ID)
        {
            return repoblog.List(x => x.Category_ID == ID);
        }
        public int Add_Blog_ad(Blog p)
        {
            if(p.Blog_Title=="")
            {
                return -1;
            }
           return repoblog.Insert(p);
        }
        public int Delete_Blog_bl(int i)
        {
            Blog blog = repoblog.Find(x => x.Blog_ID == i);
            return repoblog.Delete(blog);

        }
    }
}
