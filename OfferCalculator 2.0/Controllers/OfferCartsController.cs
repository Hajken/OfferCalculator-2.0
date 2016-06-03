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
    public class OfferCartsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OfferCarts
        public ActionResult Index()
        {
            var offerCarts = db.OfferCarts.Include(o => o.ItemInfo).Include(o => o.OfferInformation);
            return View(offerCarts.ToList());
        }

        // GET: OfferCarts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfferCart offerCart = db.OfferCarts.Find(id);
            if (offerCart == null)
            {
                return HttpNotFound();
            }
            return View(offerCart);
        }

        // GET: OfferCarts/Create
        public ActionResult Create()
        {
            ViewBag.ItemInfoID = new SelectList(db.ItemInformations, "ID", "ID");
            ViewBag.OfferInformationID = new SelectList(db.OfferInformation, "ID", "OfferName");
            return View();
        }

        // POST: OfferCarts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OfferInformationID,Quantity,ItemInfoID,Price,MaterialCost")] OfferCart offerCart)
        {
            if (ModelState.IsValid)
            {
                db.OfferCarts.Add(offerCart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ItemInfoID = new SelectList(db.ItemInformations, "ID", "ID", offerCart.ItemInfoID);
            ViewBag.OfferInformationID = new SelectList(db.OfferInformation, "ID", "OfferName", offerCart.OfferInformationID);
            return View(offerCart);
        }

        // GET: OfferCarts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfferCart offerCart = db.OfferCarts.Find(id);
            if (offerCart == null)
            {
                return HttpNotFound();
            }
            ViewBag.ItemInfoID = new SelectList(db.ItemInformations, "ID", "ID", offerCart.ItemInfoID);
            ViewBag.OfferInformationID = new SelectList(db.OfferInformation, "ID", "OfferName", offerCart.OfferInformationID);
            return View(offerCart);
        }

        // POST: OfferCarts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OfferInformationID,Quantity,ItemInfoID,Price,MaterialCost")] OfferCart offerCart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(offerCart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ItemInfoID = new SelectList(db.ItemInformations, "ID", "ID", offerCart.ItemInfoID);
            ViewBag.OfferInformationID = new SelectList(db.OfferInformation, "ID", "OfferName", offerCart.OfferInformationID);
            return View(offerCart);
        }

        // GET: OfferCarts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfferCart offerCart = db.OfferCarts.Find(id);
            if (offerCart == null)
            {
                return HttpNotFound();
            }
            return View(offerCart);
        }

        // POST: OfferCarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OfferCart offerCart = db.OfferCarts.Find(id);
            db.OfferCarts.Remove(offerCart);
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
