  public ActionResult Index()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {

                new PieData { xValue =  "Chrome", yValue = 37, text = "37%" },
                new PieData { xValue =  "UC Browser", yValue = 17, text = "17%" },
                new PieData { xValue =  "iPhone", yValue = 19, text = "19%" },
                new PieData { xValue =  "Others", yValue = 4, text = "4%" },
                new PieData { xValue =  "Opera", yValue = 11, text = "11%" },
                new PieData { xValue =  "Android", yValue = 12, text = "12%" },   

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

