using DevExpress.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresTrust.DevExReports.API.Domain;
using PresTrust.DevExReports.API.Extensions;
using PresTrust.DevExReports.API.Services;
using static PresTrust.DevExReports.API.Domain.DevExReportsDomainConstants;

namespace PresTrust.DevExReports.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Register services 
            services.AddDevExpressControls();
            services.RegisterDependencies(Configuration);

            services.AddControllers();
            var connectionString = new ConnectionStringConfiguration(Configuration.GetConnectionString(AppSettingKeys.PRESTRUST_SQL_DB_CONNECTION_STRING_SECTION));
            services.AddSingleton(connectionString);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("../swagger/v1/swagger.json", "PresTrust.DevExReports.API v1"));
            }

            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions;

            app.UseHttpsRedirection();
            app.UseCors(AppSettingKeys.CORS_POLICY_NAME);
            app.UseStaticFiles();
            app.UseDevExpressControls();
            app.UseRouting();
           // app.UseAuthentication(); // ???????????
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(new CustomReportStorageWebExtension(env));
        }
    }
}
