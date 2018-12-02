using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class GeoResult
    {
        public string search_time { get; set; }
        public int num_results { get; set; }
        public GeoInfo result { get; set; }


        public override string ToString()
        {
            return "In Main result set - Latitude: " + result.latitude + ", Longitude " + result.longitude;
        }

    }
}

