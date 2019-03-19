using SizingToolNew2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SizingToolNew2.Controllers
{
    public class SizingComponentVMController : Controller
    {
        // GET: SizingComponentVM
        public ActionResult Index()
        {
          
            SizingDbContext db = new SizingDbContext();

        List<Sizing> list = db.Sizings.ToList();
            ViewBag.SizingList = new SelectList(list, "SizingId", "SizingId");

            return View();
        }

        [HttpPost]
        public ActionResult Create(SizingComponentViewModel model)
        {
            try
            {

                SizingDbContext db = new SizingDbContext();

                List<Sizing> list = db.Sizings.ToList();
                ViewBag.DepartmentList = new SelectList(list, "SizingId", "SizingId");

                Sizing sze = new Sizing();
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


                SizingDetail szedetail = new SizingDetail();
                szedetail.SizingData = model.SizingData;
                szedetail.SizingId = latestSzeId;
           

                db.SizingDetails.Add(szedetail);
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