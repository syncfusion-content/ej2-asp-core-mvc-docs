public IActionResult Index()
        {
            List<DefaultBulletData> bulletData = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 55, target = 75, category = "Year 1"},
                new DefaultBulletData { value = 70, target = 70, category = "Year 2"},
                new DefaultBulletData { value = 85, target = 75, category = "Year 3"}
            };
            ViewBag.dataSource = bulletData;
            return View();
        }
        public class DefaultBulletData
        {           
            public double value;
            public double target;
            public string category;
        }