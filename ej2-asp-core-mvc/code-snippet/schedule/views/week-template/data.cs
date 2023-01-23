public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    { Id = 1, Subject = "Meeting", StartTime = new DateTime(2023, 1, 19, 10, 0, 0) , EndTime = new DateTime(2023, 1, 19, 12, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 2, Subject = "Conference", StartTime = new DateTime(2023, 1, 21, 9, 30, 0) , EndTime = new DateTime(2023, 1, 21, 12, 0, 0) });
    return appData;
}
    
public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}