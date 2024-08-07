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
        Subject = "Paris",
        StartTime = new DateTime(2023, 1, 28, 10, 0, 0),
        EndTime = new DateTime(2023, 1, 28, 12, 30, 0),
        CategoryColor = "#357cd2"
    });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string CategoryColor { get; set; }
}