public IActionResult Index()
        {
            List <data> dataSource = new List<data>
            {
                new data {  y = 12, y1 = 28 },
                new data {  y = 100, y1 = 44 },
                new data {  y = 500, y1 = 48 },
                new data {  y = 1000, y1 = 50 },
                new data {  y = 5000, y1 = 66 },
                new data {  y = 7000, y1 = 78 },
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