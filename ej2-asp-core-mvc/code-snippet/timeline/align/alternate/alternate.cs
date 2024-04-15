public ActionResult Demo()
{
    List<TimelineItem> frameworks = new List<TimelineItem>();
    frameworks.Add(new TimelineItem { Content = "ReactJs", OppositeContent = "Owned by Facebook" });
    frameworks.Add(new TimelineItem { Content = "Angular", OppositeContent = "Owned by Google" });
    frameworks.Add(new TimelineItem { Content = "VueJs", OppositeContent = "Owned by Evan you" });
    frameworks.Add(new TimelineItem { Content = "Svelte", OppositeContent = "Owned by Rich Harris" });
    ViewBag.frameworks = frameworks;
    
    return View();
}