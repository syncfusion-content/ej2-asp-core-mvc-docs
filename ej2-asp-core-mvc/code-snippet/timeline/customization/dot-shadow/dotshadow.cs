public ActionResult Demo()
{
    List<TimelineItem> orderStatus = new List<TimelineItem>();
    orderStatus.Add(new TimelineItem { Content = "Ordered" });
    orderStatus.Add(new TimelineItem { Content = "Shipped" });
    orderStatus.Add(new TimelineItem { Content = "Delivered" });
    ViewBag.orderStatus = orderStatus;
    return View();
}