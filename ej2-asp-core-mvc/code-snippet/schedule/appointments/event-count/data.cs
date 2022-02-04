public ActionResult Index()
{
    ViewBag.datasource = GetEventsData();
    return View();
}

public List<EventsData> GetEventsData()
{
    List<EventsData> eventsData = new List<EventsData>();
    eventsData.Add(new EventsData
    {
        Id = 1,
        Subject = "Server Maintenance",
        StartTime = new DateTime(2018, 2, 14, 10, 0, 0),
        EndTime = new DateTime(2018, 2, 14, 11, 30, 0),
        EventType = "maintenance",
        City = "Seattle",
        CategoryColor = "#1aaa55"
    });
    eventsData.Add(new EventsData
    {
        Id = 2,
        Subject = "Art & Painting Gallery",
        StartTime = new DateTime(2018, 2, 15, 12, 0, 0),
        EndTime = new DateTime(2018, 2, 15, 14, 0, 0),
        EventType = "public-event",
        City = "Costa Rica",
        CategoryColor = "#357cd2"
    });
    eventsData.Add(new EventsData
    {
        Id = 3,
        Subject = "Dany Birthday Celebration",
        StartTime = new DateTime(2018, 2, 16, 10, 0, 0),
        EndTime = new DateTime(2018, 2, 16, 11, 30, 0),
        EventType = "family-event",
        City = "Kirkland",
        CategoryColor = "#7fa900"
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
    public string City { get; set; }
    public string CategoryColor { get; set; }
}