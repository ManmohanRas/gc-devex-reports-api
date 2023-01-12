using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace PresTrust.DevExReports.API.Configurators
{
    public class CustomCountyDashboardConfigurator : DashboardConfigurator
    {
        public CustomCountyDashboardConfigurator(IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
        {
            SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
            SetDashboardStorage(new DashboardFileStorage(hostingEnvironment.ContentRootFileProvider.GetFileInfo("PredefinedDashboards/County").PhysicalPath));
            CustomParameters += CustomCountyDashboardConfigurator_CustomParameters;
        }

        private void CustomCountyDashboardConfigurator_CustomParameters(object sender, CustomParametersWebEventArgs e)
        {
            e.Parameters.Add(new Parameter("CacheParameter", typeof(string), "County"));
        }
    }

    public class CustomAgencyDashboardConfigurator : DashboardConfigurator
    {
        public CustomAgencyDashboardConfigurator(IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
        {
            SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
            SetDashboardStorage(new DashboardFileStorage(hostingEnvironment.ContentRootFileProvider.GetFileInfo("PredefinedDashboards/Agency").PhysicalPath));
            CustomParameters += CustomAgencyDashboardConfigurator_CustomParameters;
        }

        private void CustomAgencyDashboardConfigurator_CustomParameters(object sender, CustomParametersWebEventArgs e)
        {
            e.Parameters.Add(new Parameter("CacheParameter", typeof(string), "Agency"));
        }
    }
}
