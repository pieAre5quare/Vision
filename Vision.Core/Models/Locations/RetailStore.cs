using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.User;

namespace Vision.Core.Models.Locations
{
    public class RetailStore : Location
    {
        public virtual District District { get; set; }
        public virtual ApplicationUser StoreLeader { get; set; }
        public virtual ICollection<ApplicationUser> SalesReps { get; set; }
    }
}
