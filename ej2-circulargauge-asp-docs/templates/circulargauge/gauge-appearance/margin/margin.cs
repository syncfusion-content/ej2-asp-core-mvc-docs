using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2_Core_Application.Models;
using Newtonsoft.Json;
using Syncfusion.EJ2.CircularGauge;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.Value = 60;
            pointer1.Radius = "60%";
            pointers.Add(pointer1);
            ViewBag.pointers = pointers;
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 0;
            range1.End = 70;
            range1.Radius = "110%";
            range1.StartWidth = "10";
            ranges.Add(range1);
            CircularGaugeRange range2 = new CircularGaugeRange();
            range2.Start = 70;
            range2.End = 110;
            range2.Radius = "110%";
            range2.StartWidth = "10";
            ranges.Add(range2);
            CircularGaugeRange range3 = new CircularGaugeRange();
            range3.Start = 110;
            range3.End = 120;
            range3.Radius = "110%";
            range3.StartWidth = "10";
            ranges.Add(range3);
            ViewBag.ranges = ranges;
            return View();
        }
    }
}
