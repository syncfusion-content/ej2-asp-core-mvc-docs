public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Day },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Week },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Month }
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
        Subject = "Surgery - Andrew",
        EventType = "Confirmed",
        StartTime = new DateTime(2018, 2, 12, 9, 30, 0),
        EndTime = new DateTime(2018, 2, 12, 10, 30, 0),
        OwnerId = 3
    });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string EventType { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsAllDay { get; set; }
    public int OwnerId { get; set; }
}