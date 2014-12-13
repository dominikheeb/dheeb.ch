using System;
using System.Collections.Generic;
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
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PhtPage()
        {
            return PartialView();
        }
    }
}