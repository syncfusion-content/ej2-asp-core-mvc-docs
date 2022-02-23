public ActionResult Index()
{
    ViewBag.datasource = GetDoctorData();
    List<DoctorRes> doctors = new List<DoctorRes>();
    doctors.Add(new DoctorRes { text = "Will Smith", id = 1, color = "#ea7a57", workDays = new List<int> { 1, 2, 4, 5 } });
    doctors.Add(new DoctorRes { text = "Alice", id = 2, color = "rgb(53, 124, 210)", workDays = new List<int> { 1, 3, 5 } });
    doctors.Add(new DoctorRes { text = "Robson", id = 3, color = "#7fa900"});
    ViewBag.Doctors = doctors;

    string[] resources = new string[] { "Doctors" };
    ViewBag.Resources = resources;
    return View();
}

public class DoctorRes
{
    public string text { set; get; }
    public int id { set; get; }
    public string color { set; get; }
    public List<int> workDays { set; get; }
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