public ActionResult DisabledItem()
{
    List<TimelineItem> disabledItem = new List<TimelineItem>();
    disabledItem.Add(new TimelineItem { Content = "Eat" });
    disabledItem.Add(new TimelineItem { Content = "Code" });
    disabledItem.Add(new TimelineItem { Content = "Repeat", Disabled = true });
    ViewBag.disabledItem = disabledItem;
    return View();
}