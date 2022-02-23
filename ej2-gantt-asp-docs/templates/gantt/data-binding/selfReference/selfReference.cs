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
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                ParentId = null
            });
            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Identify site location",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 4,
                Progress = 70,
                ParentId = 1
            });
            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 4,
                Progress = 50,
                ParentId = 1
            });

            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 4,
                Progress = 50,
                ParentId = 1
            });
            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Project estimation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                ParentId = null
            });
            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Develop floor plan for estimation",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Progress = 70,
                ParentId = 5
            });
            GanttDataSourceCollection.Add(new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "List materials",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Progress = 50,
                ParentId = 5
            });
            return GanttDataSourceCollection;
        }
        
        public class GanttDataSource
        {
            public int TaskId { get; set; }
            public int? ParentId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int? Duration { get; set; }
            public int Progress { get; set; }
           
        }