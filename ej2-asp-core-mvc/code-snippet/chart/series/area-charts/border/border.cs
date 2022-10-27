 public ActionResult Index()
        {
            List<AxisLabelData> chartData = new List<AxisLabelData>
            {
             new AxisLabelData { x= "South Korea", y= 39.4, color="red" },
             new AxisLabelData { x= "India", y= 61.3, color="green" }, 
             new AxisLabelData { x= "Pakistan", y= 20.4, color="#ff0097" },
             new AxisLabelData { x= "Germany", y= 65.1, color="crimson" }, 
             new AxisLabelData { x= "Australia", y= 15.8, color="blue" },
             new AxisLabelData { x= "Italy", y= 29.2, color="darkorange" },
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class AxisLabelData
{
            public string x;
            public double y;
            public string color;
        }