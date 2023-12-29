public ActionResult Demo()
{
    List<Step> animation = new List<Step>();
    animation.Add(new Step { });
    animation.Add(new Step { });
    animation.Add(new Step { });
    animation.Add(new Step { });
    animation.Add(new Step { });

    var animationSettings = new StepperAnimationSettings { Enable = true, Duration = 2000, Delay = 500 };

    ViewBag.datasource = animation;
    ViewBag.animation = animationSettings;
    return View();
}