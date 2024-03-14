public ActionResult Demo()
{
    List<TimelineItem> defaultItems = new List<TimelineItem>();
    defaultItems.Add(new TimelineItem { });
    defaultItems.Add(new TimelineItem { });
    defaultItems.Add(new TimelineItem { });
    defaultItems.Add(new TimelineItem { });

    ViewBag.defaultItems = defaultItems;
    
    return View();
}