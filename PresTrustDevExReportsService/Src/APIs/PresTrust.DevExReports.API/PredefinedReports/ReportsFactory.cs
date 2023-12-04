using DevExpress.XtraReports.UI;
using PresTrust.DevExReports.API.PredefinedReports.Flood;
using PresTrust.DevExReports.API.PredefinedReports.Historic;
using PresTrust.DevExReports.API.PredefinedReports.Openspace;
using System;
using System.Collections.Generic;

namespace PresTrust.DevExReports.API.PredefinedReports
{
    public static class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            ["OSTFFundsAllocationReport"] = () => new OSTFFundsAllocationReport(),
            ["OSTFSummaryReport"] = () => new OSTFSummaryReport(),
            ["OSTFSummarySubReport0"] = () => new OSTFSummarySubReport0(),
            ["OSTFSummarySubReport1"] = () => new OSTFSummarySubReport1(),
            ["OSTFSummarySubReport2"] = () => new OSTFSummarySubReport2(),
            ["OSTFAdhocReportTemplate"] = () => new OSTFAdhocReportTemplate(),
            ["OSTFApplicationSummary"] = () => new OSTFApplicationSummaryReport(),
            ["MunicipalTrustFundInfo"] = () => new MunicipalTrustFundInformation(),
            ["OSTFFeedbackReport"] = () => new OSTFFeedbackReport(),
            ["OSTFParcelReport"] = () => new OSTFParcelReport(),
            ["OSTFOPRAReport"] = () => new OSTF_OPRA_Report(),
            ["SubreportLocation"] = () => new Subreport_Location(),
            ["SubreportFinance"] = () => new Subreport_Finance(),
            ["SubreportSite"] = () => new Subreport_Site(),
            ["SubreportDocumnts"] = () => new Subreport_Documnts(),
            ["OSTFSiteVisitReport"] = () => new OSTFSiteVisitReport(),
            ["OSTFCommissionerBookReport"] = () => new OSTFCommissionerBookReport(),
            ["HistFlexPayment"] = () => new Flex_Payment(),
            ["HistFlexScopeofWork"] = () => new Flex_ScopeofWork(),
            ["HistPropertyTotal"] = () => new Static_PropertyTotal(),
            ["HistSummarybyYear"] = () => new Static_SummaryByYear(),
            ["HistGrantStatus"] = () => new GrantStatus(),
            ["HistWebsiteSiteSummary"] = () => new WebsiteSiteSummary(),
            ["HistCommisionerHandout"] = () => new CommisionerHandout(),
            ["HistEasementReport"] = () => new EasementTemplate(),
            ["HistEasementAmendmentReport"] = () => new EasementAmendment(),
            ["HistGrantAgreementReport"] = () => new GrantAgreement(),
            ["HistReleaseOfFunds"] = () => new ReleaseOfFunds(),
            ["HistYearlyHandBook"] = () => new YearlyHandBookReport(),
            ["HistNominationSubmissionDate"] = () => new NominationSubmissionDate(),
            ["HistGrantAwardResolution"] = () => new GrantAwardResolution(),
            ["HistOPRAReport"] = () => new OPRA_Report(),
            ["FloodCoreApplicationParcel"] = () => new CoreFloodApplicationReport(),
            ["FloodCoreFloodApplicationReview"] = () => new CoreFloodApplicationReview()

        };
    }
}
