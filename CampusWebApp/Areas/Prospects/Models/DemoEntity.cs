using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampusWebApp.Areas.Prospects.Models
{
    public class DemoEntity
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public int Extn { get; set; }
        public DateTime StartDate { get; set; }
        public long Salary { get; set; }
    }
}
