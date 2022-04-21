using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using PresTrust.DevExReports.API.Contracts;

namespace PresTrust.DevExReports.API.DependencyInjection
{
    public class RegisterSwagger : IDependencyInjectionService
    {
        public void Register(IServiceCollection services, IConfiguration config)
        {
            // services.AddSwaggerGen(options =>
            //{
            //    options.SwaggerDoc("v1", new OpenApiInfo
            //    {
            //        Title = "DevExpress Reports API",
            //        Version = "v1",
            //        Description = "DevExpress Reports API"
            //    });
            //});
        }
    }
}
