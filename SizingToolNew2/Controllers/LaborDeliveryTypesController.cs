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
    public class LaborDeliveryTypesController : Controller
    {
        private SizingDbContext db = new SizingDbContext();
        private Dictionary<string, string> GetTypeFromDB()
        {
            return new Dictionary<string, string>
    {
        {"AK", "Alaska"},
        {"AL", "Alabama"},
        {"AR", "Arkansas"},
        {"AZ", "Arizona"},
        {"StdGeoDelivery", "Std. GEO Delivery"},
        {"Share/Hosted-Cloud-Support ", "Shared Hosting for 24 Cloud-Support "},
        {"Dedicated-Support", "Dedicated Off/Onsite Support"},
        {"Project/RFS/NBD", "Project-Request for Services / NBD"},
        {"Custom", "CustomGeo/Single Use"},
        // some lines skipped
    };

        }

        // GET: LaborDeliveryTypes
        public async Task<ActionResult> Index()
        {
            return View(await db.LaborDeliveryTypes.ToListAsync());
        }

        // GET: LaborDeliveryTypes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaborDeliveryType laborDeliveryType = await db.LaborDeliveryTypes.FindAsync(id);
            if (laborDeliveryType == null)
            {
                return HttpNotFound();
            }
            return View(laborDeliveryType);
        }

        // GET: LaborDeliveryTypes/Create
        public ActionResult Create()
        {
            

            return View();
        }

        // POST: LaborDeliveryTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LaborDeliveryTypeId,DeliveryUseDescription,DeliveryTypeName,MemoDeliveryNote1,DeliveryOwnerFirstName,DeliveryOwnerLastName,DeliveryOwnerFullName,DeliveryOwnerEmail,CreateBy")] LaborDeliveryType laborDeliveryType)
        {

            if (ModelState.IsValid)
            {
                db.LaborDeliveryTypes.Add(laborDeliveryType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

           


            return View(laborDeliveryType);
        }

        // GET: LaborDeliveryTypes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaborDeliveryType laborDeliveryType = await db.LaborDeliveryTypes.FindAsync(id);
            if (laborDeliveryType == null)
            {
                return HttpNotFound();
            }
            return View(laborDeliveryType);
        }

        // POST: LaborDeliveryTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LaborDeliveryTypeId,DeliveryUseDescription,DeliveryTypeName,MemoDeliveryNote1,DeliveryOwnerFirstName,DeliveryOwnerLastName,DeliveryOwnerFullName,DeliveryOwnerEmail,CreateBy")] LaborDeliveryType laborDeliveryType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(laborDeliveryType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(laborDeliveryType);
        }

        // GET: LaborDeliveryTypes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaborDeliveryType laborDeliveryType = await db.LaborDeliveryTypes.FindAsync(id);
            if (laborDeliveryType == null)
            {
                return HttpNotFound();
            }
            return View(laborDeliveryType);
        }

        // POST: LaborDeliveryTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            LaborDeliveryType laborDeliveryType = await db.LaborDeliveryTypes.FindAsync(id);
            db.LaborDeliveryTypes.Remove(laborDeliveryType);
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
