using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SizingToolNew2.Models;

namespace SizingToolNew2.Controllers
{
    public class TnTWorksheetsController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: TnTWorksheets
        public async Task<ActionResult> Index()
        {
            return View(await db.TnTWorksheet.ToListAsync());
        }

        // GET: TnTWorksheets/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TnTWorksheet tnTWorksheet = await db.TnTWorksheet.FindAsync(id);
            if (tnTWorksheet == null)
            {
                return HttpNotFound();
            }
            return View(tnTWorksheet);
        }

        // GET: TnTWorksheets/Create
        public ActionResult Create()
        {
            return View(new TnTWorksheet());
        }

        // POST: TnTWorksheets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TnTId,SizingId,TnTDescription,ExecuteTransitionPlan_Count,ExecuteTransitionPlan_TransitionHoursItem,ExecuteTransitionPlan_TransitionHours,ExecuteTransitionPlan_TransformationHoursItem,ExecuteTransitionPlan_TransformationHours,CreateBestPracticeCustom_Count,CreateBestPracticeCustom_TransitionHoursItem,CreateBestPracticeCustom_TransitionHours,CreateBestPracticeCustom_TransformationHoursItem,CreateBestPracticeCustom_TransformationHours,TestInfrastructurePOC_Count,TestInfrastructurePOC_TransitionHoursItem,TestInfrastructurePOC_TransitionHours,TestInfrastructurePOC_TransformationHoursItem,TestInfrastructurePOC_TransformationHours,TroubleshootTune_Count,TroubleshootTune_TransitionHoursItem,TroubleshootTune_TransitionHours,TroubleshootTune_TransformationHoursItem,TroubleshootTune_TransformationHours,InstallConfigure_Count,InstallConfigure_TransitionHoursItem,InstallConfigure_TransitionHours,InstallConfigure_TransformationHoursItem,InstallConfigure_TransformationHours,AdministratorTraining_Count,AdministratorTraining_TransitionHoursItem,AdministratorTraining_TransitionHours,AdministratorTraining_TransformationHoursItem,AdministratorTraining_TransformationHours,DevelopServiceResponsibilityMatrix_Count,DevelopServiceResponsibilityMatrix_TransitionHoursItem,DevelopServiceResponsibilityMatrix_TransitionHours,DevelopServiceResponsibilityMatrix_TransformationHoursItem,DevelopServiceResponsibilityMatrix_TransformationHours,EstablishAnyNeededServiceAccounts_Count,EstablishAnyNeededServiceAccounts_TransitionHoursItem,EstablishAnyNeededServiceAccounts_TransitionHours,EstablishAnyNeededServiceAccounts_TransformationHoursItem,EstablishAnyNeededServiceAccounts_TransformationHours,ResearchAndSetupEmailAutomation_Count,ResearchAndSetupEmailAutomation_TransitionHoursItem,ResearchAndSetupEmailAutomation_TransitionHours,ResearchAndSetupEmailAutomation_TransformationHoursItem,ResearchAndSetupEmailAutomation_TransformationHours,InstallConfigureRemoteConsoles_Count,InstallConfigureRemoteConsoles_TransitionHoursItem,InstallConfigureRemoteConsoles_TransitionHours,InstallConfigureRemoteConsoles_TransformationHoursItem,InstallConfigureRemoteConsoles_TransformationHours,WorkWithSECOPS_Count,WorkWithSECOPS_TransitionHoursItem,WorkWithSECOPS_TransitionHours,WorkWithSECOPS_TransformationHoursItem,WorkWithSECOPS_TransformationHours,StaffingCcoordinating_Count,StaffingCcoordinating_TransitionHoursItem,StaffingCcoordinating_TransitionHours,StaffingCcoordinating_TransformationHoursItem,StaffingCcoordinating_TransformationHours,IdentifyTestDocument_Count,IdentifyTestDocument_TransitionHoursItem,IdentifyTestDocument_TransitionHours,IdentifyTestDocument_TransformationHoursItem,IdentifyTestDocument_TransformationHours,ObtainNetworkAndOsAccessWave1_Count,ObtainNetworkAndOsAccessWave1_TransitionHoursItem,ObtainNetworkAndOsAccessWave1_TransitionHours,ObtainNetworkAndOsAccessWave1_TransformationHoursItem,ObtainNetworkAndOsAccessWave1_TransformationHours,ObtainNetworkAndOsAccessWave2_Count,ObtainNetworkAndOsAccessWave2_TransitionHoursItem,ObtainNetworkAndOsAccessWave2_TransitionHours,ObtainNetworkAndOsAccessWave2_TransformationHoursItem,ObtainNetworkAndOsAccessWave2_TransformationHours,DevelopProvideAgentSoftware_Count,DevelopProvideAgentSoftware_TransitionHoursItem,DevelopProvideAgentSoftware_TransitionHours,DevelopProvideAgentSoftware_TransformationHoursItem,DevelopProvideAgentSoftware_TransformationHours,InstallConfigureODBC_Count,InstallConfigureODBC_TransitionHoursItem,InstallConfigureODBC_TransitionHours,InstallConfigureODBC_TransformationHoursItem,InstallConfigureODBC_TransformationHours,CustomerReviewSignoff_Count,CustomerReviewSignoff_TransitionHoursItem,CustomerReviewSignoff_TransitionHours,CustomerReviewSignoff_TransformationHoursItem,CustomerReviewSignoff_TransformationHours,EstablishHealthCheck_Count,EstablishHealthCheck_TransitionHoursItem,EstablishHealthCheck_TransitionHours,EstablishHealthCheck_TransformationHoursItem,EstablishHealthCheck_TransformationHours,DevelopWorkFlows_Count,DevelopWorkFlows_TransitionHoursItem,DevelopWorkFlows_TransitionHours,DevelopWorkFlows_TransformationHoursItem,DevelopWorkFlows_TransformationHours,OperationalDocumentation_Count,OperationalDocumentation_TransitionHoursItem,OperationalDocumentation_TransitionHours,OperationalDocumentation_TransformationHoursItem,OperationalDocumentation_TransformationHours,ShadowEstablishReviewAllProcedures_Count,ShadowEstablishReviewAllProcedures_TransitionHoursItem,ShadowEstablishReviewAllProcedures_TransitionHours,ShadowEstablishReviewAllProcedures_TransformationHoursItem,ShadowEstablishReviewAllProcedures_TransformationHours,OtherDetail_Count,OtherDetail_TransitionHoursItem,OtherDetail_TransitionHours,OtherDetail_TransformationHoursItem,OtherDetail_TransformationHours,SpecialItem1_Count,SpecialItem1_TransitionHoursItem,SpecialItem1_TransitionHours,SpecialItem1_TransformationHoursItem,SpecialItem1_TransformationHours,SpecialItem2_Count,SpecialItem2_TransitionHoursItem,SpecialItem2_TransitionHours,SpecialItem2_TransformationHoursItem,SpecialItem2_TransformationHours,SpecialItem3_Count,SpecialItem3_TransitionHoursItem,SpecialItem3_TransitionHours,SpecialItem3_TransformationHoursItem,SpecialItem3_TransformationHours,SpecialItem4_Count,SpecialItem4_TransitionHoursItem,SpecialItem4_TransitionHours,SpecialItem4_TransformationHoursItem,SpecialItem4_TransformationHours,SpecialItem5_Count,SpecialItem5_TransitionHoursItem,SpecialItem5_TransitionHours,SpecialItem5_TransformationHoursItem,SpecialItem5_TransformationHours,TotalTransitionHoursItem,TotalTransformationHoursItem,NumTransitionWeeks,NumTransformationWeeks")] TnTWorksheet tnTWorksheet)
        {
            if (ModelState.IsValid)
            {
                db.TnTWorksheet.Add(tnTWorksheet);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tnTWorksheet);
        }

        // GET: TnTWorksheets/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TnTWorksheet tnTWorksheet = await db.TnTWorksheet.FindAsync(id);
            if (tnTWorksheet == null)
            {
                return HttpNotFound();
            }
            return View(tnTWorksheet);
        }

        // POST: TnTWorksheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TnTId,SizingId,TnTDescription,ExecuteTransitionPlan_Count,ExecuteTransitionPlan_TransitionHoursItem,ExecuteTransitionPlan_TransitionHours,ExecuteTransitionPlan_TransformationHoursItem,ExecuteTransitionPlan_TransformationHours,CreateBestPracticeCustom_Count,CreateBestPracticeCustom_TransitionHoursItem,CreateBestPracticeCustom_TransitionHours,CreateBestPracticeCustom_TransformationHoursItem,CreateBestPracticeCustom_TransformationHours,TestInfrastructurePOC_Count,TestInfrastructurePOC_TransitionHoursItem,TestInfrastructurePOC_TransitionHours,TestInfrastructurePOC_TransformationHoursItem,TestInfrastructurePOC_TransformationHours,TroubleshootTune_Count,TroubleshootTune_TransitionHoursItem,TroubleshootTune_TransitionHours,TroubleshootTune_TransformationHoursItem,TroubleshootTune_TransformationHours,InstallConfigure_Count,InstallConfigure_TransitionHoursItem,InstallConfigure_TransitionHours,InstallConfigure_TransformationHoursItem,InstallConfigure_TransformationHours,AdministratorTraining_Count,AdministratorTraining_TransitionHoursItem,AdministratorTraining_TransitionHours,AdministratorTraining_TransformationHoursItem,AdministratorTraining_TransformationHours,DevelopServiceResponsibilityMatrix_Count,DevelopServiceResponsibilityMatrix_TransitionHoursItem,DevelopServiceResponsibilityMatrix_TransitionHours,DevelopServiceResponsibilityMatrix_TransformationHoursItem,DevelopServiceResponsibilityMatrix_TransformationHours,EstablishAnyNeededServiceAccounts_Count,EstablishAnyNeededServiceAccounts_TransitionHoursItem,EstablishAnyNeededServiceAccounts_TransitionHours,EstablishAnyNeededServiceAccounts_TransformationHoursItem,EstablishAnyNeededServiceAccounts_TransformationHours,ResearchAndSetupEmailAutomation_Count,ResearchAndSetupEmailAutomation_TransitionHoursItem,ResearchAndSetupEmailAutomation_TransitionHours,ResearchAndSetupEmailAutomation_TransformationHoursItem,ResearchAndSetupEmailAutomation_TransformationHours,InstallConfigureRemoteConsoles_Count,InstallConfigureRemoteConsoles_TransitionHoursItem,InstallConfigureRemoteConsoles_TransitionHours,InstallConfigureRemoteConsoles_TransformationHoursItem,InstallConfigureRemoteConsoles_TransformationHours,WorkWithSECOPS_Count,WorkWithSECOPS_TransitionHoursItem,WorkWithSECOPS_TransitionHours,WorkWithSECOPS_TransformationHoursItem,WorkWithSECOPS_TransformationHours,StaffingCcoordinating_Count,StaffingCcoordinating_TransitionHoursItem,StaffingCcoordinating_TransitionHours,StaffingCcoordinating_TransformationHoursItem,StaffingCcoordinating_TransformationHours,IdentifyTestDocument_Count,IdentifyTestDocument_TransitionHoursItem,IdentifyTestDocument_TransitionHours,IdentifyTestDocument_TransformationHoursItem,IdentifyTestDocument_TransformationHours,ObtainNetworkAndOsAccessWave1_Count,ObtainNetworkAndOsAccessWave1_TransitionHoursItem,ObtainNetworkAndOsAccessWave1_TransitionHours,ObtainNetworkAndOsAccessWave1_TransformationHoursItem,ObtainNetworkAndOsAccessWave1_TransformationHours,ObtainNetworkAndOsAccessWave2_Count,ObtainNetworkAndOsAccessWave2_TransitionHoursItem,ObtainNetworkAndOsAccessWave2_TransitionHours,ObtainNetworkAndOsAccessWave2_TransformationHoursItem,ObtainNetworkAndOsAccessWave2_TransformationHours,DevelopProvideAgentSoftware_Count,DevelopProvideAgentSoftware_TransitionHoursItem,DevelopProvideAgentSoftware_TransitionHours,DevelopProvideAgentSoftware_TransformationHoursItem,DevelopProvideAgentSoftware_TransformationHours,InstallConfigureODBC_Count,InstallConfigureODBC_TransitionHoursItem,InstallConfigureODBC_TransitionHours,InstallConfigureODBC_TransformationHoursItem,InstallConfigureODBC_TransformationHours,CustomerReviewSignoff_Count,CustomerReviewSignoff_TransitionHoursItem,CustomerReviewSignoff_TransitionHours,CustomerReviewSignoff_TransformationHoursItem,CustomerReviewSignoff_TransformationHours,EstablishHealthCheck_Count,EstablishHealthCheck_TransitionHoursItem,EstablishHealthCheck_TransitionHours,EstablishHealthCheck_TransformationHoursItem,EstablishHealthCheck_TransformationHours,DevelopWorkFlows_Count,DevelopWorkFlows_TransitionHoursItem,DevelopWorkFlows_TransitionHours,DevelopWorkFlows_TransformationHoursItem,DevelopWorkFlows_TransformationHours,OperationalDocumentation_Count,OperationalDocumentation_TransitionHoursItem,OperationalDocumentation_TransitionHours,OperationalDocumentation_TransformationHoursItem,OperationalDocumentation_TransformationHours,ShadowEstablishReviewAllProcedures_Count,ShadowEstablishReviewAllProcedures_TransitionHoursItem,ShadowEstablishReviewAllProcedures_TransitionHours,ShadowEstablishReviewAllProcedures_TransformationHoursItem,ShadowEstablishReviewAllProcedures_TransformationHours,OtherDetail_Count,OtherDetail_TransitionHoursItem,OtherDetail_TransitionHours,OtherDetail_TransformationHoursItem,OtherDetail_TransformationHours,SpecialItem1_Count,SpecialItem1_TransitionHoursItem,SpecialItem1_TransitionHours,SpecialItem1_TransformationHoursItem,SpecialItem1_TransformationHours,SpecialItem2_Count,SpecialItem2_TransitionHoursItem,SpecialItem2_TransitionHours,SpecialItem2_TransformationHoursItem,SpecialItem2_TransformationHours,SpecialItem3_Count,SpecialItem3_TransitionHoursItem,SpecialItem3_TransitionHours,SpecialItem3_TransformationHoursItem,SpecialItem3_TransformationHours,SpecialItem4_Count,SpecialItem4_TransitionHoursItem,SpecialItem4_TransitionHours,SpecialItem4_TransformationHoursItem,SpecialItem4_TransformationHours,SpecialItem5_Count,SpecialItem5_TransitionHoursItem,SpecialItem5_TransitionHours,SpecialItem5_TransformationHoursItem,SpecialItem5_TransformationHours,TotalTransitionHoursItem,TotalTransformationHoursItem,NumTransitionWeeks,NumTransformationWeeks")] TnTWorksheet tnTWorksheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tnTWorksheet).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tnTWorksheet);
        }

        // GET: TnTWorksheets/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TnTWorksheet tnTWorksheet = await db.TnTWorksheet.FindAsync(id);
            if (tnTWorksheet == null)
            {
                return HttpNotFound();
            }
            return View(tnTWorksheet);
        }

        // POST: TnTWorksheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TnTWorksheet tnTWorksheet = await db.TnTWorksheet.FindAsync(id);
            db.TnTWorksheet.Remove(tnTWorksheet);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
