using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PersonalCVPageDheeb
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/js/jquery-1.11.2.min.js",
                        "~/Scripts/js/jquery.inview.min.js",
                        "~/Scripts/js/jquery.knob.min.js",
                        "~/Scripts/js/jquery-ui.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/javascripts").Include(
                        "~/Scripts/js/imagesloaded.pkgd.min.js",
                        "~/Scripts/js/isotope.pkgd.min.js",
                        "~/Scripts/js/owl.carousel.min.js",
                        "~/Scripts/js/scripts.js",
                        "~/Scripts/js/sammy-latest.min.js",
                        "~/Scripts/js/smoothscroll.js"));
            bundles.Add(new ScriptBundle("~/bundles/terrificjs").Include(
                        "~/Scripts/js/terrific-2.1.0.min.js",
                        "~/Scripts/js/terifficInit.js",
                        "~/Scripts/js/TerrificModules/*.js"
                ));
        }
    }
}