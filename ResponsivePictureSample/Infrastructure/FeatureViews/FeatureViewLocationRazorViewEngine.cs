using System.Web.Mvc;

namespace ResponsivePictureSample.Infrastructure.FeatureViews
{
    public class FeatureViewLocationRazorViewEngine : RazorViewEngine
    {
        public FeatureViewLocationRazorViewEngine()
        {
            ViewLocationFormats = new[]
            {
                "~/Features/Pages/{1}/{0}.cshtml",
                "~/Features/Pages/{1}/{1}.cshtml",
                "~/Features/{1}/{0}.cshtml"
            };

            MasterLocationFormats = new[]
            {
                "~/Features/Layouts/{0}.cshtml",
            };

            PartialViewLocationFormats = new[]
            {
                "~/Features/{0}.cshtml",                // {0} -> DisplayTemplates\Image
                "~/Features/{1}/{0}.cshtml",            // {1} -> 
                "~/Features/Blocks/{1}/{0}.cshtml",
                "~/Features/Blocks/{0}/Index.cshtml",
                "~/Features/Partials/{0}.cshtml",
                "~/Features/Partials/{0}/{0}.cshtml",
                "~/Features/Partials/{1}/{0}.cshtml",
                "~/Features/Partials/GenericPage/{0}.cshtml",
                "~/Features/Partials/GenericBlock/{0}.cshtml",
                "~/Features/Partials/ContentListBlock/{0}.cshtml",
                "~/Features/Partials/ObjectListBlock/{0}.cshtml",
                "~/Features/Partials/SystemBlock/{0}.cshtml",
            };
        }
    }
}