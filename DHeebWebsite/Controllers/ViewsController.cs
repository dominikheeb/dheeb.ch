using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DHeebWebsite.Controllers
{
    public class ViewsController : Controller
    {
        [HttpPost]
        public PartialViewResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult DevPage()
        {
            string conStr = ConfigurationManager.ConnectionStrings["FlickrNet"].ConnectionString;
            return PartialView((object)conStr);
        }

        [HttpPost]
        public PartialViewResult PhtPage()
        {
            return PartialView();
        }
    }
}