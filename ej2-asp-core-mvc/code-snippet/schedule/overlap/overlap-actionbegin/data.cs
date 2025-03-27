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
        Subject = "Board Meeting",
        StartTime = new DateTime(2025, 2, 26, 9, 30, 0),
        EndTime = new DateTime(2025, 2, 26, 11, 0, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 2,
        Subject = "Annual Conference",
        StartTime = new DateTime(2025, 3, 2, 10, 0, 0),
        EndTime = new DateTime(2025, 3, 2, 11, 0, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 3,
        Subject = "Tech Symposium",
        StartTime = new DateTime(2025, 3, 2, 10, 30, 0),
        EndTime = new DateTime(2025, 3, 2, 11, 30, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 4,
        Subject = "Project Workshop",
        StartTime = new DateTime(2025, 3, 10, 9, 0, 0),
        EndTime = new DateTime(2025, 3, 10, 11, 0, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 5,
        Subject = "Client Presentation",
        StartTime = new DateTime(2025, 3, 5, 9, 0, 0),
        EndTime = new DateTime(2025, 3, 5, 10, 30, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 6,
        Subject = "Business Meetup",
        StartTime = new DateTime(2025, 3, 15, 11, 0, 0),
        EndTime = new DateTime(2025, 3, 15, 13, 0, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 7,
        Subject = "Project Review",
        StartTime = new DateTime(2025, 3, 13, 10, 0, 0),
        EndTime = new DateTime(2025, 3, 13, 13, 0, 0),
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
}