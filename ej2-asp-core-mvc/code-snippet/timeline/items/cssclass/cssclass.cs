public ActionResult CssClass()
{
    List<TimelineItem> cssClassItem = new List<TimelineItem>();
    cssClassItem.Add(new TimelineItem { Content = "Eat" });
    cssClassItem.Add(new TimelineItem { Content = "Code" });
    cssClassItem.Add(new TimelineItem { Content = "Repeat" });
    ViewBag.cssClassItem = cssClassItem;
    return View();
}