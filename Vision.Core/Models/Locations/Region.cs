using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.BaseClass;
using Vision.Core.Models.User;

namespace Vision.Core.Models.Locations
{
    public class Region : Entity<int>
    {
        public virtual ApplicationUser RegionLeader { get; set; }
        public virtual Area Area { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
