public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {
        Id = 1,
        Subject = "Surgery - Andrew",
        StartTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0),
        EndTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 10, 0, 0),
        IsAllDay = false,
    },
    {
        Id: 2,
        Subject: "Consulting - John",
        StartTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 10, 0, 0),
        EndTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 11, 30, 0),
        IsAllDay: false
  },
  {
        Id: 3,
        Subject: "Therapy - Robert",
        StartTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 11, 30, 0),
        EndTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 12, 30, 0),
        IsAllDay: false
  },
  {
        Id: 4,
        Subject: "Observation - Steven",
        StartTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 12, 30, 0),
        EndTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 13, 30, 0),
        IsAllDay: false
  }
    );
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
