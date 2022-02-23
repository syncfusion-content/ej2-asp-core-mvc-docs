public ActionResult Index()
{
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Week, DateFormat = "dd-MMM-yyyy" },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Month, ShowWeekend = false, Readonly = true }
    };
    ViewBag.view = viewOption;
    return View();
}