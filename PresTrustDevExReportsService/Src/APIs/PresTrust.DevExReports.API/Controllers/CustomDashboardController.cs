using DevExpress.XtraReports.Web.ReportDesigner;
using Microsoft.AspNetCore.Mvc;
using DevExpress.AspNetCore.Reporting.QueryBuilder;
using DevExpress.AspNetCore.Reporting.QueryBuilder.Native.Services;
using DevExpress.AspNetCore.Reporting.ReportDesigner;
using DevExpress.AspNetCore.Reporting.ReportDesigner.Native.Services;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using Microsoft.AspNetCore.DataProtection;

namespace PresTrust.DevExReports.API.Controllers
{
    public class CustomDashboardController : DashboardController
    {
        public CustomDashboardController(DashboardConfigurator configurator, IDataProtectionProvider? dataProtectionProvider = null) : base(configurator, dataProtectionProvider) {}
    }
}
