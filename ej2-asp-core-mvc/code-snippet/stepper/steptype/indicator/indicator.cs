public ActionResult Demo()
{

    List<Step> textSteps = new List<Step>();
    textSteps.Add(new Step { Text = "1" });
    textSteps.Add(new Step { Text = "2" });
    textSteps.Add(new Step { Text = "3" });
    textSteps.Add(new Step { Text = "4" });

    List<Step> stepperSteps = new List<Step>();
    stepperSteps.Add(new Step {  });
    stepperSteps.Add(new Step {  });
    stepperSteps.Add(new Step {  });
    stepperSteps.Add(new Step {  });
    
    ViewBag.textOnly = textSteps;
    ViewBag.stepperSteps = stepperSteps;
    
    return View();
}