using BusinessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogproje.Controllers
{
    public class AuthorController : Controller
    {
        BlogManager blogm = new BlogManager();
        Author_Manager autman = new Author_Manager();
        public PartialViewResult AuthorAbout(int ID)
        {
            var author_detail = blogm.Get_Blog_With_ID(ID);
            return PartialView(author_detail);
        }
        public PartialViewResult AuthorPopularPost(int ID)
        {
            var blog_author_ID = blogm.GetAll().Where(x => x.Blog_ID == ID).Select(y => y.Author_Id).FirstOrDefault();
            ViewBag.blog_author_ID = blog_author_ID;
            var author_blogs = blogm.Get_Blog_With_ID(blog_author_ID);
            return PartialView(author_blogs);
        }
        public ActionResult Author_List()
        {
            var author_lists= autman.GetAll();
            return View(author_lists);
        }
        [HttpGet]
        public ActionResult Add_Author()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Author(Author a)
        {
            autman.Add_AuthorBl(a);
            return RedirectToAction("Author_List");
        }
        [HttpGet]
        public ActionResult Author_Edit(int ID)
        {
            Author author = autman.Find_Author(ID);
            return View(author);
        }
        [HttpPost]
        public ActionResult Author_Edit(Author a)
        {
            autman.Edit_Authors(a);
            return RedirectToAction("Author_List");
        }

    }
}