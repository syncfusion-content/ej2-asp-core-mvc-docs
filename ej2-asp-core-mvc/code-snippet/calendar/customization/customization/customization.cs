using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class CalendarController : Controller
    {
        public ActionResult sample()
        {
            ViewBag.value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15);
            return View();
        }
    }
}
