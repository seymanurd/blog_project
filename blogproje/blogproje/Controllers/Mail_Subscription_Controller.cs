using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityLayer.concrete;
using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace blogproje.Controllers
{
    public class Mail_Subscription_Controller : Controller
    {
        [HttpGet]
        public PartialViewResult Add_Mail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Add_Mail(subscription_by_mail p)
        {
            Subscription_By_Mail_Manager subm = new Subscription_By_Mail_Manager();
            subm.bl_add(p);
            return PartialView();
        }
    }
}