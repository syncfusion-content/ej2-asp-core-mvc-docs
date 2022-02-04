public ActionResult Index()
{
    ViewBag.appointments = GetScheduleData();
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {
        TravelId = 1,
        TravelSummary = "Paris",
        DepartureTime = new DateTime(2018, 2, 15, 10, 0, 0),
        ArrivalTime = new DateTime(2018, 2, 15, 12, 30, 0),
        FullDay = false,
        Source = "London",
        Comments = "Summer vacation planned for outstation.",
        Origin = "Asia/Yekaterinburg",
        Destination = "Asia/Yekaterinburg"
    });
    return appData;
}

public class AppointmentData
{
    public int TravelId { get; set; }
    public string TravelSummary { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public bool FullDay { get; set; }
    public string Source { get; set; }
    public string Comments { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
}