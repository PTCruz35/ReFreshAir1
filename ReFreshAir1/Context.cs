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
        public context() : base(@"data source=LAPTOP-OB2KV8ML\SQLEXPRESS;initial catalog=ReFreshAir1ConnectionString;User Id=sa;Password=hUladodaz3;MultipleActiveResultSets=True")
        {

        }
        public DbSet<Request> Requests { get; set; }
    }
}