using JqueryDataTables.ServerSide.AspNetCoreWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusWebApp.Areas.Prospects.Models
{
    public class Prospect
    {
        public int ProspectId { get; set; }

        [SearchableString]
        [Sortable(Default = true)]
        public string Name { get; set; }

        [SearchableString]
        [Sortable]
        public string Email { get; set; }

        [SearchableDateTime]
        [Sortable]
        public DateTime RegisterDate { get; set; }

    }
}
