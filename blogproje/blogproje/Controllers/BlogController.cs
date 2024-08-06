using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.concrete;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogproje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager bm = new BlogManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogList()
        {
            var bloglist = bm.GetAll();
            return PartialView(bloglist);
        }
        public PartialViewResult FeaturedPosts()
        {
            var post_title_1 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 1).Select(y => y.Blog_Title).FirstOrDefault();
            var post_image_1 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 1).Select(y => y.Blog_Image).FirstOrDefault();
            var blog_date_1 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 1).Select(y => y.Blog_Date).FirstOrDefault();
            var blogpostID_1 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 1).Select(y => y.Blog_ID).FirstOrDefault();
            ViewBag.post_title_1 = post_title_1;
            ViewBag.post_image_1 = post_image_1;
            ViewBag.blog_date_1 = blog_date_1;
            ViewBag.blogpostID_1 = blogpostID_1;

            var post_title_2 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 2).Select(y => y.Blog_Title).FirstOrDefault();
            var post_image_2 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 2).Select(y => y.Blog_Image).FirstOrDefault();
            var blog_date_2 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 2).Select(y => y.Blog_Date).FirstOrDefault();
            var blogpostID_2 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 2).Select(y => y.Blog_ID).FirstOrDefault();
            ViewBag.post_title_2 = post_title_2;
            ViewBag.post_image_2 = post_image_2;
            ViewBag.blog_date_2 = blog_date_2;
            ViewBag.blogpostID_2 = blogpostID_2;

            var post_title_3 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 3).Select(y => y.Blog_Title).FirstOrDefault();
            var post_image_3 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 3).Select(y => y.Blog_Image).FirstOrDefault();
            var blog_date_3 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 3).Select(y => y.Blog_Date).FirstOrDefault();
            var blogpostID_3 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 3).Select(y => y.Blog_ID).FirstOrDefault();
            ViewBag.post_title_3 = post_title_3;
            ViewBag.post_image_3 = post_image_3;
            ViewBag.blog_date_3 = blog_date_3;
            ViewBag.blogpostID_3 = blogpostID_3;

            var post_title_4 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 4).Select(y => y.Blog_Title).FirstOrDefault();
            var post_image_4 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 4).Select(y => y.Blog_Image).FirstOrDefault();
            var blog_date_4 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 4).Select(y => y.Blog_Date).FirstOrDefault();
            var blogpostID_4 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 4).Select(y => y.Blog_ID).FirstOrDefault();
            ViewBag.post_title_4 = post_title_4;
            ViewBag.post_image_4 = post_image_4;
            ViewBag.blog_date_4 = blog_date_4;
            ViewBag.blogpostID_4 = blogpostID_4;

            var post_title_5 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 5).Select(y => y.Blog_Title).FirstOrDefault();
            var post_image_5 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 5).Select(y => y.Blog_Image).FirstOrDefault();
            var blog_date_5 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 5).Select(y => y.Blog_Date).FirstOrDefault();
            var blogpostID_5 = bm.GetAll().OrderByDescending(z => z.Blog_ID).Where(x => x.Category_ID == 5).Select(y => y.Blog_ID).FirstOrDefault();
            ViewBag.post_title_5 = post_title_5;
            ViewBag.post_image_5 = post_image_5;
            ViewBag.blog_date_5 = blog_date_5;
            ViewBag.blogpostID_5 = blogpostID_5;




            return PartialView();
        }
        
        public ActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogCover(int ID)
        {
            var Blog_Details_List = bm.Get_Blog_With_ID(ID);
            return PartialView(Blog_Details_List);
        }
        public PartialViewResult BlogReadAll(int ID)
        {
            var Blog_Details_List = bm.Get_Blog_With_ID(ID);
            return PartialView(Blog_Details_List);
        }
        public ActionResult BlogByCategory(int ID)
        {
            var Blog_List_By_Category = bm.Get_Blog_With_Category(ID);
            return View(Blog_List_By_Category);
        }
        public ActionResult Admin_Blog_List()
        {
            var blog_list = bm.GetAll();
            return View(blog_list);
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
            return RedirectToAction("Admin_Blog_List");
        }
        public ActionResult Delete_Blog(int ID)
        {
            bm.Delete_Blog_bl(ID);
            return RedirectToAction("Admin_Blog_List");
        }

    }
}