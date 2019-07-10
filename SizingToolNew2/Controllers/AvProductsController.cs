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
using System.Web.Security;


namespace SizingToolNew2.Controllers
{
    [Authorize]
    
    public class AvProductsController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        // GET: AvProducts
        public async Task<ActionResult> Index()
        {
            var avProducts = db.AvProducts.Include(a => a.ProdCategory).Include(a => a.ProdVendor);
            return View(await avProducts.ToListAsync());
        }

        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        // GET: AvProducts/Details/5
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

        // GET: AvProducts/Create
       
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        public ActionResult Create()
        {
            ViewBag.ProdCategoryId = new SelectList(db.ProdCategorys, "ProdCategoryId", "CategoryName");
            ViewBag.ProdVendorId = new SelectList(db.ProdVendors, "ProdVendorId", "VendorName");
       
            return View(new AvProduct());
        }

      //  [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        // POST: AvProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AvProductId,ProdVendorId,ProdCategoryId,ProductName,ProductDesc,ProductType,ProductTypeFamily,ProductNote,ProductComplexityBase,ProductComplexityFac,Numcomponent,PrimaryComp,PrimaryCompDesc,PrimaryComplexity,TotalComplexity,MemoProductNote,MemoTechnicalNote,Component1,Component1Desc,ComponentComplexityFac1,MemoComponent1Note,MemoComponent1TechNote,Component2,Component2Desc,ComponentComplexityFac2,MemoComponent2Note,MemoComponent2TechNote,Component3,Component3Desc,ComponentComplexityFac3,MemoComponent3Note,MemoComponent3TechNote,Component4,Component4Desc,ComponentComplexityFac4,MemoComponent4Note,MemoComponent4TechNote,Component5,Component5Desc,ComponentComplexityFac5,MemoComponent5Note,MemoComponent5TechNote,Component6,Component6Desc,ComponentComplexityFac6,MemoComponent6Note,MemoComponent6TechNote,Component7,Component7Desc,ComponentComplexityFac7,MemoComponent7Note,MemoComponent7TechNote,Component8,Component8Desc,ComponentComplexityFac8,MemoComponent8Note,MemoComponent8TechNote,Component9,Component9Desc,ComponentComplexityFac9,MemoComponent9Note,MemoComponent9TechNote,Component10,Component10Desc,ComponentComplexityFac10,MemoComponent10Note,MemoComponent10TechNote,Component11,Component11Desc,ComponentComplexityFac11,MemoComponent11Note,MemoComponent11TechNote,Component12,Component12Desc,ComponentComplexityFac12,Component13,Component13Desc,ComponentComplexityFac13,MemoComponent13Note,MemoComponent13TechNote,Component14,Component14Desc,ComponentComplexityFac14,MemoComponent14Note,MemoComponent14TechNote,Component15,Component15Desc,ComponentComplexityFac15,MemoComponent15Note,MemoComponent15TechNote,NumComponents")] AvProduct avProduct)
        {
            if (ModelState.IsValid)
            {
                db.AvProducts.Add(avProduct);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ProdCategoryId = new SelectList(db.ProdCategorys, "ProdCategoryId", "CategoryName", avProduct.ProdCategoryId);
            ViewBag.ProdVendorId = new SelectList(db.ProdVendors, "ProdVendorId", "VendorName", avProduct.ProdVendorId);
         
            return View(new AvProduct());
        }
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        // GET: AvProducts/Edit/5
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


        // POST: AvProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AvProductId,ProdVendorId,ProdCategoryId,ProductName,ProductDesc,ProductType,ProductTypeFamily,ProductNote,ProductComplexityBase,ProductComplexityFac,Numcomponent,PrimaryComp,PrimaryCompDesc,PrimaryComplexity,TotalComplexity,MemoProductNote,MemoTechnicalNote,Component1,Component1Desc,ComponentComplexityFac1,MemoComponent1Note,MemoComponent1TechNote,Component2,Component2Desc,ComponentComplexityFac2,MemoComponent2Note,MemoComponent2TechNote,Component3,Component3Desc,ComponentComplexityFac3,MemoComponent3Note,MemoComponent3TechNote,Component4,Component4Desc,ComponentComplexityFac4,MemoComponent4Note,MemoComponent4TechNote,Component5,Component5Desc,ComponentComplexityFac5,MemoComponent5Note,MemoComponent5TechNote,Component6,Component6Desc,ComponentComplexityFac6,MemoComponent6Note,MemoComponent6TechNote,Component7,Component7Desc,ComponentComplexityFac7,MemoComponent7Note,MemoComponent7TechNote,Component8,Component8Desc,ComponentComplexityFac8,MemoComponent8Note,MemoComponent8TechNote,Component9,Component9Desc,ComponentComplexityFac9,MemoComponent9Note,MemoComponent9TechNote,Component10,Component10Desc,ComponentComplexityFac10,MemoComponent10Note,MemoComponent10TechNote,Component11,Component11Desc,ComponentComplexityFac11,MemoComponent11Note,MemoComponent11TechNote,Component12,Component12Desc,ComponentComplexityFac12,Component13,Component13Desc,ComponentComplexityFac13,MemoComponent13Note,MemoComponent13TechNote,Component14,Component14Desc,ComponentComplexityFac14,MemoComponent14Note,MemoComponent14TechNote,Component15,Component15Desc,ComponentComplexityFac15,MemoComponent15Note,MemoComponent15TechNote,NumComponents")] AvProduct avProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(avProduct).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ProdCategoryId = new SelectList(db.ProdCategorys, "ProdCategoryId", "CategoryName", avProduct.ProdCategoryId);
            ViewBag.ProdVendorId = new SelectList(db.ProdVendors, "ProdVendorId", "VendorName", avProduct.ProdVendorId);
          
            return View(avProduct);
        }

        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
        // GET: AvProducts/Delete/5
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

        
        // POST: AvProducts/Delete/5
        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect")]
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

        ////[ValidateInput(false)]
        ////[HttpPost]
        //[ValidateAntiForgeryToken]
        //[HttpPost, ValidateInput(false)]
        //public ActionResult SubmitMemo(AvProduct model)
        //{
        //    ViewBag.Text = model.MemoProductNote;
        //    return View();
        //}


        [AuthLog(Roles = "Administrator, Solution Manager, Solution Architect, Sizer, Viewer")]
        // GET: AvProducts
        public ActionResult ComplexityCalc3()
        {
            var avProducts = db.AvProducts.Include(a => a.ProdCategory).Include(a => a.ProdVendor);
            return View();
        }
    }
}
