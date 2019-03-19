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
    public class AvProdComponentsController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: AvProdComponents
        public async Task<ActionResult> Index()
        {
            var avProdComponents = db.AvProdComponents.Include(a => a.AvProducts);
            return View(await avProdComponents.ToListAsync());
        }

        // GET: AvProdComponents/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AvProdComponent avProdComponent = await db.AvProdComponents.FindAsync(id);
            if (avProdComponent == null)
            {
                return HttpNotFound();
            }
            return View(avProdComponent);
        }

        // GET: AvProdComponents/Create
        public ActionResult Create()
        {
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName");
            return View();
        }

        // POST: AvProdComponents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AvProdComponentId,SizingtId,AvProductId,ProductName,ComponentDesc,ComponentType,ComponentTypeFamily,ComponentNote,ComponentComplexityBase,ComponentComplexityFac,CreatedBy,CreteDate,ModifyDate")] AvProdComponent avProdComponent)
        {
            if (ModelState.IsValid)
            {
                db.AvProdComponents.Add(avProdComponent);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName", avProdComponent.AvProductId);
            return View(avProdComponent);
        }

        // GET: AvProdComponents/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AvProdComponent avProdComponent = await db.AvProdComponents.FindAsync(id);
            if (avProdComponent == null)
            {
                return HttpNotFound();
            }
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName", avProdComponent.AvProductId);
            return View(avProdComponent);
        }

        // POST: AvProdComponents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AvProdComponentId,SizingtId,AvProductId,ProductName,ComponentDesc,ComponentType,ComponentTypeFamily,ComponentNote,ComponentComplexityBase,ComponentComplexityFac,CreatedBy,CreteDate,ModifyDate")] AvProdComponent avProdComponent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(avProdComponent).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.AvProductId = new SelectList(db.AvProducts, "AvProductId", "ProductName", avProdComponent.AvProductId);
            return View(avProdComponent);
        }

        // GET: AvProdComponents/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AvProdComponent avProdComponent = await db.AvProdComponents.FindAsync(id);
            if (avProdComponent == null)
            {
                return HttpNotFound();
            }
            return View(avProdComponent);
        }

        // POST: AvProdComponents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            AvProdComponent avProdComponent = await db.AvProdComponents.FindAsync(id);
            db.AvProdComponents.Remove(avProdComponent);
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
