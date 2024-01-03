public ActionResult Demo()
{
    List<Step> stepperSteps = new List<Step>();
    stepperSteps.Add(new Step { Text = "Cart", IconCss = "sf-icon-cart" });
    stepperSteps.Add(new Step { Text = "Delivery Address", IconCss = "sf-icon-transport" });
    stepperSteps.Add(new Step { Text = "Payment", IconCss = "sf-icon-payment" });
    stepperSteps.Add(new Step { Text = "Confirmation", IconCss = "sf-icon-success" });
    
    ViewBag.datasource = stepperSteps;
    
    return View();
}