public ActionResult Demo()
{
    List<TimelineItem> dailyRoutine = new List<TimelineItem>();
    dailyRoutine.Add(new TimelineItem { Content = "Eat", CssClass = "state-initial" });
    dailyRoutine.Add(new TimelineItem { Content = "Code", CssClass = "state-intermediate" });
    dailyRoutine.Add(new TimelineItem { Content = "Repeat" });
    ViewBag.dailyRoutine = dailyRoutine;

    return View();
}