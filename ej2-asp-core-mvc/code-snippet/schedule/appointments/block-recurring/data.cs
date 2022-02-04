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
        Id = 1,
        Subject = "Paris",
        StartTime = new DateTime(2018, 2, 15, 10, 0, 0),
        EndTime = new DateTime(2018, 2, 15, 12, 30, 0),
        IsBlock = true,
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=5"
    });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string RecurrenceRule { get; set; }
    public bool IsBlock { get; set; }
}