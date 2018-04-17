using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.Commissions;

namespace Vision.Core.Models.Products
{
    public interface IProduct
    {
        decimal RetailPrice { get; set; }
        decimal ProductCost { get; set; }
        string Sku { get; set; }
        decimal Profit { get; }
        Classification Classification { get; set; }
        decimal GetProductCommissionAmt();
    }
}
