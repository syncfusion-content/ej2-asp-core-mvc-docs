public ActionResult Index()
{
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