using System;
using System.Collections.Generic;
using System.Text;

namespace CampusApp.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }

    }
}
