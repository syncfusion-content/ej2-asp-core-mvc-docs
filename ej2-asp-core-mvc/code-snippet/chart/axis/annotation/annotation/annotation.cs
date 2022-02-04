using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2CoreSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        public IActionResult Column()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData { x= "USA", yValue= 46 }, 
                new ColumnChartData { x= "GBR", yValue= 27 }, 
                new ColumnChartData { x= "CHN", yValue= 26 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ColumnChartData
        {
            public string x;
            public double yValue;
        }
    }
}