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
using SizingToolNew2.CustomFilters;

namespace SizingToolNew2.Controllers
{
    [Authorize]

    public class ProdVendorsController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: ProdVendors
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public async Task<ActionResult> Index()
        {
            return View(await db.ProdVendors.ToListAsync());
        }

        // GET: ProdVendors/Details/5
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdVendor prodVendor = await db.ProdVendors.FindAsync(id);
            if (prodVendor == null)
            {
                return HttpNotFound();
            }
            return View(prodVendor);
        }

        // GET: ProdVendors/Create
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdVendors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        public async Task<ActionResult> Create([Bind(Include = "ProdVendorId,VendorName,VendorCodeName,VendorCategory,NumVendorProducts,VendorNote,VendorWebURL,Contact1Name,Contact1Phone,Contact1Email,Contact2Name,Contact2Phone,Contact2Email,ContractNum")] ProdVendor prodVendor)
        {
            if (ModelState.IsValid)
            {
                db.ProdVendors.Add(prodVendor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(prodVendor);
        }

        // GET: ProdVendors/Edit/5
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdVendor prodVendor = await db.ProdVendors.FindAsync(id);
            if (prodVendor == null)
            {
                return HttpNotFound();
            }
            return View(prodVendor);
        }

        // POST: ProdVendors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        public async Task<ActionResult> Edit([Bind(Include = "ProdVendorId,VendorName,VendorCodeName,VendorCategory,NumVendorProducts,VendorNote,VendorWebURL,Contact1Name,Contact1Phone,Contact1Email,Contact2Name,Contact2Phone,Contact2Email,ContractNum")] ProdVendor prodVendor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prodVendor).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(prodVendor);
        }

        // GET: ProdVendors/Delete/5
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProdVendor prodVendor = await db.ProdVendors.FindAsync(id);
            if (prodVendor == null)
            {
                return HttpNotFound();
            }
            return View(prodVendor);
        }

        // POST: ProdVendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ProdVendor prodVendor = await db.ProdVendors.FindAsync(id);
            db.ProdVendors.Remove(prodVendor);
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
