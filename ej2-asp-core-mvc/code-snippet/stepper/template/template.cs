public ActionResult Demo()
{
    List<Step> iconLabel = new List<Step>();
    iconLabel.Add(new Step { Label = "PowerPoint", IconCss = "sf-icon-powerpoint" });
    iconLabel.Add(new Step { Label = "Presentation", IconCss = "sf-icon-projector" });
    iconLabel.Add(new Step { Label = "Backup", IconCss = "sf-icon-onedrive"});
    
    ViewBag.datasource = iconLabel;
    
    return View();
}