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
        Subject = "Rank 3",
        StartTime = new DateTime(2017, 9, 29, 10, 30, 0),
        EndTime = new DateTime(2017, 9, 29, 12, 30, 0),
        RankId = "3"
    });
    eventsData.Add(new EventsData
    {
        Id = 2,
        Subject = "Rank 1",
        StartTime = new DateTime(2017, 9, 29, 10, 0, 0),
        EndTime = new DateTime(2017, 9, 29, 11, 30),
        RankId = "1"
    });
    eventsData.Add(new EventsData
    {
        Id = 3,
        Subject = "Rank 6",
        StartTime = new DateTime(2017, 9, 29, 7, 0, 0),
        EndTime = new DateTime(2017, 9, 29, 14, 30, 0),
        RankId = "6"
    });
    eventsData.Add(new EventsData
    {
        Id = 4,
        Subject = "Rank 9",
        StartTime = new DateTime(2017, 9, 29, 11, 0, 0),
        EndTime = new DateTime(2017, 9, 29, 15, 30, 0),
        RankId = "9"
    });
    return eventsData;
}

public class EventsData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string RankId { get; set; }
}