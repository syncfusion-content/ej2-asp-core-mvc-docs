public IActionResult Index()
{
    ViewBag.DataSource = FirstData();
    return View();
}
public static List<GanttDataSource> FirstData()
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
        Duration = 4,
        Progress = 90
    };
    GanttDataSource Child2 = new GanttDataSource()
    {
        TaskId = 3,
        TaskName = "Perform soil test",
        StartDate = new DateTime(2019, 04, 02),
        Duration = 4,
        Progress = 40
    };
    GanttDataSource Child3 = new GanttDataSource()
    {
        TaskId = 4,
        TaskName = "Soil test approval",
        StartDate = new DateTime(2019, 04, 02),
        Duration = 4,
        Progress = 10
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
        SubTasks = new List<GanttDataSource>(),
    };
    GanttDataSource Child4 = new GanttDataSource()
    {
        TaskId = 6,
        TaskName = "Develop floor plan for estimation",
        StartDate = new DateTime(2019, 04, 04),
        Duration = 3,
        Progress = 85
    };
    GanttDataSource Child5 = new GanttDataSource()
    {
        TaskId = 7,
        TaskName = "List materials",
        StartDate = new DateTime(2019, 04, 04),
        Duration = 3,
        Progress = 15
    };
    GanttDataSource Child6 = new GanttDataSource()
    {
        TaskId = 8,
        TaskName = "Estimation approval",
        StartDate = new DateTime(2019, 04, 04),
        Duration = 3,
        Progress = 70
    };
    Record2.SubTasks.Add(Child4);
    Record2.SubTasks.Add(Child5);
    Record2.SubTasks.Add(Child6);

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
    public int Progress { get; set; }
    public List<GanttDataSource> SubTasks { get; set; }
}