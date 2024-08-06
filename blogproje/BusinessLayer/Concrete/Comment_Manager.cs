using DataAccessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Comment_Manager
    {
        Repository<Comment> repo_comment = new Repository<Comment>();
        public List<Comment> Comment_List()
        {
            return repo_comment.List();
        }
        public List<Comment> Comment_With_Blog(int ID)
        {
            return repo_comment.List(x => x.Blog_ID == ID);
        }
        public int add_comment(Comment c)
        {
            if(c.Comment_Text.Length<=1||c.Comment_Text.Length>=301||c.UserName.Length<=2||c.Mail==""||c.UserName=="")
            {
                return -1;
            }
            return repo_comment.Insert(c);
        }
    }
}
