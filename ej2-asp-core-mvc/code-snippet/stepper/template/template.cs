public ActionResult Demo()
{
    List<Step> stepperSteps = new List<Step>();
    stepperSteps.Add(new Step { Label = "Cart", IconCss = "sf-icon-cart" });
    stepperSteps.Add(new Step { Label = "Shipped", IconCss = "sf-icon-transport" });
    stepperSteps.Add(new Step { Label = "Payment", IconCss = "sf-icon-payment"});
    stepperSteps.Add(new Step { Label = "Delivered", IconCss = "sf-icon-success" });
    
    ViewBag.datasource = stepperSteps;
    
    return View();
}