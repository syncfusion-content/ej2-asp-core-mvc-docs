public IActionResult Index()
        {
            List<DefaultBulletData> bulletData = new List<DefaultBulletData>
            {
                new DefaultBulletData { value = 270, target = 250}     
            };
            return View(bulletData);
        }
        public class DefaultBulletData
        {           
            public double value;
            public double target;
        }