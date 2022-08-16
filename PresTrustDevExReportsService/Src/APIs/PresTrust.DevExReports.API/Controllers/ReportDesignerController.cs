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
    //public class reportdesignercontroller : controller
    //{
    //    public actionresult getreportdesignermodel(string reporturl)
    //    {
    //        string modeljsonscript =
    //            new reportdesignerclientsidemodelgenerator(httpcontext.requestservices)
    //            .getjsonmodelscript(
    //                reporturl,                  // the url of a report that is opened in the report designer when the application starts.
    //                null,                       // available data sources in the report designer that can be added to reports.
    //                "dxxrd",                    // the uri path of the default controller that processes requests from the report designer.
    //                "dxxrdv",                   // the uri path of the default controller that that processes requests from the web document viewer.
    //                "dxxqb"                     // the uri path of the default controller that processes requests from the query builder.
    //            );
    //        return content(modeljsonscript, "application/json");
    //    }
    //}
    public class CustomWebDocumentViewerController : WebDocumentViewerController
    {
        public CustomWebDocumentViewerController(IWebDocumentViewerMvcControllerService controllerService) : base(controllerService)
        {

        }
    }
    public class CustomReportDesignerController : ReportDesignerController
    {
        public CustomReportDesignerController(IReportDesignerMvcControllerService controllerService) : base(controllerService)
        {
        }
    }

    public class CustomQueryBuilderController : QueryBuilderController
    {
        public CustomQueryBuilderController(IQueryBuilderMvcControllerService controllerService) : base(controllerService)
        {
        }
    }

}
