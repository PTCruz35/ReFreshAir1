using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class CurrentResult
    {
        public Weather WeatherOutput { get; set; }
        public PollutionResult Pollution { get; set; }

    }
}