public ActionResult Index()
        {
            List<WaterfallChartData> chartData = new List<WaterfallChartData>
            {
                new WaterfallChartData { xValue = "Income", yValue = 4711 },
                new WaterfallChartData { xValue = "Sales", yValue = -1015 },
                new WaterfallChartData { xValue = "Development", yValue = -688 },
                new WaterfallChartData { xValue = "Revenue", yValue = 1030 },
                new WaterfallChartData { xValue = "Balance" },
                new WaterfallChartData { xValue = "Expense", yValue = -361 },
                new WaterfallChartData { xValue = "Tax", yValue = -695 },
                new WaterfallChartData { xValue = "Net Profit" },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class WaterfallChartData
        {
            public string xValue;
            public double yValue;
        }