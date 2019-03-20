using System;
using System.Collections.Generic;
using System.Text;
using CampusApp.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CampusApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        { }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Addreess> Addreesses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new AddreessConfiguration());
            modelBuilder.ApplyConfiguration(new StudentsConfiguration());
            modelBuilder.ApplyConfiguration(new EnrollmentsConfiguration());

        }

    }
}
