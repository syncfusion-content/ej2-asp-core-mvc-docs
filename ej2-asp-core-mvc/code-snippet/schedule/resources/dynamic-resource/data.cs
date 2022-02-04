public ActionResult Index()
{
    List<CalendarRes> calendarCollections = new List<CalendarRes>();
    calendarCollections.Add(new CalendarRes { CalendarName = "Company", CalendarId = 1, CalendarColor = "#c43081" });
    ViewBag.Calendars = calendarCollections;
    // scheduler views
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month }
    };
    ViewBag.view = viewOption;
    // Scheduler default resource name
    string[] resources = new string[] { "Calendars" };
    ViewBag.Resources = resources;
    // Scheduler datasource
    ViewBag.datasource = GetCalendarData();
    return View();
}

public class CalendarRes
{
    public string CalendarName { set; get; }
    public int CalendarId { set; get; }
    public string CalendarColor { set; get; }
}

public List<ResourceEventsData> GetCalendarData()
{
    List<ResourceEventsData> calendarData = new List<ResourceEventsData>();
    calendarData.Add(new ResourceEventsData
    {
        Id = 1,
        Subject = "Conference meeting",
        StartTime = new DateTime(2018, 3, 1),
        EndTime = new DateTime(2018, 3, 2),
        IsAllDay = true,
        CalendarId = 1
    });
    calendarData.Add(new ResourceEventsData
    {
        Id = 2,
        Subject = "Gladys Spellman",
        StartTime = new DateTime(2018, 3, 8),
        EndTime = new DateTime(2018, 3, 9),
        IsAllDay = true,
        CalendarId = 2
    });
    calendarData.Add(new ResourceEventsData
    {
        Id = 3,
        Subject = "Global Family Day",
        StartTime = new DateTime(2018, 3, 15),
        EndTime = new DateTime(2018, 3, 16),
        IsAllDay = true,
        CalendarId = 3
    });
    return calendarData;
}

public class ResourceEventsData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsAllDay { get; set; }
    public int CalendarId { get; set; }
}