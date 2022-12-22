public ActionResult Index()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {

                new PieChartData   { x = "Chrome", y = 100, text= "Chrome (100M)<br>40%", tooltipMappingName= "40%" },
                new PieChartData   { x=" UC Browser", y= 40, text= "UC Browser (40M)<br>16%", tooltipMappingName= "16%" },
                new PieChartData   { x= "Opera" , y= 30, text= "Opera (30M)<br>12%", tooltipMappingName= "12%" },
                new PieChartData    { x= "Safari", y= 30, text= "Safari (30M)<br>12%", tooltipMappingName= "12%" },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class PieChartData
        {
            public string x;
            public double y;
             public string text;
            public string tooltipMappingName;
        }

 