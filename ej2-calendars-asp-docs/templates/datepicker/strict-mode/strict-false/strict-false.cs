using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult DefaultFunctionalities()
        {
            ViewBag.value = new DateTime(2018, 5, 28);
            ViewBag.minDate= new DateTime(2018, 5, 5);
            ViewBag.maxDate = new DateTime(2018, 5, 25);
            return View();
        }
    }
}
