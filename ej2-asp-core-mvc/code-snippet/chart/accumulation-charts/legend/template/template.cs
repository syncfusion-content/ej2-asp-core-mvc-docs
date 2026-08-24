public ActionResult Index()
          {
            
           List<statistics> chartData = new List<Statistics>
            {
                new Statistics { Browser = "Chrome",     Users = 37, Color = "#4472c4" },
                new Statistics { Browser = "UC Browser", Users = 17, Color = "#ed7d31" },
                new Statistics { Browser = "iPhone",     Users = 19, Color = "#a5a5a5" },
                new Statistics { Browser = "Others",     Users = 4,  Color = "#ffc000" },
                new Statistics { Browser = "Opera",      Users = 11, Color = "#5b9bd5" },
                new Statistics { Browser = "Android",    Users = 12, Color = "#70ad47" },
            };

            ViewBag.StatisticsDetails = statistics;
            return View();

        }
        public class PieChartData
        {
            public string xValue;
            public double yValue;
        }

