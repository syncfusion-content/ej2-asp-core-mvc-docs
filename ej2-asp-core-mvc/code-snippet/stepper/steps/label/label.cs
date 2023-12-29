public ActionResult Demo()
{
    List<Step> stepperSteps = new List<Step>();
    stepperSteps.Add(new Step { Label = "Cart" });
    stepperSteps.Add(new Step { Label = "Delivery Address" });
    stepperSteps.Add(new Step { Label = "Payment" });
    stepperSteps.Add(new Step { Label = "Confirmation" });
    
    ViewBag.datasource = stepperSteps;
    
    return View();
}