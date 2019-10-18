using Autofac;
using Autofac.Integration.WebApi;
using CustomerData.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace CustomerData.Api.App_Start
{
    public static class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            RegisterServices(builder);
            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        public static void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerDataContext>().InstancePerRequest();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerRequest();
        }
    }
}