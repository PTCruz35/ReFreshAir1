using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class State
    {
        public string state { get; set; }

        public override string ToString()
        {
            return "State " + state;
        }
    }
}