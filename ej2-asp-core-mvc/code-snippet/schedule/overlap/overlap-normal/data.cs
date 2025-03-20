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
        Subject = "Annual Conference",
        StartTime = new DateTime(2025, 3, 2, 10, 0, 0),
        EndTime = new DateTime(2025, 3, 2, 11, 0, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 2,
        Subject = "Tech Symposium",
        StartTime = new DateTime(2025, 3, 2, 10, 30, 0),
        EndTime = new DateTime(2025, 3, 2, 11, 30, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 3,
        Subject = "Client Meeting",
        StartTime = new DateTime(2025, 3, 3, 12, 0, 0),
        EndTime = new DateTime(2025, 3, 3, 14, 0, 0),
        IsAllDay = false,
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=5"
    });
    appData.Add(new AppointmentData
    {
        Id = 4,
        Subject = "Project Review",
        StartTime = new DateTime(2025, 3, 4, 11, 0, 0),
        EndTime = new DateTime(2025, 3, 4, 14, 0, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 5,
        Subject = "Strategy Session",
        StartTime = new DateTime(2025, 3, 6, 9, 30, 0),
        EndTime = new DateTime(2025, 3, 6, 10, 0, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 6,
        Subject = "Board Meeting",
        StartTime = new DateTime(2025, 3, 6, 9, 30, 0),
        EndTime = new DateTime(2025, 3, 6, 11, 0, 0),
        IsAllDay = false
    });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsAllDay { get; set; }
    public string RecurrenceRule { get; set; }
}