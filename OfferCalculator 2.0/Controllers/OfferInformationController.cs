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
    public class OfferInformationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OfferInformation
        public ActionResult Index()
        {
            return View(db.OfferInformation.ToList());
        }

        // GET: OfferInformation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfferInformationModels offerInformationModels = db.OfferInformation.Find(id);
            if (offerInformationModels == null)
            {
                return HttpNotFound();
            }
            return View(offerInformationModels);
        }

        // GET: OfferInformation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OfferInformation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,OfferName,ContactInformation,OfferOwner")] OfferInformationModels offerInformationModels)
        {
            if (ModelState.IsValid)
            {
                db.OfferInformation.Add(offerInformationModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(offerInformationModels);
        }

        // GET: OfferInformation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfferInformationModels offerInformationModels = db.OfferInformation.Find(id);
            if (offerInformationModels == null)
            {
                return HttpNotFound();
            }
            return View(offerInformationModels);
        }

        // POST: OfferInformation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,OfferName,ContactInformation,OfferOwner")] OfferInformationModels offerInformationModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(offerInformationModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(offerInformationModels);
        }

        // GET: OfferInformation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfferInformationModels offerInformationModels = db.OfferInformation.Find(id);
            if (offerInformationModels == null)
            {
                return HttpNotFound();
            }
            return View(offerInformationModels);
        }

        // POST: OfferInformation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OfferInformationModels offerInformationModels = db.OfferInformation.Find(id);
            db.OfferInformation.Remove(offerInformationModels);
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
