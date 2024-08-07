public ActionResult Index()
{
    ViewBag.datasource = GetResourceData();
    List<OwnerResource> owners = new List<OwnerResource>();
    owners.Add(new OwnerResource { OwnerText = "Nancy", Id = 1, OwnerColor = "#ffaa00" });
    owners.Add(new OwnerResource { OwnerText = "Steven", Id = 2, OwnerColor = "#f8a398" });
    owners.Add(new OwnerResource { OwnerText = "Michael", Id = 3, OwnerColor = "#7499e1" });
    ViewBag.Owners = owners;

    ViewBag.Resources = new string[] { "Owners" };
    return View();
}

public List<ResourceData> GetResourceData()
{
    List<ResourceData> resourceData = new List<ResourceData>();
    resourceData.Add(new ResourceData
    {
        Id = 1,
        Subject = "Requirement planning",
        StartTime = new DateTime(2023, 4, 3, 10, 0, 0),
        EndTime = new DateTime(2023, 4, 3, 12, 0, 0),
        IsAllDay = false,
        OwnerId = 1
    });
    resourceData.Add(new ResourceData
    {
        Id = 2,
        Subject = "Quality Analysis",
        StartTime = new DateTime(2023, 4, 4, 10, 0, 0),
        EndTime = new DateTime(2023, 4, 4, 12, 0, 0),
        IsAllDay = false,
        OwnerId = 2
    });
    resourceData.Add(new ResourceData
    {
        Id = 3,
        Subject = "Resource planning",
        StartTime = new DateTime(2023, 4, 5, 10, 0, 0),
        EndTime = new DateTime(2023, 4, 5, 12, 0, 0),
        IsAllDay = false,
        OwnerId = 3
    });
    return resourceData;
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
public class OwnerResource
{
    public string OwnerText { set; get; }
    public int Id { set; get; }
    public string OwnerColor { set; get; }
}