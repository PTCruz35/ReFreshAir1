using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class MaterialResult
    {
        public string search_time { get; set; }
        public int num_results { get; set; }
        public List<MaterialDescription> result { get; set; }

        /*
        public override string ToString()
        {
            return base.ToString();
        }
        */


    }
}

