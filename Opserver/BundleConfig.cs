using System.Web.Optimization;

namespace StackExchange.Opserver
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Scripts

            bundles.Add(new ScriptBundle("~/assets/js/plugins").IncludeDirectory("~/Content/js/plugins", "*.js"));
            bundles.Add(new ScriptBundle("~/assets/js/scripts").Include("~/Content/js/Scripts*"));
            bundles.Add(new ScriptBundle("~/assets/js/login").Include("~/Content/js/Login.js"));

            #endregion

            #region CSS

            bundles.Add(new StyleBundle("~/assets/css/login").Include("~/Content/Login.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/assets/css/styles").Include("~/Content/Styles.css", new CssRewriteUrlTransform()));

            #endregion

            BundleTable.EnableOptimizations = false;

        }
    }
}