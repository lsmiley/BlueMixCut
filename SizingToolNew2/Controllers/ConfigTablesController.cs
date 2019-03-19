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
    public class ConfigTablesController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: ConfigTables
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public async Task<ActionResult> Index()
        {
            var configTables = db.ConfigTables.Include(c => c.ConfigMaster);
            return View(await configTables.ToListAsync());
        }

        // GET: ConfigTables/Details/5
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigTable configTable = await db.ConfigTables.FindAsync(id);
            if (configTable == null)
            {
                return HttpNotFound();
            }
            return View(configTable);
        }

        // GET: ConfigTables/Create
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public ActionResult Create()
        {
            ViewBag.ConfigMasterId = new SelectList(db.ConfigMasters, "ConfigMasterId", "ConfigMasterName");
            return View(new ConfigTable());
        }

        // POST: ConfigTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public async Task<ActionResult> Create([Bind(Include = "ConfigId,ConfigMasterId,ConfigCreateDate,ConfigModifyDate,ConfigName,ConfigDesc,ConfigType,ConfigNotes,ConfigNummber,ConfigText,ConfigLink,SizeModifier,VendorModifier,HoursModifier,ManagementModifier1stLine,ManagementModifier2ndLine,RiskFactor_Low,RiskFactor_Med,RiskFactor_High,OtherCost_Education,OtherCost_Travel,OtherCost_Equipment,EndpointRangeModifier1,EndpointRangeModifier2,EndpointRangeModifier3,EndpointRangeModifier4,EndpointRangeModifier5,EndpointRangeModifier6,Rpt_BiWeeklyModifier,Rpt_WeeklyModifier,Rpt_DailyModifier,Rpt_CustomModifier,DefaultEndpointFac,Fac_FracHrs,Fac_AdjWkstn,Fac_AdjSvrs,Fac_AdjIPs,Fac_SvrCalc,Frm_ComponentFac1,Frm_ComponentFac2,Frm_ComponentFac3,Frm_ComponentFac4,Frm_ComponentFac5,Frm_ComponentFac6,Frm_ComponentFac7,Frm_ComponentFac8,Frm_ComponentFac9,Frm_ComponentFac10,Frm_ComponentFac11,Frm_ComponentFac12")] ConfigTable configTable)
        {
            if (ModelState.IsValid)
            {
                db.ConfigTables.Add(configTable);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ConfigMasterId = new SelectList(db.ConfigMasters, "ConfigMasterId", "ConfigMasterName", configTable.ConfigMasterId);
            return View(configTable);
        }

        // GET: ConfigTables/Edit/5
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigTable configTable = await db.ConfigTables.FindAsync(id);
            if (configTable == null)
            {
                return HttpNotFound();
            }
            ViewBag.ConfigMasterId = new SelectList(db.ConfigMasters, "ConfigMasterId", "ConfigMasterName", configTable.ConfigMasterId);
            return View(configTable);
        }

        // POST: ConfigTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator, Solution Manager")]
        public async Task<ActionResult> Edit([Bind(Include = "ConfigId,ConfigMasterId,ConfigCreateDate,ConfigModifyDate,ConfigName,ConfigDesc,ConfigType,ConfigNotes,ConfigNummber,ConfigText,ConfigLink,SizeModifier,VendorModifier,HoursModifier,ManagementModifier1stLine,ManagementModifier2ndLine,RiskFactor_Low,RiskFactor_Med,RiskFactor_High,OtherCost_Education,OtherCost_Travel,OtherCost_Equipment,EndpointRangeModifier1,EndpointRangeModifier2,EndpointRangeModifier3,EndpointRangeModifier4,EndpointRangeModifier5,EndpointRangeModifier6,Rpt_BiWeeklyModifier,Rpt_WeeklyModifier,Rpt_DailyModifier,Rpt_CustomModifier,DefaultEndpointFac,Fac_FracHrs,Fac_AdjWkstn,Fac_AdjSvrs,Fac_AdjIPs,Fac_SvrCalc,Frm_ComponentFac1,Frm_ComponentFac2,Frm_ComponentFac3,Frm_ComponentFac4,Frm_ComponentFac5,Frm_ComponentFac6,Frm_ComponentFac7,Frm_ComponentFac8,Frm_ComponentFac9,Frm_ComponentFac10,Frm_ComponentFac11,Frm_ComponentFac12")] ConfigTable configTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(configTable).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ConfigMasterId = new SelectList(db.ConfigMasters, "ConfigMasterId", "ConfigMasterName", configTable.ConfigMasterId);
            return View(configTable);
        }

        // GET: ConfigTables/Delete/5
        [AuthLog(Roles = "Administrator")]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConfigTable configTable = await db.ConfigTables.FindAsync(id);
            if (configTable == null)
            {
                return HttpNotFound();
            }
            return View(configTable);
        }

        // POST: ConfigTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [AuthLog(Roles = "Administrator")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ConfigTable configTable = await db.ConfigTables.FindAsync(id);
            db.ConfigTables.Remove(configTable);
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
