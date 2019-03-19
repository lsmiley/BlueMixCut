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

    public class SecurityServicesController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: SecurityServices
        public async Task<ActionResult> Index()
        {
            return View(await db.SecurityServices.ToListAsync());
        }

        // GET: SecurityServices/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecurityService securityService = await db.SecurityServices.FindAsync(id);
            if (securityService == null)
            {
                return HttpNotFound();
            }
            return View(securityService);
        }

        // GET: SecurityServices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecurityServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SecurityServiceId,ServiceName,ServiceDesc,AvProductId,ServiceRelatedProduct,ServiceDeliveryMethod,ServiceFrequency,ServiceComplexity,ServiceFTE")] SecurityService securityService)
        {
            if (ModelState.IsValid)
            {
                db.SecurityServices.Add(securityService);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(securityService);
        }

        // GET: SecurityServices/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecurityService securityService = await db.SecurityServices.FindAsync(id);
            if (securityService == null)
            {
                return HttpNotFound();
            }
            return View(securityService);
        }

        // POST: SecurityServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SecurityServiceId,ServiceName,ServiceDesc,AvProductId,ServiceRelatedProduct,ServiceDeliveryMethod,ServiceFrequency,ServiceComplexity,ServiceFTE")] SecurityService securityService)
        {
            if (ModelState.IsValid)
            {
                db.Entry(securityService).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(securityService);
        }

        // GET: SecurityServices/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecurityService securityService = await db.SecurityServices.FindAsync(id);
            if (securityService == null)
            {
                return HttpNotFound();
            }
            return View(securityService);
        }

        // POST: SecurityServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SecurityService securityService = await db.SecurityServices.FindAsync(id);
            db.SecurityServices.Remove(securityService);
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
