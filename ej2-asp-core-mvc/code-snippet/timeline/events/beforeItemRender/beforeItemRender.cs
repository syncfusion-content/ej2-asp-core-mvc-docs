public ActionResult Demo()
{
    List<TimelineItem> productLifecycle = new List<TimelineItem>();
    productLifecycle.Add(new TimelineItem { Content = "Planning" });
    productLifecycle.Add(new TimelineItem { Content = "Developing" });
    productLifecycle.Add(new TimelineItem { Content = "Testing" });
    productLifecycle.Add(new TimelineItem { Content = "Launch" });
    ViewBag.productLifecycle = productLifecycle;

    return View();
}