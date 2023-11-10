public ActionResult Index()
        {
           List<PieChartData> chartData = new List<PieChartData>
            {

                new PieChartData { xValue = "Chrome", yValue = 37, text = "37%"},
                new PieChartData { xValue = "UC Browser", yValue = 17, text = "17%"},
                new PieChartData { xValue = "iPhone", yValue = 19, text = "19%"},
                new PieChartData { xValue = "Others", yValue = 4 , text = "4%"}
            };
            ViewBag.dataSource = chartData;
             return View();
        }
         public class PieChartData
        {
            public string xValue;
            public double yValue;
            public string text;
        }

 