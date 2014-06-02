using System.Web;
using System.Web.Optimization;

namespace Deed.Web {
    public class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery.flexslider-min.js",
                        "~/Scripts/jquery.jcarousel.min.js",
                        "~/Scripts/jquery.themepunch.revolution.min.js",
                        "~/Scripts/jquery.ui.core.min.js",
                        "~/Scripts/jquery.ui.menu.min.js",
                        "~/Scripts/jquery.ui.position.min.js",
                        "~/Scripts/respond.matchmedia.addListener.js",
                        "~/Scripts/respond.matchmedia.addListener.min.js",
                        "~/Scripts/jquery.easing.1.3.js",
                        "~/Scripts/jquery.elastislide.js",
                        "~/Scripts/jquery.form.js",
                        "~/Scripts/jquery.isotope.min.js",
                        "~/Scripts/jquery.jquery.ui.autocomplete.min.js",
                        "~/Scripts/jquery.ui.widget.min.js",
                        "~/Scripts/custom.js"
                        
                        
                        

                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"
                     
                    ));

            

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/css/font-awesome.css",
                      "~/Content/css/style.css",
                      "~/Content/css/client.css",
                       "~/Content/site.css",
                       "~/Content/css/swipebox.css",
                       "~/Content/css/main.css",
                       "~/Content/css/swipebox.css",
                        "~/Content/css/responsive.css",
                        "~/Content/css/settings.css",
                         "~/Content/css/custom-responsive.css",
                          "~/Content/css/custom-responsive.css",
                          "~/Content/css/child-custom.css"


    ));



            

        }
    }
}
