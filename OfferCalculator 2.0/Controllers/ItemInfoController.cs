using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OfferCalculator_2._0.Models;

namespace OfferCalculator_2._0.Controllers
{
    public class MetalItemInfoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ItemInfo
        public ActionResult Index()
        {
            var itemInformations = db.ItemInformations.Include(i => i.Item);
            return View(itemInformations.ToList());
        }

        // GET: ItemInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetalItemInfoModels itemInfoModels = db.ItemInformations.Find(id);
            if (itemInfoModels == null)
            {
                return HttpNotFound();
            }
            return View(itemInfoModels);
        }

        // GET: ItemInfo/Create
        public ActionResult Create()
        {
            ViewBag.ItemID = new SelectList(db.Items, "ID", "TypeOfWork");
            return View();
        }

        // POST: ItemInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ItemID,MatrialPurchasingPrice,TotalSellingPrice,MountingPrice,CountingUnit,MetalType")] MetalItemInfoModels itemInfoModels)
        {
            if (ModelState.IsValid)
            {
                db.ItemInformations.Add(itemInfoModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ItemID = new SelectList(db.Items, "ID", "TypeOfWork", itemInfoModels.ItemID);
            return View(itemInfoModels);
        }

        // GET: ItemInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetalItemInfoModels itemInfoModels = db.ItemInformations.Find(id);
            if (itemInfoModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.ItemID = new SelectList(db.Items, "ID", "TypeOfWork", itemInfoModels.ItemID);
            return View(itemInfoModels);
        }

        // POST: ItemInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ItemID,MatrialPurchasingPrice,TotalSellingPrice,MountingPrice,CountingUnit,MetalType")] MetalItemInfoModels itemInfoModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemInfoModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ItemID = new SelectList(db.Items, "ID", "TypeOfWork", itemInfoModels.ItemID);
            return View(itemInfoModels);
        }

        // GET: ItemInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetalItemInfoModels itemInfoModels = db.ItemInformations.Find(id);
            if (itemInfoModels == null)
            {
                return HttpNotFound();
            }
            return View(itemInfoModels);
        }

        // POST: ItemInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MetalItemInfoModels itemInfoModels = db.ItemInformations.Find(id);
            db.ItemInformations.Remove(itemInfoModels);
            db.SaveChanges();
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
