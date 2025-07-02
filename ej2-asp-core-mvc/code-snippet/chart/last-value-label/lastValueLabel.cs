public ActionResult Index()
        {
            List<LastValueLabelChartData> chartData = new List<LastValueLabelChartData>
            {
             new LastValueLabelChartData {x= 2005, y= 28  },
             new LastValueLabelChartData{ x= 2006, y= 25 },
             new LastValueLabelChartData{ x= 2007, y= 26 },
             new LastValueLabelChartData{ x= 2008, y= 27 },
             new LastValueLabelChartData{ x= 2009, y= 32 },
             new LastValueLabelChartData{ x= 2010, y= 35 },
             new LastValueLabelChartData{ x= 2011, y= 40 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class LastValueLabelChartData
{
            public double x;
            public double y;
        }