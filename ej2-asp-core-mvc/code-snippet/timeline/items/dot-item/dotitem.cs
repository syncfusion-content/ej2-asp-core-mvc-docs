public ActionResult DotItem()
{
    List<TimelineItem> dotItems = new List<TimelineItem>();
    dotItems.Add(new TimelineItem { Content = "Default" });
    dotItems.Add(new TimelineItem { Content = "Icon", DotCss = "e-icons e-check" });
    dotItems.Add(new TimelineItem { Content = "Image", DotCss = "custom-image" });
    dotItems.Add(new TimelineItem { Content = "Text", DotCss = "custom-text" });
    ViewBag.dotItems = dotItems;
    return View();
}