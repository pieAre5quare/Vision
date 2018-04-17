using System;
using System.Collections.Generic;
using System.Text;
using Vision.Core.Models.User;

namespace Vision.Core.Models.Locations
{
    //location details such as address/hours/phone will be accessed through the api cached daily
    public interface ILocation
    {
        DateTime OpenDate { get; set; }
        DateTime? CloseDate { get; set; }
        bool IsActive { get; set; }
    }
}
