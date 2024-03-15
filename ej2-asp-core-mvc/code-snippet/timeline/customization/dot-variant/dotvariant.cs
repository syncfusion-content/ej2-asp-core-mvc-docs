public ActionResult Demo()
{
    List<TimelineItem> dotVariants = new List<TimelineItem>();
    dotVariants.Add(new TimelineItem { Content = "Filled", CssClass = "dot-filled" });
    dotVariants.Add(new TimelineItem { Content = "Flat", CssClass = "dot-flat" });
    dotVariants.Add(new TimelineItem { Content = "Outlined", CssClass = "dot-outlined" });
    ViewBag.dotVariants = dotVariants;
    
    return View();
}