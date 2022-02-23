public ActionResult Index()
{
    ViewBag.datasource = GetResourceData();
    // datasource for owner resources
    List<OwnerResource> owners = new List<OwnerResource>();
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
        StartTime = new DateTime(2018, 4, 1, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 1, 12, 0, 0),
        IsAllDay = false,
        OwnerId = 1,
        RoomId = 1
    });
    resourceData.Add(new ResourceData
    {
        Id = 2,
        Subject = "Quality Analysis",
        StartTime = new DateTime(2018, 4, 1, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 1, 12, 0, 0),
        IsAllDay = false,
        OwnerId = 3,
        RoomId = 1
    });
    resourceData.Add(new ResourceData
    {
        Id = 3,
        Subject = "Resource planning",
        StartTime = new DateTime(2018, 4, 1, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 1, 12, 0, 0),
        IsAllDay = false,
        OwnerId = 2,
        RoomId = 2
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
    public int RoomId { get; set; }
}


public class OwnerResource
{
    public string OwnerText { set; get; }
    public int Id { set; get; }
    public string OwnerColor { set; get; }
    public int OwnerGroupId { set; get; }
}