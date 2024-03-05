using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA_MINDS_Library
{
    public class Location
    {
        public Location(int locationID, string locationName, string locationDescription)
        {
            LocationID = locationID;
            LocationName = locationName;
            LocationDescription = locationDescription;
        }

        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
    }
}
