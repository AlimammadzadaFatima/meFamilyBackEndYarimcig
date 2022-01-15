using meFamilyBackEnd.Models;
using meFamilyBackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace meFamilyBackEnd.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel HomeVM = new HomeViewModel
            {
                Stories = _context.Stories.ToList(),
                Workers = _context.Workers.ToList(),
                Settings = _context.Settings.ToList(),
                SosialMedias = _context.SosialMedias.ToList(),
                WorkerMedias = _context.WorkerMedias.ToList()
            };
            return View(HomeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
