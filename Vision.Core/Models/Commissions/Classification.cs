using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.BaseClass;

namespace Vision.Core.Models.Commissions
{
    public class Classification : Entity<Guid>
    {
        public PayPeriod PayPeriod { get; set; }
        public decimal Accelerator { get; set; }
        public decimal Spiff { get; set; }
    }
}
