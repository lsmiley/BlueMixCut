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
using System.Data.Entity.Infrastructure;

namespace SizingToolNew2.Controllers
{
    [Authorize]
    public class LaborDeliveriesController : Controller
    {
        private SizingDbContext db = new SizingDbContext();

        // GET: LaborDeliveries
        public async Task<ActionResult> Index()
        {
            var laborDeliverys = db.LaborDeliverys.Include(l => l.LaborDeliveryType);
            return View(await laborDeliverys.ToListAsync());
        }

        // GET: LaborDeliveries/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaborDelivery laborDelivery = await db.LaborDeliverys.FindAsync(id);
            if (laborDelivery == null)
            {
                return HttpNotFound();
            }
            return View(laborDelivery);
        }

        // GET: LaborDeliveries/Create
        public ActionResult Create()
        {
            ViewBag.LaborDeliveryTypeId = new SelectList(db.LaborDeliveryTypes, "LaborDeliveryTypeId", "DeliveryTypeName");
            ViewBag.SizingType = new SelectList(db.SizingTypes, "SizingTypeId", "SizingTypeName");

            List<SelectListItem> listItems = new List<SelectListItem>();
            listItems.Add(new SelectListItem(){Value = "111",Text = "Car1"});
            listItems.Add(new SelectListItem(){Value = "222",Text = "Car2"});
            listItems.Add(new SelectListItem(){Value = "3333",Text = "Car3", Selected=true});
            
            //ViewBag.DeliveryType = new SelectList(listItems, "Value", "Text");

            #region ViewData
            List<SelectListItem> mySkills = new List<SelectListItem>() {
        new SelectListItem {Text = "ASP.NET MVC", Value = "1"},
        new SelectListItem {Text = "ASP.NET WEB API", Value = "2"},
        new SelectListItem {Text = "ENTITY FRAMEWORK", Value = "3"},
        new SelectListItem {Text = "DOCUSIGN", Value = "4"},
        new SelectListItem {Text = "ORCHARD CMS", Value = "5"},
        new SelectListItem {Text = "JQUERY", Value = "6"},
        new SelectListItem {Text = "ZENDESK", Value = "7"},
        new SelectListItem {Text = "LINQ", Value = "8"},
        new SelectListItem {Text = "C#", Value = "9"},
        new SelectListItem { Text = "GOOGLE ANALYTICS", Value = "10" },
    };
            ViewData["MySkills"] = mySkills;
            #endregion
            {
                var fromDatabaseEF = new SelectList(db.LaborDeliveryTypes.ToList(), "LaborDeliveryTypeId", "DeliveryUseDescription");
                ViewData["DBLaborDeliveryTypes"] = fromDatabaseEF;

            }
            

            return View();
        }

