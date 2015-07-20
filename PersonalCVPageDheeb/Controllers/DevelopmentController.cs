using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalCVPageDheeb.Controllers
{
    public class DevelopmentController : Controller
    {
        // GET: Development
        public PartialViewResult Education()
        {
            return PartialView();
        }

        public PartialViewResult Skills()
        {
            return PartialView();
        }

        public PartialViewResult Experience()
        {
            return PartialView();
        }
    }
}