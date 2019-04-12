using AutoMapper;
using AutoMapper.QueryableExtensions;
using CampusWebApp.Areas.Prospects.Models;
using CampusWebApp.Areas.Prospects.Services.Interfaces;
using CampusWebApp.Models;
using JqueryDataTables.ServerSide.AspNetCoreWeb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusWebApp.Areas.Prospects.Services.Implementatios
{
    public class DefaultDemoService : IDemoService
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfigurationProvider _mappingConfiguration;

        public DefaultDemoService(ApplicationDbContext context, IConfigurationProvider mappingConfiguration)
        {
            _context = context;
            _mappingConfiguration = mappingConfiguration;
        }

        public async Task<Demo[]> GetDataAsync(DTParameters table)
        {
            IQueryable<DemoEntity> query = _context.Demos;
            query = new SearchOptionsProcessor<Demo, DemoEntity>().Apply(query, table.Columns);
            query = new SortOptionsProcessor<Demo, DemoEntity>().Apply(query, table);

            var items = await query
                .AsNoTracking()
                .Skip(table.Start - 1 * table.Length)
                .Take(table.Length)
                .ProjectTo<Demo>(_mappingConfiguration)
                .ToArrayAsync();

            return items;
        }
    }
}
