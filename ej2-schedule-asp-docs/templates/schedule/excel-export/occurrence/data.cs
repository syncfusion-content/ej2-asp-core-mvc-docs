public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Week }
    };
    ViewBag.view = viewOption;
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {
        Id = 1,
        Subject = "Explosion of Betelgeuse Star",
        Location = "Dallas",
        StartTime = new DateTime(2019, 1, 8, 9, 30, 0),
        EndTime = new DateTime(2019, 1, 8, 11, 0, 0),
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=10"
    });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Location { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string RecurrenceRule { get; set; }
}