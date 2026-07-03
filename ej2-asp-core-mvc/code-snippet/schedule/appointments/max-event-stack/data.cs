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
        StartTime = new DateTime(2026, 6, 15, 9, 30, 0),
        EndTime = new DateTime(2026, 6, 15, 11, 0, 0)
    });
    appData.Add(new AppointmentData
    {
        Id = 2,
        Subject = "Annual Conference",
        StartTime = new DateTime(2026, 6, 15, 10, 0, 0),
        EndTime = new DateTime(2026, 6, 15, 11, 0, 0)
    });
    appData.Add(new AppointmentData
    {
        Id = 3,
        Subject = "Tech Symposium",
        StartTime = new DateTime(2026, 6, 15, 10, 30, 0),
        EndTime = new DateTime(2026, 6, 15, 11, 30, 0)
    });
    appData.Add(new AppointmentData
    {
        Id = 4,
        Subject = "Client Meeting",
        StartTime = new DateTime(2026, 6, 15, 12, 0, 0),
        EndTime = new DateTime(2026, 6, 15, 14, 0, 0)
    });
    appData.Add(new AppointmentData
    {
        Id = 5,
        Subject = "Project Review",
        StartTime = new DateTime(2026, 6, 15, 13, 0, 0),
        EndTime = new DateTime(2026, 6, 15, 15, 0, 0)
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