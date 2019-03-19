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
    public class ConfigMastersController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: ConfigMasters
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public async Task<ActionResult> Index()
        {
            return View(await db.ConfigMasters.ToListAsync());
        }

        // GET: ConfigMasters/Details/5
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigMaster configMaster = await db.ConfigMasters.FindAsync(id);
            if (configMaster == null)
            {
                return HttpNotFound();
            }
            return View(configMaster);
        }

        // GET: ConfigMasters/Create
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfigMasters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public async Task<ActionResult> Create([Bind(Include = "ConfigMasterId,Created,ConfigMasterModifyDate,ConfigMasterName,ConfigMasterDesc,ConfigMasterNotes")] ConfigMaster configMaster)
        {
            if (ModelState.IsValid)
            {
                db.ConfigMasters.Add(configMaster);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(configMaster);
        }

        // GET: ConfigMasters/Edit/5
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigMaster configMaster = await db.ConfigMasters.FindAsync(id);
            if (configMaster == null)
            {
                return HttpNotFound();
            }
            return View(configMaster);
        }

        // POST: ConfigMasters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator, Solution Manager")]

        public async Task<ActionResult> Edit([Bind(Include = "ConfigMasterId,Created,ConfigMasterModifyDate,ConfigMasterName,ConfigMasterDesc,ConfigMasterNotes")] ConfigMaster configMaster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(configMaster).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(configMaster);
        }

        // GET: ConfigMasters/Delete/5
        [AuthLog(Roles = "Administrator")]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigMaster configMaster = await db.ConfigMasters.FindAsync(id);
            if (configMaster == null)
            {
                return HttpNotFound();
            }
            return View(configMaster);
        }

        // POST: ConfigMasters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator")]

        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ConfigMaster configMaster = await db.ConfigMasters.FindAsync(id);
            db.ConfigMasters.Remove(configMaster);
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
