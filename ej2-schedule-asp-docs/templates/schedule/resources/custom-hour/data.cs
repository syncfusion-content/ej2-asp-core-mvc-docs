public ActionResult Index()
{
    ViewBag.datasource = GetDoctorData();
    List<DoctorRes> doctors = new List<DoctorRes>();
    doctors.Add(new DoctorRes { text = "Will Smith", id = 1, color = "#ea7a57", startHour = "08:00", endHour = "15:00" });
    doctors.Add(new DoctorRes { text = "Alice", id = 2, color = "rgb(53, 124, 210)", startHour = "09:00", endHour = "17:00" });
    doctors.Add(new DoctorRes { text = "Robson", id = 3, color = "#7fa900", startHour = "08:00", endHour = "16:00" });
    ViewBag.Doctors = doctors;
    // Scheduler views
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Week },
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month },
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineWeek },
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineMonth }
    };
    ViewBag.view = viewOption;
    string[] resources = new string[] { "Doctors" };
    ViewBag.Resources = resources;
    return View();
}

public class DoctorRes
{
    public string text { set; get; }
    public int id { set; get; }
    public string color { set; get; }
    public string startHour { set; get; }
    public string endHour { set; get; }
}

public List<DoctorData> GetDoctorData()
{
    List<DoctorData> doctorData = new List<DoctorData>();
    doctorData.Add(new DoctorData
    {
        Id = 1,
        Subject = "Echocardiogram",
        StartTime = new DateTime(2018, 4, 2, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 2, 11, 30, 0),
        IsAllDay = false,
        DoctorId = 1
    });
    doctorData.Add(new DoctorData
    {
        Id = 2,
        Subject = "Lumbar punctures",
        StartTime = new DateTime(2018, 4, 2, 9, 30, 0),
        EndTime = new DateTime(2018, 4, 2, 10, 45, 0),
        IsAllDay = false,
        DoctorId = 2
    });
    doctorData.Add(new DoctorData
    {
        Id = 3,
        Subject = "Osteoarthritis",
        StartTime = new DateTime(2018, 4, 4, 10, 0, 0),
        EndTime = new DateTime(2018, 4, 4, 12, 0, 0),
        IsAllDay = false,
        DoctorId = 3
    });
    return doctorData;
}

public class DoctorData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsAllDay { get; set; }
    public int DoctorId { get; set; }
}