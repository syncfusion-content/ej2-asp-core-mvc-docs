public IActionResult Index()
        {
            List<DefaultBulletData> bulletData = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 5, comparativeMeasureValue = 7.5, category= "2001"},
                new DefaultBulletData { value = 7, comparativeMeasureValue = 5, category= "2002"},
                new DefaultBulletData { value = 10, comparativeMeasureValue = 6, category= "2003"},
                new DefaultBulletData { value = 5, comparativeMeasureValue = 8, category= "2004"},
                new DefaultBulletData { value = 12, comparativeMeasureValue = 5, category= "2005"},
                new DefaultBulletData { value = 8, comparativeMeasureValue = 6, category= "2006"}
            };
            ViewBag.dataSource = bulletData;
            return View();
        }
        public class DefaultBulletData
        {           
            public double value;
            public double comparativeMeasureValue;
            public string category;
        }