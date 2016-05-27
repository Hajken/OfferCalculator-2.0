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
    public class ItemListController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ItemList
        public ActionResult Index()
        {
            var itemInformations = db.ItemInformations.Include(i => i.Item);
            return View(itemInformations.ToList());
        }


        public ActionResult SearchItem(string searchTerm = null)
        {
            if (Request.IsAjaxRequest())
            {
                var itemInformation = db.ItemInformations
                        .Where(t =>
                            t.Item.TypeOfWork.Contains(searchTerm) ||
                            t.Dimension.ToString().Contains(searchTerm));

                if (itemInformation == null)
                {
                    ViewBag.Message = "Did not find your vehicle!";
                }
                return PartialView("_SearchResultsPartial", itemInformation);

            }
            return RedirectToAction("Index");
        }

        public ActionResult AddToOffer(int quantity, int? itemId=null)
        {
            return Json(true, JsonRequestBehavior.AllowGet);
            if (Request.IsAjaxRequest())
            {
                var itemInformation = db.ItemInformations
                        .Where(t =>
                            t.ID== itemId);

                if (itemInformation == null)
                {
                    ViewBag.Message = "Error";
                }
               
                return PartialView("_AddedToOfferCart", itemInformation);

            }
            return RedirectToAction("Index");
        }
    }
}