using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class AQIFullResult
    {
        public string Status { get; set; }
        public DataResult Data { get; set; }

        //public Weather Current { get; set; }
        //public  WeatherOutput {get; set;}
        //public PollutionResult pollution { get; set; }

        //public override string ToString()
        //{
        //    return "In Main result set - Latitude: " + pollution.Aqius + ", Longitude " + pollution.Aqius;
        ////}
    }
}