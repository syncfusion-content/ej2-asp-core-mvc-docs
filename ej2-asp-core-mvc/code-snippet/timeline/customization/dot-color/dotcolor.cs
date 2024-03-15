public ActionResult Demo()
{
    List<TimelineItem> orderStatus = new List<TimelineItem>();
    orderStatus.Add(new TimelineItem { Content = "Ordered", CssClass = "state-completed" });
    orderStatus.Add(new TimelineItem { Content = "Shipped", CssClass = "state-progress" });
    orderStatus.Add(new TimelineItem { Content = "Delivered" });
    ViewBag.orderStatus = orderStatus;
    return View();
}