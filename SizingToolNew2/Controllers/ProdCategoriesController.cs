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

    public class ProdCategoriesController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: ProdCategories
        public async Task<ActionResult> Index()
        {
            return View(await db.ProdCategorys.ToListAsync());
        }

        // GET: ProdCategories/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdCategory prodCategory = await db.ProdCategorys.FindAsync(id);
            if (prodCategory == null)
            {
                return HttpNotFound();
            }
            return View(prodCategory);
        }

        // GET: ProdCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProdCategoryId,SizingId,CategoryName,CategoryNote")] ProdCategory prodCategory)
        {
            if (ModelState.IsValid)
            {
                db.ProdCategorys.Add(prodCategory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(prodCategory);
        }

        // GET: ProdCategories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdCategory prodCategory = await db.ProdCategorys.FindAsync(id);
            if (prodCategory == null)
            {
                return HttpNotFound();
            }
            return View(prodCategory);
        }

        // POST: ProdCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProdCategoryId,SizingId,CategoryName,CategoryNote")] ProdCategory prodCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prodCategory).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(prodCategory);
        }

        // GET: ProdCategories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdCategory prodCategory = await db.ProdCategorys.FindAsync(id);
            if (prodCategory == null)
            {
                return HttpNotFound();
            }
            return View(prodCategory);
        }

        // POST: ProdCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ProdCategory prodCategory = await db.ProdCategorys.FindAsync(id);
            db.ProdCategorys.Remove(prodCategory);
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
