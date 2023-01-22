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

namespace PresTrust.DevExReports.API.Controllers
{
    public class MCWebDocumentViewerController : WebDocumentViewerController
    {
        public MCWebDocumentViewerController(IWebDocumentViewerMvcControllerService controllerService) : base(controllerService) {}
    }
    public class MCReportDesignerController : ReportDesignerController
    {
        public MCReportDesignerController(IReportDesignerMvcControllerService controllerService) : base(controllerService) {}
    }
    public class MCQueryBuilderController : QueryBuilderController
    {
        public MCQueryBuilderController(IQueryBuilderMvcControllerService controllerService) : base(controllerService) {}
    }
}
