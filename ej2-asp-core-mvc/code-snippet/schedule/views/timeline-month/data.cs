public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    ViewBag.workDays = new int[] { 1, 2, 3 };
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    { Id = 1, Subject = "Meeting", StartTime = new DateTime(2023, 2, 10, 10, 0, 0) , EndTime = new DateTime(2023, 2, 10, 12, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 2, Subject = "Conference", StartTime = new DateTime(2023, 2, 10, 9, 30, 0) , EndTime = new DateTime(2023, 2, 10, 12, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 3, Subject = "Seminar", StartTime = new DateTime(2023, 2, 22, 14, 30, 0) , EndTime = new DateTime(2023, 2, 22, 18, 0, 0) });
    return appData;
}
    
public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}