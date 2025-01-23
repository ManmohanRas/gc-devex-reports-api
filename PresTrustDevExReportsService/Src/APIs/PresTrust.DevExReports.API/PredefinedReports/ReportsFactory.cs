using DevExpress.XtraReports.UI;
using PresTrust.DevExReports.API.PredefinedReports.Farm;
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
           
            //Flood Mitigation Preview Reports
            ["FloodCoreApplicationReport"] = () => new FloodCoreApplicationReport(),
            ["FloodCoreReviewReport"] = () => new FloodCoreReviewReport(),
            ["FloodCongratulationsLettertoHomeOwner"] = () => new FloodCongratulationsLettertoHomeOwner(),
            ["FloodGrantAgreement"] = () => new FloodGrantAgreement(),
            ["FloodProjectAreaFundsExtensionRequest"] = () => new ProjectAreaFundsExtensionRequest(),
            ["FloodSoftCostReimbursementForm"] = () => new FloodSoftCostReimbursementForm(),
            ["FloodFastTrackSoftCostReimbusment"] = () => new FloodFastTrackSoftCostReimbusment(),
            ["FloodFMCPreliminaryApprovalCOREMultiple"] = () => new FloodFMCPreliminaryApprovalCOREMultiple(),
            ["FloodFMCPreliminaryApprovalCORESingle"] = () => new FloodFMCPreliminaryApprovalCORESingle(),
            ["FloodFMCPreliminaryApprovalMain"] = () => new FloodFMCPreliminaryApprovalMain(),
            ["FloodFMCPreliminaryApprovalMATCHMultiple"] = () => new FloodFMCPreliminaryApprovalMATCHMultiple(),
            ["FloodFMCPreliminaryApprovalMATCHSingle"] = () => new FloodFMCPreliminaryApprovalMATCHSingle(),
            ["FASTTRACKFinalApprovalWITHCAF"] = () => new FASTTRACKFinalApprovalWITHCAF(),
            ["FASTTRACKFinalApprovalNOCAFF"] = () => new FASTTRACKFinalApprovalNOCAF(),
            ["FloodFastTrackFinalApproval"] = () => new FloodFastTrackFinalApproval(),
            //Flood Mitigation General reports 
            ["FloodProgramSummaryReport"] = () => new FloodProgramSummaryReport(),
            ["FloodStatusReport"] = () => new FloodStatusReport(),
            ["FloodMonthlyFundingSummary"] = () => new FloodMonthlyFundingSummary(),
            ["FloodMunicipalProgramSummaryReport"] = () => new MunicipalProgramSummary(),
            ["FloodCountyCostReport"] = () => new FloodCountyCostReport(),
            ["FloodExpirationReport"] = () => new FloodExpirationReport(),
            ["FloodFlapSummary"] = () => new FloodFlapSummary(),
            ["FloodAnnualAuditReport"] = () => new FloodAnnualAuditReport(),
            ["FloodMuniCongratulationPrelimFunding"] = () => new FloodMuniCongratulationPrelimFunding(),
            ["FloodReleaseOfFunds"] = () => new FloodReleaseOfFunds(),
            ["FloodReleaseOfFundsSCSingle"] = () => new FloodReleaseOfFundsSCSingle(),
            ["FloodReleaseOfFundsSCMultiple"] = () => new FloodReleaseOfFundsSCMultiple(),
            ["FloodCoreApplicationReportGeneral"] = () => new FloodCoreApplicationReportGeneral(),
            ["FloodCoreReviewReportPreview"] = () => new FloodCoreReviewReportPreview(),
            // Farm Term Reports
            ["FarmTermProgramBookIndexReport"] = () => new FarmTermProgramBookIndexReport(),
            ["FarmTermProgramReport"] = () => new FarmTermProgramReport(),
            ["FarmEsmtPermanentlyPreservedFarmsReport"]= () => new FarmEsmtPermanentlyPreservedFarmsReport(),
            // Farm Esmt Reports
            ["FarmEasementPurchaseBreakdownReport"] = () => new FarmEasementPurchaseBreakdown(),
            ["FarmEsmtCADBPurchPrgmSADCAppraisedReport"] = () => new FarmEsmtCADBPurchPrgmSADCAppraisedReport(),
            ["FarmEsmtPreservedFarmsInMorrisCounty"] = () => new FarmEsmtPreservedFarmsInMorrisCounty(),
            ["FarmEsmtPermPresFarmsWithResiOnPresGround"] = () => new FarmEsmtPermanenltyPresFarmsWithResiOnPresGround(),
            ["FarmEsmtPermPresFarmsTownSummaries"] = () => new FarmEsmtPermanentlyPresFarmsTownSummaries(),
            ["FarmEsmtPermPresFarmsWithFarmName"] = () => new FarmEsmtPermPresFarmsWithFarmName(),
            ["FarmEsmtPresFarmsExceptionAreaReport"] = () => new FarmEsmtPreservedFarmsExceptionAreasReport(),
            ["FarmPremPresFarmsWithServableExceptionsReport"] = () => new FarmPermanentlyPreservedFarmsWithServableExceptionsReport(),
            ["FarmEsmtRdsoPresFarmsReport"] = () => new FarmEsmtRdsoPreservedFarmsReport(),
            ["FarmEsmtPermPresFarmsWithTFInfo"] = () => new FarmEsmtPermPresFarmsWithTFInfo(),
            ["FarmEsmtMonitoringInspectionReport"] = () => new FarmEsmtMonitoringInspectionReport(),
            ["FarmPreservedFarmswithSignsInstalled"] = () => new FarmPreservedFarmswithSignsInstalled(),
            ["FarmEsmtTargetedFarmEligibilityReport"] = () => new FarmEsmtTargetedFarmEligibilityReport(),
            ["FarmEsmtExhibitAPropertySurveysReport"]= () => new FarmEsmtExhibitAPropertySurveysReport(),
            ["FarmEsmtAllPendingFarmPreservationProject"] = () => new FarmEsmtAllPendingFarmPreservationProject(),
            ["FarmEsmtSummPermntlyPresFarmsInSelling"] = () => new FarmEsmtSummPermntlyPresFarmsInSelling(),
            ["FarmEsmtReSaleInfoOfPreservedFarmsReport"] = () => new FarmEsmtReSaleInfoOfPreservedFarmsReport(),
            ["FarmEsmtMCMuniLandAreaandFarmlandAcreageReport"] = () => new FarmEsmtMCMuniLandAreaandFarmlandAcreageReport(),
            ["FarmEsmtPermanentlyPreservedFarmsInMorrisCounty"] = () => new FarmEsmtPermanentlyPreservedFarmsInMorrisCounty(),
            ["FarmEsmtSummaryOfPreservedFarms"] = ()=>new FarmEsmtSummaryOfPreservedFarms(),
            ["FarmEsmtEXHIBITA"] = ()=>new FarmEsmtPendingEXHIBITAReport(),
            ["FarmEsmtReSaleInfoOfPreservedFarmsReportPreview"] = () => new FarmEsmtReSaleInfoOfPreservedFarmsReportPreview(),
            ["FarmSumOfFarmLandPresPendingProject"] = () => new FarmSumOfFarmLandPresPendingProject()
        };
    }
}
