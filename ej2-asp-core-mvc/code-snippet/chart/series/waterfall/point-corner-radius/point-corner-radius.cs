public ActionResult Index()
    {
        List<WaterfallChartData> chartData = new List<WaterfallChartData>
        {
            new WaterfallChartData { X = "Income", Y = 4711 },
            new WaterfallChartData { X = "Sales", Y = -1015 },
            new WaterfallChartData { X = "Development", Y = -688 },
            new WaterfallChartData { X = "Revenue", Y = 1030 },
            new WaterfallChartData { X = "Balance" },
            new WaterfallChartData { X = "Administrative", Y = -780 },
            new WaterfallChartData { X = "Expense", Y = -361 },
            new WaterfallChartData { X = "Tax", Y = -695 },
            new WaterfallChartData { X = "Net Profit" }
        };
        ViewBag.dataSource = chartData;
        ViewData["intermediateSumIndexes"] = new int[] {4};
        ViewData["sumIndexes"] = new int[] {8};
        return View();
    }
    public class WaterfallChartData
    {
        public string X;
        public double Y;
    }