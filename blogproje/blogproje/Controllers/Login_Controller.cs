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
    public class Login_Controller : Controller
    {
        // GET: Login_
        [HttpGet]
        public ActionResult Author_Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Author_Login(Author a)
        {
            Context c = new Context();
            var user_information = c.Authors.FirstOrDefault(x => x.Author_Mail == a.Author_Mail && x.Author_Password == a.Author_Password);
            if(user_information!=null)
            {
                FormsAuthentication.SetAuthCookie(user_information.Author_Mail, false);
                Session["Author_Mail"] = user_information.Author_Mail.ToString();
                return RedirectToAction("Index", "AuthorUser");
            }
            else
            {
                return RedirectToAction("Author_Login", "Login_");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Admin_Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Admin_Login(Admin a)
        {
            Context c = new Context();
            var admin_information = c.Admins.FirstOrDefault(x => x.UserName == a.UserName && x.Password == a.Password);
            if (admin_information != null)
            {
                FormsAuthentication.SetAuthCookie(admin_information.UserName, false);
                Session["UserName"] = admin_information.UserName.ToString();
                return RedirectToAction("Admin_Blog_List", "Blog");
            }
            else
            {
                return RedirectToAction("Admin_Login", "Login_");
            }
            return View();
        }
    }
}