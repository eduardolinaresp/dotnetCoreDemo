using CampusWebApp.Areas.Prospects.Models;
using JqueryDataTables.ServerSide.AspNetCoreWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusWebApp.Areas.Prospects.Services.Interfaces
{
    public interface IDemoService
    {
        Task<Demo[]> GetDataAsync(DTParameters table);
    }
}
