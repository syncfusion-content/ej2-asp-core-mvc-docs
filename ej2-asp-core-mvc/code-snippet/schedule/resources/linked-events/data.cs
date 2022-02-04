public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Week },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Month },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineWeek },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineMonth },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Agenda }
    };
    ViewBag.view = viewOption;
    List<ConferenceRes> conferences = new List<ConferenceRes>();
    conferences.Add(new ConferenceRes { text = "Margaret", id = 1, color = "#1aaa55" });
    conferences.Add(new ConferenceRes { text = "Robert", id = 2, color = "#357cd2" });
    conferences.Add(new ConferenceRes { text = "Laura", id = 3, color = "#7fa900" });
    ViewBag.Conferences = conferences;
    string[] resources = new string[] { "Conferences" };
    ViewBag.Resources = resources;
    return View();
}
public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {
        Id = 1,
        Subject = "Meeting",
        StartTime = new DateTime(2018, 2, 13, 10, 0, 0),
        EndTime = new DateTime(2018, 2, 13, 12, 30, 0),
        IsAllDay = false,
        ConferenceId = new int[] { 1, 2 }
    });
    appData.Add(new AppointmentData
    {
        Id = 2,
        Subject = "Testing",
        StartTime = new DateTime(2018, 2, 14, 10, 0, 0),
        EndTime = new DateTime(2018, 2, 14, 12, 30, 0),
        IsAllDay = false,
        ConferenceId = new int[] { 1, 2, 3 }
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
    public int[] ConferenceId { get; set; }
}

public class ConferenceRes
{
    public string text { set; get; }
    public int id { set; get; }
    public string color { set; get; }
}