using System.Web;
using System.Web.Optimization;

namespace Handson
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Basejquery").Include(
                       "~/Scripts/library/jquery.js",
                       "~/Scripts/library/jquery-confirm.js",
                       "~/Scripts/library/bootstrap-toggle.min.js",
                       "~/Scripts/library/bootstrap.min.js",
                       "~/Scripts/Uteis.js",
                       "~/Scripts/library/bmodal.js"));


            bundles.Add(new StyleBundle("~/bundles/Basecss").Include(
                        "~/Content/library/bootstrap-toggle.min.css",
                        "~/Content/library/jquery-confirm.css",
                        "~/Content/library/Modal.css",
                        "~/Content/library/bootstrap.min.css"));

            BundleTable.EnableOptimizations = true;
        }

    }
}
