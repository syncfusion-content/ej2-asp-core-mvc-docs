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
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 0;
            range1.End = 3;
            range1.Color = "rgba(29,29,29,0.7)";
            ranges.Add(range1);
            CircularGaugeRange range2 = new CircularGaugeRange();
            range2.Start = 3;
            range2.End = 12;
            range2.Color = "rgba(168,145,102,0.1)";
            ranges.Add(range2);
            ViewBag.ranges = ranges;
            List<CircularGaugeAnnotation> annotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation annotation1 = new CircularGaugeAnnotation();
            annotation1.Angle = 270;
            annotation1.Radius = "40%";
            annotation1.Content = "<div id=subGauge2 style=width: 90px; height: 90px;></div>";
            annotations.Add(annotation1);
            CircularGaugeAnnotation annotation2 = new CircularGaugeAnnotation();
            annotation2.Angle = 90;
            annotation2.Radius = "40%";
            annotation2.Content = "<div id=time><span>6:30 PM</span></div>";
            annotations.Add(annotation2);
            ViewBag.annotations = annotations;
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.PointerWidth = 5;
            pointer1.Radius = "40%";
            pointer1.Value = 6.5;
            pointer1.Border = new CircularGaugeBorder
            {
                Width = 1,
                Color = "rgb(29,29,29)"
            };
            pointer1.Cap = new CircularGaugeCap
            {
                Color = "rgb(29,29,29)",
                Radius = 0,
                Border = new CircularGaugeBorder
                {
                    Width = 0.2,
                    Color = "red"
                }
            };
            pointer1.NeedleTail = new CircularGaugeNeedleTail
            {
                Length = "0%"
            };
            pointer1.Animation = new CircularGaugeAnimation { Enable = false };
            pointers.Add(pointer1);
            CircularGaugePointer pointer2 = new CircularGaugePointer();
            pointer2.PointerWidth = 5;
            pointer2.Radius = "60%";
            pointer2.Color = "rgb(29,29,29)";
            pointer2.Value = 6;
            pointer2.Border = new CircularGaugeBorder
            {
                Width = 1,
                Color = "rgb(29,29,29)"
            };
            pointer2.Cap = new CircularGaugeCap
            {
                Color = "rgb(29,29,29)",
                Radius = 0,
                Border = new CircularGaugeBorder
                {
                    Width = 0.2,
                    Color = "red"
                }
            };
            pointer2.NeedleTail = new CircularGaugeNeedleTail
            {
                Length = "0%"
            };
            pointer2.Animation = new CircularGaugeAnimation{ Enable = false };
            pointers.Add(pointer2);
            CircularGaugePointer pointer3 = new CircularGaugePointer();
            pointer3.PointerWidth = 4;
            pointer3.Radius = "70%";
            pointer3.Color = "rgba(168,145,102,1)";
            pointer3.Value = 9.8;
            pointer3.Cap = new CircularGaugeCap
            {
                Color = "rgba(168,145,102,1)",
                Radius = 4,
                Border = new CircularGaugeBorder
                {
                    Width = 0.2,
                    Color = "rgba(168,145,102,1)"
                }
            };
            pointer3.NeedleTail = new CircularGaugeNeedleTail
            {
                Color = "rgba(168,145,102,1)",
                Length = "20%"
            };
            pointer3.Animation = new CircularGaugeAnimation { Enable = false, Duration = 0 };
            pointers.Add(pointer3);
            ViewBag.pointers = pointers;
            List<CircularGaugeRange> subgaugeranges = new List<CircularGaugeRange>();
            CircularGaugeRange ranges4 = new CircularGaugeRange();
            ranges4.Start = 0;
            ranges4.End = 3;
            ranges4.StartWidth = "5";
            ranges4.EndWidth = "5";
            ranges4.Color = "rgba(29,29,29,0.7)";
            subgaugeranges.Add(ranges4);
            CircularGaugeRange ranges5 = new CircularGaugeRange();
            ranges5.Start = 3;
            ranges5.End = 12;
            ranges5.StartWidth = "5";
            ranges5.EndWidth = "5";
            ranges5.Color = "rgba(168,145,102,0.1)";
            subgaugeranges.Add(ranges5);
            ViewBag.subgauge_ranges = subgaugeranges;
            List<CircularGaugePointer> subpointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer4 = new CircularGaugePointer();
            pointer4.PointerWidth = 2;
            pointer4.Radius = "40%";
            pointer4.Animation = new CircularGaugeAnimation { Enable = false };
            pointer4.Color = "rgb(29,29,29)";
            pointer4.Border = new CircularGaugeBorder
            {
                Width = 1,
                Color = "rgb(29,29,29)"
            };
            pointer4.Cap = new CircularGaugeCap
            {
                Color = "rgb(29,29,29)",
                Radius = 2,
                Border = new CircularGaugeBorder
                {
                    Width = 0.2,
                    Color = "red"
                }
            };
            pointer4.NeedleTail = new CircularGaugeNeedleTail
            {
                Length = "0%"
            };
            subpointers.Add(pointer4);
            ViewBag.subgauge_pointers = subpointers;
            return View();
        }
    }
}
