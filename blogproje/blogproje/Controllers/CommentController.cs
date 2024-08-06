using BusinessLayer.Concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogproje.Controllers
{
    public class CommentController : Controller
    {
        Comment_Manager comm = new Comment_Manager();
        public PartialViewResult CommentList(int ID)
        {
            
            var comment_list = comm.Comment_With_Blog(ID);
            return PartialView(comment_list);
        }
        [HttpGet]
        public PartialViewResult LeaveComment(int ID)
        {
            ViewBag.ID = ID;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LeaveComment(Comment c)
        {
            comm.add_comment(c);
            return PartialView();
        }
    }
}