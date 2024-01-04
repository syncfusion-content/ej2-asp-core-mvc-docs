public ActionResult Demo()
{
    List<Step> defaultStepper = new List<Step>();
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });

    ViewBag.DefaultStepper = defaultStepper;
    return View();
}