using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult StrictMode()
        {
            ViewBag.minDate= new DateTime(2019, 5, 5, 02,00,00);
            ViewBag.maxDate = new DateTime(2019, 5, 25, 02, 00, 00);
            ViewBag.value = new DateTime(2019, 5, 28, 02, 00, 00);
            return View();
        }
    }
}
