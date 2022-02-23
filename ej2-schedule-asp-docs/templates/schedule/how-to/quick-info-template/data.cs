public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    List<QuickInfoDataSourceModel> categories = new List<QuickInfoDataSourceModel>();
            categories.Add(new QuickInfoDataSourceModel { Name = "Jammy", Id = 1, Capacity = 20, Color = "#ea7a57", Type = "Conference" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Tweety", Id = 2, Capacity = 7, Color = "#7fa900", Type = "Cabin" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Nestle", Id = 3, Capacity = 5, Color = "#5978ee", Type = "Cabin" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Phoenix", Id = 4, Capacity = 15, Color = "#fec200", Type = "Conference" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Mission", Id = 5, Capacity = 25, Color = "#df5286", Type = "Conference" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Hangout", Id = 6, Capacity = 10, Color = "#00bdae", Type = "Cabin" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Rick Roll", Id = 7, Capacity = 20, Color = "#865fcf", Type = "Conference" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Rainbow", Id = 8, Capacity = 8, Color = "#1aaa55", Type = "Cabin" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Swarm", Id = 9, Capacity = 30, Color = "#df5286", Type = "Conference" });
            categories.Add(new QuickInfoDataSourceModel { Name = "Photogenic", Id = 10, Capacity = 25, Color = "#710193", Type = "Conference" });
            ViewBag.Categories = categories;
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Day },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Week },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Month }
    };
    ViewBag.view = viewOption;
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    {
        RoomId= 10,
        Id= 1,
        Subject= 'Board Meeting',
        Description= 'Meeting to discuss business goal of 2020.',
        StartTime= '2020-01-05T04:00:00.000Z',
        EndTime= '2020-01-05T05:30:00.000Z'
    });
    appData.Add(new AppointmentData
    {
        RoomId= 8,
        Id= 2,
        Subject= 'Training session on JSP',
        Description= 'Knowledge sharing on JSP topics.',
        StartTime= '2020-01-07T04:00:00.000Z',
        EndTime= '2020-01-07T05:30:00.000Z'
    });
    appData.Add(new AppointmentData
    {
        RoomId= 3,
        Id= 3,
        Subject= 'Sprint Planning with Team members',
        Description= 'Planning tasks for sprint.',
        StartTime= '2020-01-09T04:00:00.000Z',
        EndTime= '2020-01-09T05:30:00.000Z'
    });
    appData.Add(new AppointmentData
    {
        RoomId= 2,
        Id= 4,
        Subject= 'Meeting with Client',
        Description= 'Customer meeting to discuss features.',
        StartTime= '2020-01-11T03:30:00.000Z',
        EndTime= '2020-01-11T05:00:00.000Z'
    });
    appData.Add(new AppointmentData
    {
        RoomId= 5,
        Id= 5,
        Subject= 'Support Meeting with Managers',
        Description= 'Meeting to discuss support plan.',
        StartTime= '2020-01-06T06:30:00.000Z',
        EndTime= '2020-01-06T08:00:00.000Z'
    });
    appData.Add(new AppointmentData
    {
        RoomId= 1,
        Id= 6,
        Subject= 'Client Meeting',
        Description= 'Meeting to discuss client requirements.',
        StartTime= '2020-01-08T06:00:00.000Z',
        EndTime= '2020-01-08T07:30:00.000Z'
    });
    appData.Add(new AppointmentData
    {
        RoomId= 10,
        Id= 1,
        Subject= 'Board Meeting',
        Description= 'Meeting to discuss business goal of 2020.',
        StartTime= '2020-01-05T04:00:00.000Z',
        EndTime= '2020-01-05T05:30:00.000Z'
    });
    appData.Add(new AppointmentData
    {
        RoomId= 7,
        Id= 7,
        Subject= 'Appraisal Meeting',
        Description= 'Meeting to discuss employee appraisals.',
        StartTime= '2020-01-10T05:30:00.000Z',
        EndTime= '2020-01-10T07:00:00.000Z'
    });
    return appData;
}

public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public int RoomId { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public string Description { get; set; }
}

public class QuickInfoDataSourceModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Color { get; set; }
    public string Type { get; set; }
}