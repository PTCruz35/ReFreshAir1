using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class Location
    {
        public bool curbside { get; set; }
        public string description { get; set; }
        public double distance { get; set; }
        public double longitude { get; set; }
        public int location_type_id { get; set; }
        public double latitude { get; set; }
        public string location_id { get; set; }
        public bool municipal { get; set; }

        public override string ToString()
        {
            return "Description " + description;
        }

    }
}

