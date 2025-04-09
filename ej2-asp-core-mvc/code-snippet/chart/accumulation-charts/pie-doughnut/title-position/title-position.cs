  public ActionResult Pie()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {

                new PieChartData { XValue = "Saudi Arabia",  YValue = 58,  Text = "58%" },
                new PieChartData { XValue = "Persian Gulf",  YValue = 15,  Text = "15%" },
                new PieChartData { XValue = "Canada",        YValue = 13,  Text = "13%" },
                new PieChartData { XValue = "Venezuela",     YValue = 8 ,  Text = "8%" },
                new PieChartData { XValue = "Mexico",        YValue = 3 ,  Text = "3%" },
                new PieChartData { XValue = "Russia",        YValue = 2,   Text = "2%" },
                new PieChartData { XValue = "Miscellaneous", YValue = 1,   Text = "1%" }    
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PieChartData
        {
            public string XValue;
            public double YValue;
            public string Text;
        }