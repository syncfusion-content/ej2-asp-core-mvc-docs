public ActionResult Index()
{
    List<ScheduleView> viewOption = new List<ScheduleView>()
    {
        new ScheduleView { Option = Syncfusion.EJ2.Schedule.View.Month }
    };
    ViewBag.view = viewOption;
    return View();
}