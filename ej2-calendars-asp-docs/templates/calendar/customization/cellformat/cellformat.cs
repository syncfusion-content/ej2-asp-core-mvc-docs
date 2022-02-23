using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class CalendarController : Controller
    {
        public ActionResult SpecialDates()
        {
            ViewBag.value = new DateTime(2017, 3, 10);
            return View();
        }
    }
}
