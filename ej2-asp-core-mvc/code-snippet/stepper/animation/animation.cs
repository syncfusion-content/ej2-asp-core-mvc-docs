public ActionResult Demo()
{
    List<Step> defaultStepper = new List<Step>();
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });
    defaultStepper.Add(new Step { });

    var animationSettings = new StepperAnimationSettings { Enable = true, Duration = 2000, Delay = 500 };

    ViewBag.default = defaultStepper;
    ViewBag.animation = animationSettings;
    return View();
}