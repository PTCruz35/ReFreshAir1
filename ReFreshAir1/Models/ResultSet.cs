using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class ResultSet
    {
        public string search_time { get; set; }
        public int num_results { get; set; }
        //   [JsonProperty("Material")]
        public List<Location> result { get; set; }

        public override string ToString()
        {
            foreach (var temp in result)
                Console.WriteLine("In ResultSet class: Description " + temp.description);
            return "Ho";
        }
    }
}

