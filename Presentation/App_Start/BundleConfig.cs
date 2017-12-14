using System.Web;
using System.Web.Optimization;

namespace Presentation
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/GeneralJsLibraries").Include(
                "~/Scripts/Libraries/jquery-3.2.1.js",
                "~/Scripts/Libraries/DataTables-1.10.16.js",
                "~/Scripts/Libraries/bootstrap-3.3.7.js",
                "~/Scripts/Libraries/knockout-3.4.2.debug.js"                         
                ));

            bundles.Add(new StyleBundle("~/Content/GeneralCSSLibraries").Include(
                      "~/Content/Libraries/bootstrap-3.3.7.css",
                      "~/Content/Libraries/DataTables-1.110.16.css"));

            BundleTable.EnableOptimizations = true;

        }
    }
}
