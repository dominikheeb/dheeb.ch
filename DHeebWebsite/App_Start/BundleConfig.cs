using System.Web;
using System.Web.Optimization;

namespace DHeebWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/defaultTemplate").Include(
                      "~/Content/defaultTemplate/bootstrap.css"
                ));
            bundles.Add(new StyleBundle("~/Content/paperTemplate").Include(
                      "~/Content/bootswatchPaper/bootstrap.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/routingConfig").Include(
                "~/js/routing/routing.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/Chart.js",
                "~/Scripts/sammy-latest.min.js"
                ));
            bundles.Add(new LessBundle("~/Content/less").Include("~/Content/site.less"));
            bundles.Add(new LessBundle("~/Content/lessHomePage").Include("~/Content/homePage.less"));
            bundles.Add(new LessBundle("~/Content/lessDevPage").Include("~/Content/devPage.less"));
            bundles.Add(new LessBundle("~/Content/lessPhotoPage").Include("~/Content/photoPage.less"));
        }
    }
}
