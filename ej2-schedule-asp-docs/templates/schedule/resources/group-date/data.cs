public ActionResult Index()
{
    ViewBag.datasource = GetResourceData();
    List<OwnerResource> owners = new List<OwnerResource>();
    owners.Add(new OwnerResource { text = "Alice", id = 1, color = "#ffaa00" });
    owners.Add(new OwnerResource { text = "Smith", id = 2, color = "#f8a398" });
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
        StartTime = new DateTime(2018, 4, 3, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 3, 12, 0, 0),
        IsAllDay = false,
        OwnerId = 1
    });
    resourceData.Add(new ResourceData
    {
        Id = 2,
        Subject = "Quality Analysis",
        StartTime = new DateTime(2018, 4, 4, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 4, 12, 0, 0),
        IsAllDay = false,
        OwnerId = 2
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
    public string text { set; get; }
    public int id { set; get; }
    public string color { set; get; }
}