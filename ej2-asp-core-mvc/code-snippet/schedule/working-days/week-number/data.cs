public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    ViewBag.workday = new int[] { 1, 3, 4, 5 };
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    { Id = 1, Subject = "Blue Moon Eclipse", StartTime = new DateTime(2023, 2, 12, 9, 30, 0), EndTime = new DateTime(2023, 2, 12, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 2, Subject = "Milky Way as Melting pot", StartTime = new DateTime(2023, 2, 14, 9, 30, 0), EndTime = new DateTime(2023, 2, 14, 11, 0, 0) });
    return appData;
}
    
public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}