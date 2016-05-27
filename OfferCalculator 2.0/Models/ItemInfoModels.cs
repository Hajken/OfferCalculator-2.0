using OfferCalculator_2._0.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfferCalculator_2._0.Models
{
    public class ItemInfoModels
    {
        public int ID { get; set; }

        public int ItemID { get; set; }
        public virtual ItemModels Item { get; set; }


        public decimal MatrialPurchasingPrice { get; set; }


        public decimal TotalSellingPrice { get; set; }

        public decimal MountingPrice { get; set; }

        public CountingUnit CountingUnit { get; set; }

        public int Dimension { get; set; }

        public ItemPriceOverSQM QuantityOfWork { get; set; }

        public MetalTypes MetalType { get; set; }
    }
}