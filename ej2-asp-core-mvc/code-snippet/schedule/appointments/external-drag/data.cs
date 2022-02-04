public ActionResult Index()
{
    ViewBag.appointments = GetScheduleData();
    ViewBag.treeDataSource = GetTreeData();
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {
        Id = 1,
        Subject = "Paris",
        StartTime = new DateTime(2018, 1, 28, 10, 0, 0),
        EndTime = new DateTime(2018, 1, 28, 12, 30, 0)
    });
    return appData;
}

public List<AppointmentData> GetTreeData()
{
    List<AppointmentData> treeData = new List<AppointmentData>();
    treeData.Add(new AppointmentData
    {
        Id = 11,
        Subject = "Sky Gazers",
        StartTime = new DateTime(2018, 1, 27, 10, 0, 0),
        EndTime = new DateTime(2018, 1, 27, 12, 30, 0)
    });
    treeData.Add(new AppointmentData
    {
        Id = 12,
        Subject = "The Cycle of Seasons",
        StartTime = new DateTime(2018, 1, 28, 14, 0, 0),
        EndTime = new DateTime(2018, 1, 28, 15, 0, 0)
    });
    treeData.Add(new AppointmentData
    {
        Id = 13,
        Subject = "Aliens vs Humans",
        StartTime = new DateTime(2018, 1, 29, 13, 0, 0),
        EndTime = new DateTime(2018, 1, 29, 14, 0, 0)
    });
    return treeData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}