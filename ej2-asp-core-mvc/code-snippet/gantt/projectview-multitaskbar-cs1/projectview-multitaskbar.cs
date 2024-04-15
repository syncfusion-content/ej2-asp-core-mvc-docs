public IActionResult Index()
{
    ViewBag.DataSource = projectViewMultiTaskData();
    return View();
}

 public static List<GanttDataSource> projectViewMultiTaskData()
        {
            List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();

            GanttDataSource Record1 = new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Product Concept",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                isExpand = false,
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Child1 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Defining the product and its usage",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 3,
                Progress = 30
              
            };
            GanttDataSource Child2 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Defining target audience",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                
            };
            GanttDataSource Child3 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Prepare product sketch and notes",
                StartDate = new DateTime(2019, 04, 10),
                Duration = 3,
                Progress = 30
            };
            Record1.SubTasks.Add(Child1);
            Record1.SubTasks.Add(Child2);
            Record1.SubTasks.Add(Child3);

            GanttDataSource Record2 = new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Feedback and Testing",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                isExpand = true,
                SubTasks = new List<GanttDataSource>()
            };
            GanttDataSource Child4 = new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Internal testing and feedback",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 5,
                Progress = 30
            };
            GanttDataSource Child5 = new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "Customer testing and feedback",
                StartDate = new DateTime(2019, 04, 10),
                Duration = 7,
                Progress = 30
            };
            Record2.SubTasks.Add(Child4);
            Record2.SubTasks.Add(Child5);

            GanttDataSource Record3 = new GanttDataSource()
            {
                TaskId = 8,
                TaskName = "Product Development",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                isExpand = false,
                SubTasks = new List<GanttDataSource>()
            };
            GanttDataSource Child6 = new GanttDataSource()
            {
                TaskId = 9,
                TaskName = "Important improvements",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 2,
                Progress = 30
            };
            GanttDataSource Child7 = new GanttDataSource()
            {
                TaskId = 10,
                TaskName = "Address any unforeseen issues",
                StartDate = new DateTime(2019, 04, 06),
                Duration = 2,
                Progress = 30
            };
            Record2.SubTasks.Add(Child6);
            Record2.SubTasks.Add(Child7);

            GanttDataSource Record4 = new GanttDataSource()
            {
                TaskId = 11,
                TaskName = "Final Product",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                isExpand = false,
                SubTasks = new List<GanttDataSource>()
            };
            GanttDataSource Child8 = new GanttDataSource()
            {
                TaskId = 12,
                TaskName = "Branding product",
                StartDate = new DateTime(2019, 04, 06),
                Duration = 5
            };
            GanttDataSource Child9 = new GanttDataSource()
            {
                TaskId = 13,
                TaskName = "Marketing and pre-sales",
                StartDate = new DateTime(2019, 04, 12),
                Duration = 10,
                Progress = 30
            };
            Record2.SubTasks.Add(Child8);
            Record2.SubTasks.Add(Child9);

            GanttDataSourceCollection.Add(Record1);
            GanttDataSourceCollection.Add(Record2);
            GanttDataSourceCollection.Add(Record3);
            GanttDataSourceCollection.Add(Record4);

            return GanttDataSourceCollection;
        }
       
        public class GanttDataSource
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int? Duration { get; set; }
            public DateTime BaselineStartDate { get; set; }
            public DateTime BaselineEndDate { get; set; }
            public int Progress { get; set; }
            public bool isExpand { get; set; }
            public List<GanttDataSource> SubTasks { get; set; }
        }