using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class GeoInfo
    {
        public string province { get; set; }
        public string city { get; set; }
        public string metro { get; set; }
        public string region { get; set; }
        public double longitude { get; set; }
        public string postal_code { get; set; }
        public double latitude { get; set; }
        public int population { get; set; }


        public override string ToString()
        {
            return "Latitude: " + latitude + ", Longitude " + longitude;
        }

    }
}

