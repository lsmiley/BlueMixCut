using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SizingToolNew2.Models;
using SizingToolNew2.ViewModels;
using EntityState = System.Data.Entity.EntityState;

namespace SizingToolNew2.Controllers
{
    public class SizingComponent5VMController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: SizngComponent5VM
        public async Task<ActionResult> Index()
        {
            return View(await db.Sizings.ToListAsync());
        }

        // GET: SizngComponent5VM/Create
        public ActionResult Create()
        {
            var sizings = db.Sizings.Include(s => s.AcctCustId).Include(s => s.AvProductId).Include(s => s.ConfigId).Include(s => s.LaborDeliveryId).Include(s => s.SizingTypeId).Include(s => s.StatusStateId).Include(s => s.TnTId);

            ViewBag.AcctCustId = new SelectList(db.AcctCusts, "AcctCustId", "AcctName");
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ConfigId = new SelectList(db.ConfigTables, "ConfigId", "ConfigName");
            ViewBag.LaborDeliveryId = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.SizingTypeId = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName");
            ViewBag.StatusStateId = new SelectList(db.StatusStates, "StatusStateId", "StatusStateName");
            ViewBag.TnTId = new SelectList(db.TnTWorksheet, "TnTId", "TnTDescription");
            return View();
        }

        // POST: SizngComponent5VM/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Prefix = "SizingId,AcctCustId,AvProductId,LaborDeliveryId,SizingTypeId,NumWorkstation,NumServer,NumIpAddress,SalesConnectNum,RFSNum,PrepardedBy,ConfigId,TnTId,StatusStateId,DisplayForSizingID,MemoNote,ValidToDate,Created")] Sizing sizing, [Bind(Prefix = "SizingData,NoteDesc,Note,MemoNote1,MemoNote2,MemoNote3,MemoNote4,MemoNote5,MemoNote6,MemoNote7")] SizingDetail sizingDetail)
        {
            var sizings = db.Sizings.Include(s => s.AcctCustId).Include(s => s.AvProductId).Include(s => s.ConfigId).Include(s => s.LaborDeliveryId).Include(s => s.SizingTypeId).Include(s => s.StatusStateId).Include(s => s.TnTId);

            ViewBag.AcctCustId = new SelectList(db.AcctCusts, "AcctCustId", "AcctName");
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ConfigId = new SelectList(db.ConfigTables, "ConfigId", "ConfigName");
            ViewBag.LaborDeliveryId = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.SizingTypeId = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName");
            ViewBag.StatusStateId = new SelectList(db.StatusStates, "StatusStateId", "StatusStateName");
            ViewBag.TnTId = new SelectList(db.TnTWorksheet, "TnTId", "TnTDescription");


            if (ModelState.IsValid)
            {
                SizingDbContext db = new SizingDbContext();
                List<Sizing> list = db.Sizings.ToList();

                Sizing sze = new Sizing();

                sze.AcctCustId = sizing.AcctCustId;
                sze.AvProductId = sizing.AvProductId;
                sze.LaborDeliveryId = sizing.LaborDeliveryId;
                sze.SizingTypeId = sizing.SizingTypeId;
                sze.NumWorkstation = sizing.NumWorkstation;
                sze.NumServer = sizing.NumServer;
                sze.NumIpAddress = sizing.NumIpAddress;
                sze.SalesConnectNum = sizing.SalesConnectNum;
                sze.RFSNum = sizing.RFSNum;
                sze.PrepardedBy = sizing.PrepardedBy;
                sze.ConfigId = sizing.ConfigId;
                sze.RFSNum = sizing.RFSNum;
                sze.TnTId = sizing.TnTId;
                sze.StatusStateId = sizing.StatusStateId;
                sze.DisplayForSizingID = sizing.DisplayForSizingID;
                sze.MemoNote = sizing.MemoNote;
                sze.Created = sizing.Created;
                sze.ValidToDate = sizing.ValidToDate;

                db.Sizings.Add(sizing);
                await db.SaveChangesAsync();

                int latestSzeId = sze.SizingId;


                SizingDetail sdetail = new SizingDetail();

                sdetail.SizingId = latestSzeId;
                sdetail.SizingData = sizingDetail.SizingData;
                sdetail.NoteDesc = sizingDetail.NoteDesc;
                sdetail.Note = sizingDetail.Note;
                sdetail.MemoNote1 = sizingDetail.MemoNote1;
                sdetail.MemoNote2 = sizingDetail.MemoNote2;
                sdetail.MemoNote3 = sizingDetail.MemoNote3;
                sdetail.MemoNote4 = sizingDetail.MemoNote4;
                sdetail.MemoNote5 = sizingDetail.MemoNote5;
                sdetail.MemoNote6 = sizingDetail.MemoNote6;
                sdetail.MemoNote7 = sizingDetail.MemoNote7;


                db.SizingDetails.Add(sizingDetail);
                await db.SaveChangesAsync();


                return RedirectToAction("Index");
            }

            return View(sizing);
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