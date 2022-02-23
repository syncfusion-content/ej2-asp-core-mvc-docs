public IActionResult Index()
        {
            List<DefaultBulletData> bulletData = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 23, target = 22}     
            };
            ViewBag.dataSource = bulletData;
            return View();
        }
        public class DefaultBulletData
        {           
            public double value;
            public double target;
        }