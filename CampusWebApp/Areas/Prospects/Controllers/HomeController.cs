using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CampusWebApp.Areas.Prospects.Models;
using CampusWebApp.Areas.Prospects.Services.Interfaces;
using CampusWebApp.Models;
using JqueryDataTables.ServerSide.AspNetCoreWeb;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CampusWebApp.Areas.Prospects.Controllers
{
    [Area("Prospects")]
    public class HomeController : Controller
    {

        private readonly IDemoService _demoService;

        public HomeController(IDemoService demoService)
        {
            _demoService = demoService;
        }


        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoadTable([FromBody]DTParameters param)
        {
            try
            {
                var data = await _demoService.GetDataAsync(param);

                return new JsonResult(new DTResult<Demo>
                {
                    draw = param.Draw,
                    data = data,
                    recordsFiltered = data.Length,
                    recordsTotal = data.Length
                });
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return new JsonResult(new { error = "Internal Server Error" });
            }
        }

    }
}