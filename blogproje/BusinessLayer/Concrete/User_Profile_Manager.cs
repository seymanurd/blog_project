using DataAccessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class User_Profile_Manager
    {
        Repository<Author> repo_userman = new Repository<Author>();
        Repository<Blog> repo_userblog = new Repository<Blog>();

        public List<Author> Get_Author_With_Mail(string s)
        {
            return repo_userman.List(x => x.Author_Mail == s);
        }
        public List<Blog> Get_Blog_With_Author(int ID)
        {
            return repo_userblog.List(x => x.Author_Id == ID);
        }
        public int Edit_Authors(Author a)
        {
            Author author = repo_userman.Find(x => x.Author_Id == a.Author_Id);
            author.Author_About = a.Author_About;
            author.Author_Name = a.Author_Name;
            author.Author_Image = a.Author_Image;
            author.Author_Password = a.Author_Password;
            author.Author_Mail = a.Author_Mail;
            author.Author_Phone = a.Author_Phone;
            return repo_userman.Update(author);
        }
    }
}
