using System.Web;
using System.Web.Optimization;

namespace Deed.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery-migrate.min.js",
                        "~/Scripts/jquery.jcarousel.min.js",
                        "~/Scripts/jquery.themepunch.plugins.min.js",
                        "~/Scripts/jquery.themepunch.revolution.min.js",
                        "~/Scripts/jquery.flexslider-min.js",
                        //"~/Scripts/jquery.easing.1.3.js",
                        "~/Scripts/jquery.elastislide.js",
                        "~/Scripts/jquery.prettyPhoto.js",
                        "~/Scripts/jquery.swipebox.min.js",
                        "~/Scripts/jquery.isotope.min.js",
                        
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.form.js",
                        "~/Scripts/jquery.selectbox.js",
                        "~/Scripts/jquery.transit.min.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootstrap-carousel.js",

                        "~/Scripts/jquery.ui.core.min.js",
                        "~/Scripts/jquery.ui.widget.min.js",
                        "~/Scripts/jquery.ui.position.min.js",
                        "~/Scripts/jquery.ui.menu.min.js",
                        "~/Scripts/jquery.jquery.ui.autocomplete.min.js",
                        "~/Scripts/jquery.localisation.js",
                        "~/Scripts/custom.js",
                        "~/Scripts/respond.matchmedia.addListener.js",
                        "~/Scripts/respond.matchmedia.addListener.min.js",
                        "~/Scripts/main.js",
                        "~/Scripts/ProgresBar.js",
                        "~/Scripts/knockout-3.1.0.js",
                        "~/Scripts/js-image-slider.js"

                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"

            //        ));



            bundles.Add(new StyleBundle("~/Styles/css").Include(

                      "~/Content/css/client1.css",
                      "~/Content/css/client.css",
                      "~/Content/css/settings.css",
                      "~/Content/css/dynamic-captions.css",
                      "~/Content/css/css1.css",
                      "~/Content/css/css.css",
                      "~/Content/bootstrap.css",
                      "~/Content/css/responsive.css",
                       "~/Content/css/font-awesome.css",
                       "~/Content/flexslider.css",
                       "~/Content/css/prettyPhoto.css",
                       "~/Content/css/swipebox.css",
                       "~/Content/css/main.css",
                        "~/Content/css/custom-responsive.css",
                        "~/Content/css/custom.css",
                        "~/Content/css/child-custom.css",
                       "~/Content/site.css",
                        "~/Content/js-image-slider.css",
                         "~/Content/site.css",
                         "~/Content/Progress.css",
                       "~/Content/css/generic.css"

                    ));
        }
    }
}
