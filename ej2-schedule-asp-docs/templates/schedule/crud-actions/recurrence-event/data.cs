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
        Id = 3,
        Subject = "Testing",
        StartTime = new DateTime(2018, 2, 11, 9, 0, 0),
        EndTime = new DateTime(2018, 2, 11, 10, 0, 0),
        IsAllDay = false,
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=3",
    });
    appData.Add(new AppointmentData
    {
        Id = 4,
        Subject = "Vacation",
        StartTime = new DateTime(2018, 2, 12, 11, 0, 0),
        EndTime = new DateTime(2018, 2, 12, 12, 0, 0),
        IsAllDay = false,
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=2"
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
    public string RecurrenceRule { get; set; }
}