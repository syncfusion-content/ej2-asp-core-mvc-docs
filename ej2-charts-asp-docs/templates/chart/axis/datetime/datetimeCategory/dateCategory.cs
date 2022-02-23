public ActionResult Index()
        {
            List<LineChartData> chartData = new List<LineChartData>
            {
              new LineChartData{ x= new DateTime(2017, 11, 20), y= 21 },
              new LineChartData{ x= new DateTime(2017, 11, 21), y= 24 },
              new LineChartData{ x= new DateTime(2017, 11, 22), y= 24 },
              new LineChartData{ x= new DateTime(2017, 11, 26), y= 70 },
              new LineChartData{ x= new DateTime(2017, 11, 27), y= 75 }, 
              new LineChartData{ x= new DateTime(2018, 0, 2), y= 82 },
              new LineChartData{ x= new DateTime(2018, 0, 3), y= 53 },
              new LineChartData{ x= new DateTime(2018, 0, 4), y= 54 },
              new LineChartData{ x= new DateTime(2018, 0, 5), y= 53 },
              new LineChartData{ x= new DateTime(2018, 0, 8), y= 45 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class LineChartData
        {
            public DateTime x;
            public double y;
        }