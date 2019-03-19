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
    [Authorize]
    public class LaborDeliveriesController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: LaborDeliveries
        public async Task<ActionResult> Index()
        {
            return View(await db.LaborDeliverys.ToListAsync());
        }

        // GET: LaborDeliveries/Details/5
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

        // GET: LaborDeliveries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LaborDeliveries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LaborDeliveryId,RegionNumber,Regions,DeliveryOption,CurrencyType,DefaultFTE_Year,WorkWeek,DeliveryCtrCostFactor,Band2,Band2Name,Band2Count,Band2Percentage,Band3,Band3Name,Band3Count,Band3Percentage,Band4,Band4Name,Band4Count,Band4Percentage,Band5,Band5Name,Band5Count,Band5Percentage,Band6,Band6Name,Band6Count,Band6Percentage,Band7,Band7Name,Band7Count,Band7Percentage,Band8,Band8Name,Band8Count,Band8Percentage,Band9,Band9Name,Band9Count,Band9Percentage,Band10,Band10Name,Band10Count,Band10Percentage,BandsTotalCount")] LaborDelivery laborDelivery)
        {
            if (ModelState.IsValid)
            {
                db.LaborDeliverys.Add(laborDelivery);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(laborDelivery);
        }

        // GET: LaborDeliveries/Edit/5
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
            return View(laborDelivery);
        }

        // POST: LaborDeliveries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LaborDeliveryId,RegionNumber,Regions,DeliveryOption,CurrencyType,DefaultFTE_Year,WorkWeek,DeliveryCtrCostFactor,Band2,Band2Name,Band2Count,Band2Percentage,Band3,Band3Name,Band3Count,Band3Percentage,Band4,Band4Name,Band4Count,Band4Percentage,Band5,Band5Name,Band5Count,Band5Percentage,Band6,Band6Name,Band6Count,Band6Percentage,Band7,Band7Name,Band7Count,Band7Percentage,Band8,Band8Name,Band8Count,Band8Percentage,Band9,Band9Name,Band9Count,Band9Percentage,Band10,Band10Name,Band10Count,Band10Percentage,BandsTotalCount")] LaborDelivery laborDelivery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(laborDelivery).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(laborDelivery);
        }

        // GET: LaborDeliveries/Delete/5
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

        // POST: LaborDeliveries/Delete/5
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
