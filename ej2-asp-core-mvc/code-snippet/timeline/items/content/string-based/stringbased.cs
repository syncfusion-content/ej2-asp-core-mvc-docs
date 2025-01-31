public ActionResult StringContent()
{
    List<TimelineItem> orderStatus = new List<TimelineItem>();
    orderStatus.Add(new TimelineItem { Content = "Shipped" });
    orderStatus.Add(new TimelineItem { Content = "Departed" });
    orderStatus.Add(new TimelineItem { Content = "Arrived" });
    orderStatus.Add(new TimelineItem { Content = "Out for Delivery" });
    ViewBag.orderStatus = orderStatus;
    return View();
}