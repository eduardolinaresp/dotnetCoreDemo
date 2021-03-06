﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusWebApp.Areas.Instructors.Models;
using CampusWebApp.Areas.Prospects.Models;


namespace CampusWebApp.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        { }


        public DbSet<Student> Students { get; set; }


        public DbSet<Instructor> Instructors { get; set; }


        public DbSet<Prospect> Prospects { get; set; }

        public DbSet<DemoEntity> Demos { get; set; }
    }
}

