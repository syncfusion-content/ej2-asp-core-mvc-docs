public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    { Id = 1, Subject = "Blue Moon Eclipse", StartTime = new DateTime(2018, 2, 15, 9, 30, 0), EndTime = new DateTime(2018, 2, 15, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 2, Subject = "Milky Way as Melting pot", StartTime = new DateTime(2018, 2, 15, 13, 0, 0), EndTime = new DateTime(2018, 2, 15, 14, 0, 0) });
    return appData;
}
    
public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}