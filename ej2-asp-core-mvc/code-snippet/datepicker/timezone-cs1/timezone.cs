using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Datepicker()
        {
            ViewBag.serverTimezoneOffset=5.5;
            ViewBag.initalDate=new Date();
            return View();
        }
    }
}
