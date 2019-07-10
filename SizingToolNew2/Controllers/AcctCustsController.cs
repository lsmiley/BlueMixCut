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
    public class AcctCustsController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: AcctCusts
        public async Task<ActionResult> Index()
        {
            return View(await db.AcctCusts.ToListAsync());
        }

        // GET: AcctCusts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcctCust acctCust = await db.AcctCusts.FindAsync(id);
            if (acctCust == null)
            {
                return HttpNotFound();
            }
            return View(acctCust);
        }

        // GET: AcctCusts/Create
        public ActionResult Create()
        {
            return View(new AcctCust());
        }

        // POST: AcctCusts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AcctCustId,AcctName,BusinessSec,Regulatory,Created,Address1,Address2,City,State,Country,Contact1Name,Contact1Phone,Contact1Email,Contact2Name,Contact2Phone,Contact2Email,WebURL,CreatedBy,ModifyDate")] AcctCust acctCust)
        {
            if (ModelState.IsValid)
            {
                db.AcctCusts.Add(acctCust);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(new AcctCust());
        }

        // GET: AcctCusts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcctCust acctCust = await db.AcctCusts.FindAsync(id);
            if (acctCust == null)
            {
                return HttpNotFound();
            }
            return View(acctCust);
        }

        // POST: AcctCusts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AcctCustId,AcctName,BusinessSec,Regulatory,Created,Address1,Address2,City,State,Country,Contact1Name,Contact1Phone,Contact1Email,Contact2Name,Contact2Phone,Contact2Email,WebURL,CreatedBy,ModifyDate")] AcctCust acctCust)
        {
            if (ModelState.IsValid)
            {
                db.Entry(acctCust).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(acctCust);
        }

        // GET: AcctCusts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcctCust acctCust = await db.AcctCusts.FindAsync(id);
            if (acctCust == null)
            {
                return HttpNotFound();
            }
            return View(acctCust);
        }

        // POST: AcctCusts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            AcctCust acctCust = await db.AcctCusts.FindAsync(id);
            db.AcctCusts.Remove(acctCust);
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
