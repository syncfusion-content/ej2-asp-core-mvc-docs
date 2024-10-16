public ActionResult Index()
        {
            List<AxisLabelData> chartData = new List<AxisLabelData>
            {
                new AxisLabelData { x= "South Korea", y= 39.4 },
                new AxisLabelData { x= "India", y= 61.3 }, 
                new AxisLabelData { x= "Pakistan", y= 20.4 },
                new AxisLabelData { x= "Germany", y= 65.1 }, 
                new AxisLabelData { x= "Australia", y= 15.8 },
                new AxisLabelData { x= "Italy", y= 29.2 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class AxisLabelData
        {
            public string x;
            public double y;
        }