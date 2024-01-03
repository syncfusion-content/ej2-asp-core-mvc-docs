public ActionResult Demo()
{
    List<Step> stepperSteps = new List<Step>();
    stepperSteps.Add(new Step { Text = "Review your cart items", Label = "Cart", IconCss = "sf-icon-cart" });
    stepperSteps.Add(new Step { Text = "Enter your delivery address", Label = "Delivery Address", IconCss = "sf-icon-transport" });
    stepperSteps.Add(new Step { Text = "Complete your purchase securely", Label = "Payment", IconCss = "sf-icon-payment" });
    stepperSteps.Add(new Step { Text = "Verify your order details", Label = "Confirmation", IconCss = "sf-icon-success" });
    
    ViewBag.datasource = stepperSteps;
    
    return View();
}