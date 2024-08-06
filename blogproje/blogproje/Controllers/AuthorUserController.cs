using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace blogproje.Controllers
{
    public class AuthorUserController : Controller
    {
        // GET: AuthorUser
        User_Profile_Manager user_Profile = new User_Profile_Manager();
        BlogManager bm = new BlogManager();
        public ActionResult Index(string s)
        {
            var mail = (string)Session["Author_Mail"];
            s = mail;
            var profileinfoval = user_Profile.Get_Author_With_Mail(s);
            return View(profileinfoval);
        }
        public ActionResult Update_AuthorUser_Profile(Author a)
        {
            user_Profile.Edit_Authors(a);
            return RedirectToAction("Index");
        }
        public ActionResult Blog_Lists(string s)
        {
            var mail = (string)Session["Author_Mail"];
            s = mail;
            Context c = new Context();
            int ID = c.Authors.Where(x => x.Author_Mail == s).Select(y => y.Author_Id).FirstOrDefault();
            var blogs = user_Profile.Get_Blog_With_Author(ID);
            return View(blogs);
        }
        [HttpGet]
        public ActionResult Add_Blog()
        {
            Context co = new Context();
            List<SelectListItem> value = (from x in co.Categories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.Category_Name,
                                              Value = x.Category_ID.ToString()
                                          }).ToList();
            ViewBag.value = value;
            return View();
        }
        [HttpPost]
        public ActionResult Add_Blog(Blog k)
        {
            bm.Add_Blog_ad(k);
            return RedirectToAction("Blog_Lists");
        }
        public ActionResult Delete_Blog(int ID)
        {
            bm.Delete_Blog_bl(ID);
            return RedirectToAction("Blog_Lists");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Author_Login", "Login_");
        }
    }
}