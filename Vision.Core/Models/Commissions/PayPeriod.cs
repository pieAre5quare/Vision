using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.BaseClass;

namespace Vision.Core.Models.Commissions
{
    public class PayPeriod : Entity<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
