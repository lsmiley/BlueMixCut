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
    public class TestAvProducts1Controller : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: TestAvProducts1
        public async Task<ActionResult> Index()
        {
            var avProducts = db.AvProducts.Include(a => a.ProdCategory).Include(a => a.ProdVendor);
            return View(await avProducts.ToListAsync());
        }

        // GET: TestAvProducts1/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AvProduct avProduct = await db.AvProducts.FindAsync(id);
            if (avProduct == null)
            {
                return HttpNotFound();
            }
            return View(avProduct);
        }

        // GET: TestAvProducts1/Create
        public ActionResult Create()
        {
            ViewBag.ProdCategoryId = new SelectList(db.ProdCategorys, "ProdCategoryId", "CategoryName");
            ViewBag.ProdVendorId = new SelectList(db.ProdVendors, "ProdVendorId", "VendorName");
           
            return View();
        }

        // POST: TestAvProducts1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AvProductId,ProdVendorId,ProdCategoryId,ProdTypeId,SupportTypeId,ProductName,ProductDesc,ProductType,ProductTypeFamily,ProductNote,ProductComplexityBase,ProductComplexityFac,Numcomponent,PrimaryComp,PrimaryCompDesc,PrimaryComplexity,TotalComplexity,Component1,Component1Desc,ComponentComplexityFac1,Component2,Component2Desc,ComponentComplexityFac2,Component3,Component3Desc,ComponentComplexityFac3,Component4,Component4Desc,ComponentComplexityFac4,Component5,Component5Desc,ComponentComplexityFac5,Component6,Component6Desc,ComponentComplexityFac6,Component7,Component7Desc,ComponentComplexityFac7,Component8,Component8Desc,ComponentComplexityFac8,Component9,Component9Desc,ComponentComplexityFac9,Component10,Component10Desc,ComponentComplexityFac10,Component11,Component11Desc,ComponentComplexityFac11,Component12,Component12Desc,ComponentComplexityFac12,Component13,Component13Desc,ComponentComplexityFac13,Component14,Component14Desc,ComponentComplexityFac14,Component15,Component15Desc,ComponentComplexityFac15,NumComponents")] AvProduct avProduct)
        {
            if (ModelState.IsValid)
            {
                db.AvProducts.Add(avProduct);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ProdCategoryId = new SelectList(db.ProdCategorys, "ProdCategoryId", "CategoryName", avProduct.ProdCategoryId);
            ViewBag.ProdVendorId = new SelectList(db.ProdVendors, "ProdVendorId", "VendorName", avProduct.ProdVendorId);
            
            return View(avProduct);
        }

        // GET: TestAvProducts1/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AvProduct avProduct = await db.AvProducts.FindAsync(id);
            if (avProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProdCategoryId = new SelectList(db.ProdCategorys, "ProdCategoryId", "CategoryName", avProduct.ProdCategoryId);
            ViewBag.ProdVendorId = new SelectList(db.ProdVendors, "ProdVendorId", "VendorName", avProduct.ProdVendorId);
       
            return View(avProduct);
        }

        // POST: TestAvProducts1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AvProductId,ProdVendorId,ProdCategoryId,ProdTypeId,SupportTypeId,ProductName,ProductDesc,ProductType,ProductTypeFamily,ProductNote,ProductComplexityBase,ProductComplexityFac,Numcomponent,PrimaryComp,PrimaryCompDesc,PrimaryComplexity,TotalComplexity,Component1,Component1Desc,ComponentComplexityFac1,Component2,Component2Desc,ComponentComplexityFac2,Component3,Component3Desc,ComponentComplexityFac3,Component4,Component4Desc,ComponentComplexityFac4,Component5,Component5Desc,ComponentComplexityFac5,Component6,Component6Desc,ComponentComplexityFac6,Component7,Component7Desc,ComponentComplexityFac7,Component8,Component8Desc,ComponentComplexityFac8,Component9,Component9Desc,ComponentComplexityFac9,Component10,Component10Desc,ComponentComplexityFac10,Component11,Component11Desc,ComponentComplexityFac11,Component12,Component12Desc,ComponentComplexityFac12,Component13,Component13Desc,ComponentComplexityFac13,Component14,Component14Desc,ComponentComplexityFac14,Component15,Component15Desc,ComponentComplexityFac15,NumComponents")] AvProduct avProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(avProduct).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ProdCategoryId = new SelectList(db.ProdCategorys, "ProdCategoryId", "CategoryName", avProduct.ProdCategoryId);
            ViewBag.ProdVendorId = new SelectList(db.ProdVendors, "ProdVendorId", "VendorName", avProduct.ProdVendorId);
            return View(avProduct);
        }

        // GET: TestAvProducts1/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AvProduct avProduct = await db.AvProducts.FindAsync(id);
            if (avProduct == null)
            {
                return HttpNotFound();
            }
            return View(avProduct);
        }

        // POST: TestAvProducts1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            AvProduct avProduct = await db.AvProducts.FindAsync(id);
            db.AvProducts.Remove(avProduct);
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

        public ActionResult ExitWithoutSaving()
        {
            return RedirectToAction("Index");
        }
    }
}
