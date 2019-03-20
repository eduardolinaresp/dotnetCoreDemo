using CampusApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace CampusApp
{
    class Program
    {
               

     
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DesignTimeDbContextFactory p = new DesignTimeDbContextFactory();

            using (var context = p.CreateDbContext(null))
            {


                foreach (var item in context.Students.ToList())
                {
                    Console.WriteLine(string.Format("{0},{1}", item.LastName, item.FirstMidName));
                }

                foreach (var item in context.Instructors.ToList())
                {
                    Console.WriteLine(string.Format("{0},{1}", item.FirstName, item.LastName));
                }

                Console.ReadKey();
            }
        }
    }
}
