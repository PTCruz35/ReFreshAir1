using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class DataResult
    {
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public DataLocationResult Location { get; set; }
        public CurrentResult Current { get; set; }
    }
}