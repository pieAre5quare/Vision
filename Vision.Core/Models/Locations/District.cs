using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.BaseClass;
using Vision.Core.Models.User;

namespace Vision.Core.Models.Locations
{
    public class District : Entity<int>
    {
        public virtual ApplicationUser DistrictLeader { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<RetailStore> RetailStores { get; set; }
    }
}
