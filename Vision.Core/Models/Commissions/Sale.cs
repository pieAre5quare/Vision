using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.BaseClass;
using Vision.Core.Models.Locations;
using Vision.Core.Models.User;

namespace Vision.Core.Models.Commissions
{
    public class Sale : Entity<Guid>
    {
        public virtual ApplicationUser Employee { get; set; }
        public virtual RetailStore Store { get; set; }
        public virtual PayPeriod PayPeriod { get; set; }
        public virtual IEnumerable<SaleItem> Items { get; set; }
    }
}
