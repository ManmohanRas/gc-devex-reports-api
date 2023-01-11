using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb.Native;
using DevExpress.DashboardWeb;
using Microsoft.Extensions.FileProviders;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.Json;
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
        public Startup(IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            FileProvider = hostingEnvironment.ContentRootFileProvider;
            DashboardExportSettings.CompatibilityMode = DashboardExportCompatibilityMode.Restricted;
        }

        public IFileProvider FileProvider { get; }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDevExpressControls();
            services.RegisterDependencies(Configuration);
            services.AddControllers();
            var connectionString = new ConnectionStringConfiguration(Configuration.GetConnectionString(AppSettingKeys.PRESTRUST_SQL_DB_CONNECTION_STRING_SECTION));
            services.AddSingleton(connectionString);
            services.AddScoped<DashboardConfigurator>((System.IServiceProvider serviceProvider) => {
                DashboardConfigurator configurator = new DashboardConfigurator();
                //configurator.SetDashboardStorage(new DashboardFileStorage(FileProvider.GetFileInfo("PredefinedDashboards/Dashboard1.xml").PhysicalPath));
                configurator.SetDashboardStorage(new DashboardFileStorage(FileProvider.GetFileInfo("PredefinedDashboards").PhysicalPath));
                configurator.SetConnectionStringsProvider(new DashboardConnectionStringsProvider(Configuration));
                return configurator;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("../swagger/v1/swagger.json", "PresTrust.DevExReports.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors(AppSettingKeys.CORS_POLICY_NAME);
            app.UseStaticFiles();
            app.UseDevExpressControls();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                EndpointRouteBuilderExtension.MapDashboardRoute(endpoints, "dashboard", "CustomDashboard");
                endpoints.MapControllers();
            });

            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions;
            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(new CustomReportStorageWebExtension(env));
        }
    }
}
