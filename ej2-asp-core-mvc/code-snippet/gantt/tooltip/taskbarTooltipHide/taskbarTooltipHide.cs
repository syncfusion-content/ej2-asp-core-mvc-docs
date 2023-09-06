public IActionResult Index()
{
    ViewBag.DataSource = ProjectNewData();
    return View();
}

public static List<GanttDataSource> ProjectNewData()
{
    List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();

    GanttDataSource Record1 = new GanttDataSource()
    {
        TaskId = 1,
        TaskName = "Project initiation",
        StartDate = new DateTime(2019, 04, 02),
        EndDate = new DateTime(2019, 04, 21),
        SubTasks = new List<GanttDataSource>(),
    };
	GanttDataSource Child1 = new GanttDataSource()
    {
        TaskId = 2,
        TaskName = "Identify site location",
        StartDate = new DateTime(2019, 04, 02),
        BaselineStartDate = new DateTime(2019, 04, 02),
        BaselineEndDate = new DateTime(2019, 04, 02),
        Duration = 0,
        Progress = 70,

    };
    GanttDataSource Child2 = new GanttDataSource()
    {
        TaskId = 3,
        TaskName = "Perform soil test",
        StartDate = new DateTime(2019, 04, 02),
        BaselineStartDate = new DateTime(2019, 04, 04),
        BaselineEndDate = new DateTime(2019, 04, 09),
        Duration = 8,
        Progress = 50

    };
	GanttDataSource Child3 = new GanttDataSource()
    {
        TaskId = 4,
        TaskName = "Soil test approval",
        StartDate = new DateTime(2019, 04, 02),
        BaselineStartDate = new DateTime(2019, 04, 08),
        BaselineEndDate = new DateTime(2019, 04, 12),
        Duration = 4,
        Progress = 50
    };
    Record1.SubTasks.Add(Child1);
    Record1.SubTasks.Add(Child2);
    Record1.SubTasks.Add(Child3);

    GanttDataSource Record2 = new GanttDataSource()
    {
        TaskId = 5,
		TaskName = "Project estimation",
        StartDate = new DateTime(2019, 04, 02),
        EndDate = new DateTime(2019, 04, 21),
        SubTasks = new List<GanttDataSource>()
    };
    GanttDataSource Child4 = new GanttDataSource()
    {
        TaskId = 6,
        TaskName = "Develop floor plan for estimation",
        StartDate = new DateTime(2019, 04, 04),
        BaselineStartDate = new DateTime(2019, 04, 08),
        BaselineEndDate = new DateTime(2019, 04, 12),
        Duration = 4,
        Progress = 70
    };
    GanttDataSource Child5 = new GanttDataSource()
    {
        TaskId = 7,
        TaskName = "List materials",
        StartDate = new DateTime(2019, 04, 04),
        BaselineStartDate = new DateTime(2019, 04, 02),
        BaselineEndDate = new DateTime(2019, 04, 02),
        Duration = 0,
        Progress = 50
    };
    Record2.SubTasks.Add(Child4);
    Record2.SubTasks.Add(Child5);

	GanttDataSourceCollection.Add(Record1);
	GanttDataSourceCollection.Add(Record2);

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
	public string Dependency { get; set; }
    public List<GanttDataSource> SubTasks { get; set; }
}