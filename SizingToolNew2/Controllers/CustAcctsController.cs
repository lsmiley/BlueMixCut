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
    public class CustAcctsController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: CustAccts
        public async Task<ActionResult> Index()
        {
            return View(await db.CustAccts.ToListAsync());
        }

        // GET: CustAccts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustAcct custAcct = await db.CustAccts.FindAsync(id);
            if (custAcct == null)
            {
                return HttpNotFound();
            }
            return View(custAcct);
        }

        // GET: CustAccts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustAccts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CustAcctId,CustAcctName,CustAcctCodeName,SectorType,Address1,Address2,City,State,Zip,Country,Phone,Fax,Web,Contact1,Contact1Phone,Contact1Email,Contact2,Contact2Phone,Contact2Email,VendorNumProd,VendorNote")] CustAcct custAcct)
        {
            if (ModelState.IsValid)
            {
                db.CustAccts.Add(custAcct);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(custAcct);
        }

        // GET: CustAccts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustAcct custAcct = await db.CustAccts.FindAsync(id);
            if (custAcct == null)
            {
                return HttpNotFound();
            }
            return View(custAcct);
        }

        // POST: CustAccts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CustAcctId,CustAcctName,CustAcctCodeName,SectorType,Address1,Address2,City,State,Zip,Country,Phone,Fax,Web,Contact1,Contact1Phone,Contact1Email,Contact2,Contact2Phone,Contact2Email,VendorNumProd,VendorNote")] CustAcct custAcct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(custAcct).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(custAcct);
        }

        // GET: CustAccts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustAcct custAcct = await db.CustAccts.FindAsync(id);
            if (custAcct == null)
            {
                return HttpNotFound();
            }
            return View(custAcct);
        }

        // POST: CustAccts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CustAcct custAcct = await db.CustAccts.FindAsync(id);
            db.CustAccts.Remove(custAcct);
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
