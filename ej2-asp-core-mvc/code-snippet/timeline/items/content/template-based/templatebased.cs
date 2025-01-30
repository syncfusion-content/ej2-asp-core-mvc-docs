public ActionResult TemplateContent()
{
    List<TimelineItem> orderStatus = new List<TimelineItem>();
    orderStatus.Add(new TimelineItem { Content = "#content-template" });
    orderStatus.Add(new TimelineItem { Content = "#content-template" });
    orderStatus.Add(new TimelineItem { Content = "#content-template" });
    orderStatus.Add(new TimelineItem { Content = "Out for Delivery" });
    ViewBag.orderStatus = orderStatus;
    return View();
}