using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReFreshAir1.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
