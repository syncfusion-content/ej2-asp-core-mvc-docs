public ActionResult Demo()
{
    List<Step> stepperSteps = new List<Step>();
    stepperSteps.Add(new Step { Text = "Cart" });
    stepperSteps.Add(new Step { Text = "Delivery Address" });
    stepperSteps.Add(new Step { Text = "Payment" });
    stepperSteps.Add(new Step { Text = "Confirmation" });
    
    ViewBag.datasource = stepperSteps;
    
    return View();
}