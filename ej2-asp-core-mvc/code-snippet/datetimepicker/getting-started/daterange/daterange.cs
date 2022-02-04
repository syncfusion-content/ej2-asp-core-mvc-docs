using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DateTimeRange()
        {
            ViewBag.minDate= new DateTime(2019,11,22, 12,00,00);
            ViewBag.maxDate = new DateTime(2019, 11, 25, 05, 00, 00);
            return View();
        }
    }
}
