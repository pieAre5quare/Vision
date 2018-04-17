using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Vision.Core.Models.BaseClass;

namespace Vision.Core.Models.Commissions
{
    public class SaleItem : Entity<Guid>
    {
        public string Sku { get; set; }
        public decimal CommissionAmount { get; set; }
        public Sale Sale { get; set; }
    }
}
