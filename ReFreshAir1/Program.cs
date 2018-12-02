using ReFreshAir1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ReFreshAir1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new context())
            {
                context.Requests.Add(new Request()
                {
                    FirstName = "Praveen",
                    LastName = "Tetali",
                    Address = "abc"


                });
                context.SaveChanges();
                var requests = context.Requests.ToList();
                foreach(var request in requests)
                {
                    Console.WriteLine(request.FirstName);
                }
                Console.ReadLine();
            }

        }
    }
}