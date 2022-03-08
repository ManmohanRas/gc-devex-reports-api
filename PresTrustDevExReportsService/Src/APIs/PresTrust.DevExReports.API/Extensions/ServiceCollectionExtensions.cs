using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PresTrust.DevExReports.API.Contracts;
using System;
using System.Linq;

namespace PresTrust.DevExReports.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var appServices = typeof(Startup).Assembly.DefinedTypes
                            .Where(x => typeof(IDependencyInjectionService)
                            .IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                            .Select(Activator.CreateInstance)
                            .Cast<IDependencyInjectionService>().ToList();

            appServices.ForEach(svc => svc.Register(services, configuration));
        }
    }
}
