public ActionResult Demo()
{
    List<TimelineItem> tripItenerary = new List<TimelineItem>();
    tripItenerary.Add(new TimelineItem { Content = "Day 1, 4:00 PM", OppositeContent = "Check-in and campsite visit" });
    tripItenerary.Add(new TimelineItem { Content = "Day 1, 7:00 PM", OppositeContent = "Dinner with music" });
    tripItenerary.Add(new TimelineItem { Content = "Day 2, 5:30 AM", OppositeContent = "Sunrise between mountains" });
    tripItenerary.Add(new TimelineItem { Content = "Day 2, 8:00 AM", OppositeContent = "Breakfast and check-out" });
    ViewBag.tripItenerary = tripItenerary;
    
    return View();
}