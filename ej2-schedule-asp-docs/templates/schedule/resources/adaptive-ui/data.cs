public ActionResult Index()
{
    ViewBag.datasource = GetTimelineResourceData();
    // datasource for project resources
    List<ResourceDataSourceModel> projects = new List<ResourceDataSourceModel>();
    projects.Add(new ResourceDataSourceModel { text = "PROJECT 1", id = 1, color = "#cb6bb2" });
    projects.Add(new ResourceDataSourceModel { text = "PROJECT 2", id = 2, color = "#56ca85" });
    projects.Add(new ResourceDataSourceModel { text = "PROJECT 3", id = 3, color = "#df5286" });
    ViewBag.Projects = projects;
    // datasource for category resources

    List<ResourceDataSourceModel> categories = new List<ResourceDataSourceModel>();
    categories.Add(new ResourceDataSourceModel { text = "Nancy", id = 1, groupId = 1, color = "#df5286" });
    categories.Add(new ResourceDataSourceModel { text = "Steven", id = 2, groupId = 1, color = "#7fa900" });
    categories.Add(new ResourceDataSourceModel { text = "Robert", id = 3, groupId = 2, color = "#ea7a57" });
    categories.Add(new ResourceDataSourceModel { text = "Smith", id = 4, groupId = 2, color = "#5978ee" });
    categories.Add(new ResourceDataSourceModel { text = "Michael", id = 5, groupId = 3, color = "#df5286" });
    categories.Add(new ResourceDataSourceModel { text = "Root", id = 6, groupId = 3, color = "#00bdae" });

    ViewBag.Categories = categories;

    ViewBag.Resources = new string[] { "Projects", "Categories" };
    return View();
}

public List<ResourceData> GetTimelineResourceData()
{
    List<ResourceData> timelineResourceData = new List<ResourceData>();
    timelineResourceData.Add(new ResourceData
    {
        Id = 1,
        Subject = "Decoding",
        StartTime = new DateTime(2018, 4, 3, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 3, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 1,
        TaskId = 1
    });
    timelineResourceData.Add(new ResourceData
    {
        Id = 2,
        Subject = "Bug Automation",
        StartTime = new DateTime(2018, 4, 4, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 4, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 2,
        TaskId = 1
    });
    timelineResourceData.Add(new ResourceData
    {
        Id = 3,
        Subject = "Functionality testing",
        StartTime = new DateTime(2018, 4, 5, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 5, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 3,
        TaskId = 1
    });
    timelineResourceData.Add(new ResourceData
    {
        Id = 4,
        Subject = "Resolution-based testing",
        StartTime = new DateTime(2018, 4, 3, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 3, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 1,
        TaskId = 2
    });
    timelineResourceData.Add(new ResourceData
    {
        Id = 5,
        Subject = "Test report Validation",
        StartTime = new DateTime(2018, 4, 4, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 4, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 2,
        TaskId = 2
    });
    timelineResourceData.Add(new ResourceData
    {
        Id = 6,
        Subject = "Test case correction",
        StartTime = new DateTime(2018, 4, 5, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 5, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 3,
        TaskId = 2
    });
    return timelineResourceData;
}


public class ResourceData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsAllDay { get; set; }
    public int ProjectId { get; set; }
    public int TaskId { get; set; }
}

public class ResourceDataSourceModel
{
    public string text { set; get; }
    public int id { set; get; }
    public string color { set; get; }
    public int groupId { set; get; }
}