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

    public class StatusStatesController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: StatusStates
        public async Task<ActionResult> Index()
        {
            return View(await db.StatusStates.ToListAsync());
        }

        // GET: StatusStates/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusState statusState = await db.StatusStates.FindAsync(id);
            if (statusState == null)
            {
                return HttpNotFound();
            }
            return View(statusState);
        }

        // GET: StatusStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatusStates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StatusStateId,StatusStateName,StatusStateDesc,StatusStateType,Memo")] StatusState statusState)
        {
            if (ModelState.IsValid)
            {
                db.StatusStates.Add(statusState);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(statusState);
        }

        // GET: StatusStates/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusState statusState = await db.StatusStates.FindAsync(id);
            if (statusState == null)
            {
                return HttpNotFound();
            }
            return View(statusState);
        }

        // POST: StatusStates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "StatusStateId,StatusStateName,StatusStateDesc,StatusStateType,Memo")] StatusState statusState)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statusState).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(statusState);
        }

        // GET: StatusStates/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatusState statusState = await db.StatusStates.FindAsync(id);
            if (statusState == null)
            {
                return HttpNotFound();
            }
            return View(statusState);
        }

        // POST: StatusStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            StatusState statusState = await db.StatusStates.FindAsync(id);
            db.StatusStates.Remove(statusState);
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
