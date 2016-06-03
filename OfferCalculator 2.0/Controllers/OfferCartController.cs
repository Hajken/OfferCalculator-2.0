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
    [Authorize]
    public class OfferCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OfferCart
        public ActionResult Index()
        {
            var offerCarts = db.OfferCarts.Include(o => o.ItemInfo);
            return View(offerCarts.ToList());
        }

        // GET: OfferCart/Details/5
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

        // GET: OfferCart/Create
        public ActionResult Create()
        {
            ViewBag.ItemInfoID = new SelectList(db.ItemInformations, "ID", "ID");
            return View();
        }

        // POST: OfferCart/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OfferCartName,Quantity,OfferOwner,ItemInfoID,Price,MaterialCost")] OfferCart offerCart)
        {
            if (ModelState.IsValid)
            {
                db.OfferCarts.Add(offerCart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ItemInfoID = new SelectList(db.ItemInformations, "ID", "ID", offerCart.ItemInfoID);
            return View(offerCart);
        }

        // GET: OfferCart/Edit/5
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
            return View(offerCart);
        }

        // POST: OfferCart/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OfferCartName,Quantity,OfferOwner,ItemInfoID,Price,MaterialCost")] OfferCart offerCart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(offerCart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ItemInfoID = new SelectList(db.ItemInformations, "ID", "ID", offerCart.ItemInfoID);
            return View(offerCart);
        }

        // GET: OfferCart/Delete/5
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

        // POST: OfferCart/Delete/5
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
