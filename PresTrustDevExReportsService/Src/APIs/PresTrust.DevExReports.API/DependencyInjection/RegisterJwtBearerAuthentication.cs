using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PresTrust.DevExReports.API.Contracts;
using static PresTrust.DevExReports.API.Domain.DevExReportsDomainConstants;

namespace PresTrust.DevExReports.API.DependencyInjection
{
    public class RegisterJwtBearerAuthentication : IDependencyInjectionService
    {
        public void Register(IServiceCollection services, IConfiguration config)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.Authority = config[AppSettingKeys.SECURITY_TOKEN_SERVICE_URL];
                o.Audience = config[AppSettingKeys.IDENTITY_SERVER_AUTHENTICATION_OPTION_API_NAME];
                o.TokenValidationParameters = new TokenValidationParameters { ValidateAudience = false };
                o.SaveToken = true;
            });
        }
    }
}
