using SizingToolNew2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SizingToolNew2.Controllers
{
    public class SizingComponentViewModelController : Controller

    {
        SizingDbContext db = new SizingDbContext();

        // GET: SizingComponentViewModel
        //  public ActionResult Create()
        public ActionResult Create()
        {
          //  List<Sizing> list = db.Sizings.ToList();
            var sizings = db.SizingComponentViewModels.Include(s => s.AcctCustId).Include(s => s.AvProductId).Include(s => s.ConfigId).Include(s => s.LaborDeliveryId).Include(s => s.SizingTypeId).Include(s => s.StatusStateId).Include(s => s.TnTId);

            ViewBag.AcctCustId = new SelectList(db.AcctCusts, "AcctCustId", "AcctName");
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            ViewBag.ConfigId = new SelectList(db.ConfigTables, "ConfigId", "ConfigName");
            ViewBag.LaborDeliveryId = new SelectList(db.LaborDeliverys, "LaborDeliveryId", "Regions");
            ViewBag.SizingTypeId = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName");
            ViewBag.StatusStateId = new SelectList(db.StatusStates, "StatusStateId", "StatusStateName");
            ViewBag.TnTId = new SelectList(db.TnTWorksheet, "TnTId", "TnTDescription");

          return View();

         //   return View(await sizings.ToListAsync());
        }

        [HttpPost]
        public ActionResult Create(SizingComponentViewModel model)
        {
            try
            {
                SizingDbContext db = new SizingDbContext();

                List<Sizing> list = db.Sizings.ToList();

                Sizing sze = new Sizing();
                sze.AcctCustId = model.AcctCustId;
                sze.AvProductId = model.AvProductId;
                sze.LaborDeliveryId = model.LaborDeliveryId;
                sze.SizingTypeId = model.SizingTypeId;
                sze.NumWorkstation = model.NumWorkstation;
                sze.NumServer = model.NumServer;
                sze.NumIpAddress = model.NumIpAddress;
                sze.SalesConnectNum = model.SalesConnectNum;
                sze.RFSNum = model.RFSNum;
                sze.PrepardedBy = model.PrepardedBy;
                sze.ConfigId = model.ConfigId;
                sze.RFSNum = model.RFSNum;
                sze.TnTId = model.TnTId;
                sze.StatusStateId = model.StatusStateId;
                sze.DisplayForSizingID = model.DisplayForSizingID;
                sze.MemoNote = model.MemoNote;
                sze.Created = model.Created;
                sze.ValidToDate = model.ValidToDate;

                db.Sizings.Add(sze);
                db.SaveChanges();

                int latestSzeId = sze.SizingId;
         


                SizingDetail sizingdetail = new SizingDetail();
                sizingdetail.SizingData = model.SizingData;
                sizingdetail.SizingId = latestSzeId;


                db.SizingDetails.Add(sizingdetail);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return View(model);
        }


    }
}