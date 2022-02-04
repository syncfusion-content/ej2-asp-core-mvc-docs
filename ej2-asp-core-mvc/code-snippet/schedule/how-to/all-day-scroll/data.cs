public ActionResult Index()
{
    ViewBag.appointments = generateObject();
    return View();
}

public List<AppointmentData> generateObject()
{
    List<AppointmentData> appData = new List<AppointmentData>(25);
    for (int a = 0; a <= 25; a++)
    { 
        appData.Add(new AppointmentData
        {
            Id = a + 1,
            Subject = 'Testing',
            StartTime = new Date(2021, 3, 28),
            EndTime = new Date(2021, 3, 29),
            IsAllDay = true
        });
    }
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