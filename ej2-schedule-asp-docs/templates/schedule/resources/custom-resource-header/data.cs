public ActionResult Index()
{
    ViewBag.datasource = GetRoomData();

    List<RoomResource> rooms = new List<RoomResource>();
    rooms.Add(new RoomResource { name = "Jammy", id = 1, color = "#ea7a57", capacity = 20, type = "Conference" });
    rooms.Add(new RoomResource { name = "Tweety", id = 2, color = "#7fa900", capacity = 7, type = "Cabin" });
    rooms.Add(new RoomResource { name = "Nestle", id = 3, color = "#5978ee", capacity = 5, type = "Cabin" });
    rooms.Add(new RoomResource { name = "Phoenix", id = 4, color = "#fec200", capacity = 15, type = "Conference" });
    rooms.Add(new RoomResource { name = "Mission", id = 5, color = "#df5286", capacity = 25, type = "Conference" });
    rooms.Add(new RoomResource { name = "Hangout", id = 6, color = "#00bdae", capacity = 10, type = "Cabin" });
    rooms.Add(new RoomResource { name = "Rick Roll", id = 7, color = "#865fcf", capacity = 20, type = "Conference" });
    rooms.Add(new RoomResource { name = "Rainbow", id = 8, color = "#1aaa55", capacity = 8, type = "Cabin" });
    rooms.Add(new RoomResource { name = "Swarm", id = 9, color = "#df5286", capacity = 30, type = "Conference" });
    rooms.Add(new RoomResource { name = "Photogenic", id = 10, color = "#710193", capacity = 25, type = "Conference" });
    ViewBag.RoomDatas = rooms;

    string[] resources = new string[] { "MeetingRoom" };
    ViewBag.ResourceNames = resources;
    return View();
}

public class RoomResource
{
    public int id { set; get; }
    public string name { set; get; }
    public string color { set; get; }
    public int capacity { set; get; }
    public string type { set; get; }
}


public List<RoomData> GetRoomData()
{
    List<RoomData> roomData = new List<RoomData>();
    roomData.Add(new RoomData
    {
        Id = 1,
        Subject = "Board Meeting",
        Description = "Meeting to discuss business goal of 2018.",
        StartTime = new DateTime(2018, 7, 30, 9, 0, 0),
        EndTime = new DateTime(2018, 7, 30, 11, 0, 0),
        RoomId = 1
    });
    roomData.Add(new RoomData
    {
        Id = 2,
        Subject = "Training session on JSP",
        Description = "Knowledge sharing on JSP topics.",
        StartTime = new DateTime(2018, 7, 30, 15, 0, 0),
        EndTime = new DateTime(2018, 7, 30, 17, 0, 0),
        RoomId = 3
    });
    roomData.Add(new RoomData
    {
        Id = 3,
        Subject = "Sprint Planning with Team members",
        Description = "Planning tasks for sprint.",
        StartTime = new DateTime(2018, 7, 30, 9, 30, 0),
        EndTime = new DateTime(2018, 7, 30, 11, 0, 0),
        RoomId = 5
    });
    return roomData;
}

public class RoomData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int RoomId { get; set; }
}