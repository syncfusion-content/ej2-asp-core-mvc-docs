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
        Subject = "Paris",
        StartTime = new DateTime(2018, 1, 15, 10, 0, 0),
        EndTime = new DateTime(2018, 1, 17, 12, 30, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    { 
        Id = 2,
        Subject = "London",
        StartTime = new DateTime(2018, 1, 16, 12, 0, 0),
        EndTime = new DateTime(2018, 1, 18, 13, 0, 0),
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