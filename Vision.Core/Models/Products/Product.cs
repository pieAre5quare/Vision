using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Vision.Core.Models.BaseClass;
using Vision.Core.Models.Commissions;

namespace Vision.Core.Models.Products
{
    public class Product : Entity<Guid>, IProduct
    {
        public decimal RetailPrice { get; set; }
        public decimal ProductCost { get; set; }
        public string Sku { get; set; }
        [NotMapped]
        public decimal Profit => RetailPrice - ProductCost;
        public Classification Classification { get; set; } //could be collection of classifications likely better as one for simplicity

        public decimal GetProductCommissionAmt()
        {
            return (Classification.Accelerator * Profit) + Classification.Spiff;
        }
    }
}
