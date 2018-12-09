using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class Weather
    {
        public string TsWeather { get; set; }
        public int Hu { get; set; }
        public string Ic { get; set; }
        public int Pr { get; set; }
        public int Tp { get; set; }
        public int Wd { get; set; }
        public double Ws { get; set; }
    }
}