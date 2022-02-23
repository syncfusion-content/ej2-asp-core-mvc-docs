public ActionResult Index()
{
    ViewBag.datasource = GetResourceData();
    List<OwnerResources> owners = new List<OwnerResources>();
    owners.Add(new OwnerResources { OwnerText = "Nancy", Id = 1, OwnerColor = "#ffaa00" });
    owners.Add(new OwnerResources { OwnerText = "Steven", Id = 2, OwnerColor = "#f8a398" });
    owners.Add(new OwnerResources { OwnerText = "Michael", Id = 3, OwnerColor = "#7499e1" });
    ViewBag.Owners = owners;
    return View();
}

public List<ResourceData> GetResourceData()
{
    List<ResourceData> resourceData = new List<ResourceData>();
    resourceData.Add(new ResourceData
    {
        Id = 1,
        Subject = "Workflow Analysis",
        StartTime = new DateTime(2018, 4, 3, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 3, 13, 0, 0),
        IsAllDay = false,
        OwnerId = 1
    });
    resourceData.Add(new ResourceData
    {
        Id = 2,
        Subject = "Requirement planning",
        StartTime = new DateTime(2018, 4, 4, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 4, 13, 0, 0),
        IsAllDay = false,
        OwnerId = 2
    });
    resourceData.Add(new ResourceData
    {
        Id = 3,
        Subject = "Quality Analysis",
        StartTime = new DateTime(2018, 4, 5, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 5, 13, 0, 0),
        IsAllDay = false,
        OwnerId = 3
    });
    return resourceData;
}

public class OwnerResources
{
    public string OwnerText { set; get; }
    public int Id { set; get; }
    public string OwnerColor { set; get; }
}

public class ResourceData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsAllDay { get; set; }
    public int OwnerId { get; set; }
}