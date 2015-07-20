using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalCVPageDheeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Home()
        {
            return PartialView();
        }
        public PartialViewResult AboutMe()
        {
            return PartialView();
        }

        public PartialViewResult Contact()
        {
            return PartialView();
        }

        public PartialViewResult Blog()
        {
            return PartialView();
        }
    }
}