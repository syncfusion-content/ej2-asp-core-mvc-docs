public ActionResult Index()
{
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Week },
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.TimelineDay }
    };
    ViewBag.view = viewOption;
    return View();
}