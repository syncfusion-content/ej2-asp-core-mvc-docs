public ActionResult Demo()
{
    List<Step> defaultStepper = new List<Step>();
    customText.Add(new Step { });
    customText.Add(new Step { });
    customText.Add(new Step { });
    customText.Add(new Step { });
    customText.Add(new Step { });
    ViewBag.datasource = defaultStepper;
    
    return View();
}