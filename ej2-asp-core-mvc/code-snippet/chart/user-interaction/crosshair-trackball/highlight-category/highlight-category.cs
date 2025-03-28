public ActionResult Index()
        {
            List<HighLightCategoryData> chartData = new List<HighLightCategoryData>
            {
                new HighLightCategoryData { Country = "USA",       Gold = 50 },
                new HighLightCategoryData { Country = "China",     Gold = 40 },
                new HighLightCategoryData { Country = "Japan",     Gold = 70 },
                new HighLightCategoryData { Country = "Australia", Gold = 60 },
                new HighLightCategoryData { Country = "France",    Gold = 50 },
                new HighLightCategoryData { Country = "Germany",   Gold = 40 },
                new HighLightCategoryData { Country = "Italy",     Gold = 40 },
                new HighLightCategoryData { Country = "Sweden",    Gold = 30 }
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class HighLightCategoryData
        {
            public string Country;
            public double Gold;
        }