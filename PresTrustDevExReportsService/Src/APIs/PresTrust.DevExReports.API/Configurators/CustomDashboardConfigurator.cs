using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace PresTrust.DevExReports.API.Configurators
{
    public class CustomCountyDashboardConfigurator : DashboardConfigurator
    {
        private readonly string programType;
        public CustomCountyDashboardConfigurator(IConfiguration configuration, IWebHostEnvironment hostingEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            this.programType = httpContextAccessor.HttpContext.Request.Headers["User_ProgramType"];
            SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
            AllowExecutingCustomSql = true;
            SetDashboardStorage(new DashboardFileStorage(hostingEnvironment.ContentRootFileProvider.GetFileInfo("PredefinedDashboards/County").PhysicalPath));
            CustomParameters += CustomCountyDashboardConfigurator_CustomParameters;
        }

        private void CustomCountyDashboardConfigurator_CustomParameters(object sender, CustomParametersWebEventArgs e)
        {
            e.Parameters.Add(new Parameter("User_ProgramType", typeof(string), programType));
        }
    }

    public class CustomAgencyDashboardConfigurator : DashboardConfigurator
    {
        private readonly string programType;
        private readonly string agencyIds;
        public CustomAgencyDashboardConfigurator(IConfiguration configuration, IWebHostEnvironment hostingEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            this.programType = httpContextAccessor.HttpContext.Request.Headers["User_ProgramType"];
            this.agencyIds = httpContextAccessor.HttpContext.Request.Headers["User_AgencyIds"];
            SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
            AllowExecutingCustomSql = true;
            SetDashboardStorage(new DashboardFileStorage(hostingEnvironment.ContentRootFileProvider.GetFileInfo("PredefinedDashboards/Agency").PhysicalPath));
            CustomParameters += CustomAgencyDashboardConfigurator_CustomParameters;
        }

        private void CustomAgencyDashboardConfigurator_CustomParameters(object sender, CustomParametersWebEventArgs e)
        {
            string[] agencyIdsArr = agencyIds.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> agencyIdsList = new List<int>();
            foreach (var item in agencyIdsArr)
            {
                int id = 0;
                int.TryParse(item, out id);
                if (id > 0 && !agencyIdsList.Contains(id))
                    agencyIdsList.Add(id);
            }
            e.Parameters.Add(new Parameter("User_ProgramType", typeof(string), programType));
            e.Parameters.Add(new Parameter("User_AgencyIds", typeof(List<int>), agencyIdsList));
        }
    }
}
