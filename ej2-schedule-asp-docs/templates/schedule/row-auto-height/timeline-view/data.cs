public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineDay },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineWeek },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineWorkWeek },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineMonth },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Agenda }
    };
    ViewBag.view = viewOption;
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    { Id = 1, Subject = "Explosion of Betelgeuse Star", Location = "Dallas", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 2, Subject = "Thule Air Crash Report", Location = "Texas", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 3, Subject = "Blue Moon Eclipse", Location = "Australia", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 4, Subject = "Meteor Showers in 2019", Location = "Canada", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 5, Subject = "Milky Way as Melting pot", Location = "Mexico", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 6, Subject = "Mysteries of Bermuda Triangle", Location = "Bermuda", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 7, Subject = "Glaciers and Snowflakes", Location = "Himalayas", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 8, Subject = "Life on Mars", Location = "Space Centre USA", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 9, Subject = "Alien Civilization", Location = "Space Centre USA", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 10, Subject = "Wildlife Galleries", Location = "Africa", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 11, Subject = "Best Photography 2018", Location = "London", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 12, Subject = "Smarter Puppies", Location = "Sweden", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 13, Subject = "Myths of Andromeda Galaxy", Location = "Space Centre USA", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 14, Subject = "Aliens vs Humans", Location = "Research Centre of USA", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 15, Subject = "Facts of Humming Birds", Location = "California", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 16, Subject = "Sky Gazers", Location = "Alaska", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 17, Subject = "The Cycle of Seasons", Location = "Research Centre of USA", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 18, Subject = "Space Galaxies and Planets", Location = "Space Centre USA", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 19, Subject = "Lifecycle of Bumblebee", Location = "San Fransisco", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    appData.Add(new AppointmentData
    { Id = 20, Subject = "Alien Civilization", Location = "Space Centre USA", StartTime = new DateTime(2019, 1, 10, 9, 30, 0), EndTime = new DateTime(2019, 1, 10, 11, 0, 0) });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Location { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}