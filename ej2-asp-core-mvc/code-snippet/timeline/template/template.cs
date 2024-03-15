public ActionResult Demo()
{
    List<TimelineItem> projectMilestones = new List<TimelineItem>();
    projectMilestones.Add(new TimelineItem { Content = "Kickoff meeting" });
    projectMilestones.Add(new TimelineItem { Content = "Content approved" });
    projectMilestones.Add(new TimelineItem { Content = "Design approved" });
    projectMilestones.Add(new TimelineItem { Content = "Product delivered" });

    ViewBag.projectMilestones = projectMilestones;

    return View();
}