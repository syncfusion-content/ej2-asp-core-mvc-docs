public ActionResult Index()
{
    ViewBag.datasource = GetScheduleData();
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month }
    };
    ViewBag.view = viewOption;
     List<ScheduleToolbarItem> toolbarItems = new List<ScheduleToolbarItem>()
        {
            new ScheduleToolbarItem { Name = ToolbarName.Previous, Align = ItemAlign.Left },
            new ScheduleToolbarItem { Name = ToolbarName.Next, Align = ItemAlign.Left },
            new ScheduleToolbarItem { Name = ToolbarName.DateRangeText, Align = ItemAlign.Left },
            new ScheduleToolbarItem { Name = ToolbarName.Today, Align = ItemAlign.Right },
            new ScheduleToolbarItem { Align = ItemAlign.Right, PrefixIcon = "user-icon", Text = "Nancy", CssClass = "e-schedule-user-icon", Click = "onIconClick" },
        };
        ViewBag.toolbarItems = toolbarItems;
    return View();
}

public List<AppointmentData> GetScheduleData()
{
    List<AppointmentData> appData = new List<AppointmentData>();
    appData.Add(new AppointmentData
    { Id = 1, Subject = "Explosion of Betelgeuse Star", StartTime = new DateTime(2023, 2, 14, 9, 30, 0), EndTime = new DateTime(2023, 2, 14, 11, 0, 0) });
    return appData;
}
    
public class AppointmentData
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}
