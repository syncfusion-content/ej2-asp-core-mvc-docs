public ActionResult Demo()
{
    List<Step> stepperSteps = new List<Step>();
    stepperSteps.Add(new Step { Label = "PowerPoint", IconCss = "sf-icon-powerpoint" });
    stepperSteps.Add(new Step { Label = "Presentation", IconCss = "sf-icon-projector" });
    stepperSteps.Add(new Step { Label = "Backup", IconCss = "sf-icon-onedrive"});
    
    ViewBag.datasource = stepperSteps;
    
    return View();
}