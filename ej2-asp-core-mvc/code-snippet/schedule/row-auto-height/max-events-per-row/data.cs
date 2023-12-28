public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {Id: 1, Subject: 'Explosion of Betelgeuse Star', StartTime: new Date(2023, 11, 11, 9, 30), EndTime: new Date(2023, 11, 11, 11, 0) });
    appData.Add(new AppointmentData
    {Id: 2, Subject: 'Thule Air Crash Report', StartTime: new Date(2023, 11, 11, 12, 30), EndTime: new Date(2023, 11, 11, 13, 0) });
    appData.Add(new AppointmentData
    {Id: 3, Subject: 'Blue Moon Eclipse', StartTime: new Date(2023, 11, 11, 13, 30), EndTime: new Date(2023, 11, 11, 15, 30) });
    appData.Add(new AppointmentData
    {Id: 4, Subject: 'Meteor Showers in 2023', StartTime: new Date(2023, 11, 14, 13, 0), EndTime: new Date(2023, 11, 14, 14, 30) });
    appData.Add(new AppointmentData
    {Id: 5, Subject: 'Milky Way as Melting pot', StartTime: new Date(2023, 11, 14, 15, 0), EndTime: new Date(2023, 11, 14, 15, 30) });
    appData.Add(new AppointmentData
    {Id: 6, Subject: 'Mysteries of Bermuda Triangle', StartTime: new Date(2023, 11, 15, 9, 30), EndTime: new Date(2023, 11, 15, 11, 0) });
    appData.Add(new AppointmentData
    {Id: 7, Subject: 'Glaciers and Snowflakes', StartTime: new Date(2023, 11, 15, 11, 0), EndTime: new Date(2023, 11, 15, 12, 30) });
    appData.Add(new AppointmentData
    {Id: 8, Subject: 'Life on Mars', StartTime: new Date(2023, 11, 17, 9, 0), EndTime: new Date(2023, 11, 17, 10, 0) });
    appData.Add(new AppointmentData
    {Id: 9, Subject: 'Alien Civilization', StartTime: new Date(2023, 11, 17, 12, 0), EndTime: new Date(2023, 11, 17, 13, 0) });
    appData.Add(new AppointmentData
    {Id: 10, Subject: 'Wildlife Galleries', StartTime: new Date(2023, 11, 17, 15, 0), EndTime: new Date(2023, 11, 17, 17, 0) });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}