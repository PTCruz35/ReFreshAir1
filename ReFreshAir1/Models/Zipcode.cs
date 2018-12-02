using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class Zipcode
    {
        public string zipcode { get; set; }

        public override string ToString()
        {
            return "Zipcode: " + zipcode;
        }
    }
}

