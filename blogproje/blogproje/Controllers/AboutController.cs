using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Concrete;
using System.Web;
using System.Web.Mvc;

namespace blogproje.Controllers
{
    public class AboutController : Controller
    {
        About_Manager aboutm = new About_Manager();
        public ActionResult Index()
        {
            var about_content = aboutm.GetAll();
            return View(about_content);
        }
        public PartialViewResult Footer()
        {
            
            var about_content_list = aboutm.GetAll();
            return PartialView(about_content_list);
        }
        public PartialViewResult MeetTheTeam()
        {
            Author_Manager authorm = new Author_Manager();
            var author_list = authorm.GetAll();
            return PartialView(author_list);
        }
    }
}