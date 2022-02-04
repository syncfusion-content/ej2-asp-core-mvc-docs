public ActionResult Index()
{
    ViewBag.datasource = GetResourceData();
    // datasource for room resources
    List<RoomResource> rooms = new List<RoomResource>();
    rooms.Add(new RoomResource { RoomText = "ROOM 1", Id = 1, RoomColor = "#cb6bb2" });
    rooms.Add(new RoomResource { RoomText = "ROOM 2", Id = 2, RoomColor = "#56ca85" });
    ViewBag.Rooms = rooms;
    // datasource for owner resources
    List<OwnerResource> owners = new List<OwnerResource>();
    owners.Add(new OwnerResource { OwnerText = "Nancy", Id = 1, OwnerGroupId = 1, OwnerColor = "#ffaa00" });
    owners.Add(new OwnerResource { OwnerText = "Steven", Id = 2, OwnerGroupId = 2, OwnerColor = "#f8a398" });
    owners.Add(new OwnerResource { OwnerText = "Michael", Id = 3, OwnerGroupId = 1, OwnerColor = "#7499e1" });
    ViewBag.Owners = owners;

    ViewBag.Resources = new string[] { "Rooms", "Owners" };
    return View();
}

public List<ResourceData> GetResourceData()
{
    List<ResourceData> resourceData = new List<ResourceData>();
    resourceData.Add(new ResourceData
    {
        Id = 1,
        Subject = "Requirement planning",
        StartTime = new DateTime(2021, 7, 4, 9, 30),
        EndTime = new DateTime(2021, 7, 4, 12, 0),
        IsAllDay = false,
        OwnerId = 1,
        RoomId = 1
    });
    resourceData.Add(new ResourceData
    {
        Id = 2,
        Subject = "Quality Analysis",
        StartTime = new DateTime(2021, 7, 4, 10, 30),
        EndTime = new DateTime(2021, 7, 4, 14, 0),
        IsAllDay = false,
        OwnerId = 3,
        RoomId = 1
    });
    resourceData.Add(new ResourceData
    {
        Id = 3,
        Subject = "Resource planning",
        StartTime = new DateTime(2021, 7, 5, 10, 0),
        EndTime = new DateTime(2021, 7, 5, 12, 30),
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

public class RoomResource
{
    public string RoomText { set; get; }
    public int Id { set; get; }
    public string RoomColor { set; get; }
}
public class OwnerResource
{
    public string OwnerText { set; get; }
    public int Id { set; get; }
    public string OwnerColor { set; get; }
    public int OwnerGroupId { set; get; }
}