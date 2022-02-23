using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class HomeController : Controller
    {
        public ActionResult DateRange()
        {
            ViewBag.value = new DateTime(DateTime.Now.Year,DateTime.Now.Month,14);
            ViewBag.minDate= new DateTime(DateTime.Now.Year,DateTime.Now.Month,07);
            ViewBag.maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27);
            return View();
        }
    }
}
