using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfferCalculator_2._0.Models
{
    public class OfferCart
    {
        private DateTime _date = DateTime.Now;
        public int ID { get; set; }

        public int OfferInformationID { get; set; }

        public virtual OfferInformationModels OfferInformation { get; set; }

        public DateTime DateCreated
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Quantity { get; set; }


        public int ItemInfoID { get; set; }


        public virtual MetalItemInfoModels ItemInfo { get; set; }


        public decimal Price { get; set; }


        public decimal MaterialCost { get; set; }

    }
}