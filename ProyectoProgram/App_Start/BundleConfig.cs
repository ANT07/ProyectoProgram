using System.Web;
using System.Web.Optimization;

namespace ProyectoProgram
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquer").Include(
                        "~/Scripts/jquery-{version}.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryva").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                "~/Content/themes/base/accordion.css",
                "~/Content/themes/base/all.css",
                "~/Content/themes/base/autocomplete.css",
                "~/Content/themes/base/base.css",
                "~/Content/themes/base/button.css",
                "~/Content/themes/base/core.css",
                "~/Content/themes/base/datepicker.css",
                "~/Content/themes/base/dialog.css",
                "~/Content/themes/base/draggable.css",
                "~/Content/themes/base/jquery-ui.css",
                "~/Content/themes/base/menu.css",
                "~/Content/themes/base/progressbar.css",
                "~/Content/themes/base/resizable.css",
                "~/Content/themes/base/selectable.css",
                "~/Content/themes/base/selectmenu.css",
                "~/Content/themes/base/slider.css",
                "~/Content/themes/base/sortable.css",
                "~/Content/themes/base/spinner.css",
                "~/Content/themes/base/tabs.css",
                "~/Content/themes/base/theme.css",
                "~/Content/themes/base/tooltip.css"
                ));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                       "~/Content/bootstrap-theme.css",
                       "~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/Bootstrap").Include(
                       "~/Scripts/bootstrap.js"));
        }
    }
}
