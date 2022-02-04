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
            ViewBag.minDate= new DateTime(DateTime.Now.Year,DateTime.Now.Month, 7, 0, 0, 0);
            ViewBag.maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            ViewBag.value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 14, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            return View();
        }
    }
}
