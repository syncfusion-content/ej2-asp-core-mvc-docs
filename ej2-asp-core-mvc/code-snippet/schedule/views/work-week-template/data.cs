public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    ViewBag.workDays = new int[] { 1, 3, 5 };
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    { Id = 1, Subject = "Meeting", StartTime = new DateTime(2023, 1, 17, 10, 0, 0) , EndTime = new DateTime(2023, 1, 17, 12, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 2, Subject = "Conference", StartTime = new DateTime(2023, 1, 19, 9, 30, 0) , EndTime = new DateTime(2023, 1, 19, 12, 0, 0) });
    return appData;
}
    
public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}