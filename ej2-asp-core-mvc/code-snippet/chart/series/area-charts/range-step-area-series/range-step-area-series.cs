public IActionResult Index () 
        {
            List<ChartData> chartData = new List<ChartData>
            {
                new ChartData { x = "Jan", high1 = 29, low1 = 19 },
                new ChartData { x = "Feb", high1 = 32, low1 = 22 },
                new ChartData { x = "Mar", high1 = 35, low1 = 25 },
                new ChartData { x = "Apr", high1 = 37, low1 = 27 },
                new ChartData { x = "May", high1 = 35, low1 = 25 },
                new ChartData { x = "Jun", high1 = 32, low1 = 22 },
                new ChartData { x = "Jul", high1 = 30, low1 = 20 },
                new ChartData { x = "Aug", high1 = 32, low1 = 22 },
                new ChartData { x = "Sep", high1 = 35, low1 = 25 },
                new ChartData { x = "Oct", high1 = 37, low1 = 27 },
                new ChartData { x = "Nov", high1 = 35, low1 = 25 },
                new ChartData { x = "Dec", high1 = 32, low1 = 22 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class ChartData
        {
            public string x;
            public double high1;
            public double low1;
        }