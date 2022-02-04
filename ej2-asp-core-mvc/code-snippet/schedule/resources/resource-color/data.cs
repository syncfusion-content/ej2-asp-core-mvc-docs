public ActionResult Index()
{
    ViewBag.datasource = GetResourceTeamData();
    // datasource for Room resources
    List<RoomResources> rooms = new List<RoomResources>();
    rooms.Add(new RoomResources { RoomText = "ROOM 1", Id = 1, RoomGroupId = 1, RoomColor = "#cb6bb2" });
    rooms.Add(new RoomResources { RoomText = "ROOM 2", Id = 2, RoomGroupId = 2, RoomColor = "#56ca85" });
    ViewBag.Rooms = rooms;
    // datasource for Owner resources
    List<OwnerResources> owners = new List<OwnerResources>();
    owners.Add(new OwnerResources { OwnerText = "Nancy", Id = 1, OwnerGroupId = 1, OwnerColor = "#1aaa55" });
    owners.Add(new OwnerResources { OwnerText = "Steven", Id = 2, OwnerGroupId = 2, OwnerColor = "#7fa900" });
    ViewBag.Owners = owners;
    // Scheduler resource names
    ViewBag.Resources = new string[] { "Rooms", "Owners" };
    // Scheduler views
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Week },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Month },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineWeek },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineMonth },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Agenda }
    };
    ViewBag.view = viewOption;
    return View();
}

public List<ResourceData> GetResourceTeamData()
{
    List<ResourceData> resourceTeamData = new List<ResourceData>();
    resourceTeamData.Add(new ResourceData
    {
        Id = 1,
        Subject = "Decoding",
        StartTime = new DateTime(2018, 4, 3, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 3, 11, 30, 0),
        IsAllDay = false,
        RoomId = 1,
        OwnerId = 1
    });
    resourceTeamData.Add(new ResourceData
    {
        Id = 2,
        Subject = "Bug Automation",
        StartTime = new DateTime(2018, 4, 4, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 4, 11, 30, 0),
        IsAllDay = false,
        RoomId = 2,
        OwnerId = 2
    });
    return resourceTeamData;
}


public class ResourceData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsAllDay { get; set; }
    public int RoomId { get; set; }
    public int OwnerId { get; set; }
}

public class RoomResources
{
    public string RoomText { set; get; }
    public int Id { set; get; }
    public int RoomGroupId { set; get; }
    public string RoomColor { set; get; }
}
public class OwnerResources
{
    public string OwnerText { set; get; }
    public int Id { set; get; }
    public int OwnerGroupId { set; get; }
    public string OwnerColor { set; get; }
}