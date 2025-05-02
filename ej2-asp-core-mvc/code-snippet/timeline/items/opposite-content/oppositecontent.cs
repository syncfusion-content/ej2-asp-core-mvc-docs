public ActionResult OppositeContent()
{
    List<TimelineItem> mealTimes = new List<TimelineItem>();
    mealTimes.Add(new TimelineItem { Content = "Breakfast", OppositeContent = "8:00 AM" });
    mealTimes.Add(new TimelineItem { Content = "Lunch", OppositeContent = "1:00 PM" });
    mealTimes.Add(new TimelineItem { Content = "Dinner", OppositeContent = "8:00 PM" });
    ViewBag.mealTimes = mealTimes;
    return View();
}