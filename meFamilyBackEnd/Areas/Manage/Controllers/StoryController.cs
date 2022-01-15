using meFamilyBackEnd.Models;
using meFamilyBackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meFamilyBackEnd.Areas.Manage.Controllers
{
    [Area("manage")]
    public class StoryController : Controller
    {
        private readonly DataContext _context;
        public StoryController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel HomeVM = new HomeViewModel
            {
                Stories=_context.Stories.ToList()
            };
            return View(HomeVM);
        }
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Delete( int id)
        //{

        //}
    }
  

}
