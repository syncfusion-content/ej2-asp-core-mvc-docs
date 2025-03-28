  public ActionResult Pie()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {

                new PieChartData { xValue = "Saudi Arabia", yValue = 58, text = "58%"},
                new PieChartData { xValue = "Persian Gulf", yValue = 15, text = "15%"},
                new PieChartData { xValue = "Canada", yValue = 13, text = "13%"},
                new PieChartData { xValue = "Venezuela", yValue = 8 , text = "8%"},
                new PieChartData { xValue = "Mexico", yValue = 3 , text = "3%"},
                new PieChartData { xValue = "Russia", yValue = 2, text = "2%"},
                new PieChartData { xValue = "Miscellaneous", yValue = 1, text = "1%"}    
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