using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class MaterialDescription
    {

        public string description { get; set; }
        public string url { get; set; }
        public string description_legacy { get; set; }
        public int material_id { get; set; }
        public string long_description { get; set; }
        public List<int> family_ids { get; set; }
        public string image { get; set; }
    }
}

