public IActionResult Index()
        {
            List <data>dataSource = new List<data>
            {
                new data {  y = 12, y1 = 28 },
                new data {  y = 34, y1 = 44 },
                new data {  y = 45, y1 = 48 },
                new data {  y = 56, y1 = 50 },
                new data {  y = 67, y1 = 66 },
                new data {  y = 78, y1 = 78 },
                new data {  y = 89, y1 = 84 },
            };
            ViewBag.dataSource = dataSource;
            return View();
        }
        public class data
        {            
            public double y;
            public double y1;
        }