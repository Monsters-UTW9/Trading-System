using System.Web;
using System.Web.Optimization;

namespace UTW9Project
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            var jqueryCdnPath = "http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js";

            bundles.Add(new StyleBundle("~/Content/SharedStyles").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/SharedStyle.css",
                      "~/Content/font-awesome.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts/SharedScripts", jqueryCdnPath).Include(
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/DataTables", jqueryCdnPath).Include(
                      "~/Scripts/dataTables/jquery.dataTables.min.js",
                      "~/Scripts/dataTables/dataTables.bootstrap.min.js",
                      "~/Scripts/dataTables/dataTables.keyTable.min.js",
                      "~/Scripts/UserScript.js"));

        }
    }
}
