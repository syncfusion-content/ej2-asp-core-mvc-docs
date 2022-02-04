public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    List<RoomData> rooms = new List<RoomData>();
    rooms.Add(new RoomData { name = "Room A", id = 1, color = "#98AFC7" });
    rooms.Add(new RoomData { name = "Room B", id = 2, color = "#99c68e" });
    rooms.Add(new RoomData { name = "Room C", id = 3, color = "#C2B280" });
    rooms.Add(new RoomData { name = "Room D", id = 4, color = "#3090C7" });
    rooms.Add(new RoomData { name = "Room E", id = 5, color = "#95b9" });
    rooms.Add(new RoomData { name = "Room F", id = 6, color = "#95b9c7" });
    rooms.Add(new RoomData { name = "Room G", id = 7, color = "#deb887" });
    rooms.Add(new RoomData { name = "Room H", id = 8, color = "#3090C7" });
    rooms.Add(new RoomData { name = "Room I", id = 9, color = "#98AFC7" });
    rooms.Add(new RoomData { name = "Room J", id = 10, color = "#778899" });
    ViewBag.RoomDatas = rooms;
    string[] resources = new string[] { "MeetingRoom" };
    ViewBag.ResourceNames = resources;
    return View();
}

public class RoomData
{
    public int id { set; get; }
    public string name { set; get; }
    public string color { set; get; }
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    { Id = 1, Subject = "Explosion of Betelgeuse Star", StartTime = new DateTime(2018, 2, 11, 9, 30, 0), EndTime = new DateTime(2018, 2, 11, 11, 0, 0), RoomId = 1 });
    appData.Add(new AppointmentData
    { Id = 2, Subject = "Thule Air Crash Report", StartTime = new DateTime(2018, 2, 11, 9, 30, 0), EndTime = new DateTime(2018, 2, 11, 11, 0, 0), RoomId = 1 });
    appData.Add(new AppointmentData
    { Id = 3, Subject = "Blue Moon Eclipse", StartTime = new DateTime(2018, 2, 11, 9, 30, 0), EndTime = new DateTime(2018, 2, 11, 11, 0, 0), RoomId = 1 });
    appData.Add(new AppointmentData
    { Id = 4, Subject = "Meteor Showers in 2018", StartTime = new DateTime(2018, 2, 11, 9, 30, 0), EndTime = new DateTime(2018, 2, 11, 11, 0, 0), RoomId = 1 });
    appData.Add(new AppointmentData
    { Id = 5, Subject = "Milky Way as Melting pot", StartTime = new DateTime(2018, 2, 11, 9, 0, 0), EndTime = new DateTime(2018, 2, 11, 11, 30, 0), RoomId = 2 });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int RoomId { get; set; }
}