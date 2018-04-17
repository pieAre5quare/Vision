using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.User;

namespace Vision.Core.Models.Locations
{
    public class CorporateOffice : Location
    {
        public virtual ApplicationUser OfficeManager { get; set; }
        public virtual ICollection<ApplicationUser> Employees { get; set; }
    }
}
