﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalCVPageDheeb.Controllers
{
    public class WidgetsController : Controller
    {
        // GET: Widgets
        public PartialViewResult ContactSidebar()
        {
            return PartialView();
        }
    }
}