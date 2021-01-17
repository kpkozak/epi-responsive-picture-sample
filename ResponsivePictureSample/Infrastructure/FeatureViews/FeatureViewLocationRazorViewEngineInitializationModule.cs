using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace ResponsivePictureSample.Infrastructure.FeatureViews
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class FeatureViewLocationRazorViewEngineInitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            ViewEngines.Engines.Add(new FeatureViewLocationRazorViewEngine());
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}