public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DataSource = new List<GanttDataSource>();
            return View();
        }

        public class GanttDataSource
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int? Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public List<GanttDataSource> SubTasks { get; set; }
        }

    }