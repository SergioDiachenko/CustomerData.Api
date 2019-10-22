using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using CustomerData.Api.Data;
using System.Reflection;
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
            var config = new MapperConfiguration(configuration =>
            {
                configuration.AddProfile(new CustomerMappingProfile());
            });

            builder.RegisterInstance(config.CreateMapper())
                .As<IMapper>()
                .SingleInstance();

            builder.RegisterType<CustomerDataContext>().InstancePerRequest();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerRequest();
        }
    }
}