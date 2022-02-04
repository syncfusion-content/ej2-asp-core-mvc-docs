public ActionResult Index()
{
    ViewBag.datasource = GetResourceTeamData();
    // datasource for project resources
    List<ProjectResource> projects = new List<ProjectResource>();
    projects.Add(new ProjectResource { text = "PROJECT 1", id = 1, color = "#cb6bb2" });
    projects.Add(new ProjectResource { text = "PROJECT 2", id = 2, color = "#56ca85" });
    ViewBag.Projects = projects;
    // datasource for category resources
    List<CategoryResource> categories = new List<CategoryResource>();
    categories.Add(new CategoryResource { text = "Development", id = 1, groupId = 1, color = "#1aaa55" });
    categories.Add(new CategoryResource { text = "Testing", id = 2, groupId = 2, color = "#7fa900" });
    categories.Add(new CategoryResource { text = "Documentation", id = 3, groupId = 2, color = "#7499e1" });
    ViewBag.Categories = categories;

    ViewBag.Resources = new string[] { "Projects", "Categories" };
    return View();
}

public List<ResourceTeamData> GetResourceTeamData()
{
    List<ResourceTeamData> resourceTeamData = new List<ResourceTeamData>();
    resourceTeamData.Add(new ResourceTeamData
    {
        Id = 1,
        Subject = "Developers Meeting",
        StartTime = new DateTime(2018, 4, 3, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 3, 12, 0, 0),
        RecurrenceRule = "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR",
        ProjectId = 1,
        CategoryId = 1
    });
    resourceTeamData.Add(new ResourceTeamData
    {
        Id = 2,
        Subject = "Test report Validation",
        StartTime = new DateTime(2018, 4, 4, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 4, 12, 0, 0),
        RecurrenceRule = "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,WE,FR",
        ProjectId = 1,
        CategoryId = 3
    });
    resourceTeamData.Add(new ResourceTeamData
    {
        Id = 3,
        Subject = "Requirement planning",
        StartTime = new DateTime(2018, 4, 5, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 5, 12, 0, 0),
        RecurrenceRule = "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR",
        ProjectId = 2,
        CategoryId = 2
    });
    return resourceTeamData;
}
public class ProjectResource
{
    public string text { set; get; }
    public int id { set; get; }
    public string color { set; get; }
}

public class CategoryResource
{
    public string text { set; get; }
    public int id { set; get; }
    public int groupId { set; get; }
    public string color { set; get; }
}

public class ResourceTeamData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int ProjectId { get; set; }
    public int CategoryId { get; set; }
    public string RecurrenceRule { get; set; }
}