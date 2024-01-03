public ActionResult Demo()
{
    List<Step> stepperSteps = new List<Step>();
    stepperSteps.Add(new Step { Label = "Cart", IconCss = "sf-icon-cart" });
    stepperSteps.Add(new Step { Label = "Payment", IconCss = "sf-icon-payment"});
    stepperSteps.Add(new Step { Label = "Ordered", IconCss = "sf-icon-success" });
    
    ViewBag.datasource = stepperSteps;
    
    return View();
}