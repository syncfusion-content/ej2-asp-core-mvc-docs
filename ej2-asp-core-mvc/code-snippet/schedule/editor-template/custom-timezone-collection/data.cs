public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    { 
        Id = 1,
        Subject = "Explosion of Betelgeuse Star",
        StartTime= new DateTime(2023, 1, 15, 10, 0, 0),
        EndTime= new DateTime(2023, 1, 15, 12, 30, 0),
        IsAllDay= false
    });
    appData.Add(new AppointmentData
    { 
        Id = 2,
        Subject = "Blue Moon Eclipse",
        StartTime = new DateTime(2023, 1, 16, 12, 0, 0),
        EndTime = new DateTime(2023, 1, 16, 13, 0, 0),
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
