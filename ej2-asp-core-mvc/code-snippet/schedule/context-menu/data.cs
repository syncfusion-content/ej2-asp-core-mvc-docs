public ActionResult Index()
{
    ViewBag.appointments = GetScheduleData();
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        text = "New Event",
        iconCss = "e-icons new",
        id = "Add"
    });
    menuItems.Add(new
    {
        text = "New Recurring Event",
        iconCss = "e-icons recurrence",
        id = "AddRecurrence"
    });
    menuItems.Add(new
    {
        text = "Today",
        iconCss = "e-icons today",
        id = "Today"
    });
    menuItems.Add(new
    {
        text = "Edit Event",
        iconCss = "e-icons edit",
        id = "Save"
    });
    menuItems.Add(new
    {
        text = "Edit Event",
        id = "EditRecurrenceEvent",
        iconCss = "e-icons edit",
        items = new List<object>() {
            new { text = "Edit Occurrence", id = "EditOccurrence"},
            new { text = "Edit Series", id = "EditSeries" }
        }
    });
    menuItems.Add(new
    {
        text = "Delete Event",
        iconCss = "e-icons delete",
        id = "Delete"
    });
    menuItems.Add(new
    {
        text = "Delete Event",
        id = "DeleteRecurrenceEvent",
        iconCss = "e-icons delete",
        items = new List<object>() {
            new { text = "Delete Occurrence", id = "DeleteOccurrence" },
            new { text = "Delete Series", id = "DeleteSeries"}
        }
    });

    ViewBag.menuItems = menuItems;
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {
        Id = 2,
        Subject = "Meeting",
        StartTime = new DateTime(2018, 2, 15, 10, 0, 0),
        EndTime = new DateTime(2018, 2, 15, 12, 30, 0),
        IsAllDay = false,
        Status = "Completed",
        Priority = "High"
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
    public string Status { get; set; }
    public string Priority { get; set; }
}