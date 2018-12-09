using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class DataLocationResult
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }
}