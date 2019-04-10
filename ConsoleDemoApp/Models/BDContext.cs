using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestCore.Models
{
    public class BDContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                  @"Data Source = (local)\sqlexpress;Initial Catalog=BD;User ID=sistema;Password=pass");


        }

    }
}
