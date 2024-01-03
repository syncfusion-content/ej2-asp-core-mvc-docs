public ActionResult Demo()
{
    List<Step> textOnlySteps = new List<Step>();
    stepperSteps.Add(new Step { Text = "A" });
    stepperSteps.Add(new Step { Text = "B" });
    stepperSteps.Add(new Step { Text = "C" });
    stepperSteps.Add(new Step { Text = "D" });

    List<Step> labelOnlySteps = new List<Step>();
    stepperSteps.Add(new Step { Label = "Cart" });
    stepperSteps.Add(new Step { Label = "Delivery Address" });
    stepperSteps.Add(new Step { Label = "Payment" });
    stepperSteps.Add(new Step { Label = "Confirmation" });
    
    ViewBag.labelOnly = labelOnlySteps;
    ViewBag.textOnly = textOnlySteps;
    
    return View();
}