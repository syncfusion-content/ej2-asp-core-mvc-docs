public ActionResult Index()
{
    ViewBag.datasource = GetEventsData();
    List<OwnerRes> owners = new List<OwnerRes>();
    owners.Add(new OwnerRes { text = "Nancy", id = 1, color = "#1aaa55" });
    owners.Add(new OwnerRes { text = "Smith", id = 2, color = "#7fa900" });
    owners.Add(new OwnerRes { text = "Paul", id = 3, color = "#357cd2" });
    ViewBag.Owners = owners;
    string[] resources = new string[] { "Owners" };
    ViewBag.Resources = resources;
    return View();
}

public class OwnerRes
{
    public string text { set; get; }
    public int id { set; get; }
    public string color { set; get; }
}

public List<EventsData> GetEventsData()
{
    List<EventsData> eventsData = new List<EventsData>();
    eventsData.Add(new EventsData
    {
        Id = 1,
        Subject = "Surgery - Nancy",
        StartTime = new DateTime(2018, 2, 11, 10, 0, 0),
        EndTime = new DateTime(2018, 2, 11, 12, 0, 0),
        EventType = "Confirmed",
        OwnerId = 1
    });
    eventsData.Add(new EventsData
    {
        Id = 2,
        Subject = "Therapy - Smith",
        StartTime = new DateTime(2018, 2, 12, 10, 0, 0),
        EndTime = new DateTime(2018, 2, 12, 12, 0, 0),
        EventType = "New",
        OwnerId = 2
    });
    eventsData.Add(new EventsData
    {
        Id = 3,
        Subject = "Surgery - Paul",
        StartTime = new DateTime(2018, 2, 13, 10, 0, 0),
        EndTime = new DateTime(2018, 2, 13, 12, 0, 0),
        EventType = "Requested",
        OwnerId = 3
    });
    return eventsData;
}

public class EventsData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string EventType { get; set; }
    public int OwnerId { get; set; }
}