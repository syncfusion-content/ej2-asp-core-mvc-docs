public ActionResult Demo()
{
    List<Step> defaultStepper = new List<Step>();
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });
    ViewBag.datasource = defaultStepper;
    
    return View();
}