using AutoMapper;
using CampusWebApp.Areas.Prospects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusWebApp.Areas.Prospects.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DemoEntity, Demo>();
        }
    }
}
