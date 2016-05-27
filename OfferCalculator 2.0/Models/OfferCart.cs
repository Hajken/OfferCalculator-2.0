using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfferCalculator_2._0.Models
{
    public class OfferCart
    {
        public int ID { get; set; }

        public string OfferCartName { get; set; }

        public int Quantity { get; set; }

        public string OfferOwner { get; set; }

        public int ItemInfoID { get; set; }

        public virtual ItemInfoModels ItemInfo { get; set; }

        public decimal Price { get; set; }

        public decimal MaterialCost { get; set; }

    }
}