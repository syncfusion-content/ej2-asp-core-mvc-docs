public ActionResult Index()
{
    ViewBag.Appointments = GetScheduleData();
    ViewBag.Resources = GetResourceData();
    ViewBag.value = 1;

    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>
    {
        new AppointmentData { Id = 1, Subject = "Meeting with Margaret", StartTime = new DateTime(2025, 3, 10, 10, 0, 0), EndTime = new DateTime(2025, 3, 10, 11, 0, 0), OwnerId = 1 },
        new AppointmentData { Id = 2, Subject = "Call with Margaret", StartTime = new DateTime(2025, 3, 11, 14, 0, 0), EndTime = new DateTime(2025, 3, 11, 15, 0, 0), OwnerId = 1 },
        new AppointmentData { Id = 3, Subject = "Review with Margaret", StartTime = new DateTime(2025, 3, 12, 9, 0, 0), EndTime = new DateTime(2025, 3, 12, 10, 0, 0), OwnerId = 1 },
        new AppointmentData { Id = 4, Subject = "Meeting with Robert", StartTime = new DateTime(2025, 3, 12, 14, 0, 0), EndTime = new DateTime(2025, 3, 12, 15, 0, 0), OwnerId = 2 },
        new AppointmentData { Id = 5, Subject = "Discussion with Robert", StartTime = new DateTime(2025, 3, 13, 10, 0, 0), EndTime = new DateTime(2025, 3, 13, 11, 0, 0), OwnerId = 2 },
        new AppointmentData { Id = 6, Subject = "Training with Robert", StartTime = new DateTime(2025, 3, 14, 13, 0, 0), EndTime = new DateTime(2025, 3, 14, 14, 0, 0), OwnerId = 2 },
        new AppointmentData { Id = 7, Subject = "Call with Laura", StartTime = new DateTime(2025, 3, 15, 9, 0, 0), EndTime = new DateTime(2025, 3, 15, 10, 0, 0), OwnerId = 3 },
        new AppointmentData { Id = 8, Subject = "Meeting with Laura", StartTime = new DateTime(2025, 3, 16, 11, 0, 0), EndTime = new DateTime(2025, 3, 16, 12, 0, 0), OwnerId = 3 },
        new AppointmentData { Id = 9, Subject = "Project Review with Laura", StartTime = new DateTime(2025, 3, 17, 14, 0, 0), EndTime = new DateTime(2025, 3, 17, 15, 0, 0), OwnerId = 3 }
    };

    return appData;
}

public List<ResourceData> GetResourceData()
{
    List<ResourceData> resourceData = new List<ResourceData>
    {
        new ResourceData { OwnerText = "Margaret", OwnerId = 1, Color = "#ea7a57" },
        new ResourceData { OwnerText = "Robert", OwnerId = 2, Color = "#df5286" },
        new ResourceData { OwnerText = "Laura", OwnerId = 3, Color = "#865fcf" }
    };

    return resourceData;
}
    
public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int OwnerId { get; set; }
}

public class ResourceData
{
    public string OwnerText { get; set; }
    public int OwnerId { get; set; }
    public string Color { get; set; }
}