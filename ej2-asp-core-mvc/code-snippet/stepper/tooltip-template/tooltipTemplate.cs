public ActionResult Demo()
{
    List<Step> textLabelIcon = new List<Step>();
    textLabelIcon.Add(new Step { Text = "Review your cart items", Label = "Cart", IconCss = "sf-icon-cart" });
    textLabelIcon.Add(new Step { Text = "Enter your delivery address", Label = "Delivery Address", IconCss = "sf-icon-transport" });
    textLabelIcon.Add(new Step { Text = "Complete your purchase securely", Label = "Payment", IconCss = "sf-icon-payment" });
    textLabelIcon.Add(new Step { Text = "Verify your order details", Label = "Confirmation", IconCss = "sf-icon-success" });
    
    ViewBag.datasource = textLabelIcon;
    
    return View();
}