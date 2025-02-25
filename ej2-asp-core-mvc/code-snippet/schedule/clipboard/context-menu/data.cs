public ActionResult Index()
{
    ViewBag.appointments = GetScheduleData();
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        text = "Cut Event",
        iconCss = "e-icons e-cut",
        id = "Cut"
    });
    menuItems.Add(new
    {
        text = "Copy Event",
        iconCss = "e-icons e-copy",
        id = "Copy"
    });
    menuItems.Add(new
    {
        text = "Paste",
        iconCss = "e-icons e-paste",
        id = "Paste"
    });

    ViewBag.menuItems = menuItems;
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {
        Id = 2,
        Subject = "Meeting",
        StartTime = new DateTime(2024, 2, 15, 10, 0, 0),
        EndTime = new DateTime(2024, 2, 15, 12, 30, 0),
        IsAllDay = false,
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