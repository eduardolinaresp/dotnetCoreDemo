using JqueryDataTables.ServerSide.AspNetCoreWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusWebApp.Areas.Prospects.Models
{
    public class Demo
    {
        public int Id { get; set; }

        [SearchableString]
        [Sortable(Default = true)]
        public string Name { get; set; }

        [SearchableString]
        [Sortable]
        public string Position { get; set; }

        [SearchableString]
        [Sortable]
        public string Office { get; set; }

        [SearchableInt]
        [Sortable]
        public int Extn { get; set; }

        [SearchableDateTime]
        [Sortable]
        public DateTime StartDate { get; set; }

        [SearchableLong]
        [Sortable]
        public long Salary { get; set; }
    }
}
