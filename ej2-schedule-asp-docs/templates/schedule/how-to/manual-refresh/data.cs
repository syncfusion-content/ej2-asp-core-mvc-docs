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
        Subject = "Conference",
        StartTime = new Date(2021, 10, 16, 10, 0),
        EndTime = new Date(2021, 10, 16, 12, 0),
        IsAllDay = false
    });
    appData.Add(new AppointmentData
    {
        Id = 2,
        Subject = "Meeting",
        StartTime = new Date(2021, 10, 18, 10, 0),
        EndTime = new Date(2021, 10, 18, 12, 30),
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