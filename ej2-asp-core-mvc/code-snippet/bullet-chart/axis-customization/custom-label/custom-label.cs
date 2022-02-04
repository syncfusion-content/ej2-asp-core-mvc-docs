public IActionResult Index()
        {
            List<DefaultBulletData> bulletData = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 1500, target = 1300}     
            };
            ViewBag.dataSource = bulletData;
            return View();
        }
        public class DefaultBulletData
        {           
            public double value;
            public double target;
        }