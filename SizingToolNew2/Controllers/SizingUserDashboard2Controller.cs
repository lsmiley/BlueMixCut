﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SizingToolNew2.Models;
using Rotativa;
using Rotativa.MVC;
using SelectPdf;
using SizingToolNew2.CustomFilters;
using EntityState = System.Data.Entity.EntityState;

namespace SizingToolNew2.Controllers
{
    [Authorize]
    public class SizingUserDashboard2Controller : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: SizingUserDashboard2
        public async Task<ActionResult> Index()
        {

            var sizings = db.Sizings.Include(s => s.AcctCust).Include(s => s.AvProduct).Include(s => s.ConfigTable).Include(s => s.LaborDelivery).Include(s => s.SizingType).Include(s => s.StatusState).Include(s => s.TnTWorksheet);

            return View(await sizings.ToListAsync());
        }

        

        [HttpPost]
        [AuthLog(Roles = "Administrator, Solution Architect, Sizer, Viewer")]
        public ActionResult SubmitAction(FormCollection collection)
        {


            // read parameters from the webpage
            string url = collection["TxtUrl"];

            string pdf_page_size = collection["DdlPageSize"];
            PdfPageSize pageSize =
                (PdfPageSize)Enum.Parse(typeof(PdfPageSize), pdf_page_size, true);

            string pdf_orientation = collection["DdlPageOrientation"];
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 0;
            try
            {
                webPageWidth = System.Convert.ToInt32(collection["TxtWidth"]);
            }
            catch { }

            int webPageHeight = 0;
            try
            {
                webPageHeight = System.Convert.ToInt32(collection["TxtHeight"]);
            }
            catch { }

            // instantiate a html to pdf converter object
            HtmlToPdf converter = new HtmlToPdf();

            // set converter options
            converter.Options.Authentication.Username = "lsmiley@us.ibm.com";
            converter.Options.Authentication.Password = "Hexx2you2?";
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            // create a new pdf document converting an url

            PdfDocument doc = converter.ConvertUrl(url);

            // save pdf document
            byte[] pdf = doc.Save();

            // close pdf document
            doc.Close();

            // return resulted pdf document
            FileResult fileResult = new FileContentResult(pdf, "application/pdf");
            fileResult.FileDownloadName = "Document.pdf";
            return fileResult;
        }


