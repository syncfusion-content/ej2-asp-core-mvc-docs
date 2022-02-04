 public ActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public ActionResult GetServerData()
        {
            List<LineChart> data1 = new List<LineChart>();
            data1.Add(new LineChart("India", 1));
            data1.Add(new LineChart("USA", 5));
            data1.Add(new LineChart("USSR", 10));
            data1.Add(new LineChart("Chinaa", 12));
            data1.Add(new LineChart("Japan", 8));
            return Json(data1);
        }

        public class LineChart
        {
            public LineChart(string name, double cnt)
            {
                this.x = name;
                this.y = cnt;
            }
            public string x { get; set; }
            public double y { get; set; }
        }
