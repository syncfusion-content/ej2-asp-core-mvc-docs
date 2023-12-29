public ActionResult Demo()
{
    List<Step> stepperSteps = new List<Step>();
    stepperSteps.Add(new Step { });
    stepperSteps.Add(new Step { });
    stepperSteps.Add(new Step { });
    stepperSteps.Add(new Step { });
    stepperSteps.Add(new Step { });

    ViewBag.datasource = stepperSteps;
    return View();
}