        // POST: LaborDeliveries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LaborDeliveryId,RegionNumber,Regions,DeliveryOption,LaborDeliveryTypeId,CurrencyType,DefaultFTE_Year,WorkWeek,DeliveryCtrCostFactor,Band2,Band2Name,Band2Count,Band2Percentage,Band3,Band3Name,Band3Count,Band3Percentage,Band4,Band4Name,Band4Count,Band4Percentage,Band5,Band5Name,Band5Count,Band5Percentage,Band6,Band6Name,Band6Count,Band6Percentage,Band7,Band7Name,Band7Count,Band7Percentage,Band8,Band8Name,Band8Count,Band8Percentage,Band9,Band9Name,Band9Count,Band9Percentage,Band10,Band10Name,Band10Count,Band10Percentage,BandsTotalCount,DeliveryType,DeliveryUseDescription,MemoDeliveryNote1,DeliveryOwnerFirstName,DeliveryOwnerLastName,DeliveryOwnerFullName,DeliveryOwnerEmail,CreateBy")] LaborDelivery laborDelivery)
        {
            if (ModelState.IsValid)
            {

            
                var typeDeliverys = new List<SelectListItem>();
                typeDeliverys.Add(new SelectListItem() { Text = "Select...", Value = string.Empty });
                typeDeliverys.Add(new SelectListItem() { Text = "Shared/Hosted-Cloud-Support", Value = "0" });
                typeDeliverys.Add(new SelectListItem() { Text = "Dedicated-Support", Value = "1" });
                typeDeliverys.Add(new SelectListItem() { Text = "Project/RFS/NBD", Value = "2" });
                typeDeliverys.Add(new SelectListItem() { Text = "Custom", Value = "9" });

                ViewBag.DeliveryType = typeDeliverys;
                {
                    #region ViewData
                List<SelectListItem> mySkills = new List<SelectListItem>() {
        new SelectListItem {Text = "ASP.NET MVC", Value = "1"},
        new SelectListItem {Text = "ASP.NET WEB API", Value = "2"},
        new SelectListItem {Text = "ENTITY FRAMEWORK", Value = "3"},
        new SelectListItem {Text = "DOCUSIGN", Value = "4"},
        new SelectListItem {Text = "ORCHARD CMS", Value = "5"},
        new SelectListItem {Text = "JQUERY", Value = "6"},
        new SelectListItem {Text = "ZENDESK", Value = "7"},
        new SelectListItem {Text = "LINQ", Value = "8"},
        new SelectListItem {Text = "C#", Value = "9"},
        new SelectListItem { Text = "GOOGLE ANALYTICS", Value = "10" },
    };
                    ViewData["MySkills"] = mySkills;
                    #endregion
                }

                db.LaborDeliverys.Add(laborDelivery);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.LaborDeliveryTypeId = new SelectList(db.LaborDeliveryTypes, "LaborDeliveryTypeId", "DeliveryTypeName", laborDelivery.LaborDeliveryTypeId);

            //{    List<string> ListItems = new List<string>();
            //    ListItems.Add("Select");
            //    ListItems.Add("StdGeoDelivery");
            //    ListItems.Add("Shared/Hosted-Cloud-Support");
            //    ListItems.Add("Dedicated-Support");
            //    ListItems.Add("Project/RFS/NBD");
            //    ListItems.Add("Custom");
            //    SelectList DeliveryTypes = new SelectList(ListItems);
            //    ViewData["DeliveryTypes"] = DeliveryTypes;




            return View(laborDelivery);
        }

        // GET: LaborDeliveries/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaborDelivery laborDelivery = await db.LaborDeliverys.FindAsync(id);
            if (laborDelivery == null)
            {
                return HttpNotFound();
            }

            #region ViewData
            List<SelectListItem> mySkills = new List<SelectListItem>() {
        new SelectListItem {Text = "ASP.NET MVC", Value = "1"},
        new SelectListItem {Text = "ASP.NET WEB API", Value = "2"},
        new SelectListItem {Text = "ENTITY FRAMEWORK", Value = "3"},
        new SelectListItem {Text = "DOCUSIGN", Value = "4"},
        new SelectListItem {Text = "ORCHARD CMS", Value = "5"},
        new SelectListItem {Text = "JQUERY", Value = "6"},
        new SelectListItem {Text = "ZENDESK", Value = "7"},
        new SelectListItem {Text = "LINQ", Value = "8"},
        new SelectListItem {Text = "C#", Value = "9"},
        new SelectListItem { Text = "GOOGLE ANALYTICS", Value = "10" },
    };
            ViewData["MySkills"] = mySkills;
            #endregion

            ViewBag.LaborDeliveryTypeId = new SelectList(db.LaborDeliveryTypes, "LaborDeliveryTypeId", "DeliveryTypeName", laborDelivery.LaborDeliveryTypeId);
            return View(laborDelivery);
        }

        // POST: LaborDeliveries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LaborDeliveryId,RegionNumber,Regions,DeliveryOption,LaborDeliveryTypeId,CurrencyType,DefaultFTE_Year,WorkWeek,DeliveryCtrCostFactor,Band2,Band2Name,Band2Count,Band2Percentage,Band3,Band3Name,Band3Count,Band3Percentage,Band4,Band4Name,Band4Count,Band4Percentage,Band5,Band5Name,Band5Count,Band5Percentage,Band6,Band6Name,Band6Count,Band6Percentage,Band7,Band7Name,Band7Count,Band7Percentage,Band8,Band8Name,Band8Count,Band8Percentage,Band9,Band9Name,Band9Count,Band9Percentage,Band10,Band10Name,Band10Count,Band10Percentage,BandsTotalCount,DeliveryType,DeliveryUseDescription,MemoDeliveryNote1,DeliveryOwnerFirstName,DeliveryOwnerLastName,DeliveryOwnerFullName,DeliveryOwnerEmail,CreateBy")] LaborDelivery laborDelivery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(laborDelivery).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            #region ViewData
            List<SelectListItem> mySkills = new List<SelectListItem>() {
        new SelectListItem {Text = "ASP.NET MVC", Value = "1"},
        new SelectListItem {Text = "ASP.NET WEB API", Value = "2"},
        new SelectListItem {Text = "ENTITY FRAMEWORK", Value = "3"},
        new SelectListItem {Text = "DOCUSIGN", Value = "4"},
        new SelectListItem {Text = "ORCHARD CMS", Value = "5"},
        new SelectListItem {Text = "JQUERY", Value = "6"},
        new SelectListItem {Text = "ZENDESK", Value = "7"},
        new SelectListItem {Text = "LINQ", Value = "8"},
        new SelectListItem {Text = "C#", Value = "9"},
        new SelectListItem { Text = "GOOGLE ANALYTICS", Value = "10" },
    };
            ViewData["MySkills"] = mySkills;
            #endregion

            ViewBag.LaborDeliveryTypeId = new SelectList(db.LaborDeliveryTypes, "LaborDeliveryTypeId", "DeliveryTypeName", laborDelivery.LaborDeliveryTypeId);
            return View(laborDelivery);
        }

        // GET: LaborDeliveries/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaborDelivery laborDelivery = await db.LaborDeliverys.FindAsync(id);
            if (laborDelivery == null)
            {
                return HttpNotFound();
            }
            return View(laborDelivery);
        }

        // POST: LaborDeliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            LaborDelivery laborDelivery = await db.LaborDeliverys.FindAsync(id);
            db.LaborDeliverys.Remove(laborDelivery);
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
