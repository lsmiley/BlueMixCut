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

    public class SizingTypesController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: SizingTypes
        public async Task<ActionResult> Index()
        {
            return View(await db.SizingTypes.ToListAsync());
        }

        // GET: SizingTypes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SizingType sizingType = await db.SizingTypes.FindAsync(id);
            if (sizingType == null)
            {
                return HttpNotFound();
            }
            return View(sizingType);
        }

        // GET: SizingTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SizingTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SizingTypeId,SizingId,SizingTypeName,SizingTypeDescription,SizingTypeNote,SizingPrimaryProduct,SizingSecondProduct,SizingThirdProduct,SizingForthProduct,SizingPrimaryService,SizingSecondService,SizingThirdService,SizingForthService")] SizingType sizingType)
        {
            if (ModelState.IsValid)
            {
                db.SizingTypes.Add(sizingType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sizingType);
        }

        // GET: SizingTypes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SizingType sizingType = await db.SizingTypes.FindAsync(id);
            if (sizingType == null)
            {
                return HttpNotFound();
            }
            return View(sizingType);
        }

        // POST: SizingTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SizingTypeId,SizingId,SizingTypeName,SizingTypeDescription,SizingTypeNote,SizingPrimaryProduct,SizingSecondProduct,SizingThirdProduct,SizingForthProduct,SizingPrimaryService,SizingSecondService,SizingThirdService,SizingForthService")] SizingType sizingType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sizingType).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sizingType);
        }

        // GET: SizingTypes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SizingType sizingType = await db.SizingTypes.FindAsync(id);
            if (sizingType == null)
            {
                return HttpNotFound();
            }
            return View(sizingType);
        }

        // POST: SizingTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SizingType sizingType = await db.SizingTypes.FindAsync(id);
            db.SizingTypes.Remove(sizingType);
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
