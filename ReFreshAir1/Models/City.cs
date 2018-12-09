using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class City
    {
        public string city { get; set; }

        public override string ToString()
        {
            return "City " + city;
        }

    }
}