public ActionResult Demo()
{

    List<Step> textOnly = new List<Step>();
    textOnly.Add(new Step { Text = "1" });
    textOnly.Add(new Step { Text = "2" });
    textOnly.Add(new Step { Text = "3" });
    textOnly.Add(new Step { Text = "4" });

    List<Step> defaultSteps = new List<Step>();
    defaultSteps.Add(new Step {  });
    defaultSteps.Add(new Step {  });
    defaultSteps.Add(new Step {  });
    defaultSteps.Add(new Step {  });
    
    ViewBag.TextOnly = textOnly;
    ViewBag.StepperSteps = defaultSteps;
    
    return View();
}