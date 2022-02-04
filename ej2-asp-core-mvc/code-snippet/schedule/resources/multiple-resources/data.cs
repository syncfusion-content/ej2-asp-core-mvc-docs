public ActionResult Index()
{
    ViewBag.datasource = GetTimelineResourceData();
    // datasource for project resources
    List<ResourceFields> projects = new List<ResourceFields>();
    projects.Add(new ResourceFields { text = "PROJECT 1", id = 1, color = "#cb6bb2" });
    projects.Add(new ResourceFields { text = "PROJECT 2", id = 2, color = "#56ca85" });
    projects.Add(new ResourceFields { text = "PROJECT 3", id = 3, color = "#df5286" });
    ViewBag.Projects = projects;
    // datasource for category resources
    List<ResourceFields> categories = new List<ResourceFields>();
    categories.Add(new ResourceFields { text = "Development", id = 1, color = "#df5286" });
    categories.Add(new ResourceFields { text = "Testing", id = 2, color = "#7fa900" });
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
        CategoryId = 1
    });
    timelineResourceData.Add(new ResourceData
    {
        Id = 2,
        Subject = "Bug Automation",
        StartTime = new DateTime(2018, 4, 4, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 4, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 2,
        CategoryId = 1
    });
    timelineResourceData.Add(new ResourceData
    {
        Id = 3,
        Subject = "Functionality testing",
        StartTime = new DateTime(2018, 4, 5, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 5, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 3,
        CategoryId = 1
    });
    timelineResourceData.Add(new ResourceData
    {
        Id = 4,
        Subject = "Resolution-based testing",
        StartTime = new DateTime(2018, 4, 3, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 3, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 1,
        CategoryId = 2
    });
    timelineResourceData.Add(new ResourceData
    {
        Id = 5,
        Subject = "Test report Validation",
        StartTime = new DateTime(2018, 4, 4, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 4, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 2,
        CategoryId = 2
    });
    timelineResourceData.Add(new ResourceData
    {
        Id = 6,
        Subject = "Test case correction",
        StartTime = new DateTime(2018, 4, 5, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 5, 11, 30, 0),
        IsAllDay = false,
        ProjectId = 3,
        CategoryId = 2
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
    public int CategoryId { get; set; }
}

public class ResourceFields
{
    public string text { set; get; }
    public int id { set; get; }
    public string color { set; get; }
}