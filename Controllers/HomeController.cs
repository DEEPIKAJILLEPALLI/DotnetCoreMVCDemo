using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreWebApplication1.Controllers
{
    public class HomeController: Controller
    {
        private readonly IClock _clock;
        public HomeController(IClock clock)
        {
            _clock = clock;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = $"It is {_clock.GetTime().ToString("T")}";
            return View();
        }
    }
}
