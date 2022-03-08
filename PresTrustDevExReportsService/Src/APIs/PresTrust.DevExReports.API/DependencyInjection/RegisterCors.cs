using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PresTrust.DevExReports.API.Contracts;
using static PresTrust.DevExReports.API.Domain.DevExReportsDomainConstants;

namespace PresTrust.DevExReports.API.DependencyInjection
{
    public class RegisterCors : IDependencyInjectionService
    {
        public void Register(IServiceCollection services, IConfiguration config)
        {
            string[] allowedHosts = config.GetSection(AppSettingKeys.CORS_POLICIES_SECTION).Get<string[]>();

            services.AddCors(options =>
            {
                options.AddPolicy(AppSettingKeys.CORS_POLICY_NAME,
                builder =>
                {
                    builder.WithOrigins(allowedHosts)
                           .AllowAnyHeader()
                           .AllowAnyMethod()
                           .AllowCredentials();
                });
            });
        }
    }
}
