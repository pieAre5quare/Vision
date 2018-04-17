using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.BaseClass;
using Vision.Core.Models.User;

namespace Vision.Core.Models.Locations
{
    public class Area : Entity<int>
    {
        public virtual ApplicationUser AreaLeader { get; set; }

        public virtual ICollection<Region> Regions { get; set; }
    }
}
