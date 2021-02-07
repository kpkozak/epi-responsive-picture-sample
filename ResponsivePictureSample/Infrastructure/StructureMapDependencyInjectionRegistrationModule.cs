using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using StructureMap;
using IDependencyResolver = System.Web.Http.Dependencies.IDependencyResolver;
using InitializationModule = EPiServer.Web.InitializationModule;

// Based on
// https://github.com/fortedigital/EpiCommonUtils/blob/master/EpiCommonUtils/Infrastructure/DependencyInjection/StructureMapDependencyInjectionRegistrationModule.cs

namespace ResponsivePictureSample.Infrastructure
{
    [InitializableModule]
    [ModuleDependency(typeof(InitializationModule))]
    public class StructureMapDependencyInjectionRegistrationModule : IConfigurableModule
    {
        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            var resolver = new StructureMapDependencyResolver(context.StructureMap());
            DependencyResolver.SetResolver(resolver);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }

        private class StructureMapDependencyResolver : StructureMapDependencyScope, IDependencyResolver,
            System.Web.Mvc.IDependencyResolver
        {
            public StructureMapDependencyResolver(IContainer container) : base(container)
            {
            }

            public IDependencyScope BeginScope()
            {
                return new StructureMapDependencyScope(Container.GetNestedContainer());
            }
        }

        internal class StructureMapDependencyScope : IDependencyScope
        {
            protected readonly IContainer Container;

            public StructureMapDependencyScope(IContainer container)
            {
                Container = container;
            }

            public object GetService(Type serviceType)
            {
                if (serviceType.IsInterface || serviceType.IsAbstract)
                    return Container.TryGetInstance(serviceType);

                return Container.GetInstance(serviceType);
            }

            public IEnumerable<object> GetServices(Type serviceType)
            {
                return Container.GetAllInstances(serviceType).Cast<object>();
            }

            public void Dispose()
            {
                Container.Dispose();
            }
        }
    }
}