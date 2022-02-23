public ActionResult Index()
{
    ViewBag.appointments = GetScheduleData();
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {
        Id = 1,
        Subject = "Scrum Meeting",
        StartTime = new DateTime(2018, 1, 28, 10, 0, 0),
        EndTime = new DateTime(2018, 1, 28, 12, 30, 0),
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1;UNTIL=20180129T043000Z;"
    });
    appData.Add(new AppointmentData
    {
        Id = 2,
        Subject = "Scrum Meeting - Following Edited",
        StartTime = new DateTime(2018, 1,30, 10, 0, 0),
        EndTime = new DateTime(2018, 1, 30, 10, 30, 0),
		RecurrenceRule = "FREQ=DAILY;INTERVAL=1;UNTIL=20180204T043000Z;",
        FollowingID = 1
    });
    return appData;
}
public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string RecurrenceRule { get; set; }
    public string RecurrenceException { get; set; }
    public int FollowingID { get; set; }
}