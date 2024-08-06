using DataAccessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Author_Manager
    {
        Repository<Author> repo_author = new Repository<Author>();

        public List<Author> GetAll()
        {
            return repo_author.List();
        }
        public int Add_AuthorBl(Author a)
        {
            if(a.Author_Name=="")
            {
                return -1;
            }
            return repo_author.Insert(a);
        }

        // yazarı ide göre edit sayfasına taşıma
        public Author Find_Author(int ID)
        {
            return repo_author.Find(x => x.Author_Id == ID);
        }
        public int Edit_Authors(Author a)
        {
            Author author = repo_author.Find(x => x.Author_Id == a.Author_Id);
            author.Author_About = a.Author_About;
            author.Author_Name = a.Author_Name;
            author.Author_Image = a.Author_Image;
            author.Author_Password = a.Author_Password;
            author.Author_Mail = a.Author_Mail;
            author.Author_Phone = a.Author_Phone;
            return repo_author.Update(author);
        }

    }
}
