using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.BaseClass;

namespace Vision.Core.Models.Locations
{
    public class Company : Entity<int>
    {
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<CorporateOffice> CorporateOffices { get; set; }
    }
}