        // GET: SizingUserDashboard2/Details/5
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sizing sizing = await db.Sizings.FindAsync(id);
            if (sizing == null)
            {
                return HttpNotFound();
            }
            // return View(sizing);
            return new Rotativa.ViewAsPdf(sizing);
        }


        // GET: SizingUserDashboard2/Create
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public ActionResult Create()
        {
            ViewBag.AcctCustId = new SelectList(db.AcctCusts, "AcctCustId", "AcctName");
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ConfigId = new SelectList(db.ConfigTables, "ConfigId", "ConfigName");
            ViewBag.LaborDeliveryId = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.SizingTypeId = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName");
            ViewBag.StatusStateId = new SelectList(db.StatusStates, "StatusStateId", "StatusStateName");
            ViewBag.TnTId = new SelectList(db.TnTWorksheet, "TnTId", "TnTDescription");


            return View(new Sizing());
        }

        // POST: SizingUserDashboard2/Create
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public async Task<ActionResult> Create([Bind(Include = "SizingId,ConfigId,AcctCustId,AvProductId,SizingTypeId,LaborDeliveryId,TnTId,StatusStateId,SizingDetailDataId,DisplayForSizingID,SizingName,Created,SizingStatus,ValidToDate,SalesConnectNum,RFSNum,PrepardedBy,RiskRating,TypeSizing,TransitionChrg,TransformationChrg,MemoNote,StedyStateBase,NumServer,NumServer1,NumServer2,NumServer3,NumWorkstation,NumWorkstation1,NumWorkstation2,NumWorkstation3,Total,WorkstationFTE,WorkstationFTE1,WorkstationFTE2,WorkstationFTE3,WkstnsHoursCalc,WkstnsHoursCalc1,WkstnsHoursCalc2,WkstnsHoursCalc3,ServerFTE,ServerFTE1,ServerFTE2,ServerFTE3,SrvsHoursCalc,SrvsHoursCalc1,SrvsHoursCalc2,SrvsHoursCalc3,IPEndpointFTE,IPEndpointFTE1,IPEndpointFTE2,IPEndpointFTE3,IPsHoursCalc,IPsHoursCalc1,IPsHoursCalc2,IPsHoursCalc3,NumIpAddress,NumIpAddress1,NumIpAddress2,NumIpAddress3,AppChangeFTE,AppChangeFTE1,AppChangeFTE2,AppChangeFTE3,AppChangeHoursCalc,AppChangeHoursCalc1,AppChangeHoursCalc2,AppChangeHoursCalc3,NumAppChange,NumAppChange1,NumAppChange2,NumAppChange3,AddlConFTE,AddlConFTE1,AddlConFTE2,AddlConFTE3,AddlConHoursCalc,NumAddlCon,NumAddlCon1,AddlConHoursCalc1,NumAddlCon2,AddlConHoursCalc2,NumAddlCon3,AddlConHoursCalc3,SoftLifeWkstnFTE,SoftLifeSvrFTE,SoftLifeSrvHoursCalc,SoftLifeSvrYesNo,SecComplRptFTE,SecCompHoursCalc,SecCompRptYesNo,ReportingFTE,RportingHoursCalc,ReportingYesNo,SlaRprtFTE,SlaRptHoursCalc,SLAReportingYesNo,FTE,HoursCalc,SteadyStateTotalHours,SteadyStateTotalBand3,SteadyStateTotalBand4,SteadyStateTotalBand5,SteadyStateTotalBand6,SteadyStateTotalBand7,SteadyStateTotalBand8,SteadyStateTotalBand9,SteadyStateBandsTotal,FirstLineMangerBand8Hours,FirstLineMangerBand8Total,FirstLineMangerBand8TotalFTE,SecondLineMangerBand9Hours,SecondLineMangerBand9Total,SecondLineMangerBand9TotalFTE,SteadyStateSubTotalHours,SteadyStateSubTotalBand3,SteadyStateSubTotalBand4,SteadyStateSubTotalBand5,SteadyStateSubTotalBand6,SteadyStateSubTotalBand7,SteadyStateSubTotalBand8,SteadyStateSubTotalBand9,SteadyStateSubTotalTotal,TravelCostCount,TravelCostDesc,TravelCost,TravelCostAmt,RemoteConsoleCostCount,RemoteConsoleDesc,RemoteConsoleCost,RemoteConsoleCostAmt,EducationCostCount,EducationCostDesc,EducationCost,EducationCostAmt,OtherCostCount1,OtherCostDesc1,OtherCost1,OtherCost1Amt,OtherCostCount2,OtherCostDesc2,OtherCost2,OtherCost2Amt,OtherCostCount3,OtherCostDesc3,OtherCost3,OtherCost3Amt,OtherCostsDollarSubTotal,TotalSteadyStateFTE,TotalSteadyStateHours,TotalSteadyStateBand3,TotalSteadyStateBand4,TotalSteadyStateBand5,TotalSteadyStateBand6,TotalSteadyStateBand7,TotalSteadyStateBand8,TotalSteadyStateBand9,TotalSteadyStateTotal1stLineMgr,TotalSteadyStateTotal2ndLineMgr,SteadyStateTotalFTE,SubTotalTotalEffortFTE,SubTotalTotalEffortHours,SubTotalTotalEffortBand3,SubTotalTotalEffortBand4,SubTotalTotalEffortBand5,SubTotalTotalEffortBand6,SubTotalTotalEffortBand7,SubTotalTotalEffortBand8,SubTotalTotalEffortBand9,SubTotalTotalEffort1stLineMgr,SubTotalTotalEffort2ndLineMgr,SubTotalTotalEffortTotalFTE,RiskRatingTotalFTE,SteadyStateGrandTotalFTE,GrandTotalFTE,AvWkstnBand3,AvWkstnBand4,AvWkstnBand5,AvWkstnBand6,AvWkstnBand7,AvWkstnBand8,AvWkstnBand9,AvWkstnBand3_1,AvWkstnBand4_1,AvWkstnBand5_1,AvWkstnBand6_1,AvWkstnBand7_1,AvWkstnBand8_1,AvWkstnBand9_1,AvWkstnBand3_2,AvWkstnBand4_2,AvWkstnBand5_2,AvWkstnBand6_2,AvWkstnBand7_2,AvWkstnBand8_2,AvWkstnBand9_2,AvWkstnBand3_3,AvWkstnBand4_3,AvWkstnBand5_3,AvWkstnBand6_3,AvWkstnBand7_3,AvWkstnBand8_3,AvWkstnBand9_3,AvSvrBand3,AvSvrBand4,AvSvrBand5,AvSvrBand6,AvSvrBand7,AvSvrBand8,AvSvrBand9,AvSvrBand3_1,AvSvrBand4_1,AvSvrBand5_1,AvSvrBand6_1,AvSvrBand7_1,AvSvrBand8_1,AvSvrBand9_1,AvSvrBand3_2,AvSvrBand4_2,AvSvrBand5_2,AvSvrBand6_2,AvSvrBand7_2,AvSvrBand8_2,AvSvrBand9_2,AvSvrBand3_3,AvSvrBand4_3,AvSvrBand5_3,AvSvrBand6_3,AvSvrBand7_3,AvSvrBand8_3,AvSvrBand9_3,AScanBBand3,AScanBBand4,AScanBBand5,AScanBBand6,AScanBBand7,AScanBBand8,AScanBBand9,AScanBBand3_1,AScanBBand4_1,AScanBBand5_1,AScanBBand6_1,AScanBBand7_1,AScanBBand8_1,AScanBBand9_1,AScanBBand3_2,AScanBBand4_2,AScanBBand5_2,AScanBBand6_2,AScanBBand7_2,AScanBBand8_2,AScanBBand9_2,AScanBBand3_3,AScanBBand4_3,AScanBBand5_3,AScanBBand6_3,AScanBBand7_3,AScanBBand8_3,AScanBBand9_3,AddConBand3,AddConBand4,AddConBand5,AddConBand6,AddConBand7,AddConBand8,AddConBand9,AddConBand3_1,AddConBand4_1,AddConBand5_1,AddConBand6_1,AddConBand7_1,AddConBand8_1,AddConBand9_1,AddConBand3_2,AddConBand4_2,AddConBand5_2,AddConBand6_2,AddConBand7_2,AddConBand8_2,AddConBand9_2,AddConBand3_3,AddConBand4_3,AddConBand5_3,AddConBand6_3,AddConBand7_3,AddConBand8_3,AddConBand9_3,TransitionWeeks,TransformationWeeks,Product1,TransitionYesNo,TransformationYesNo,Prod1Compnent1Desc,Prod2Compnent1Desc,Prod3Compnent1Desc,Prod4Compnent1Desc,Prod1Component1,Prod2Component1,Prod3Component1,Prod4Component1,Prod1ComponentHours1,Prod2ComponentHours1,Prod3ComponentHours1,Prod4ComponentHours1,Prod1Component1_Wkstn,Prod2Component1_Wkstn,Prod3Component1_Wkstn,Prod4Component1_Wkstn,Prod1Component1_Svr,Prod2Component1_Svr,Prod3Component1_Svr,Prod4Component1_Svr,Prod1Component1_IP,Prod2Component1_IP,Prod3Component1_IP,Prod4Component1_IP,Prod1Component_Qty1,Prod2Component_Qty1,Prod3Component_Qty1,Prod4Component_Qty1,Prod1Component1_WkstnHours,Prod2Component1_WkstnHours,Prod3Component1_WkstnHours,Prod4Component1_WkstnHours,Prod1Component1_SvrHours,Prod2Component1_SvrHours,Prod3Component1_SvrHours,Prod4Component1_SvrHours,Prod1Component1_IPHours,Prod2Component1_IPHours,Prod3Component1_IPHours,Prod4Component1_IPHours,Prod1Compnent2Desc,Prod2Compnent2Desc,Prod3Compnent2Desc,Prod4Compnent2Desc,Prod1ComponentHours2,Prod2ComponentHours2,Prod3ComponentHours2,Prod4ComponentHours2,Prod1Component2,Prod2Component2,Prod3Component2,Prod4Component2,Prod1Component2_Wkstn,Prod2Component2_Wkstn,Prod3Component2_Wkstn,Prod4Component2_Wkstn,Prod1Component2_Svr,Prod2Component2_Svr,Prod3Component2_Svr,Prod4Component2_Svr,Prod1Component2_IP,Prod2Component2_IP,Prod3Component2_IP,Prod4Component2_IP,Prod1Component_Qty2,Prod2Component_Qty2,Prod3Component_Qty2,Prod4Component_Qty2,Prod1Component2_WkstnHours,Prod2Component2_WkstnHours,Prod3Component2_WkstnHours,Prod4Component2_WkstnHours,Prod1Component2_SvrHours,Prod2Component2_SvrHours,Prod3Component2_SvrHours,Prod4Component2_SvrHours,Prod1Component2_IPHours,Prod2Component2_IPHours,Prod3Component2_IPHours,Prod4Component2_IPHours,Prod2ComponentComplexityFac1_1,Prod2ComponentComplexityFac2_1,Prod2ComponentComplexityFac3_1,Prod2ComponentComplexityFac4_1,Prod2ComponentComplexityFac5_1,Prod2ComponentComplexityFac6_1,Prod2ComponentComplexityFac7_1,Prod2ComponentComplexityFac8_1,Prod2ComponentComplexityFac9_1,Prod2ComponentComplexityFac10_1,Prod2ComponentComplexityFac11_1,Prod2ComponentComplexityFac12_1,Prod2ComponentComplexityFac13_1,Prod2ComponentComplexityFac14_1,Prod2ComponentComplexityFac15_1,Prod3ComponentComplexityFac1_1,Prod3ComponentComplexityFac2_1,Prod3ComponentComplexityFac3_1,Prod3ComponentComplexityFac4_1,Prod3ComponentComplexityFac5_1,Prod3ComponentComplexityFac6_1,Prod3ComponentComplexityFac7_1,Prod3ComponentComplexityFac8_1,Prod3ComponentComplexityFac9_1,Prod3ComponentComplexityFac10_1,Prod3ComponentComplexityFac11_1,Prod3ComponentComplexityFac12_1,Prod3ComponentComplexityFac13_1,Prod3ComponentComplexityFac14_1,Prod3ComponentComplexityFac15_1,Prod4ComponentComplexityFac1_1,Prod4ComponentComplexityFac2_1,Prod4ComponentComplexityFac3_1,Prod4ComponentComplexityFac4_1,Prod4ComponentComplexityFac5_1,Prod4ComponentComplexityFac6_1,Prod4ComponentComplexityFac7_1,Prod4ComponentComplexityFac8_1,Prod4ComponentComplexityFac9_1,Prod4ComponentComplexityFac10_1,Prod4ComponentComplexityFac11_1,Prod4ComponentComplexityFac12_1,Prod4ComponentComplexityFac13_1,Prod4ComponentComplexityFac14_1,Prod4ComponentComplexityFac15_1,Prod1Compnent3Desc,Prod2Compnent3Desc,Prod3Compnent3Desc,Prod4Compnent3Desc,Prod1ComponentHours3,Prod2ComponentHours3,Prod3ComponentHours3,Prod4ComponentHours3,Prod1Component3,Prod2Component3,Prod3Component3,Prod4Component3,Prod1Component3_Wkstn,Prod2Component3_Wkstn,Prod3Component3_Wkstn,Prod4Component3_Wkstn,Prod1Component3_Svr,Prod2Component3_Svr,Prod3Component3_Svr,Prod4Component3_Svr,Prod1Component3_IP,Prod2Component3_IP,Prod3Component3_IP,Prod4Component3_IP,Prod1Component_Qty3,Prod2Component_Qty3,Prod3Component_Qty3,Prod4Component_Qty3,Prod1Component3_WkstnHours,Prod2Component3_WkstnHours,Prod3Component3_WkstnHours,Prod4Component3_WkstnHours,Prod1Component3_SvrHours,Prod2Component3_SvrHours,Prod3Component3_SvrHours,Prod4Component3_SvrHours,Prod1Component3_IPHours,Prod2Component3_IPHours,Prod3Component3_IPHours,Prod4Component3_IPHours,Prod1Compnent4Desc,Prod2Compnent4Desc,Prod3Compnent4Desc,Prod4Compnent4Desc,Prod1ComponentHours4,Prod2ComponentHours4,Prod3ComponentHours4,Prod4ComponentHours4,Prod1Component4,Prod2Component4,Prod3Component4,Prod4Component4,Prod1Component4_Wkstn,Prod2Component4_Wkstn,Prod3Component4_Wkstn,Prod4Component4_Wkstn,Prod1Component4_Svr,Prod2Component4_Svr,Prod3Component4_Svr,Prod4Component4_Svr,Prod1Component4_IP,Prod2Component4_IP,Prod3Component4_IP,Prod4Component4_IP,Prod1Component_Qty4,Prod2Component_Qty4,Prod3Component_Qty4,Prod4Component_Qty4,Prod1Component4_WkstnHours,Prod2Component4_WkstnHours,Prod3Component4_WkstnHours,Prod4Component4_WkstnHours,Prod1Component4_SvrHours,Prod2Component4_SvrHours,Prod3Component4_SvrHours,Prod4Component4_SvrHours,Prod1Component4_IPHours,Prod2Component4_IPHours,Prod3Component4_IPHours,Prod4Component4_IPHours,Prod1Compnent5Desc,Prod2Compnent5Desc,Prod3Compnent5Desc,Prod4Compnent5Desc,Prod1ComponentHours5,Prod2ComponentHours5,Prod3ComponentHours5,Prod4ComponentHours5,Prod1Component5,Prod2Component5,Prod3Component5,Prod4Component5,Prod1Component5_Wkstn,Prod2Component5_Wkstn,Prod3Component5_Wkstn,Prod4Component5_Wkstn,Prod1Component5_Svr,Prod2Component5_Svr,Prod3Component5_Svr,Prod4Component5_Svr,Prod1Component5_IP,Prod2Component5_IP,Prod3Component5_IP,Prod4Component5_IP,Prod1Component_Qty5,Prod2Component_Qty5,Prod3Component_Qty5,Prod4Component_Qty5,Prod1Component5_WkstnHours,Prod2Component5_WkstnHours,Prod3Component5_WkstnHours,Prod4Component5_WkstnHours,Prod1Component5_SvrHours,Prod2Component5_SvrHours,Prod3Component5_SvrHours,Prod4Component5_SvrHours,Prod1Component5_IPHours,Prod2Component5_IPHours,Prod3Component5_IPHours,Prod4Component5_IPHours,Prod1Compnent6Desc,Prod2Compnent6Desc,Prod3Compnent6Desc,Prod4Compnent6Desc,Prod1ComponentHours6,Prod2ComponentHours6,Prod3ComponentHours6,Prod4ComponentHours6,Prod1Component6,Prod2Component6,Prod3Component6,Prod4Component6,Prod1Component6_Wkstn,Prod2Component6_Wkstn,Prod3Component6_Wkstn,Prod4Component6_Wkstn,Prod1Component6_Svr,Prod2Component6_Svr,Prod3Component6_Svr,Prod4Component6_Svr,Prod1Component6_IP,Prod2Component6_IP,Prod3Component6_IP,Prod4Component6_IP,Prod1Component_Qty6,Prod2Component_Qty6,Prod3Component_Qty6,Prod4Component_Qty6,Prod1Component6_WkstnHours,Prod2Component6_WkstnHours,Prod3Component6_WkstnHours,Prod4Component6_WkstnHours,Prod1Component6_SvrHours,Prod2Component6_SvrHours,Prod3Component6_SvrHours,Prod4Component6_SvrHours,Prod1Component6_IPHours,Prod2Component6_IPHours,Prod3Component6_IPHours,Prod4Component6_IPHours,Prod1Compnent7Desc,Prod2Compnent7Desc,Prod3Compnent7Desc,Prod4Compnent7Desc,Prod1ComponentHours7,Prod2ComponentHours7,Prod3ComponentHours7,Prod4ComponentHours7,Prod1Component7,Prod2Component7,Prod3Component7,Prod4Component7,Prod1Component7_Wkstn,Prod2Component7_Wkstn,Prod3Component7_Wkstn,Prod4Component7_Wkstn,Prod1Component7_Svr,Prod2Component7_Svr,Prod3Component7_Svr,Prod4Component7_Svr,Prod1Component7_IP,Prod2Component7_IP,Prod3Component7_IP,Prod4Component7_IP,Prod1Component_Qty7,Prod2Component_Qty7,Prod3Component_Qty7,Prod4Component_Qty7,Prod1Component7_WkstnHours,Prod2Component7_WkstnHours,Prod3Component7_WkstnHours,Prod4Component7_WkstnHours,Prod1Component7_SvrHours,Prod2Component7_SvrHours,Prod3Component7_SvrHours,Prod4Component7_SvrHours,Prod1Component7_IPHours,Prod2Component7_IPHours,Prod3Component7_IPHours,Prod4Component7_IPHours,Prod1Compnent8Desc,Prod2Compnent8Desc,Prod3Compnent8Desc,Prod4Compnent8Desc,Prod1ComponentHours8,Prod2ComponentHours8,Prod3ComponentHours8,Prod4ComponentHours8,Prod1Component8,Prod2Component8,Prod3Component8,Prod4Component8,Prod1Component8_Wkstn,Prod2Component8_Wkstn,Prod3Component8_Wkstn,Prod4Component8_Wkstn,Prod1Component8_Svr,Prod2Component8_Svr,Prod3Component8_Svr,Prod4Component8_Svr,Prod1Component8_IP,Prod2Component8_IP,Prod3Component8_IP,Prod4Component8_IP,Prod1Component_Qty8,Prod2Component_Qty8,Prod3Component_Qty8,Prod4Component_Qty8,Prod1Component8_WkstnHours,Prod2Component8_WkstnHours,Prod3Component8_WkstnHours,Prod4Component8_WkstnHours,Prod1Component8_SvrHours,Prod2Component8_SvrHours,Prod3Component8_SvrHours,Prod4Component8_SvrHours,Prod1Component8_IPHours,Prod2Component8_IPHours,Prod3Component8_IPHours,Prod4Component8_IPHours,Prod1Compnent9Desc,Prod2Compnent9Desc,Prod3Compnent9Desc,Prod4Compnent9Desc,Prod1ComponentHours9,Prod2ComponentHours9,Prod3ComponentHours9,Prod4ComponentHours9,Prod1Component9,Prod2Component9,Prod3Component9,Prod4Component9,Prod1Component9_Wkstn,Prod2Component9_Wkstn,Prod3Component9_Wkstn,Prod4Component9_Wkstn,Prod1Component9_Svr,Prod2Component9_Svr,Prod3Component9_Svr,Prod4Component9_Svr,Prod1Component9_IP,Prod2Component9_IP,Prod3Component9_IP,Prod4Component9_IP,Prod1Component_Qty9,Prod2Component_Qty9,Prod3Component_Qty9,Prod4Component_Qty9,Prod1Component9_WkstnHours,Prod2Component9_WkstnHours,Prod3Component9_WkstnHours,Prod4Component9_WkstnHours,Prod1Component9_SvrHours,Prod2Component9_SvrHours,Prod3Component9_SvrHours,Prod4Component9_SvrHours,Prod1Component9_IPHours,Prod2Component9_IPHours,Prod3Component9_IPHours,Prod4Component9_IPHours,Prod1Compnent10Desc,Prod2Compnent10Desc,Prod3Compnent10Desc,Prod4Compnent10Desc,Prod1ComponentHours10,Prod2ComponentHours10,Prod3ComponentHours10,Prod4ComponentHours10,Prod1Component10,Prod2Component10,Prod3Component10,Prod4Component10,Prod1Component10_Wkstn,Prod2Component10_Wkstn,Prod3Component10_Wkstn,Prod4Component10_Wkstn,Prod1Component10_Svr,Prod2Component10_Svr,Prod3Component10_Svr,Prod4Component10_Svr,Prod1Component10_IP,Prod2Component10_IP,Prod3Component10_IP,Prod4Component10_IP,Prod1Component_Qty10,Prod2Component_Qty10,Prod3Component_Qty10,Prod4Component_Qty10,Prod1Component10_WkstnHours,Prod2Component10_WkstnHours,Prod3Component10_WkstnHours,Prod4Component10_WkstnHours,Prod1Component10_SvrHours,Prod2Component10_SvrHours,Prod3Component10_SvrHours,Prod4Component10_SvrHours,Prod1Component10_IPHours,Prod2Component10_IPHours,Prod3Component10_IPHours,Prod4Component10_IPHours,Prod1Compnent11Desc,Prod2Compnent11Desc,Prod3Compnent11Desc,Prod4Compnent11Desc,Prod1ComponentHours11,Prod2ComponentHours11,Prod3ComponentHours11,Prod4ComponentHours11,Prod1Component11,Prod2Component11,Prod3Component11,Prod4Component11,Prod1Component11_Wkstn,Prod2Component11_Wkstn,Prod3Component11_Wkstn,Prod4Component11_Wkstn,Prod1Component11_Svr,Prod2Component11_Svr,Prod3Component11_Svr,Prod4Component11_Svr,Prod1Component11_IP,Prod2Component11_IP,Prod3Component11_IP,Prod4Component11_IP,Prod1Component_Qty11,Prod2Component_Qty11,Prod3Component_Qty11,Prod4Component_Qty11,Prod1Component11_WkstnHours,Prod2Component11_WkstnHours,Prod3Component11_WkstnHours,Prod4Component11_WkstnHours,Prod1Component11_SvrHours,Prod2Component11_SvrHours,Prod3Component11_SvrHours,Prod4Component11_SvrHours,Prod1Component11_IPHours,Prod2Component11_IPHours,Prod3Component11_IPHours,Prod4Component11_IPHours,Prod1Compnent12Desc,Prod2Compnent12Desc,Prod3Compnent12Desc,Prod4Compnent12Desc,Prod1ComponentHours12,Prod2ComponentHours12,Prod3ComponentHours12,Prod4ComponentHours12,Prod1Component12,Prod2Component12,Prod3Component12,Prod4Component12,Prod1Component12_Wkstn,Prod2Component12_Wkstn,Prod3Component12_Wkstn,Prod4Component12_Wkstn,Prod1Component12_Svr,Prod2Component12_Svr,Prod3Component12_Svr,Prod4Component12_Svr,Prod1Component12_IP,Prod2Component12_IP,Prod3Component12_IP,Prod4Component12_IP,Prod1Component_Qty12,Prod2Component_Qty12,Prod3Component_Qty12,Prod4Component_Qty12,Prod1Component12_WkstnHours,Prod2Component12_WkstnHours,Prod3Component12_WkstnHours,Prod4Component12_WkstnHours,Prod1Component12_SvrHours,Prod2Component12_SvrHours,Prod3Component12_SvrHours,Prod4Component12_SvrHours,Prod1Component12_IPHours,Prod2Component12_IPHours,Prod3Component12_IPHours,Prod4Component12_IPHours,Prod1Compnent13Desc,Prod2Compnent13Desc,Prod3Compnent13Desc,Prod4Compnent13Desc,Prod1ComponentHours13,Prod2ComponentHours13,Prod3ComponentHours13,Prod4ComponentHours13,Prod1Component13,Prod2Component13,Prod3Component13,Prod4Component13,Prod1Component13_Wkstn,Prod2Component13_Wkstn,Prod3Component13_Wkstn,Prod4Component13_Wkstn,Prod1Component13_Svr,Prod2Component13_Svr,Prod3Component13_Svr,Prod4Component13_Svr,Prod1Component13_IP,Prod2Component13_IP,Prod3Component13_IP,Prod4Component13_IP,Prod1Component_Qty13,Prod2Component_Qty13,Prod3Component_Qty13,Prod4Component_Qty13,Prod1Component13_WkstnHours,Prod2Component13_WkstnHours,Prod3Component13_WkstnHours,Prod4Component13_WkstnHours,Prod1Component13_SvrHours,Prod2Component13_SvrHours,Prod3Component13_SvrHours,Prod4Component13_SvrHours,Prod1Component13_IPHours,Prod2Component13_IPHours,Prod3Component13_IPHours,Prod4Component13_IPHours,Prod1Compnent14Desc,Prod2Compnent14Desc,Prod3Compnent14Desc,Prod4Compnent14Desc,Prod1ComponentHours14,Prod2ComponentHours14,Prod3ComponentHours14,Prod4ComponentHours14,Prod1Component14,Prod2Component14,Prod3Component14,Prod4Component14,Prod1Component14_Wkstn,Prod2Component14_Wkstn,Prod3Component14_Wkstn,Prod4Component14_Wkstn,Prod1Component14_Svr,Prod2Component14_Svr,Prod3Component14_Svr,Prod4Component14_Svr,Prod1Component14_IP,Prod2Component14_IP,Prod3Component14_IP,Prod4Component14_IP,Prod1Component_Qty14,Prod2Component_Qty14,Prod3Component_Qty14,Prod4Component_Qty14,Prod1Component14_WkstnHours,Prod2Component14_WkstnHours,Prod3Component14_WkstnHours,Prod4Component14_WkstnHours,Prod1Component14_SvrHours,Prod2Component14_SvrHours,Prod3Component14_SvrHours,Prod4Component14_SvrHours,Prod1Component14_IPHours,Prod2Component14_IPHours,Prod3Component14_IPHours,Prod4Component14_IPHours,Prod1Compnent15Desc,Prod2Compnent15Desc,Prod3Compnent15Desc,Prod4Compnent15Desc,Prod1ComponentHours15,Prod2ComponentHours15,Prod3ComponentHours15,Prod4ComponentHours15,Prod1Component15,Prod2Component15,Prod3Component15,Prod4Component15,Prod1Component15_Wkstn,Prod2Component15_Wkstn,Prod3Component15_Wkstn,Prod4Component15_Wkstn,Prod1Component15_Svr,Prod2Component15_Svr,Prod3Component15_Svr,Prod4Component15_Svr,Prod1Component15_IP,Prod2Component15_IP,Prod3Component15_IP,Prod4Component15_IP,Prod1Component_Qty15,Prod2Component_Qty15,Prod3Component_Qty15,Prod4Component_Qty15,Prod1Component15_WkstnHours,Prod2Component15_WkstnHours,Prod3Component15_WkstnHours,Prod4Component15_WkstnHours,Prod1Component15_SvrHours,Prod2Component15_SvrHours,Prod3Component15_SvrHours,Prod4Component15_SvrHours,Prod1Component15_IPHours,Prod2Component15_IPHours,Prod3Component15_IPHours,Prod4Component15_IPHours,CustomComponent_Qty1,CustomComponent_Qty2,CustomComponent_Qty3,CustomComponent_Qty4,CustomComponent_Qty5,CustomComponent1,CustomComponent1Desc,CustomComponent1_Hours,CustomComponent1_TotalHours,CustomComponent2,CustomComponent2Desc,CustomComponent2_Hours,CustomComponent2_TotalHours,CustomComponent3,CustomComponent3Desc,CustomComponent3_Hours,CustomComponent3_TotalHours,CustomComponent4,CustomComponent4Desc,CustomComponent4_Hours,CustomComponent4_TotalHours,CustomComponent5,CustomComponent5Desc,CustomComponent5_Hours,CustomComponent5_TotalHours,TotalCustomHours,TotalCustomFTE,TotalComponents_Hours,TotalComponentsFTE,NumMonths_1,NumMonths_2,NumMonths_3,NumMonths_4,AdditionalServices,AdditionalFTE,SteadyStateHoursTtl,SteadyStateFTETtl,NewSteadyStateSubTtl,ProdLegendTtl_1,ProdLegendTtl_2,ProdLegendTtl_3,ProdLegendTtl_4,TotalOfProdLegendTtl,Password,Username,UserId,RoleId,TeamId,DescProduct_2,DescProduct_3,DescProduct_4,DescLaborDelivery_2,Default_Yr_LaborDelivery_2,DescLaborDelivery_3,Default_Yr_LaborDelivery_3,DescLaborDelivery_4,Default_Yr_LaborDelivery_4,Prod1_Band3_Percentage,Prod1_Band4_Percentage,Prod1_Band5_Percentage,Prod1_Band6_Percentage,Prod1_Band7_Percentage,Prod1_Band8_Percentage,Prod1_Band9_Percentage,Prod2_Band3_Percentage,Prod2_Band4_Percentage,Prod2_Band5_Percentage,Prod2_Band6_Percentage,Prod2_Band7_Percentage,Prod2_Band8_Percentage,Prod2_Band9_Percentage,Prod3_Band3_Percentage,Prod3_Band4_Percentage,Prod3_Band5_Percentage,Prod3_Band6_Percentage,Prod3_Band7_Percentage,Prod3_Band8_Percentage,Prod3_Band9_Percentage")] Sizing sizing)
        {
            if (ModelState.IsValid)
            {
                db.Sizings.Add(sizing);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AcctCustId = new SelectList(db.AcctCusts, "AcctCustId", "AcctName", sizing.AcctCustId);
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName", sizing.AvProductId);
            ViewBag.ConfigId = new SelectList(db.ConfigTables, "ConfigId", "ConfigName", sizing.ConfigId);
            ViewBag.LaborDeliveryId = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions", sizing.LaborDeliveryId);
            ViewBag.SizingTypeId = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName", sizing.SizingTypeId);
            ViewBag.StatusStateId = new SelectList(db.StatusStates, "StatusStateId", "StatusStateName", sizing.StatusStateId);
            ViewBag.TnTId = new SelectList(db.TnTWorksheet, "TnTId", "TnTDescription", sizing.TnTId);

            return View(new Sizing());

        }

        // GET: SizingUserDashboard2/Edit/5
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sizing sizing = await db.Sizings.FindAsync(id);
            if (sizing == null)
            {
                return HttpNotFound();
            }

            ViewBag.AcctCustId = new SelectList(db.AcctCusts, "AcctCustId", "AcctName", sizing.AcctCustId);
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName", sizing.AvProductId);
            ViewBag.ConfigId = new SelectList(db.ConfigTables, "ConfigId", "ConfigName", sizing.ConfigId);
            ViewBag.LaborDeliveryId = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions", sizing.LaborDeliveryId);
            ViewBag.SizingTypeId = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName", sizing.SizingTypeId);
            ViewBag.StatusStateId = new SelectList(db.StatusStates, "StatusStateId", "StatusStateName", sizing.StatusStateId);
            ViewBag.TnTId = new SelectList(db.TnTWorksheet, "TnTId", "TnTDescription", sizing.TnTId);

            // Added for multiple Product Drop-Downs
            ViewBag.Product1 = new SelectList(db.AvProducts, "AvProductId", "ProductName", "Select One");
            ViewBag.Product2 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product3 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product4 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product5 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product6 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product7 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product8 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product9 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product10 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product11 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product12 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ddlProduct13 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.jobID = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.AvProductList = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.AntiVirusProd1 = new SelectList(db.AvProducts, "AvProductId", "TotalComplexity", "Select");

            ViewBag.ddl_AvProduct1 = new SelectList(db.AvProducts, "AvProductId", "ProductName", sizing.AvProductId);
            ViewBag.ProductData = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.CountriesList = new SelectList(db.AvProducts, "AvproductId", "ProductName");

            // Added for multiple Delivery Center Drop-Downs
            ViewBag.DeliveredFrom1 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom2 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom3 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom4 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom5 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom6 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom7 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom8 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom9 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom10 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom11 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom12 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");

            // Added for Band Level Drop usage in Formula to calc FTE
            ViewBag.Bands1 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands2 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands3 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands4 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands5 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands6 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands7 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands8 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands9 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands10 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands11 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands12 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");

            return View(sizing);
        }

        // POST: SizingUserDashboard2/Edit/5

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public async Task<ActionResult> Edit([Bind(Include = "SizingId,ConfigId,AcctCustId,AvProductId,SizingTypeId,LaborDeliveryId,TnTId,StatusStateId,SizingDetailDataId,DisplayForSizingID,SizingName,Created,SizingStatus,ValidToDate,SalesConnectNum,RFSNum,PrepardedBy,RiskRating,TypeSizing,TransitionChrg,TransformationChrg,MemoNote,StedyStateBase,NumServer,NumServer1,NumServer2,NumServer3,NumWorkstation,NumWorkstation1,NumWorkstation2,NumWorkstation3,Total,WorkstationFTE,WorkstationFTE1,WorkstationFTE2,WorkstationFTE3,WkstnsHoursCalc,WkstnsHoursCalc1,WkstnsHoursCalc2,WkstnsHoursCalc3,ServerFTE,ServerFTE1,ServerFTE2,ServerFTE3,SrvsHoursCalc,SrvsHoursCalc1,SrvsHoursCalc2,SrvsHoursCalc3,IPEndpointFTE,IPEndpointFTE1,IPEndpointFTE2,IPEndpointFTE3,IPsHoursCalc,IPsHoursCalc1,IPsHoursCalc2,IPsHoursCalc3,NumIpAddress,NumIpAddress1,NumIpAddress2,NumIpAddress3,AppChangeFTE,AppChangeFTE1,AppChangeFTE2,AppChangeFTE3,AppChangeHoursCalc,AppChangeHoursCalc1,AppChangeHoursCalc2,AppChangeHoursCalc3,NumAppChange,NumAppChange1,NumAppChange2,NumAppChange3,AddlConFTE,AddlConFTE1,AddlConFTE2,AddlConFTE3,AddlConHoursCalc,NumAddlCon,NumAddlCon1,AddlConHoursCalc1,NumAddlCon2,AddlConHoursCalc2,NumAddlCon3,AddlConHoursCalc3,SoftLifeWkstnFTE,SoftLifeSvrFTE,SoftLifeSrvHoursCalc,SoftLifeSvrYesNo,SecComplRptFTE,SecCompHoursCalc,SecCompRptYesNo,ReportingFTE,RportingHoursCalc,ReportingYesNo,SlaRprtFTE,SlaRptHoursCalc,SLAReportingYesNo,FTE,HoursCalc,SteadyStateTotalHours,SteadyStateTotalBand3,SteadyStateTotalBand4,SteadyStateTotalBand5,SteadyStateTotalBand6,SteadyStateTotalBand7,SteadyStateTotalBand8,SteadyStateTotalBand9,SteadyStateBandsTotal,FirstLineMangerBand8Hours,FirstLineMangerBand8Total,FirstLineMangerBand8TotalFTE,SecondLineMangerBand9Hours,SecondLineMangerBand9Total,SecondLineMangerBand9TotalFTE,SteadyStateSubTotalHours,SteadyStateSubTotalBand3,SteadyStateSubTotalBand4,SteadyStateSubTotalBand5,SteadyStateSubTotalBand6,SteadyStateSubTotalBand7,SteadyStateSubTotalBand8,SteadyStateSubTotalBand9,SteadyStateSubTotalTotal,TravelCostCount,TravelCostDesc,TravelCost,TravelCostAmt,RemoteConsoleCostCount,RemoteConsoleDesc,RemoteConsoleCost,RemoteConsoleCostAmt,EducationCostCount,EducationCostDesc,EducationCost,EducationCostAmt,OtherCostCount1,OtherCostDesc1,OtherCost1,OtherCost1Amt,OtherCostCount2,OtherCostDesc2,OtherCost2,OtherCost2Amt,OtherCostCount3,OtherCostDesc3,OtherCost3,OtherCost3Amt,OtherCostsDollarSubTotal,TotalSteadyStateFTE,TotalSteadyStateHours,TotalSteadyStateBand3,TotalSteadyStateBand4,TotalSteadyStateBand5,TotalSteadyStateBand6,TotalSteadyStateBand7,TotalSteadyStateBand8,TotalSteadyStateBand9,TotalSteadyStateTotal1stLineMgr,TotalSteadyStateTotal2ndLineMgr,SteadyStateTotalFTE,SubTotalTotalEffortFTE,SubTotalTotalEffortHours,SubTotalTotalEffortBand3,SubTotalTotalEffortBand4,SubTotalTotalEffortBand5,SubTotalTotalEffortBand6,SubTotalTotalEffortBand7,SubTotalTotalEffortBand8,SubTotalTotalEffortBand9,SubTotalTotalEffort1stLineMgr,SubTotalTotalEffort2ndLineMgr,SubTotalTotalEffortTotalFTE,RiskRatingTotalFTE,SteadyStateGrandTotalFTE,GrandTotalFTE,AvWkstnBand3,AvWkstnBand4,AvWkstnBand5,AvWkstnBand6,AvWkstnBand7,AvWkstnBand8,AvWkstnBand9,AvWkstnBand3_1,AvWkstnBand4_1,AvWkstnBand5_1,AvWkstnBand6_1,AvWkstnBand7_1,AvWkstnBand8_1,AvWkstnBand9_1,AvWkstnBand3_2,AvWkstnBand4_2,AvWkstnBand5_2,AvWkstnBand6_2,AvWkstnBand7_2,AvWkstnBand8_2,AvWkstnBand9_2,AvWkstnBand3_3,AvWkstnBand4_3,AvWkstnBand5_3,AvWkstnBand6_3,AvWkstnBand7_3,AvWkstnBand8_3,AvWkstnBand9_3,AvSvrBand3,AvSvrBand4,AvSvrBand5,AvSvrBand6,AvSvrBand7,AvSvrBand8,AvSvrBand9,AvSvrBand3_1,AvSvrBand4_1,AvSvrBand5_1,AvSvrBand6_1,AvSvrBand7_1,AvSvrBand8_1,AvSvrBand9_1,AvSvrBand3_2,AvSvrBand4_2,AvSvrBand5_2,AvSvrBand6_2,AvSvrBand7_2,AvSvrBand8_2,AvSvrBand9_2,AvSvrBand3_3,AvSvrBand4_3,AvSvrBand5_3,AvSvrBand6_3,AvSvrBand7_3,AvSvrBand8_3,AvSvrBand9_3,AScanBBand3,AScanBBand4,AScanBBand5,AScanBBand6,AScanBBand7,AScanBBand8,AScanBBand9,AScanBBand3_1,AScanBBand4_1,AScanBBand5_1,AScanBBand6_1,AScanBBand7_1,AScanBBand8_1,AScanBBand9_1,AScanBBand3_2,AScanBBand4_2,AScanBBand5_2,AScanBBand6_2,AScanBBand7_2,AScanBBand8_2,AScanBBand9_2,AScanBBand3_3,AScanBBand4_3,AScanBBand5_3,AScanBBand6_3,AScanBBand7_3,AScanBBand8_3,AScanBBand9_3,AddConBand3,AddConBand4,AddConBand5,AddConBand6,AddConBand7,AddConBand8,AddConBand9,AddConBand3_1,AddConBand4_1,AddConBand5_1,AddConBand6_1,AddConBand7_1,AddConBand8_1,AddConBand9_1,AddConBand3_2,AddConBand4_2,AddConBand5_2,AddConBand6_2,AddConBand7_2,AddConBand8_2,AddConBand9_2,AddConBand3_3,AddConBand4_3,AddConBand5_3,AddConBand6_3,AddConBand7_3,AddConBand8_3,AddConBand9_3,TransitionWeeks,TransformationWeeks,Product1,TransitionYesNo,TransformationYesNo,Prod1Compnent1Desc,Prod2Compnent1Desc,Prod3Compnent1Desc,Prod4Compnent1Desc,Prod1Component1,Prod2Component1,Prod3Component1,Prod4Component1,Prod1ComponentHours1,Prod2ComponentHours1,Prod3ComponentHours1,Prod4ComponentHours1,Prod1Component1_Wkstn,Prod2Component1_Wkstn,Prod3Component1_Wkstn,Prod4Component1_Wkstn,Prod1Component1_Svr,Prod2Component1_Svr,Prod3Component1_Svr,Prod4Component1_Svr,Prod1Component1_IP,Prod2Component1_IP,Prod3Component1_IP,Prod4Component1_IP,Prod1Component_Qty1,Prod2Component_Qty1,Prod3Component_Qty1,Prod4Component_Qty1,Prod1Component1_WkstnHours,Prod2Component1_WkstnHours,Prod3Component1_WkstnHours,Prod4Component1_WkstnHours,Prod1Component1_SvrHours,Prod2Component1_SvrHours,Prod3Component1_SvrHours,Prod4Component1_SvrHours,Prod1Component1_IPHours,Prod2Component1_IPHours,Prod3Component1_IPHours,Prod4Component1_IPHours,Prod1Compnent2Desc,Prod2Compnent2Desc,Prod3Compnent2Desc,Prod4Compnent2Desc,Prod1ComponentHours2,Prod2ComponentHours2,Prod3ComponentHours2,Prod4ComponentHours2,Prod1Component2,Prod2Component2,Prod3Component2,Prod4Component2,Prod1Component2_Wkstn,Prod2Component2_Wkstn,Prod3Component2_Wkstn,Prod4Component2_Wkstn,Prod1Component2_Svr,Prod2Component2_Svr,Prod3Component2_Svr,Prod4Component2_Svr,Prod1Component2_IP,Prod2Component2_IP,Prod3Component2_IP,Prod4Component2_IP,Prod1Component_Qty2,Prod2Component_Qty2,Prod3Component_Qty2,Prod4Component_Qty2,Prod1Component2_WkstnHours,Prod2Component2_WkstnHours,Prod3Component2_WkstnHours,Prod4Component2_WkstnHours,Prod1Component2_SvrHours,Prod2Component2_SvrHours,Prod3Component2_SvrHours,Prod4Component2_SvrHours,Prod1Component2_IPHours,Prod2Component2_IPHours,Prod3Component2_IPHours,Prod4Component2_IPHours,Prod2ComponentComplexityFac1_1,Prod2ComponentComplexityFac2_1,Prod2ComponentComplexityFac3_1,Prod2ComponentComplexityFac4_1,Prod2ComponentComplexityFac5_1,Prod2ComponentComplexityFac6_1,Prod2ComponentComplexityFac7_1,Prod2ComponentComplexityFac8_1,Prod2ComponentComplexityFac9_1,Prod2ComponentComplexityFac10_1,Prod2ComponentComplexityFac11_1,Prod2ComponentComplexityFac12_1,Prod2ComponentComplexityFac13_1,Prod2ComponentComplexityFac14_1,Prod2ComponentComplexityFac15_1,Prod3ComponentComplexityFac1_1,Prod3ComponentComplexityFac2_1,Prod3ComponentComplexityFac3_1,Prod3ComponentComplexityFac4_1,Prod3ComponentComplexityFac5_1,Prod3ComponentComplexityFac6_1,Prod3ComponentComplexityFac7_1,Prod3ComponentComplexityFac8_1,Prod3ComponentComplexityFac9_1,Prod3ComponentComplexityFac10_1,Prod3ComponentComplexityFac11_1,Prod3ComponentComplexityFac12_1,Prod3ComponentComplexityFac13_1,Prod3ComponentComplexityFac14_1,Prod3ComponentComplexityFac15_1,Prod4ComponentComplexityFac1_1,Prod4ComponentComplexityFac2_1,Prod4ComponentComplexityFac3_1,Prod4ComponentComplexityFac4_1,Prod4ComponentComplexityFac5_1,Prod4ComponentComplexityFac6_1,Prod4ComponentComplexityFac7_1,Prod4ComponentComplexityFac8_1,Prod4ComponentComplexityFac9_1,Prod4ComponentComplexityFac10_1,Prod4ComponentComplexityFac11_1,Prod4ComponentComplexityFac12_1,Prod4ComponentComplexityFac13_1,Prod4ComponentComplexityFac14_1,Prod4ComponentComplexityFac15_1,Prod1Compnent3Desc,Prod2Compnent3Desc,Prod3Compnent3Desc,Prod4Compnent3Desc,Prod1ComponentHours3,Prod2ComponentHours3,Prod3ComponentHours3,Prod4ComponentHours3,Prod1Component3,Prod2Component3,Prod3Component3,Prod4Component3,Prod1Component3_Wkstn,Prod2Component3_Wkstn,Prod3Component3_Wkstn,Prod4Component3_Wkstn,Prod1Component3_Svr,Prod2Component3_Svr,Prod3Component3_Svr,Prod4Component3_Svr,Prod1Component3_IP,Prod2Component3_IP,Prod3Component3_IP,Prod4Component3_IP,Prod1Component_Qty3,Prod2Component_Qty3,Prod3Component_Qty3,Prod4Component_Qty3,Prod1Component3_WkstnHours,Prod2Component3_WkstnHours,Prod3Component3_WkstnHours,Prod4Component3_WkstnHours,Prod1Component3_SvrHours,Prod2Component3_SvrHours,Prod3Component3_SvrHours,Prod4Component3_SvrHours,Prod1Component3_IPHours,Prod2Component3_IPHours,Prod3Component3_IPHours,Prod4Component3_IPHours,Prod1Compnent4Desc,Prod2Compnent4Desc,Prod3Compnent4Desc,Prod4Compnent4Desc,Prod1ComponentHours4,Prod2ComponentHours4,Prod3ComponentHours4,Prod4ComponentHours4,Prod1Component4,Prod2Component4,Prod3Component4,Prod4Component4,Prod1Component4_Wkstn,Prod2Component4_Wkstn,Prod3Component4_Wkstn,Prod4Component4_Wkstn,Prod1Component4_Svr,Prod2Component4_Svr,Prod3Component4_Svr,Prod4Component4_Svr,Prod1Component4_IP,Prod2Component4_IP,Prod3Component4_IP,Prod4Component4_IP,Prod1Component_Qty4,Prod2Component_Qty4,Prod3Component_Qty4,Prod4Component_Qty4,Prod1Component4_WkstnHours,Prod2Component4_WkstnHours,Prod3Component4_WkstnHours,Prod4Component4_WkstnHours,Prod1Component4_SvrHours,Prod2Component4_SvrHours,Prod3Component4_SvrHours,Prod4Component4_SvrHours,Prod1Component4_IPHours,Prod2Component4_IPHours,Prod3Component4_IPHours,Prod4Component4_IPHours,Prod1Compnent5Desc,Prod2Compnent5Desc,Prod3Compnent5Desc,Prod4Compnent5Desc,Prod1ComponentHours5,Prod2ComponentHours5,Prod3ComponentHours5,Prod4ComponentHours5,Prod1Component5,Prod2Component5,Prod3Component5,Prod4Component5,Prod1Component5_Wkstn,Prod2Component5_Wkstn,Prod3Component5_Wkstn,Prod4Component5_Wkstn,Prod1Component5_Svr,Prod2Component5_Svr,Prod3Component5_Svr,Prod4Component5_Svr,Prod1Component5_IP,Prod2Component5_IP,Prod3Component5_IP,Prod4Component5_IP,Prod1Component_Qty5,Prod2Component_Qty5,Prod3Component_Qty5,Prod4Component_Qty5,Prod1Component5_WkstnHours,Prod2Component5_WkstnHours,Prod3Component5_WkstnHours,Prod4Component5_WkstnHours,Prod1Component5_SvrHours,Prod2Component5_SvrHours,Prod3Component5_SvrHours,Prod4Component5_SvrHours,Prod1Component5_IPHours,Prod2Component5_IPHours,Prod3Component5_IPHours,Prod4Component5_IPHours,Prod1Compnent6Desc,Prod2Compnent6Desc,Prod3Compnent6Desc,Prod4Compnent6Desc,Prod1ComponentHours6,Prod2ComponentHours6,Prod3ComponentHours6,Prod4ComponentHours6,Prod1Component6,Prod2Component6,Prod3Component6,Prod4Component6,Prod1Component6_Wkstn,Prod2Component6_Wkstn,Prod3Component6_Wkstn,Prod4Component6_Wkstn,Prod1Component6_Svr,Prod2Component6_Svr,Prod3Component6_Svr,Prod4Component6_Svr,Prod1Component6_IP,Prod2Component6_IP,Prod3Component6_IP,Prod4Component6_IP,Prod1Component_Qty6,Prod2Component_Qty6,Prod3Component_Qty6,Prod4Component_Qty6,Prod1Component6_WkstnHours,Prod2Component6_WkstnHours,Prod3Component6_WkstnHours,Prod4Component6_WkstnHours,Prod1Component6_SvrHours,Prod2Component6_SvrHours,Prod3Component6_SvrHours,Prod4Component6_SvrHours,Prod1Component6_IPHours,Prod2Component6_IPHours,Prod3Component6_IPHours,Prod4Component6_IPHours,Prod1Compnent7Desc,Prod2Compnent7Desc,Prod3Compnent7Desc,Prod4Compnent7Desc,Prod1ComponentHours7,Prod2ComponentHours7,Prod3ComponentHours7,Prod4ComponentHours7,Prod1Component7,Prod2Component7,Prod3Component7,Prod4Component7,Prod1Component7_Wkstn,Prod2Component7_Wkstn,Prod3Component7_Wkstn,Prod4Component7_Wkstn,Prod1Component7_Svr,Prod2Component7_Svr,Prod3Component7_Svr,Prod4Component7_Svr,Prod1Component7_IP,Prod2Component7_IP,Prod3Component7_IP,Prod4Component7_IP,Prod1Component_Qty7,Prod2Component_Qty7,Prod3Component_Qty7,Prod4Component_Qty7,Prod1Component7_WkstnHours,Prod2Component7_WkstnHours,Prod3Component7_WkstnHours,Prod4Component7_WkstnHours,Prod1Component7_SvrHours,Prod2Component7_SvrHours,Prod3Component7_SvrHours,Prod4Component7_SvrHours,Prod1Component7_IPHours,Prod2Component7_IPHours,Prod3Component7_IPHours,Prod4Component7_IPHours,Prod1Compnent8Desc,Prod2Compnent8Desc,Prod3Compnent8Desc,Prod4Compnent8Desc,Prod1ComponentHours8,Prod2ComponentHours8,Prod3ComponentHours8,Prod4ComponentHours8,Prod1Component8,Prod2Component8,Prod3Component8,Prod4Component8,Prod1Component8_Wkstn,Prod2Component8_Wkstn,Prod3Component8_Wkstn,Prod4Component8_Wkstn,Prod1Component8_Svr,Prod2Component8_Svr,Prod3Component8_Svr,Prod4Component8_Svr,Prod1Component8_IP,Prod2Component8_IP,Prod3Component8_IP,Prod4Component8_IP,Prod1Component_Qty8,Prod2Component_Qty8,Prod3Component_Qty8,Prod4Component_Qty8,Prod1Component8_WkstnHours,Prod2Component8_WkstnHours,Prod3Component8_WkstnHours,Prod4Component8_WkstnHours,Prod1Component8_SvrHours,Prod2Component8_SvrHours,Prod3Component8_SvrHours,Prod4Component8_SvrHours,Prod1Component8_IPHours,Prod2Component8_IPHours,Prod3Component8_IPHours,Prod4Component8_IPHours,Prod1Compnent9Desc,Prod2Compnent9Desc,Prod3Compnent9Desc,Prod4Compnent9Desc,Prod1ComponentHours9,Prod2ComponentHours9,Prod3ComponentHours9,Prod4ComponentHours9,Prod1Component9,Prod2Component9,Prod3Component9,Prod4Component9,Prod1Component9_Wkstn,Prod2Component9_Wkstn,Prod3Component9_Wkstn,Prod4Component9_Wkstn,Prod1Component9_Svr,Prod2Component9_Svr,Prod3Component9_Svr,Prod4Component9_Svr,Prod1Component9_IP,Prod2Component9_IP,Prod3Component9_IP,Prod4Component9_IP,Prod1Component_Qty9,Prod2Component_Qty9,Prod3Component_Qty9,Prod4Component_Qty9,Prod1Component9_WkstnHours,Prod2Component9_WkstnHours,Prod3Component9_WkstnHours,Prod4Component9_WkstnHours,Prod1Component9_SvrHours,Prod2Component9_SvrHours,Prod3Component9_SvrHours,Prod4Component9_SvrHours,Prod1Component9_IPHours,Prod2Component9_IPHours,Prod3Component9_IPHours,Prod4Component9_IPHours,Prod1Compnent10Desc,Prod2Compnent10Desc,Prod3Compnent10Desc,Prod4Compnent10Desc,Prod1ComponentHours10,Prod2ComponentHours10,Prod3ComponentHours10,Prod4ComponentHours10,Prod1Component10,Prod2Component10,Prod3Component10,Prod4Component10,Prod1Component10_Wkstn,Prod2Component10_Wkstn,Prod3Component10_Wkstn,Prod4Component10_Wkstn,Prod1Component10_Svr,Prod2Component10_Svr,Prod3Component10_Svr,Prod4Component10_Svr,Prod1Component10_IP,Prod2Component10_IP,Prod3Component10_IP,Prod4Component10_IP,Prod1Component_Qty10,Prod2Component_Qty10,Prod3Component_Qty10,Prod4Component_Qty10,Prod1Component10_WkstnHours,Prod2Component10_WkstnHours,Prod3Component10_WkstnHours,Prod4Component10_WkstnHours,Prod1Component10_SvrHours,Prod2Component10_SvrHours,Prod3Component10_SvrHours,Prod4Component10_SvrHours,Prod1Component10_IPHours,Prod2Component10_IPHours,Prod3Component10_IPHours,Prod4Component10_IPHours,Prod1Compnent11Desc,Prod2Compnent11Desc,Prod3Compnent11Desc,Prod4Compnent11Desc,Prod1ComponentHours11,Prod2ComponentHours11,Prod3ComponentHours11,Prod4ComponentHours11,Prod1Component11,Prod2Component11,Prod3Component11,Prod4Component11,Prod1Component11_Wkstn,Prod2Component11_Wkstn,Prod3Component11_Wkstn,Prod4Component11_Wkstn,Prod1Component11_Svr,Prod2Component11_Svr,Prod3Component11_Svr,Prod4Component11_Svr,Prod1Component11_IP,Prod2Component11_IP,Prod3Component11_IP,Prod4Component11_IP,Prod1Component_Qty11,Prod2Component_Qty11,Prod3Component_Qty11,Prod4Component_Qty11,Prod1Component11_WkstnHours,Prod2Component11_WkstnHours,Prod3Component11_WkstnHours,Prod4Component11_WkstnHours,Prod1Component11_SvrHours,Prod2Component11_SvrHours,Prod3Component11_SvrHours,Prod4Component11_SvrHours,Prod1Component11_IPHours,Prod2Component11_IPHours,Prod3Component11_IPHours,Prod4Component11_IPHours,Prod1Compnent12Desc,Prod2Compnent12Desc,Prod3Compnent12Desc,Prod4Compnent12Desc,Prod1ComponentHours12,Prod2ComponentHours12,Prod3ComponentHours12,Prod4ComponentHours12,Prod1Component12,Prod2Component12,Prod3Component12,Prod4Component12,Prod1Component12_Wkstn,Prod2Component12_Wkstn,Prod3Component12_Wkstn,Prod4Component12_Wkstn,Prod1Component12_Svr,Prod2Component12_Svr,Prod3Component12_Svr,Prod4Component12_Svr,Prod1Component12_IP,Prod2Component12_IP,Prod3Component12_IP,Prod4Component12_IP,Prod1Component_Qty12,Prod2Component_Qty12,Prod3Component_Qty12,Prod4Component_Qty12,Prod1Component12_WkstnHours,Prod2Component12_WkstnHours,Prod3Component12_WkstnHours,Prod4Component12_WkstnHours,Prod1Component12_SvrHours,Prod2Component12_SvrHours,Prod3Component12_SvrHours,Prod4Component12_SvrHours,Prod1Component12_IPHours,Prod2Component12_IPHours,Prod3Component12_IPHours,Prod4Component12_IPHours,Prod1Compnent13Desc,Prod2Compnent13Desc,Prod3Compnent13Desc,Prod4Compnent13Desc,Prod1ComponentHours13,Prod2ComponentHours13,Prod3ComponentHours13,Prod4ComponentHours13,Prod1Component13,Prod2Component13,Prod3Component13,Prod4Component13,Prod1Component13_Wkstn,Prod2Component13_Wkstn,Prod3Component13_Wkstn,Prod4Component13_Wkstn,Prod1Component13_Svr,Prod2Component13_Svr,Prod3Component13_Svr,Prod4Component13_Svr,Prod1Component13_IP,Prod2Component13_IP,Prod3Component13_IP,Prod4Component13_IP,Prod1Component_Qty13,Prod2Component_Qty13,Prod3Component_Qty13,Prod4Component_Qty13,Prod1Component13_WkstnHours,Prod2Component13_WkstnHours,Prod3Component13_WkstnHours,Prod4Component13_WkstnHours,Prod1Component13_SvrHours,Prod2Component13_SvrHours,Prod3Component13_SvrHours,Prod4Component13_SvrHours,Prod1Component13_IPHours,Prod2Component13_IPHours,Prod3Component13_IPHours,Prod4Component13_IPHours,Prod1Compnent14Desc,Prod2Compnent14Desc,Prod3Compnent14Desc,Prod4Compnent14Desc,Prod1ComponentHours14,Prod2ComponentHours14,Prod3ComponentHours14,Prod4ComponentHours14,Prod1Component14,Prod2Component14,Prod3Component14,Prod4Component14,Prod1Component14_Wkstn,Prod2Component14_Wkstn,Prod3Component14_Wkstn,Prod4Component14_Wkstn,Prod1Component14_Svr,Prod2Component14_Svr,Prod3Component14_Svr,Prod4Component14_Svr,Prod1Component14_IP,Prod2Component14_IP,Prod3Component14_IP,Prod4Component14_IP,Prod1Component_Qty14,Prod2Component_Qty14,Prod3Component_Qty14,Prod4Component_Qty14,Prod1Component14_WkstnHours,Prod2Component14_WkstnHours,Prod3Component14_WkstnHours,Prod4Component14_WkstnHours,Prod1Component14_SvrHours,Prod2Component14_SvrHours,Prod3Component14_SvrHours,Prod4Component14_SvrHours,Prod1Component14_IPHours,Prod2Component14_IPHours,Prod3Component14_IPHours,Prod4Component14_IPHours,Prod1Compnent15Desc,Prod2Compnent15Desc,Prod3Compnent15Desc,Prod4Compnent15Desc,Prod1ComponentHours15,Prod2ComponentHours15,Prod3ComponentHours15,Prod4ComponentHours15,Prod1Component15,Prod2Component15,Prod3Component15,Prod4Component15,Prod1Component15_Wkstn,Prod2Component15_Wkstn,Prod3Component15_Wkstn,Prod4Component15_Wkstn,Prod1Component15_Svr,Prod2Component15_Svr,Prod3Component15_Svr,Prod4Component15_Svr,Prod1Component15_IP,Prod2Component15_IP,Prod3Component15_IP,Prod4Component15_IP,Prod1Component_Qty15,Prod2Component_Qty15,Prod3Component_Qty15,Prod4Component_Qty15,Prod1Component15_WkstnHours,Prod2Component15_WkstnHours,Prod3Component15_WkstnHours,Prod4Component15_WkstnHours,Prod1Component15_SvrHours,Prod2Component15_SvrHours,Prod3Component15_SvrHours,Prod4Component15_SvrHours,Prod1Component15_IPHours,Prod2Component15_IPHours,Prod3Component15_IPHours,Prod4Component15_IPHours,CustomComponent_Qty1,CustomComponent_Qty2,CustomComponent_Qty3,CustomComponent_Qty4,CustomComponent_Qty5,CustomComponent1,CustomComponent1Desc,CustomComponent1_Hours,CustomComponent1_TotalHours,CustomComponent2,CustomComponent2Desc,CustomComponent2_Hours,CustomComponent2_TotalHours,CustomComponent3,CustomComponent3Desc,CustomComponent3_Hours,CustomComponent3_TotalHours,CustomComponent4,CustomComponent4Desc,CustomComponent4_Hours,CustomComponent4_TotalHours,CustomComponent5,CustomComponent5Desc,CustomComponent5_Hours,CustomComponent5_TotalHours,TotalCustomHours,TotalCustomFTE,TotalComponents_Hours,TotalComponentsFTE,NumMonths_1,NumMonths_2,NumMonths_3,NumMonths_4,AdditionalServices,AdditionalFTE,SteadyStateHoursTtl,SteadyStateFTETtl,NewSteadyStateSubTtl,ProdLegendTtl_1,ProdLegendTtl_2,ProdLegendTtl_3,ProdLegendTtl_4,TotalOfProdLegendTtl,Password,Username,UserId,RoleId,TeamId,DescProduct_2,DescProduct_3,DescProduct_4,DescLaborDelivery_2,Default_Yr_LaborDelivery_2,DescLaborDelivery_3,Default_Yr_LaborDelivery_3,DescLaborDelivery_4,Default_Yr_LaborDelivery_4,Prod1_Band3_Percentage,Prod1_Band4_Percentage,Prod1_Band5_Percentage,Prod1_Band6_Percentage,Prod1_Band7_Percentage,Prod1_Band8_Percentage,Prod1_Band9_Percentage,Prod2_Band3_Percentage,Prod2_Band4_Percentage,Prod2_Band5_Percentage,Prod2_Band6_Percentage,Prod2_Band7_Percentage,Prod2_Band8_Percentage,Prod2_Band9_Percentage,Prod3_Band3_Percentage,Prod3_Band4_Percentage,Prod3_Band5_Percentage,Prod3_Band6_Percentage,Prod3_Band7_Percentage,Prod3_Band8_Percentage,Prod3_Band9_Percentage")] Sizing sizing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sizing).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Edit");
            }
            ViewBag.AcctCustId = new SelectList(db.AcctCusts, "AcctCustId", "AcctName", sizing.AcctCustId);
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName", sizing.AvProductId);
            ViewBag.ConfigId = new SelectList(db.ConfigTables, "ConfigId", "ConfigName", sizing.ConfigId);
            ViewBag.LaborDeliveryId = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions", sizing.LaborDeliveryId);
            ViewBag.SizingTypeId = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName", sizing.SizingTypeId);
            ViewBag.StatusStateId = new SelectList(db.StatusStates, "StatusStateId", "StatusStateName", sizing.StatusStateId);
            ViewBag.TnTId = new SelectList(db.TnTWorksheet, "TnTId", "TnTDescription", sizing.TnTId);

            // Added for multiple Product Drop-Downs
            ViewBag.Product1 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product2 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product3 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product4 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product5 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product6 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product7 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product8 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product9 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product10 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product11 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product12 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ddlProduct13 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.jobID = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.AvProductList = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.AntiVirusProd1 = new SelectList(db.AvProducts, "AvProductId", "TotalComplexity", "Select");

            // DropDow Source for Sizing Sheet Drop-Downs
            ViewBag.SecurityProducts = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ProductData = new SelectList(db.AvProducts, "AvProductId", "ProductName");



            // Added for multiple Delivery Center Drop-Downs
            ViewBag.DeliveredFrom1 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom2 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom3 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom4 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom5 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom6 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom7 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom8 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom9 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom10 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom11 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom12 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");

            // Added for Band Level Drop usage in Formula to calc FTE
            ViewBag.Bands1 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands2 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands3 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands4 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands5 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands6 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands7 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands8 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands9 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands10 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands11 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands12 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");

            return View(sizing);
        }

        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public ActionResult ProcessForm(Sizing obj, string submit)
        {
            switch (submit)
            {
                case "Save":
                    ViewBag.Message = "Customer saved successfully!";
                    break;
                case "Cancel":
                    ViewBag.Message = "The operation was cancelled!";
                    break;
            }
            return View("Result", obj);
        }

        // GET: SizingUserDashboard2/Delete/5
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sizing sizing = await db.Sizings.FindAsync(id);
            if (sizing == null)
            {
                return HttpNotFound();
            }
            return View(sizing);
        }

        // POST: SizingUserDashboard2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Sizing sizing = await db.Sizings.FindAsync(id);
            db.Sizings.Remove(sizing);
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

        // GET: SizingUserDashboard2/GetSizings/5
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        public async Task<ActionResult> GetSizings(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sizing sizing = await db.Sizings.FindAsync(id);
            if (sizing == null)
            {
                return HttpNotFound();
            }

            ViewBag.AcctCustId = new SelectList(db.AcctCusts, "AcctCustId", "AcctName", sizing.AcctCustId);
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName", sizing.AvProductId);
            ViewBag.ConfigId = new SelectList(db.ConfigTables, "ConfigId", "ConfigName", sizing.ConfigId);
            ViewBag.LaborDeliveryId = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions", sizing.LaborDeliveryId);
            ViewBag.SizingTypeId = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName", sizing.SizingTypeId);
            ViewBag.StatusStateId = new SelectList(db.StatusStates, "StatusStateId", "StatusStateName", sizing.StatusStateId);
            ViewBag.TnTId = new SelectList(db.TnTWorksheet, "TnTId", "TnTDescription", sizing.TnTId);

            // Added for multiple Product Drop-Downs
            ViewBag.Product1 = new SelectList(db.AvProducts, "AvProductId", "ProductName", "Select One");
            ViewBag.Product2 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product3 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product4 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product5 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product6 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product7 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product8 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product9 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product10 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product11 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product12 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ddlProduct13 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.jobID = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.AvProductList = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.AntiVirusProd1 = new SelectList(db.AvProducts, "AvProductId", "TotalComplexity", "Select");

            ViewBag.ddl_AvProduct1 = new SelectList(db.AvProducts, "AvProductId", "ProductName", sizing.AvProductId);
            ViewBag.ProductData = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.CountriesList = new SelectList(db.AvProducts, "AvproductId", "ProductName");

            // Added for multiple Delivery Center Drop-Downs
            ViewBag.DeliveredFrom1 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom2 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom3 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom4 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom5 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom6 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom7 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom8 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom9 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom10 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom11 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom12 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");

            // Added for Band Level Drop usage in Formula to calc FTE
            ViewBag.Bands1 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands2 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands3 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands4 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands5 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands6 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands7 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands8 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands9 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands10 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands11 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands12 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");

            return View(sizing);
        }
        [AllowAnonymous]
        // GET: SizingUserDashboard2/GeneratePDF
        public ActionResult GeneratePDF()
        {
            return new Rotativa.ActionAsPdf("GetSizings");
        }

        public ActionResult PrintSalarySlip()
        {
            var report = new Rotativa.MVC.ActionAsPdf("Index");
            return report;
        }

        public ActionResult ExitWithoutSaving()
        {
            return RedirectToAction("Index");
        }

        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public ActionResult GetProductByID1(string id)
        {
            int AvProdId = Convert.ToInt32(id);
            //According id to query the database and get the relevant values.
            var query = db.AvProducts.Where(c => c.AvProductId == AvProdId).Select(c => new { AvProductId = c.AvProductId, ProductName = c.ProductName, ProductDesc = c.ProductDesc, ProductComplexityFac = c.ProductComplexityFac, ProductComplexityBase = c.ProductComplexityBase, TotalComplexity = c.TotalComplexity, Component1Desc = c.Component1Desc, Component2Desc = c.Component2Desc, Component3Desc = c.Component3Desc, Component4Desc = c.Component4Desc, Component5Desc = c.Component5Desc, Component6Desc = c.Component6Desc, Component7Desc = c.Component7Desc, Component8Desc = c.Component8Desc, Component9Desc = c.Component9Desc, Component10Desc = c.Component10Desc, Component11Desc = c.Component11Desc, Component12Desc = c.Component12Desc, Component13Desc = c.Component13Desc, Component14Desc = c.Component14Desc, Component15Desc = c.Component15Desc, ComponentComplexityFac1 = c.ComponentComplexityFac1, ComponentComplexityFac2 = c.ComponentComplexityFac2, ComponentComplexityFac3 = c.ComponentComplexityFac3, ComponentComplexityFac4 = c.ComponentComplexityFac4, ComponentComplexityFac5 = c.ComponentComplexityFac5, ComponentComplexityFac6 = c.ComponentComplexityFac6, ComponentComplexityFac7 = c.ComponentComplexityFac7, ComponentComplexityFac8 = c.ComponentComplexityFac8, ComponentComplexityFac9 = c.ComponentComplexityFac9, ComponentComplexityFac10 = c.ComponentComplexityFac10, ComponentComplexityFac11 = c.ComponentComplexityFac11, ComponentComplexityFac12 = c.ComponentComplexityFac12, ComponentComplexityFac13 = c.ComponentComplexityFac13, ComponentComplexityFac14 = c.ComponentComplexityFac14, ComponentComplexityFac15 = c.ComponentComplexityFac15 }).FirstOrDefault();
            return Json(query, JsonRequestBehavior.AllowGet);
        }
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public ActionResult GetProductByID2(string id)
        {
            int AvProdId2 = Convert.ToInt32(id);
            //According id to query the database and get the relevant values.
            var query = db.AvProducts.Where(c => c.AvProductId == AvProdId2).Select(c => new { AvProductId = c.AvProductId, ProductName = c.ProductName, ProductDesc = c.ProductDesc, ProductComplexityFac = c.ProductComplexityFac, ProductComplexityBase = c.ProductComplexityBase, TotalComplexity = c.TotalComplexity, Component1Desc = c.Component1Desc, Component2Desc = c.Component2Desc, Component3Desc = c.Component3Desc, Component4Desc = c.Component4Desc, Component5Desc = c.Component5Desc, Component6Desc = c.Component6Desc, Component7Desc = c.Component7Desc, Component8Desc = c.Component8Desc, Component9Desc = c.Component9Desc, Component10Desc = c.Component10Desc, Component11Desc = c.Component11Desc, Component12Desc = c.Component12Desc, Component13Desc = c.Component13Desc, Component14Desc = c.Component14Desc, Component15Desc = c.Component15Desc, ComponentComplexityFac1 = c.ComponentComplexityFac1, ComponentComplexityFac2 = c.ComponentComplexityFac2, ComponentComplexityFac3 = c.ComponentComplexityFac3, ComponentComplexityFac4 = c.ComponentComplexityFac4, ComponentComplexityFac5 = c.ComponentComplexityFac5, ComponentComplexityFac6 = c.ComponentComplexityFac6, ComponentComplexityFac7 = c.ComponentComplexityFac7, ComponentComplexityFac8 = c.ComponentComplexityFac8, ComponentComplexityFac9 = c.ComponentComplexityFac9, ComponentComplexityFac10 = c.ComponentComplexityFac10, ComponentComplexityFac11 = c.ComponentComplexityFac11, ComponentComplexityFac12 = c.ComponentComplexityFac12, ComponentComplexityFac13 = c.ComponentComplexityFac13, ComponentComplexityFac14 = c.ComponentComplexityFac14, ComponentComplexityFac15 = c.ComponentComplexityFac15 }).FirstOrDefault();
            return Json(query, JsonRequestBehavior.AllowGet);
        }
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public ActionResult GetProductByID3(string id)
        {
            int AvProdId3 = Convert.ToInt32(id);
            //According id to query the database and get the relevant values.
            var query = db.AvProducts.Where(c => c.AvProductId == AvProdId3).Select(c => new { AvProductId = c.AvProductId, ProductName = c.ProductName, ProductDesc = c.ProductDesc, ProductComplexityFac = c.ProductComplexityFac, ProductComplexityBase = c.ProductComplexityBase, TotalComplexity = c.TotalComplexity, Component1Desc = c.Component1Desc, Component2Desc = c.Component2Desc, Component3Desc = c.Component3Desc, Component4Desc = c.Component4Desc, Component5Desc = c.Component5Desc, Component6Desc = c.Component6Desc, Component7Desc = c.Component7Desc, Component8Desc = c.Component8Desc, Component9Desc = c.Component9Desc, Component10Desc = c.Component10Desc, Component11Desc = c.Component11Desc, Component12Desc = c.Component12Desc, Component13Desc = c.Component13Desc, Component14Desc = c.Component14Desc, Component15Desc = c.Component15Desc, ComponentComplexityFac1 = c.ComponentComplexityFac1, ComponentComplexityFac2 = c.ComponentComplexityFac2, ComponentComplexityFac3 = c.ComponentComplexityFac3, ComponentComplexityFac4 = c.ComponentComplexityFac4, ComponentComplexityFac5 = c.ComponentComplexityFac5, ComponentComplexityFac6 = c.ComponentComplexityFac6, ComponentComplexityFac7 = c.ComponentComplexityFac7, ComponentComplexityFac8 = c.ComponentComplexityFac8, ComponentComplexityFac9 = c.ComponentComplexityFac9, ComponentComplexityFac10 = c.ComponentComplexityFac10, ComponentComplexityFac11 = c.ComponentComplexityFac11, ComponentComplexityFac12 = c.ComponentComplexityFac12, ComponentComplexityFac13 = c.ComponentComplexityFac13, ComponentComplexityFac14 = c.ComponentComplexityFac14, ComponentComplexityFac15 = c.ComponentComplexityFac15 }).FirstOrDefault();
            return Json(query, JsonRequestBehavior.AllowGet);
        }
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public ActionResult GetProductByID4(string id)
        {
            int AvProdId4 = Convert.ToInt32(id);
            //According id to query the database and get the relevant values.
            var query = db.AvProducts.Where(c => c.AvProductId == AvProdId4).Select(c => new { AvProductId = c.AvProductId, ProductName = c.ProductName, ProductDesc = c.ProductDesc, ProductComplexityFac = c.ProductComplexityFac, ProductComplexityBase = c.ProductComplexityBase, TotalComplexity = c.TotalComplexity, Component1Desc = c.Component1Desc, Component2Desc = c.Component2Desc, Component3Desc = c.Component3Desc, Component4Desc = c.Component4Desc, Component5Desc = c.Component5Desc, Component6Desc = c.Component6Desc, Component7Desc = c.Component7Desc, Component8Desc = c.Component8Desc, Component9Desc = c.Component9Desc, Component10Desc = c.Component10Desc, Component11Desc = c.Component11Desc, Component12Desc = c.Component12Desc, Component13Desc = c.Component13Desc, Component14Desc = c.Component14Desc, Component15Desc = c.Component15Desc, ComponentComplexityFac1 = c.ComponentComplexityFac1, ComponentComplexityFac2 = c.ComponentComplexityFac2, ComponentComplexityFac3 = c.ComponentComplexityFac3, ComponentComplexityFac4 = c.ComponentComplexityFac4, ComponentComplexityFac5 = c.ComponentComplexityFac5, ComponentComplexityFac6 = c.ComponentComplexityFac6, ComponentComplexityFac7 = c.ComponentComplexityFac7, ComponentComplexityFac8 = c.ComponentComplexityFac8, ComponentComplexityFac9 = c.ComponentComplexityFac9, ComponentComplexityFac10 = c.ComponentComplexityFac10, ComponentComplexityFac11 = c.ComponentComplexityFac11, ComponentComplexityFac12 = c.ComponentComplexityFac12, ComponentComplexityFac13 = c.ComponentComplexityFac13, ComponentComplexityFac14 = c.ComponentComplexityFac14, ComponentComplexityFac15 = c.ComponentComplexityFac15 }).FirstOrDefault();
            return Json(query, JsonRequestBehavior.AllowGet);
        }

        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public ActionResult GetLaborByID1(string id)
        {
            int LaborId1 = Convert.ToInt32(id);
            //According id to query the database and get the relevant values.
            var query = db.LaborDeliverys.Where(c => c.LaborDeliveryId == LaborId1).Select(c => new { LaborDeliveryId = c.LaborDeliveryId, RegionNumber = c.RegionNumber, Regions = c.Regions, DeliveryOption = c.DeliveryOption, CurrencyType = c.CurrencyType, DefaultFTE_Year = c.DefaultFTE_Year }).FirstOrDefault();
            return Json(query, JsonRequestBehavior.AllowGet);
        }
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public ActionResult GetLaborByID2(string id)
        {
            int LaborId2 = Convert.ToInt32(id);
            //According id to query the database and get the relevant values.
            var query = db.LaborDeliverys.Where(c => c.LaborDeliveryId == LaborId2).Select(c => new { LaborDeliveryId = c.LaborDeliveryId, RegionNumber = c.RegionNumber, Regions = c.Regions, DeliveryOption = c.DeliveryOption, CurrencyType = c.CurrencyType, DefaultFTE_Year = c.DefaultFTE_Year }).FirstOrDefault();
            return Json(query, JsonRequestBehavior.AllowGet);
        }
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public ActionResult GetLaborByID3(string id)
        {
            int LaborId3 = Convert.ToInt32(id);
            //According id to query the database and get the relevant values.
            var query = db.LaborDeliverys.Where(c => c.LaborDeliveryId == LaborId3).Select(c => new { LaborDeliveryId = c.LaborDeliveryId, RegionNumber = c.RegionNumber, Regions = c.Regions, DeliveryOption = c.DeliveryOption, CurrencyType = c.CurrencyType, DefaultFTE_Year = c.DefaultFTE_Year }).FirstOrDefault();
            return Json(query, JsonRequestBehavior.AllowGet);
        }
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public ActionResult GetLaborByID4(string id)
        {
            int LaborId4 = Convert.ToInt32(id);
            //According id to query the database and get the relevant values.
            var query = db.LaborDeliverys.Where(c => c.LaborDeliveryId == LaborId4).Select(c => new { LaborDeliveryId = c.LaborDeliveryId, RegionNumber = c.RegionNumber, Regions = c.Regions, DeliveryOption = c.DeliveryOption, CurrencyType = c.CurrencyType, DefaultFTE_Year = c.DefaultFTE_Year }).FirstOrDefault();
            return Json(query, JsonRequestBehavior.AllowGet);
        }




        // GET: SizingUserDashboard2/GBO/5
        [AllowAnonymous]
        public async Task<ActionResult> GBO(int? id)
        {

            ViewBag.AcctCustId = new SelectList(db.AcctCusts, "AcctCustId", "AcctName");
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ConfigId = new SelectList(db.ConfigTables, "ConfigId", "ConfigName");
            ViewBag.LaborDeliveryId = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.SizingTypeId = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName");
            ViewBag.StatusStateId = new SelectList(db.StatusStates, "StatusStateId", "StatusStateName");
            ViewBag.TnTId = new SelectList(db.TnTWorksheet, "TnTId", "TnTDescription");

            // Added for multiple Product Drop-Downs
            ViewBag.Product1 = new SelectList(db.AvProducts, "AvProductId", "ProductName", "Select One");
            ViewBag.Product2 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product3 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product4 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product5 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product6 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product7 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product8 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product9 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product10 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product11 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product12 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ddlProduct13 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.jobID = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.AvProductList = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.AntiVirusProd1 = new SelectList(db.AvProducts, "AvProductId", "TotalComplexity", "Select");

            // ViewBag.ddl_AvProduct1 = new SelectList(db.AvProducts, "AvProductId", "ProductName", sizing.AvProductId);
            ViewBag.ProductData = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.CountriesList = new SelectList(db.AvProducts, "AvproductId", "ProductName");

            // Added for multiple Delivery Center Drop-Downs
            ViewBag.DeliveredFrom1 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom2 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom3 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom4 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom5 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom6 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom7 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom8 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom9 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom10 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom11 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom12 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");

            // Added for Band Level Drop usage in Formula to calc FTE
            ViewBag.Bands1 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands2 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands3 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands4 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands5 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands6 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands7 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands8 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands9 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands10 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands11 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands12 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sizing sizing = await db.Sizings.FindAsync(id);
            if (sizing == null)
            {
                return HttpNotFound();
            }
            return View(sizing);
        }



        // GET: SizingUserDashboard2/GBONew/5
        [AllowAnonymous]
        public async Task<ActionResult> GBONew(int? id)
        {

            ViewBag.AcctCustId = new SelectList(db.AcctCusts, "AcctCustId", "AcctName");
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ConfigId = new SelectList(db.ConfigTables, "ConfigId", "ConfigName");
            ViewBag.LaborDeliveryId = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.SizingTypeId = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName");
            ViewBag.StatusStateId = new SelectList(db.StatusStates, "StatusStateId", "StatusStateName");
            ViewBag.TnTId = new SelectList(db.TnTWorksheet, "TnTId", "TnTDescription");

            // Added for multiple Product Drop-Downs
            ViewBag.Product1 = new SelectList(db.AvProducts, "AvProductId", "ProductName", "Select One");
            ViewBag.Product2 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product3 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product4 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product5 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product6 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product7 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product8 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product9 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product10 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product11 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.Product12 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ddlProduct13 = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.jobID = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.AvProductList = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.AntiVirusProd1 = new SelectList(db.AvProducts, "AvProductId", "TotalComplexity", "Select");

            // ViewBag.ddl_AvProduct1 = new SelectList(db.AvProducts, "AvProductId", "ProductName", sizing.AvProductId);
            ViewBag.ProductData = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.CountriesList = new SelectList(db.AvProducts, "AvproductId", "ProductName");

            // Added for multiple Delivery Center Drop-Downs
            ViewBag.DeliveredFrom1 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom2 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom3 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom4 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom5 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom6 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom7 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom8 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom9 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom10 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom11 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.DeliveredFrom12 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");

            // Added for Band Level Drop usage in Formula to calc FTE
            ViewBag.Bands1 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands2 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands3 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands4 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands5 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands6 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands7 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands8 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands9 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands10 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands11 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");
            ViewBag.Bands12 = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Band3", "16");

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sizing sizing = await db.Sizings.FindAsync(id);
            if (sizing == null)
            {
                return HttpNotFound();
            }
            return View(sizing);
        }

    }
}
