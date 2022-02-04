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
    appData.Add(new AppointmentData{  Id = 1, Subject = "Meeting-1",  StartTime = new DateTime(2018, 2, 15, 10, 0, 0), EndTime = new DateTime(2018, 2, 15, 12, 30, 0), IsAllDay = true });
    appData.Add(new AppointmentData{  Id = 2, Subject = "Meeting-2",  StartTime = new DateTime(2018, 2, 15, 10, 0, 0), EndTime = new DateTime(2018, 2, 15, 12, 30, 0), IsAllDay = true });
    appData.Add(new AppointmentData{  Id = 3, Subject = "Meeting-3",  StartTime = new DateTime(2018, 2, 15, 10, 0, 0), EndTime = new DateTime(2018, 2, 15, 12, 30, 0), IsAllDay = true });
    appData.Add(new AppointmentData{  Id = 4, Subject = "Meeting-4",  StartTime = new DateTime(2018, 2, 15, 10, 0, 0), EndTime = new DateTime(2018, 2, 15, 12, 30, 0), IsAllDay = true });
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