        public IActionResult Index()
        {
            List<RangeColorMappingData> chartData = new List<RangeColorMappingData>
            {
                  new RangeColorMappingData { x= "Jan", y= 6.96, color= "red" },
                  new RangeColorMappingData { x= "Feb", y= 8.9, color = "blue" },
                  new RangeColorMappingData { x= "Mar", y= 12, color = "orange" },
                  new RangeColorMappingData { x= "Apr", y= 17.5, color = "aqua" },
                  new RangeColorMappingData { x= "May", y= 22.1, color = "grey" }
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public class RangeColorMappingData
        {
            public string x;
            public double y;
            public string color;
        }