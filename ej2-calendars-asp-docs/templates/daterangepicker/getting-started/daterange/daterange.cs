using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class DateRangePickerController : Controller
    {
        public ActionResult DateRange()
        {
            ViewBag.startDate = new DateTime(2017, 11, 09);
            ViewBag.endDate = new DateTime(2017, 11, 21);
            return View();
        }
    }
}
