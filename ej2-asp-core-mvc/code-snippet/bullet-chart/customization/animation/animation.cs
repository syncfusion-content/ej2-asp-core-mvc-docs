public IActionResult Index()
        {
            List<DefaultBulletData> bulletData = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 55, target = 75}     
            };
            ViewBag.dataSource = bulletData;
            return View();
        }
        public class DefaultBulletData
        {           
            public double value;
            public double target;
        }