using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ResponsivePictureSample.ReactConfig), "Configure")]

namespace ResponsivePictureSample
{
	public static class ReactConfig
	{
		public static void Configure()
		{
			// https://github.com/vikpe/react-webpack-typescript-starter
			ReactSiteConfiguration.Configuration
				.SetLoadBabel(false)
				.SetLoadReact(false)
				.SetJsonSerializerSettings(new JsonSerializerSettings
				{
					ContractResolver = new CamelCasePropertyNamesContractResolver(),
				})
				.AddScriptWithoutTransform("~/dist/js/bundle.min.js");

			JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
			JsEngineSwitcher.Current.EngineFactories.AddV8();
		}
	}
}