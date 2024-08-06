using BusinessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogproje.Controllers
{
    public class ContactController : Controller
    {
        Contact_Manager conm = new Contact_Manager();
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Add_Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Contact(Contact k)
        {
            conm.buslContactAdd(k);
            return View();
        }
    }
}