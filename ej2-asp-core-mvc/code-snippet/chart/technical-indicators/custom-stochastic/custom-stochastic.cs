using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        public ActionResult Stochastic()
        {
            ViewBag.crosshairTooltip = new { enable = true };
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.animation = new { enable = false };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.upperLine =new { color = "#0f0000" };
            ViewBag.lowerLine = new { color = "#080000" };
            ViewBag.periodLine =new { color = "#f2ec2f" };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
    }
}