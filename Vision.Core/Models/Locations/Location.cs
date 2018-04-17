using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.BaseClass;
using Vision.Core.Models.User;

namespace Vision.Core.Models.Locations
{
    //location details such as address/hours/phone will be accessed through the api cached daily
    public abstract class Location : Entity<int>, ILocation
    {
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public bool IsActive { get; set; }
    }
}
