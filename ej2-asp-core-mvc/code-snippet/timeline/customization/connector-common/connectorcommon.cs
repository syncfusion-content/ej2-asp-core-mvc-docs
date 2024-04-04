public ActionResult Demo()
{
    List<TimelineItem> dailyRoutine = new List<TimelineItem>();
    dailyRoutine.Add(new TimelineItem { Content = "Eat" });
    dailyRoutine.Add(new TimelineItem { Content = "Code" });
    dailyRoutine.Add(new TimelineItem { Content = "Repeat" });
    ViewBag.dailyRoutine = dailyRoutine;

    return View();
}