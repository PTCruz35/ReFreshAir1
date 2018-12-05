using ReFreshAir1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReFreshAir1
{
    public class context : DbContext
    {
        public context() : base()
        {
            
        }
        public DbSet<Request> Requests { get; set; }
    }
}