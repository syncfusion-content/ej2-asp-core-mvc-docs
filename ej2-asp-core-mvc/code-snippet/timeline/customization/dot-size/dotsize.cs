public ActionResult Demo()
{
    List<TimelineItem> dotSizes = new List<TimelineItem>();
    dotSizes.Add(new TimelineItem { Content = "Extra Small", CssClass = "x-small" });
    dotSizes.Add(new TimelineItem { Content = "Small", CssClass = "small" });
    dotSizes.Add(new TimelineItem { Content = "Medium", CssClass = "medium" });
    dotSizes.Add(new TimelineItem { Content = "Large", CssClass = "large" });
    ViewBag.dotSizes = dotSizes;
    
    return View();
}