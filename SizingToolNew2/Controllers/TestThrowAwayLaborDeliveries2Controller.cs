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
using EntityState = System.Data.Entity.EntityState;

namespace SizingToolNew2.Controllers
{
    public class TestThrowAwayLaborDeliveries2Controller : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: TestThrowAwayLaborDeliveries2
        public async Task<ActionResult> Index()
        {
            var laborDeliverys = db.LaborDeliverys.Include(l => l.LaborDeliveryType);
            return View(await laborDeliverys.ToListAsync());
        }

        // GET: TestThrowAwayLaborDeliveries2/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaborDelivery laborDelivery = await db.LaborDeliverys.FindAsync(id);
            if (laborDelivery == null)
            {
                return HttpNotFound();
            }
            return View(laborDelivery);
        }

        // GET: TestThrowAwayLaborDeliveries2/Create
        public ActionResult Create()
        {
            ViewBag.LaborDeliveryTypeId = new SelectList(db.LaborDeliveryTypes, "LaborDeliveryTypeId", "DeliveryTypeName");
            return View(new LaborDelivery());
        }

        // POST: TestThrowAwayLaborDeliveries2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LaborDeliveryId,RegionNumber,Regions,DeliveryOption,LaborDeliveryTypeId,CurrencyType,DefaultFTE_Year,WorkWeek,DeliveryCtrCostFactor,Band2,Band2Name,Band2Count,Band2Percentage,Band3,Band3Name,Band3Count,Band3Percentage,Band4,Band4Name,Band4Count,Band4Percentage,Band5,Band5Name,Band5Count,Band5Percentage,Band6,Band6Name,Band6Count,Band6Percentage,Band7,Band7Name,Band7Count,Band7Percentage,Band8,Band8Name,Band8Count,Band8Percentage,Band9,Band9Name,Band9Count,Band9Percentage,Band10,Band10Name,Band10Count,Band10Percentage,BandsTotalCount,DeliveryType,DeliveryUseDescription,MemoDeliveryNote1,DeliveryOwnerFirstName,DeliveryOwnerLastName,DeliveryOwnerFullName,DeliveryOwnerEmail,CreateBy")] LaborDelivery laborDelivery)
        {
            if (ModelState.IsValid)
            {
                db.LaborDeliverys.Add(laborDelivery);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.LaborDeliveryTypeId = new SelectList(db.LaborDeliveryTypes, "LaborDeliveryTypeId", "DeliveryTypeName", laborDelivery.LaborDeliveryTypeId);
            return View(new LaborDelivery());
        }

        // GET: TestThrowAwayLaborDeliveries2/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaborDelivery laborDelivery = await db.LaborDeliverys.FindAsync(id);
            if (laborDelivery == null)
            {
                return HttpNotFound();
            }
            ViewBag.LaborDeliveryTypeId = new SelectList(db.LaborDeliveryTypes, "LaborDeliveryTypeId", "DeliveryTypeName", laborDelivery.LaborDeliveryTypeId);
            return View(laborDelivery);
        }

        // POST: TestThrowAwayLaborDeliveries2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LaborDeliveryId,RegionNumber,Regions,DeliveryOption,LaborDeliveryTypeId,CurrencyType,DefaultFTE_Year,WorkWeek,DeliveryCtrCostFactor,Band2,Band2Name,Band2Count,Band2Percentage,Band3,Band3Name,Band3Count,Band3Percentage,Band4,Band4Name,Band4Count,Band4Percentage,Band5,Band5Name,Band5Count,Band5Percentage,Band6,Band6Name,Band6Count,Band6Percentage,Band7,Band7Name,Band7Count,Band7Percentage,Band8,Band8Name,Band8Count,Band8Percentage,Band9,Band9Name,Band9Count,Band9Percentage,Band10,Band10Name,Band10Count,Band10Percentage,BandsTotalCount,DeliveryType,DeliveryUseDescription,MemoDeliveryNote1,DeliveryOwnerFirstName,DeliveryOwnerLastName,DeliveryOwnerFullName,DeliveryOwnerEmail,CreateBy")] LaborDelivery laborDelivery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(laborDelivery).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.LaborDeliveryTypeId = new SelectList(db.LaborDeliveryTypes, "LaborDeliveryTypeId", "DeliveryTypeName", laborDelivery.LaborDeliveryTypeId);
            return View(laborDelivery);
        }

        // GET: TestThrowAwayLaborDeliveries2/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaborDelivery laborDelivery = await db.LaborDeliverys.FindAsync(id);
            if (laborDelivery == null)
            {
                return HttpNotFound();
            }
            return View(laborDelivery);
        }

        // POST: TestThrowAwayLaborDeliveries2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            LaborDelivery laborDelivery = await db.LaborDeliverys.FindAsync(id);
            db.LaborDeliverys.Remove(laborDelivery);
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
