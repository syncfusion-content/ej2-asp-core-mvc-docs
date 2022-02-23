public ActionResult Index()
        {
            List<MultipleAxesChartData> chartData = new List<MultipleAxesChartData>
            {
                new MultipleAxesChartData{ x= "Jan", y= 15, y1= 33 },
                new MultipleAxesChartData{ x= "Feb", y= 20, y1= 31 },
                new MultipleAxesChartData{ x= "Mar", y= 35, y1= 30 },
                new MultipleAxesChartData{ x= "Apr", y= 40, y1= 28 },
                new MultipleAxesChartData{ x= "May", y= 80, y1= 29 },
                new MultipleAxesChartData{ x= "Jun", y= 70, y1= 30 },
                new MultipleAxesChartData{ x= "Jul", y= 65, y1= 33 }, 
                new MultipleAxesChartData{ x= "Aug", y= 55, y1= 32 },
                new MultipleAxesChartData{ x= "Sep", y= 50, y1= 34 },
                new MultipleAxesChartData{ x= "Oct", y= 30, y1= 32 },
                new MultipleAxesChartData{ x= "Nov", y= 35, y1= 32 },
                new MultipleAxesChartData{ x= "Dec", y= 35, y1= 31 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class MultipleAxesChartData
        {
            public string x;
            public double y;
            public double