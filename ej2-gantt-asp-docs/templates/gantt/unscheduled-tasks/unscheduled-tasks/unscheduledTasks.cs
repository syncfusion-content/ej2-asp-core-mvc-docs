public IActionResult Index()
{
    ViewBag.DataSource = ganttData();
    return View();
}

 public static List<GanttDataSource> ganttData()
        {
            List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();
            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Project initiation",
                Duration = 4
            });
            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Identify site location",
                StartDate = new DateTime(2019, 04, 02)
            });
            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                EndDate = new DateTime(2019, 04, 08)
            });

            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 06),
                Progress=50
            });
            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Project estimation",
                Duration=0
            });
            return GanttDataSourceCollection;
        }

        public class GanttDataSource
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public int? Duration { get; set; }
            public int Progress { get; set; }

        }